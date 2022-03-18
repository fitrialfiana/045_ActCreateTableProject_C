using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Table_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Create();
        }

        public void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-6IF85PV\\FITRIALFIANA;database=ProdiTI;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }

            finally
            {
                con.Close();
            }
        }
    }
}
