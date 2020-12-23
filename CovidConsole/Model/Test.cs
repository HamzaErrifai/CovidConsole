﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Test : Model
    {
        public Test()
        {
            tableName = "test";
        }

        protected void addData(string typeT, DateTime dateT, bool hassymptoms, string resultat, string cinC)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);

            try
            {
                conn.Open();
                command.CommandText = $"INSERT INTO test (typeT, dateT, hassymptoms, resultat, cinC)" +
                    $"VALUES ('{typeT}', '{dateT.ToString("MM/dd/yyyy HH:mm:ss")}', {(hassymptoms ? 1 : 0)}, '{resultat}', '{cinC}')";
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
