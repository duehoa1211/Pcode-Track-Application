using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;
using TonberryLib;

namespace PTool_Table_To_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection_string = @"Data Source=DESKTOP-ER4EF01\SQLEXPRESS;Initial Catalog=PCodeTrackDB;Integrated Security=True";
            ObjectConfig obconfig = new ObjectConfig(connection_string);
            DirectoryInfo Di = new DirectoryInfo("../../Result");
            if (Di.GetFiles().Any())
            {
                foreach (FileInfo item in Di.GetFiles())
                {
                    item.Delete();
                }
            }
            using (IDbConnection db = new SqlConnection(obconfig.Connect))
            {
                List<string> ls_table_get = db.Query<string>(@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'").ToList();
                if (ls_table_get.Any())
                {
                    foreach (var item in ls_table_get)
                    {
                        string classget = db.Query<string>(@"exec renderTabletoClass '$$$nametable$$$'".Replace("$$$nametable$$$", item)).FirstOrDefault();
                        File.WriteAllText(string.Format("../../Result/{0}", item + ".cs"), obconfig.TempCreate_Cs.Replace("$$$datavalue$$$", classget));
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
