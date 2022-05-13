using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmorcIRL.TempMail;
using SmorcIRL.TempMail.Models;

namespace TEMP_MAIL_GENERATOR
{
    public class insta_mail
    {
         MailClient client = new MailClient();
        public async Task<string> Mail_gen()
        {
            string domain = await client.GetFirstAvailableDomainName();

            //Algorithm To Generate Random Garbage String and return it
            static string RandomString(int length)
            {
                Random random = new Random();
                const string chars = "stuvwxyz";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }

            string sdfs = RandomString(6);
            Console.WriteLine(sdfs + '@' + domain);
            await client.Register("" + (sdfs + '@' + domain), "authentic");
            AccountInfo info = await client.GetAccountInfo();
            return info.Address;


        }

        public async Task<string> OTP_waiter() { 
            while (true)
            {
                try
                {
                    MessageInfo[] messages = await client.GetAllMessages();
                    if (messages.Length != 0)
                    {
                        foreach (MessageInfo message in messages)
                        {
                            return message.Subject.Substring(0, 6).ToString();
                        }
                    }
                    await Task.Delay(1000);
                }
                catch
                {

                }
                
                

            }
        
        
        }



    }
}
