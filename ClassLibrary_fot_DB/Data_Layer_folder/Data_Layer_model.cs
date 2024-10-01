using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ClassLibrary_fot_DB.Models;
using static ClassLibrary_fot_DB.Data_Layer_folder.Data_Layer_model;

namespace ClassLibrary_fot_DB.Data_Layer_folder
{
    public class Data_Layer_model
    {
        public static string connectionstring { get; set; } = ConfigurationManager.ConnectionStrings["English"].ConnectionString;

        public static class Question
        {
            public static void Insert(string title, int categoryId, int typeId)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Question_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@TypeId", typeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static class Answer
        {
            public static void Insert(string title, bool isRight, int answer_masId)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Answer_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@IsRight", isRight);
                    cmd.Parameters.AddWithValue("Answer_masId", answer_masId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static class Answer_mas
        {
            public static void Insert(int  questionId)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Answer_masses_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Question_Id", questionId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static class Category
        {
            public static void Insert(string tmp)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Category_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", tmp);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static class Type_
        {
            public static void Insert(string tmp)
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    string command = "dbo.Type_add";
                    SqlCommand cmd = new SqlCommand(command, conn);

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", tmp);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

