using Mail.Repo;
using MailSendSystem;
using System.Text;


addrepo addrepo = new addrepo();

//StudentMaildetail studentMaildetail = new StudentMaildetail();

//studentMaildetail.Name = "gautam";
//studentMaildetail.Email = "Gautamprajapati1963@gmail.com";
//studentMaildetail.PhoneNumber = 322548514;

//addrepo.addstudent(studentMaildetail);

var m = addrepo.getstudents();

foreach (var item in m)
{
Notification notification = new();

var title = new StringBuilder("##Name##  mail for you");
var message1 = new StringBuilder("##Name## you login with ##email##");

title.Replace("##Name##", item.Name);
    message1.Replace("##Name##", item.Name);
    message1.Replace("##email##", item.Email);

    string titles = title.ToString();
    string message = message1.ToString();
    notification.SendNotification(item.Email, titles, message);


}
Console.WriteLine("mail sand");