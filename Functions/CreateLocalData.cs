using System;
using System.IO;

namespace PasswordManager.Functions
{
    internal static class CreateLocalData
    {
        internal static (bool sucssesfull,string msg) CreateMasterPassword(string masterPassword)
        {
            try
            {
                if (!GetLocalData.GetMasterPWD().StartsWith("ERROR", StringComparison.OrdinalIgnoreCase))
                {
                    return (false, "Data Already Exist");
                }

                Console.WriteLine("Createting SaveFile");
                var data = new Models.PWDObj();
                data.Data.Add(new Models.Data { Alias = "MASTER_PWD", PWD = Hashing.HashPasswordBcrypt(masterPassword) });
                var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                path = Path.Combine(path, "PWDManager");
                Directory.CreateDirectory(path);
                path = Path.Combine(path, "PASSWORD_DATA.json");
                File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(data));
                Console.WriteLine("Done");
                return (true,"sucssesfull");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return (false,"internal error");
            }
        }
        internal static string GenerateAndStoreLocalData(string alias)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(Path.Combine(path, "PWDManager"), "PASSWORD_DATA.json");
            var genreatedStr = new Fare.Xeger("^[A-Za-z0-9#?!@$%\"^&*-]{5}[a-z]{1}[#?!@$%^\"&*-]{1}[A-Z]{1}[0-9]{1}[A-Za-z0-9]{5}$[A-Za-z0-9#?!@$\"%^&*-]{5}", new Random()).Generate();
            var data = GetLocalData.GetLocalFileData();
            data.Data.Add(new Models.Data { Alias = alias, PWD = Hashing.HashPasswordOwn(genreatedStr) });
            var jsonInput = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            File.WriteAllText(path, jsonInput);
            return genreatedStr;
        }
    }
}