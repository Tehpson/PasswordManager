namespace PasswordManager.Functions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Linq;

    internal static class GetLocalData
    {
        internal static string GetMasterPWD()
        {
            var fileData = GetLocalFileData();
            if (fileData == null)
            {
                Console.WriteLine("ERROR - PWD file do not exist");
                return "ERROR FILE DOSE NOT EXIST";
            }
            else
            {
                Console.WriteLine("Found masterPassword");
                return fileData.Data.Find(x => x.Alias == "MASTER_PWD").PWD;
            }
        }
        internal static Models.PWDObj GetLocalFileData()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(Path.Combine(path, "PWDManager"), "PASSWORD_DATA.json");
            return File.Exists(path) ? Newtonsoft.Json.JsonConvert.DeserializeObject<Models.PWDObj>(File.ReadAllText(path)) : null;
        }
    }
}
