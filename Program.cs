using System;

namespace mailerCLI
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.Write("Enter to email: ");
            MailInfo info = new MailInfo()
            {
                fromName = "automailer",
                to = Console.ReadLine(),
                toName = "john smith"
            };
            config email1 = new config()
            {
                subject = "This is a test email",
                body = $"Hello, {info.toName} this is a test email, your email {info.to} is being sent this email because you are included in our test!"
        };
            try
            {

                SendMail.send(email1, info);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sent!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
