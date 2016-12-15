using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace Session
{
    public class Recorder
    {
        SqlConnection connect; 
        SqlDataAdapter adapter;

        // получаем строку подключения из app.config
     string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Clinic.mdf;Integrated Security=True;Connect Timeout=30";

        public void InsertPatient(Patient p)
        {
            try
            {
                string cmdText = "INSERT INTO dbo.Patient"+
                    "(id, fio, gender, db,address,dr,cardid,docid)Values(@id, @fio, @gender, @db,@address,@dr,@cardid,@docid)";
                SqlCommand cmd = new SqlCommand(cmdText,connect);
                // Добавить параметры
                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.Parameters.AddWithValue("@fio", p.Fio);
                cmd.Parameters.AddWithValue("@gender", p.Gender);
                cmd.Parameters.AddWithValue("@db", p.Db);
                cmd.Parameters.AddWithValue("@address", p.Address);
                cmd.Parameters.AddWithValue("@dr", p.Dr);
                cmd.Parameters.AddWithValue("@cardid", p.Cardid);
                cmd.Parameters.AddWithValue("@docid", p.Docid);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception)
            { throw; }
        }

    }
}
