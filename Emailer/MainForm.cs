using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Emailer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		String passwd ;
		String senderEmail ;
		
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
	}
		void BWyslijClick(object sender, EventArgs e)
		{
			senderEmail = tblogin.Text;
			passwd =tbhaslo.Text;
			MailMessage mailMessage = new MailMessage();
	        MailAddress mailAddress = new MailAddress(senderEmail, senderEmail); //input Sender Email Address 
	        mailMessage.From = mailAddress;
	        mailAddress = new MailAddress(textBox1.Text);
	        mailMessage.To.Add(mailAddress);
	        mailMessage.Subject = textBox2.Text;
	        mailMessage.Body = textBox3.Text;
	        mailMessage.IsBodyHtml = true;

        SmtpClient mailSender = new SmtpClient("smtp.gmail.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(senderEmail, passwd)       // input sender email address  
                                                                           //pass = sender email password
        };

        try
        {
            mailSender.Send(mailMessage);
            MessageBox.Show("wysłano wiadomosc");
        }
        catch (SmtpFailedRecipientException ex)
        {MessageBox.Show("Błąd, nie wysłano"+ex); }
        catch (SmtpException ex)
        {MessageBox.Show("Błąd, nie wysłano"+ex); }
        finally
        {
            mailSender = null;
            mailMessage.Dispose();
            passwd = "";
            senderEmail = "";
        }
        
		}
	}
	
}
			
			