function UserAddVerify() {
    
    //所有信息
    var userName = document.getElementById("TextBox1").value;
    var password = document.getElementById("TextBox2").value;
    var repassword = document.getElementById("TextBox3").value;
    var email = document.getElementById("TextBox4").value;
    //正则表达式
    //验证规则：字母、数字、下划线组成，字母开头，4-16位
    var userNameReg = /^[a-zA-z]\w{3,15}$/;
    var emailReg = /^(\w-*\.*)+@(\w-?)+(\.\w{2,})+$/;

    if (userName == "" || userName == null || userNameReg.test(userName) === false) {

        document.getElementById("info").innerHTML = "<font color='red'>用户名格式不正确！</font>";
        return false;
    }
    else if (password == "" || password == null) {
        document.getElementById("info").innerHTML = "<font color='red'>密码不能为空！</font>";
        return false;
    }
    else if (repassword == "" || repassword == null || repassword != password) {
        document.getElementById("info").innerHTML = "<font color='red'>两次密码不一致！</font>";
        return false;
    }
    else if(email == "" || email == null || emailReg.test(email) === false){
        document.getElementById("info").innerHTML = "<font color='red'>请输入正确的邮箱账号！</font>";
        return false;
    }
    /*
    else if (identity == "" || identity == null || identityReg.test(identity) === false) {
        alert("请输入合法的身份证号码");
        return false;
    }
    else if (mobile == "" || mobile == null || mobileReg.test(mobile) == false) {
        alert("请输入合法的手机号码");
        return false;
    }
    else if (realName == "" || realName == null) {
        alert("姓名不能为空");
        return false;
    }
    */
    return true;
}

function check() {

    var name = document.getElementById("TextBox1").value;
    if (name == null) {
        document.getElementById("info").innerHTML = "<font color='red'>用户名格式不正确！</font>";
    }
}
