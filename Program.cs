using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 数据库连接及开启
            SqlConnection con2 = new SqlConnection();//方法2

            con2.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;";
            try
            {
                con2.Open();//打开数据库连接
                Console.WriteLine(con2.State);//输出数据库连接状态
                Console.WriteLine("数据库连接成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine(con2.State);//输出数据库连接状态
                Console.WriteLine("数据库连接失败" + ex.Message);
            }
            #endregion

        }
    }
}
