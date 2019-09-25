using System;
using System.Net.Mail;

namespace Mail_Sender
{
	internal static class Program
	{
		private static void Main()
		{
			try
			{
				MailMessage message = new MailMessage();
				SmtpClient smtp = new SmtpClient();
				message.From = new MailAddress("AAA@gmail.com");
				message.To.Add(new MailAddress("AAA@AAA.com"));
				message.Subject = "Test";
				message.IsBodyHtml = true;
				message.Body = "AAA Test message.";
				smtp.Port = 587;
				smtp.Host = "smtp.gmail.com";
				smtp.EnableSsl = true;
				smtp.UseDefaultCredentials = true;
				smtp.Credentials = new System.Net.NetworkCredential("AAA@gmail.com", "PAAAAAASSWORD");
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtp.Send(message);

				Console.WriteLine("mail Sent.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine("Done.");
		}
	}
}
