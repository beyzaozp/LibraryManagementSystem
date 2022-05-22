using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.DataAccess.Functions
{
    public class ConnectionStringInfo
    {
        private static string FilePath = Application.StartupPath + "\\Connection.dat";
        public static string get()
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllText(FilePath);
            }
            return null;
        }
        public static void Set(string connectionString)
        {
            //if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}"))
            //{
            //    Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}");
            //}
            File.WriteAllText(FilePath, connectionString);
        }
    }
}
