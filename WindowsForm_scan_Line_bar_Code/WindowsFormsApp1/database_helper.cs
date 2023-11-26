using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using LineBarScanner;
using System.Data;
using System.IO.Ports;

public static class database_helper
{
    public static string connectionString = @"Data Source=..\database\data.db;Version =3;";
    public static void inital_database()
    {
        if (!File.Exists(@"..\database\data.db"))
        {
            Console.WriteLine(@"database has not found");
            SQLiteConnection.CreateFile(@"..\database\data.db");
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createCodetable = @"
                    CREATE TABLE IF NOT EXISTS CodeBox(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    BoxID TEXT NOT NULL,
                    Code TEXT NOT NULL,
                    Timestamp DEFAULT CURRENT_TIMESTAMP NOT NULL
                    )
                    ";
                using (var command = new SQLiteCommand(connection)) 
                {
                    command.CommandText = createCodetable;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        else { Console.WriteLine("database founded"); }
    }
    public static bool insertcode(string box_id,string linecode, string date="")
    {
        using(var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insert_query = "INSERT INTO CodeBox(BoxID,Code,Timestamp) VALUES(@box_id,@linecode,DATETIME('now'))";
            using (var command_insert = new SQLiteCommand(insert_query,connection))
            {
                try
                {
                    command_insert.Parameters.AddWithValue("@box_id", box_id);
                    command_insert.Parameters.AddWithValue("@linecode", linecode);
                    command_insert.ExecuteNonQuery ();
                    connection.Close();
                    return true;
                }
                catch
                {
                    Console.WriteLine("can not insert this record");
                    //connection.Close();
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
  

        }
    }
    
    public static string count_code(string box_id)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string sum_query = "SELECT COUNT(*) as cout FROM CodeBox WHERE BoxID ='"+ box_id+"'";
            using (var command_sum = new SQLiteCommand(sum_query, connection))
            {
                try
                {
                    int result =0;
                    SQLiteDataReader _r = command_sum.ExecuteReader();
                    //_read_record_total = command_sum.ExecuteReader();
                    //connection.Close();
                    while(_r.Read())
                    {
                        int _result = Convert.ToInt32(_r["cout"]);
                        if (_result> result) result = _result;
                    }
                    connection.Close();
                    return Convert.ToString(result);


                }
                catch
                {
                    Console.WriteLine("can not sum this boxID");
                    connection.Close();
                    return "0";
                }
            }

        }
    }
    public static string get_latest_code()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string sum_query = "SELECT BoxID FROM CodeBox ORDER BY Timestamp desc LIMIT 1";
            using (var command_sum = new SQLiteCommand(sum_query, connection))
            {
                try
                {
                    string result="";
                    SQLiteDataReader _r = command_sum.ExecuteReader();
                    //_read_record_total = command_sum.ExecuteReader();
                    //connection.Close();
                    while (_r.Read())
                    {
                        string _result = _r["BoxID"].ToString();
                        if (_result != result) result = _result;
                    }
                    connection.Close();
                    return result;


                }
                catch
                {
                    Console.WriteLine("can not sum this boxID");
                    connection.Close();
                    return "";
                }
            }

        }
    }
    public static DataTable get_code(string box_id, string split_rule)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            string _box_id= box_id.Split(split_rule.FirstOrDefault())[0];
            string sum_query;
            connection.Open();
            if (box_id=="")
            sum_query = "SELECT BoxID,Code,STRFTIME('%d/%m/%Y, %H:%M', Timestamp) as Timestamp FROM CodeBox";
            else
            sum_query = "SELECT BoxID,Code,STRFTIME('%d/%m/%Y, %H:%M', Timestamp) as Timestamp FROM CodeBox WHERE BoxID ='" + _box_id + "'";
            using (var command_sum = new SQLiteCommand(sum_query, connection))
            {
                using(SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command_sum))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        // Fill the DataTable with the result set from the query
                        dataAdapter.Fill(dataTable);
                        // Close the connection
                        connection.Close();

                        return dataTable;
                        // Display the DataTable in a DataGridView
                        //targetgrid.DataSource = dataTable;
                    }
                    catch
                    {
                        Console.WriteLine("database is empty");
                        return null;
                        
                    }
                    
                }
            }

        }
    }
    public static bool cleardatabase()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insert_query = "DELETE FROM CodeBox WHERE 1=1";
            using (var command_insert = new SQLiteCommand(insert_query, connection))
            {
                try
                {
                    command_insert.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch
                {
                    Console.WriteLine("can not clear table");
                    //connection.Close();
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
public class data_processing
{
    public string get_prefix(string content, char char_split = '-')
    {
        return content.Split(char_split)[0];
    }
}