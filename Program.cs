// See https://aka.ms/new-console-template for more information

List<string> password = new List<string> { "admin1234", "100", "Mm123456", "60111111", "MyPassWord" };

var MyPass = Reg.GetInfo(password);
foreach (var item in MyPass)
{
    Console.WriteLine(item);
}

