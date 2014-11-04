using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
///UserDao 的摘要说明
/// </summary>
public class UserDao
{
	public UserDao()
	{
		
	}
    /*
    public void dataOp(String sql)
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=123456;database=MailProject");
        MySqlCommand myCmd = new MySqlCommand(sql, conn);
        conn.Open();
        myCmd.ExecuteNonQuery();
    }
    */
    public User getUser(String userName)
    {
        User user;
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=123456;database=MailProject");
        String sql = "select * from userInfo where userName = '" + userName + "'";
        MySqlCommand myCmd = new MySqlCommand(sql, conn);
        conn.Open();
        myCmd.ExecuteNonQuery();
        MySqlDataReader myDataReader = myCmd.ExecuteReader();
        String username;
        String userPassword;
        String email;
        String sex;
        if (myDataReader.Read())
        {
            username = myDataReader["userName"].ToString();
            userPassword = myDataReader["userPassword"].ToString();
            sex = myDataReader["sex"].ToString();
            email = myDataReader["email"].ToString();
            user = new User(username,sex,userPassword,email);

        }
        else
            user = null;
        myDataReader.Close();
        conn.Close();
        return user;
    }
    public bool checkUser(User u,String userPsaaword)
    {
        return u != null && u.getUserPassword() == userPsaaword;
    }

    public bool addUser(User u)
    {
        String userName = u.getUserName();
        String sex = u.getSex();
        String userPassword = u.getUserPassword();
        String eMail = u.getEmail();
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=123456;database=MailProject");
        String sql = "insert into userInfo(userName,sex,userPassword,eMail) values('"+userName+"','"+sex+"','"+userPassword+"','"+eMail+"')";
        MySqlCommand myCmd = new MySqlCommand(sql, conn);
        conn.Open();
        return myCmd.ExecuteNonQuery() == 1;
    }

}