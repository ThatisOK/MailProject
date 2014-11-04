function UserAddVerify() {
    
    //������Ϣ
    var userName = document.getElementById("TextBox1").value;
    var password = document.getElementById("TextBox2").value;
    var repassword = document.getElementById("TextBox3").value;
    var email = document.getElementById("TextBox4").value;
    //������ʽ
    //��֤������ĸ�����֡��»�����ɣ���ĸ��ͷ��4-16λ
    var userNameReg = /^[a-zA-z]\w{3,15}$/;
    var emailReg = /^(\w-*\.*)+@(\w-?)+(\.\w{2,})+$/;

    if (userName == "" || userName == null || userNameReg.test(userName) === false) {

        document.getElementById("info").innerHTML = "<font color='red'>�û�����ʽ����ȷ��</font>";
        return false;
    }
    else if (password == "" || password == null) {
        document.getElementById("info").innerHTML = "<font color='red'>���벻��Ϊ�գ�</font>";
        return false;
    }
    else if (repassword == "" || repassword == null || repassword != password) {
        document.getElementById("info").innerHTML = "<font color='red'>�������벻һ�£�</font>";
        return false;
    }
    else if(email == "" || email == null || emailReg.test(email) === false){
        document.getElementById("info").innerHTML = "<font color='red'>��������ȷ�������˺ţ�</font>";
        return false;
    }
    /*
    else if (identity == "" || identity == null || identityReg.test(identity) === false) {
        alert("������Ϸ������֤����");
        return false;
    }
    else if (mobile == "" || mobile == null || mobileReg.test(mobile) == false) {
        alert("������Ϸ����ֻ�����");
        return false;
    }
    else if (realName == "" || realName == null) {
        alert("��������Ϊ��");
        return false;
    }
    */
    return true;
}

function check() {

    var name = document.getElementById("TextBox1").value;
    if (name == null) {
        document.getElementById("info").innerHTML = "<font color='red'>�û�����ʽ����ȷ��</font>";
    }
}
