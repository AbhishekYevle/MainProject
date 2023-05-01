using System.Data.SQLite;
using System.Windows;
using MainProject.Model;
namespace MainProject.Database
{
  class Database
  {
    private static Database Instance = null;
    public static Database GetInstance()
    {
      if (Instance == null)
      {
        Instance = new Database();
      }
      return Instance;
    }
    private Database()
    {
    }


    public SQLiteConnection CreateConnection()
    {
      SQLiteConnection sqlite_con;
      sqlite_con = new SQLiteConnection("Data Source=sample.db;Version=3;New=True;Compress=True;");

      try
      {
        sqlite_con.Open();
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }

      sqlite_con.Close();
      return sqlite_con;
    }

    public void CreateTable()
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=sample.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = "CREATE TABLE IF NOT EXISTS user(ID INT,Name VARCHAR(50));";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }

    public void InsertData(int Id, String name)
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=sample.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = $"INSERT INTO user(ID, Name) VALUES({Id}, '{name}');";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }

    public List<MainModel> ReadData()
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=sample.db;Version=3");
      conn.Open();
      List<Model> dblist = new List<Model>();
      SQLiteDataReader sqlite_datareader;
      SQLiteCommand sqlite_cmd;
      string createsql = "SELECT * FROM user;";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_datareader = sqlite_cmd.ExecuteReader();

      while (sqlite_datareader.Read())
      {
        var tmpobj = new Model();
        tmpobj.ID = sqlite_datareader.GetInt32(0);
        tmpobj.Name = sqlite_datareader.GetString(1);
        dblist.Add(tmpobj);
      }
      conn.Close();
      return dblist;
    }
    public void DeleteData(int id)
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=sample.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = $"DELETE FROM user WHERE ID = {id}";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();

    }

    public void Updatedata(string name, int id)
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=sample.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = $"UPDATE user SET Name = '{name}' WHERE ID = {id}";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }
  }
}