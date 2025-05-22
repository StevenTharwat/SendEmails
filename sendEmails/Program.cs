using System.Net;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        // Set the sender, recipient, subject, and body of the email
        string from = "Sender Email";
        string to = "receiver Email";

        string subject = "this email is from C# to test the app";
        string body = @"
Email Body
";

        // Create a MailMessage object with the above properties
        MailMessage message = new MailMessage(from, to, subject, body);


        // Set the SMTP server information
        SmtpClient client = new SmtpClient("smtp.office365.com"); //smtp.office365.com
        client.Port = 587; // Use the appropriate port number for your server
        client.EnableSsl = true;
        client.Credentials = new NetworkCredential(from, "Sender Pass");




        try
        {
            // Send the email
            client.Send(message);
            Console.WriteLine("Email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sending email: " + ex.Message);
        }
    }
}

