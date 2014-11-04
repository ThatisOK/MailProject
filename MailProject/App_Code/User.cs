using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///User 的摘要说明
/// </summary>
public class User
{
    private String userName;
    private String sex;
    private String userPassword;
    private String eMail;

	public User()
	{
	}

    public User(String userName,String sex,String userPassword,String eMail)
    {
        this.userName = userName;
        this.sex = sex;
        this.userPassword = userPassword;
        this.eMail = eMail;
    }

    public User(String userName,String userPassword)
    {
        this.userName = userName;
        this.userPassword = userPassword;
    }

    public String getUserName()
    {
        return this.userName;
    }

    public void setUserName(String userName)
    {
        this.userName = userName;
    }

    public String getSex()
    {
        return this.sex;
    }

    public void setSex(String sex)
    {
        this.sex = sex;
    }

    public String getUserPassword()
    {
        return this.userPassword;
    }

    public void setUserPassword(String userPassword)
    {
        this.userPassword = userPassword;
    }

    public String getEmail()
    {
        return this.eMail;
    }

    public void setEmail(String eMail)
    {
        this.eMail = eMail;
    }


}