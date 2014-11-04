using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String userName = TextBox1.Text.Trim();
        String userPassword = TextBox2.Text.Trim();
        UserDao ud = new UserDao();
        User user = ud.getUser(userName);
        if (ud.checkUser(user, userPassword))
        {
            Session["user"] = user;
            //Response.Redirect("Success.aspx", true);
            Response.Redirect("Main.aspx", true);
        }
        else
            //Response.Redirect("Failure.aspx", true);
            InfoLable.Text = "Wrong username or password!";

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registe.aspx", true);
    }
}