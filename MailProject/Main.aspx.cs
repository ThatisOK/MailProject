using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        User user = Session["user"] as User;
        UserDao ud = new UserDao();
        User currentUser = ud.getUser(user.getUserName());
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(currentUser.getEmail());
        mail.To.Add(TextBox1.Text.Trim());
        mail.Subject = TextBox2.Text.Trim();
        mail.SubjectEncoding = System.Text.Encoding.UTF8;
        mail.Body = TextBox3.Text.Trim();
       // String name = FileUpload1.FileName;
        Attachment files = new Attachment("E:/TDDOWNLOAD/pgd-481-avi/pgd481pl.jpg");
        mail.Attachments.Add(files);
        mail.IsBodyHtml = true;
        mail.Priority = MailPriority.High;
        SmtpClient client = new SmtpClient();
        client.Host = "SMTP.qq.com";
        client.Port = 25;
        client.Credentials = new System.Net.NetworkCredential(currentUser.getEmail(), currentUser.getUserPassword());
        client.Send(mail);
    }
}