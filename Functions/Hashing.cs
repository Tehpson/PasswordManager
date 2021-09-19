namespace PasswordManager.Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    internal static class Hashing
    {
        internal static string HashPasswordBcrypt(string pwd)
        {
            return BCrypt.Net.BCrypt.HashPassword(pwd);
        }

        internal static bool VerifyPasswordBcrypt(string pwd, string passwordHash)
        {
            bool response;
            try
            {
                response = BCrypt.Net.BCrypt.Verify(pwd, passwordHash);
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        internal static string HashPasswordOwn(string pwd)
        {
            var charstring = new List<string>();
            var rnd = new Random();
            var pwdchar = pwd.ToCharArray();
            var chararr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890#?!@$\"%^&*-".ToCharArray();
            foreach (var item in pwd)
            {
                var randnumb = rnd.Next(10, 70);
                charstring.Add(rnd.Next(0, 2) == 0 ? (randnumb -= randnumb * 2).ToString() : randnumb.ToString() );
            }
            charstring.Add("/");
            for (int i = 0; i < pwd.Length; i++)
            {
                var shift = int.Parse(charstring[i]);
                var index = Array.FindIndex(chararr, x => x == pwdchar[i]);
                index += shift;
                index = index > 73 ? index -= 73 : index < 0 ? index += 73 : index;
                charstring.Add(chararr[index].ToString());
            }
            var str = string.Concat(charstring.ToArray());
            return str;
        }

        internal static string DecryptPasswordOwn(Models.Data selectedItem)
        {
            if (selectedItem.Alias == "MASTER_PWD") return "MASTER_PWD NOT ABLE TO DECRYPT";
            int index = 0, shift;
            var chararr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890#?!@$\"%^&*-".ToCharArray();
            var spliced = selectedItem.PWD.Split('/');
            var listString = new List<string>();

            foreach (var charecter in spliced[1])
            {
                if (spliced[0][index].ToString() == "-")
                {
                    shift = int.Parse(String.Concat(spliced[0][index + 1], spliced[0][index + 2]));
                    index += 3;
                }
                else
                {
                    shift = int.Parse(String.Concat("-",spliced[0][index], spliced[0][index + 1]));
                    index += 2;
                }

                var charecterIndex = Array.FindIndex(chararr, x => x == charecter);
                charecterIndex += shift;
                charecterIndex = charecterIndex > 73 ? charecterIndex -= 73 : charecterIndex < 0 ? charecterIndex += 73 : charecterIndex;
                listString.Add(chararr[charecterIndex].ToString());
            }
            return String.Concat(listString);
        }
    }
}
