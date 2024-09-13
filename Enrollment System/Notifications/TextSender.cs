using Enrollment_System.Entity_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Enrollment_System.Notifications
{

    // THIS CODE WILL WORK IF TWILIO ACCOUNT IS VERIFIED
    public class TextSender
    {
        public static async Task SendTextAsync(Accounts account)
        {

            if (string.IsNullOrEmpty(accountSid) || string.IsNullOrEmpty(authToken))
            {
                MessageBox.Show("ERROR");

            }

            TwilioClient.Init(accountSid, authToken);


            var messageOptions = new CreateMessageOptions(new PhoneNumber(account.phoneNumber))
            {
                From = new PhoneNumber("+16189258466"),
                Body = "Your ticket number is approaching. Please proceed to the Enrollment Room."
            };

            try
            {
                var message = await MessageResource.CreateAsync(messageOptions);
                Console.WriteLine(message.Body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
