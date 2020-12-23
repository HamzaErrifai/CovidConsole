﻿using System.Data;
using System.Data.SqlClient;

namespace CovidConsole.Model
{
    class Model
    {
        protected string tableName = "";

        /*
        * @return datatable
        * **/
        protected DataTable getData()
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            conn.Open();
            command.CommandText = $"SELECT * FROM {tableName}";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        /*
         * idItem  : valeur de l'id
         * @return datatable
         * **/
        protected DataTable getByCin(string cinC)
        {
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            string cinName = (tableName == "citoyen") ? "cin" : "cinC";

            conn.Open();
            command.CommandText = $"SELECT * FROM {tableName} WHERE {cinName} = '{cinC}'";
            command.Prepare();
            command.ExecuteNonQuery();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        /*
         * itemName  : field name in db 
         * itemValue : value that user want to change
         * **/
        protected void UpdateByCin<T>(string idItem, string itemName, T itemValue)
        {
            /* in case of boolean you should send an int 1 or 0 to this fonction
             * in case of dataTime you should send a formated dateTime to America's time format
             * **/
            SqlConnection conn = Db.Connect();
            SqlCommand command = new SqlCommand(null, conn);
            string cinName = (tableName == "citoyen") ? "cin" : "cinC";

            conn.Open();
            //if the item is numeric remove the Apostrophe ( ' )
            if (itemValue.GetType() == typeof(int) || (itemValue.GetType() == typeof(double)) || itemValue.GetType() == typeof(bool))
                command.CommandText = $"UPDATE {tableName} SET {itemName} = {itemValue} WHERE {cinName} = '{idItem}'";
            else
                command.CommandText = $"UPDATE {tableName} SET {itemName} = '{itemValue}' WHERE {cinName} = '{idItem}'";
            command.Prepare();
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
