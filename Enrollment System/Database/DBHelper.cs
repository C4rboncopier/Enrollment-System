using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Enrollment_System.Entity_Class;
using Microsoft.Data.Sqlite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Enrollment_System.Database
{
    public sealed class DBHelper
    {
        private static DBHelper? _instance = null;
        private readonly SqliteConnection? _connection = null;

        public const string DB_NAME = "EnrollmentSystem.db";

        private DBHelper()
        {
            _connection = new SqliteConnection("Data Source=" + DB_NAME);

            _connection.Open();
        }

        public static DBHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBHelper();
                }

                return _instance;
            }
        }

        public Accounts? CreateUser(Accounts accounts)
        {
            var createUserCommand = _connection?.CreateCommand();

            createUserCommand!.CommandText = $@"
                INSERT INTO Students (firstName, lastName, schoolEmail, phoneNumber, program, year, RFID, schoolID)
                VALUES ('{accounts.firstName}', '{accounts.lastName}', '{accounts.email}', 
                '{accounts.phoneNumber}', '{accounts.program}', '{accounts.year}', '{accounts.RFID}', '{accounts.schoolID}')";

            try
            {
                var result = createUserCommand.ExecuteNonQuery();

                if (result < 0)
                {
                    return null;
                }

                accounts.ID = GetUserID(accounts.RFID);
            }
            catch (Exception)
            {
                accounts.ID = GetUserID(accounts.RFID);
            }

            return accounts;
        }
        
        public int GetUserID(string RFID)
        {
            var selectCommand = _connection?.CreateCommand();
            selectCommand!.CommandText = $@"SELECT ID FROM Students WHERE RFID = '{RFID}'";
            var reader = selectCommand.ExecuteReader();

            if (!reader.Read())
            {
                return -1;
            }

            int userId = reader.GetInt32(0);

            return userId;
        }

        public string? getStudentID(string RFID)
        {
            if (_connection == null)
            {
                return null;
            }

            string? studentID = null;

            try
            {
                using (var selectCommand = _connection.CreateCommand())
                {
                    selectCommand.CommandText = @"SELECT schoolID FROM Students WHERE RFID = @RFID";
                    selectCommand.Parameters.AddWithValue("@RFID", RFID);

                    var result = selectCommand.ExecuteScalar();

                    if (result != null)
                    {
                        studentID = result.ToString();
                    }
                }
            }
            catch (Exception)
            {
                // Handle database errors
                studentID = null;
            }

            return studentID;
        }

        public int? isTicketFound(string studentID)
        {
            try
            {
                using (var selectCommand = _connection.CreateCommand())
                {
                    selectCommand.CommandText = @"SELECT ID FROM Queue WHERE Student = @studentID";
                    selectCommand.Parameters.AddWithValue("@studentID", studentID);

                    var reader = selectCommand.ExecuteReader();

                    if (!reader.Read())
                    {
                        reader.Close();
                        return -1;
                    }

                    int ID = reader.GetInt32(0);
                    reader.Close();
                    return ID;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return -1;
            }
        }

        public Tickets? CreateTicket(Tickets tickets)
        {
            var createTicketCommand = _connection?.CreateCommand();

            string prefix = tickets.studentType == "Enrollment" ? "E" : "A";

            var getMaxTicketCommand = _connection?.CreateCommand();
            getMaxTicketCommand!.CommandText = $@"
                SELECT MAX(ticketNum) FROM Queue WHERE Type = '{tickets.studentType}' AND ticketNum LIKE '{prefix}%'";

            string newTicketNum;

            try
            {
                var maxTicketNum = getMaxTicketCommand.ExecuteScalar()?.ToString();

                if (!string.IsNullOrEmpty(maxTicketNum))
                {
                    int currentMaxNum = int.Parse(maxTicketNum.Substring(1));
                    newTicketNum = $"{prefix}{(currentMaxNum + 1).ToString("D3")}";
                }
                else
                {
                    newTicketNum = $"{prefix}001";
                }
            }
            catch (Exception)
            {
                newTicketNum = $"{prefix}001";
            }

            tickets.ticketNum = newTicketNum;

            createTicketCommand!.CommandText = $@"
                INSERT INTO Queue (ticketNum, Student, Type, dateTime, Notif, NotifSent, Status, Unit)
                VALUES ('{tickets.ticketNum}', '{tickets.studentID}', '{tickets.studentType}',
                '{tickets.dateTime}', '{tickets.notifOptions}', 'None', 'Waiting', 'None')";

            try
            {
                var result = createTicketCommand.ExecuteNonQuery();

                if (result < 0)
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return tickets;
        }

        public string getTicketNumber(string type)
        {
            string prefix = type == "Enrollment" ? "E" : "A";

            try
            {
                using (var getMaxTicketCommand = _connection?.CreateCommand())
                {
                    if (getMaxTicketCommand == null)
                    {
                        throw new InvalidOperationException("Database connection is not initialized.");
                    }

                    getMaxTicketCommand.CommandText = @"
                        SELECT MIN(ticketNum) FROM Queue
                        WHERE Type = @type
                        AND ticketNum LIKE @prefix
                        AND Status = 'Waiting'";
                    getMaxTicketCommand.Parameters.AddWithValue("@type", type);
                    getMaxTicketCommand.Parameters.AddWithValue("@prefix", $"{prefix}%");

                    var maxTicketNum = getMaxTicketCommand.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(maxTicketNum))
                    {
                        return "None";
                    }

                    return maxTicketNum;
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public string getMaxNumber(string type)
        {
            string prefix = type == "Enrollment" ? "E" : "A";

            try
            {
                using (var getMaxTicketCommand = _connection?.CreateCommand())
                {
                    if (getMaxTicketCommand == null)
                    {
                        throw new InvalidOperationException("Database connection is not initialized.");
                    }

                    getMaxTicketCommand.CommandText = @"
                        SELECT MAX(ticketNum) FROM Queue
                        WHERE Type = @type
                        AND ticketNum LIKE @prefix
                        AND Status = 'Waiting'";
                    getMaxTicketCommand.Parameters.AddWithValue("@type", type);
                    getMaxTicketCommand.Parameters.AddWithValue("@prefix", $"{prefix}%");

                    var maxTicketNum = getMaxTicketCommand.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(maxTicketNum))
                    {
                        return "None";
                    }

                    return maxTicketNum;
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public string getCurrentNumber(string unitNum)
        {
            try
            {
                if (_connection == null)
                {
                    throw new InvalidOperationException("Database connection is not initialized.");
                }

                using (var getCurrentNumberCommand = _connection.CreateCommand())
                {
                    getCurrentNumberCommand.CommandText = @"
                        SELECT currentNum FROM Units
                        WHERE Unit = @unit";
                    getCurrentNumberCommand.Parameters.AddWithValue("@unit", unitNum);

                    var currentNum = getCurrentNumberCommand.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(currentNum))
                    {
                        return "None";
                    }

                    return currentNum;
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public string getStudentNotif(string ticketNum)
        {
            try
            {
                using (var getStudentNotifCommand = _connection.CreateCommand())
                {
                    getStudentNotifCommand.CommandText = @"
                        SELECT Notif FROM Queue
                        WHERE ticketNum = @ticketNum";
                    getStudentNotifCommand.Parameters.AddWithValue("@ticketNum", ticketNum);

                    var studentNotif = getStudentNotifCommand.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(studentNotif))
                    {
                        return "None";
                    }

                    return studentNotif;
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public string getNotifStatus(string ticketNum)
        {
            try
            {
                using (var getNotifStatusCommand = _connection.CreateCommand())
                {
                    getNotifStatusCommand.CommandText = @"
                        SELECT NotifSent FROM Queue
                        WHERE ticketNum = @ticketNum";
                    getNotifStatusCommand.Parameters.AddWithValue("@ticketNum", ticketNum);

                    var NotifStatus = getNotifStatusCommand.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(NotifStatus))
                    {
                        return "ERROR";
                    }

                    return NotifStatus;
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public string getSpecificUnitStatus(string unit)
        {
            try
            {
                if (_connection == null)
                {
                    throw new InvalidOperationException("Database connection is not initialized.");
                }

                using (var getStatusCommand = _connection.CreateCommand())
                {
                    getStatusCommand.CommandText = @"
                SELECT Status, Type FROM Units
                WHERE Unit = @unit";
                    getStatusCommand.Parameters.AddWithValue("@unit", unit);

                    using (var reader = getStatusCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var currentStatus = reader["Status"].ToString();
                            var unitType = reader["Type"].ToString();

                            if (string.IsNullOrEmpty(currentStatus))
                            {
                                return "None";
                            }

                            return $"{currentStatus} - {unitType}";
                        }
                    }

                    return "None";
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public string getStudentEmail(string ticketNum)
        {
            try
            {
                using (var getStudentEmailCommand = _connection.CreateCommand())
                {
                    getStudentEmailCommand.CommandText = @"
                        SELECT s.schoolEmail
                        FROM Students s
                        JOIN QUEUE q ON s.schoolID = q.Student
                        WHERE q.ticketNum = @ticketNum";
                    getStudentEmailCommand.Parameters.AddWithValue("@ticketNum", ticketNum);

                    using (var reader = getStudentEmailCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string email = reader["schoolEmail"].ToString();
                            return email;
                        }
                        else
                        {
                            return "ERROR";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public string getStudentNumber(string ticketNum)
        {
            try
            {
                using (var getStudentEmailCommand = _connection.CreateCommand())
                {
                    getStudentEmailCommand.CommandText = @"
                        SELECT s.phoneNumber
                        FROM Students s
                        JOIN QUEUE q ON s.schoolID = q.Student
                        WHERE q.ticketNum = @ticketNum";
                    getStudentEmailCommand.Parameters.AddWithValue("@ticketNum", ticketNum);

                    using (var reader = getStudentEmailCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string email = reader["phoneNumber"].ToString();
                            return email;
                        }
                        else
                        {
                            return "ERROR";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public string getStudentName(string currentNum)
        {
            try
            {
                if (_connection == null)
                {
                    throw new InvalidOperationException("Database connection is not initialized.");
                }

                using (var getStudentNameCommand = _connection.CreateCommand())
                {
                    getStudentNameCommand.CommandText = @"
                        SELECT s.firstName, s.lastName 
                        FROM Students s
                        JOIN Queue q ON s.schoolID = q.Student
                        WHERE q.ticketNum = @ticketNum";
                    getStudentNameCommand.Parameters.AddWithValue("@ticketNum", currentNum);

                    using (var reader = getStudentNameCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["firstName"].ToString();
                            string lastName = reader["lastName"].ToString();
                            return $"{firstName} {lastName}";
                        }
                        else
                        {
                            return "Student not found";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "Error retrieving student name";
            }
        }

        public int updateTicket(Tickets tickets)
        {
            try
            {
                using (var updateCommand = _connection?.CreateCommand())
                {
                    if (updateCommand == null)
                    {
                        throw new InvalidOperationException("Database connection is not initialized.");
                    }

                    updateCommand.CommandText = @"
                        UPDATE Queue
                        SET Status = @status, Unit = @unit
                        WHERE ticketNum = @ticketnum";

                    updateCommand.Parameters.AddWithValue("@status", tickets.status);
                    updateCommand.Parameters.AddWithValue("@unit", tickets.unit);
                    updateCommand.Parameters.AddWithValue("@ticketnum", tickets.ticketNum);

                    int result = updateCommand.ExecuteNonQuery();

                    return result > 0 ? 1 : -1;
                }
            }
            catch
            {
                return 0;
            }
        }

        public void deleteMinTicketNumber(string type, string ticketNum)
        {
            try
            {
                if (_connection == null)
                    throw new InvalidOperationException("Database connection is not initialized.");

                using (var deleteTicketCommand = _connection.CreateCommand())
                {
                    deleteTicketCommand.CommandText = @"
                        DELETE FROM Queue
                        WHERE Type = @type
                        AND ticketNum = @ticketNum
                        AND Status = 'Serving'";
                    deleteTicketCommand.Parameters.AddWithValue("@type", type);
                    deleteTicketCommand.Parameters.AddWithValue("@ticketNum", ticketNum);

                    int rowsAffected = deleteTicketCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("No rows were deleted. The ticket might not exist or its status is not 'Serving'.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error deleting the minimum ticket number.", ex);
            }
        }

        public int updateUnit(Units units)
        {
            try
            {
                using (var updateCommand = _connection?.CreateCommand())
                {
                    if (updateCommand == null)
                    {
                        throw new InvalidOperationException("Database connection is not initialized.");
                    }

                    updateCommand.CommandText = @"
                        UPDATE Units 
                        SET Status = @status, Type = @type
                        WHERE Unit = @currentUnit";
                    updateCommand.Parameters.AddWithValue("@status", units.currentStatus);
                    updateCommand.Parameters.AddWithValue("@type", units.currentType);
                    updateCommand.Parameters.AddWithValue("@currentUnit", units.currentUnit);

                    int result = updateCommand.ExecuteNonQuery();

                    return result > 0 ? 1 : -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public int updateNotifStatus(string ticketNum)
        {
            try
            {
                using (var updateCommand = _connection?.CreateCommand())
                {
                    updateCommand.CommandText = @"
                        UPDATE Queue
                        SET NotifSent = @notifUpdate
                        WHERE ticketNum = @ticketNum";
                    updateCommand.Parameters.AddWithValue("@notifUpdate", "Sent");
                    updateCommand.Parameters.AddWithValue("@ticketNum", ticketNum);

                    int result = updateCommand.ExecuteNonQuery();

                    return result > 0 ? 1 : -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public int updateUnitNum(Units units)
        {
            try
            {
                using (var updateCommand = _connection?.CreateCommand())
                {
                    if (updateCommand == null)
                    {
                        throw new InvalidOperationException("Database connection is not initialized.");
                    }

                    updateCommand.CommandText = @"
                        UPDATE Units 
                        SET currentNum = @currentnum
                        WHERE Unit = @currentUnit";
                    updateCommand.Parameters.AddWithValue("@currentUnit", units.currentUnit);
                    updateCommand.Parameters.AddWithValue("@currentnum", units.currentNum);

                    int result = updateCommand.ExecuteNonQuery();

                    return result > 0 ? 1 : -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public Dictionary<string, string> getUnitStatus()
        {
            Dictionary<string, string> unitsStatus = new Dictionary<string, string>();
            try
            {
                var getStatusCommand = _connection?.CreateCommand();
                getStatusCommand!.CommandText = $@"
                    SELECT Unit, Status FROM Units";

                var reader = getStatusCommand.ExecuteReader();

                while (reader.Read())
                {
                    string unit = reader["Unit"].ToString();
                    string status = reader["Status"].ToString();
                    unitsStatus[unit] = status;
                }
                
            }
            catch (Exception ex)
            {
                return null;
            }

            return unitsStatus;
        }

        public string CheckEnrollmentTickets()
        {
            try
            {
                using (var checkTicketCommand = _connection?.CreateCommand())
                {
                    var smallestEnrollmentTicket = GetSmallestTicketNumberE();

                    if (smallestEnrollmentTicket.HasValue)
                    {
                        var EnrollTicket = smallestEnrollmentTicket + 10;
                        string enrollTicket = EnrollTicket.Value.ToString("D3");
                        return $"E{enrollTicket}";
                    }

                    return null;
                }

            }
            catch
            {
                return null;
            }
        }
        public string CheckAdvisingTickets()
        {
            try
            {
                using (var checkTicketCommand = _connection?.CreateCommand())
                {
                    var smallestAdvisingTicket = GetSmallestTicketNumberA();

                    if (smallestAdvisingTicket.HasValue)
                    {
                        var AdviseTicket = smallestAdvisingTicket + 10;
                        string adviseTicket = AdviseTicket.Value.ToString("D3");
                        return $"A{adviseTicket}";
                    }

                    return null;
                }

            }
            catch
            {
                return null;
            }
        }
        private int? GetSmallestTicketNumberE()
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT MAX(ticketNum) FROM Queue WHERE ticketNum LIKE @ticketType || '%' AND Status = 'Serving'";
                command.Parameters.AddWithValue("@ticketType", 'E');

                var result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    var ticketNumStr = result.ToString();
                    if (ticketNumStr.Length > 1)
                    {
                        var numericPart = ticketNumStr.Substring(1);
                        if (int.TryParse(numericPart, out int ticketNum))
                        {
                            return ticketNum;
                        }
                    }
                }

                return null;
            }
        }
        private int? GetSmallestTicketNumberA()
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT MAX(ticketNum) FROM Queue WHERE ticketNum LIKE @ticketType || '%' AND Status = 'Serving'";
                command.Parameters.AddWithValue("@ticketType", 'A');

                var result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    var ticketNumStr = result.ToString();
                    if (ticketNumStr.Length > 1)
                    {
                        var numericPart = ticketNumStr.Substring(1);
                        if (int.TryParse(numericPart, out int ticketNum))
                        {
                            return ticketNum;
                        }
                    }
                }

                return null;
            }
        }

        public int QueueRowCount(string type)
        {
            try
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Queue WHERE Type = @type";
                    command.Parameters.AddWithValue("@type", type);

                    var result = command.ExecuteScalar();

                    return result != DBNull.Value && result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
