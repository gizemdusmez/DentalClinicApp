using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DentalClinicApp
{
    public static class DatabaseHelper
    {

        private static readonly string ConnectionString = @"Data Source=C:\Users\gizem\Desktop\New folder (2)\New folder\DentalClinicApp\DentalClinicApp\Data1\Database1.db;Version=3;";
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
        //Veri ekleme,silme,güncelleme işlemleri
        public static void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        //Veri Sorgulama
        public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
    }
}

