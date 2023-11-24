using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Collections;

public static class database_helper
{
    public static string connectionString = @"Data Source=..\..\database\data.db;Version =3;";
    public static void inital_database()
    {
        if (!File.Exists(@"database\data.db"))
        {
            Console.WriteLine(@"..\..\database has not found");
            SQLiteConnection.CreateFile(@"..\..\database\data.db");
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createCodetable = @"
                    CREATE TABLE IF NOT EXISTS CodeBox(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    BoxID TEXT NOT NULL,
                    Code TEXT NOT NULL,
                    Timestamp DEFAULT CURRENT_TIMESTAMP NOT NULL,
                    UNIQUE(BoxID, Code)
                    )
                    ";
                using (var command = new SQLiteCommand(connection)) 
                {
                    command.CommandText = createCodetable;
                    command.ExecuteNonQuery();
                }
            }
        }
        else { Console.WriteLine("database founded"); }
    }
    public static string insertcode(string box_id,string linecode, string date)
    {
        using(var connection = new SQLiteConnection(connectionString))
        {
            
            try
            {
                var Query = new SQLiteCommand(connection);
                SQLiteDataReader _read_record_total;
                Query.CommandText = "INSERT INTO CodeBox(BoxID,Code,Timestamp) VALUES(@box_id,@linecode,@Date)";
                Query.Parameters.AddWithValue("@box_id", box_id);
                Query.Parameters.AddWithValue("@linecode", linecode);
                Query.Parameters.AddWithValue("@Date", date);
                Query.ExecuteNonQuery();
                // check number of code has been inserted
                Query.CommandText = "SELECT SUM(Code) FROM CodeBox WHERE BoxID=@box_id";
                Query.Parameters.AddWithValue("@box_id", box_id);
                _read_record_total = Query.ExecuteReader();
                return _read_record_total.GetString(0);
            }
            catch {
                Console.WriteLine("can not insert this record");
                return null;
            }
        }
    }
    public static List<Tuple<string, string>> get_code(string box_id)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            var Query = new SQLiteCommand(connection);
            Query.CommandText = "SELECT * FROM CodeBox WHERE BoxID=@box_id";
            Query.Parameters.AddWithValue("@box_id", box_id);
            SQLiteDataReader _read_record_get_code = Query.ExecuteReader();
            var code_list = new List<string>();
            while (_read_record_get_code.Read())
            {
                code_list.Add(_read_record_get_code.GetString(2));
            }
            string combinedCode = string.Join(",", code_list.ToArray());

            Query.CommandText = "SELECT SUM(Code) FROM CodeBox WHERE BoxID=@box_id";
            Query.Parameters.AddWithValue("@box_id", box_id);
            SQLiteDataReader _read_record_total = Query.ExecuteReader();
            // Create a new dictionary of strings, with string keys.
            //
            List<Tuple<string, string>> Result = new List<Tuple<string, string>>();
            Result.Add(new Tuple<string, string>("Code", combinedCode));
            Result.Add(new Tuple<string, string>("BoxID", box_id));
            Result.Add(new Tuple<string, string>("Total", _read_record_total.GetString(0)));
            return Result;

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