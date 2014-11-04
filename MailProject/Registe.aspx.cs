using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Button1.Attributes.Add("OnClick", "return UserAddVerify();");
            
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String userName = TextBox1.Text.Trim();
        String passWord = TextBox2.Text.Trim();
        String sex;
        if(Male.Checked)
            sex = "男";
        else
            sex = "女";
        String eMail = TextBox4.Text.Trim();
        UserDao ud = new UserDao();
        User user = new User(userName, sex,passWord, eMail);
        if(ud.addUser(user))
            Response.Redirect("Success.aspx",true);
        else
            Response.Redirect("Failure.aspx", true);


    }
}