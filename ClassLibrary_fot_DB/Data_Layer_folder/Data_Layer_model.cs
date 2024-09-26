using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ClassLibrary_fot_DB.Models;

namespace ClassLibrary_fot_DB.Data_Layer_folder
{
    public class Data_Layer_model
    {
        public static string connectionstring { get; set; } = ConfigurationManager.ConnectionStrings["English2"].ConnectionString;
        public static class User
        {
            public static void Insert(User_model user)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.User_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = user.First_name;
                    cmd.Parameters[2].Value = user.Last_name;
                    cmd.Parameters[3].Value = user.Age; ;
                    cmd.Parameters[4].Value = user.Score;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static class Question
        {
            public static void Insert(Question_model question)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Question_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = question.Title;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static class Answer
        {
            public static void Insert(Answer_model answer)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Answer_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(cmd);

                    cmd.Parameters[0].Value = DBNull.Value;
                    cmd.Parameters[1].Value = answer.Title;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
