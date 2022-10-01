// using PassWord_Gen;
using Serenity.Web.Providers;

public static class Reg
{

    public static List<string> GetInfo(List<string> list)
    {
        List<string> MyList = new();
        foreach (var password in list)
        {

            string salt = null;
            var Hash = GenerateHash(password, ref salt);
            var Salt = salt;
            var namev = "{'PassWord':'" + password + " , 'Hash':'" + Hash + "' , 'Salt': '" + Salt + "'}";
            MyList.Add(namev);
        }

        return MyList;
    }



    public static string CalculateHash(string password, string salt)
    {
        return SiteMembershipProvider.ComputeSHA512(password + salt);
    }

    public static string GenerateHash(string password, ref string salt)
    {
        salt = salt ?? Serenity.IO.TemporaryFileHelper.RandomFileCode().Substring(0, 5);
        return CalculateHash(password, salt);
    }




}
