using System.Data.SQLite;
using System.Windows;
using MainProject.Model;
namespace MainProject.Database
{
  class MainDatabase
  {
    private static MainDatabase Instance = null;
    public static MainDatabase GetInstance()
    {
      if (Instance == null)
      {
        Instance = new MainDatabase();
      }
      return Instance;
    }
    private MainDatabase()
    {
    }


    public SQLiteConnection CreateConnection()
    {
      SQLiteConnection sqlite_con;
      sqlite_con = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3;New=True;Compress=True;");

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
    public void DELETETABLE()
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = "DROP TABLE tblStudent;";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }

    // <----------------------- Student Table Section ----------------------->

    public void CreateStudentTable()
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = "CREATE TABLE IF NOT EXISTS tblStudent (StudentID INTEGER PRIMARY KEY AUTOINCREMENT, stdFirstName VARCHAR(50), stdLastName VARCHAR(50), stdEnrollNumber VARCHAR(50),stdMobileNumber VARCHAR(10),stdEMail VARCHAR(50), stdCollege VARCHAR(100), stdDispline VARCHAR(20), stdPassword VARCHAR(20) );";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }


    public void InsertStudentData(String fname, string lname, string emplynum, string mnum, string email, string college, string displine, string Password)
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = $"INSERT INTO tblStudent(StudentID, stdFirstName, stdLastName, stdEnrollNumber, stdMobileNumber, stdEMail, stdCollege, stdDispline, stdPassword) VALUES(NULL, '{fname}', '{lname}','{emplynum}','{mnum}','{email}','{college}','{displine}','{Password}');";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }

    // <----------------------- Teacher Table Section ----------------------->

    public void CreateTeacherTable()
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Teacher_Portal.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = "CREATE TABLE IF NOT EXISTS tblTeacher (TeacherID INTEGER PRIMARY KEY AUTOINCREMENT, tchrFirstName VARCHAR(50), tchrLastName VARCHAR(50), tchrEmployeeNumber VARCHAR(50), tchrMobileNumber VARCHAR(10), tchrEMail VARCHAR(50), tchrCollege VARCHAR(100), tchrSubject VARCHAR(20), tchrPassword VARCHAR(20) );";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }

    public void InsertTeacherData(string fname, string lname, string emplynum, string mnum, string email, string college, string displine, string Password)
    {
      SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Teacher_Portal.db;Version=3");
      conn.Open();
      SQLiteCommand sqlite_cmd;
      string createsql = $"INSERT INTO tblTeacher(TeacherID, tchrFirstName, tchrLastName, tchrEmployeeNumber, tchrMobileNumber, tchrEMail, tchrCollege, tchrSubject, tchrPassword) VALUES(NULL, '{fname}', '{lname}','{emplynum}','{mnum}','{email}','{college}','{displine}','{Password}');";
      sqlite_cmd = conn.CreateCommand();
      sqlite_cmd.CommandText = createsql;
      sqlite_cmd.ExecuteNonQuery();
      conn.Close();
    }
  }
}





// public List<PropDatabase> ReadStudentData()
// {
//   SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
//   conn.Open();
//   List<PropDatabase> dblist = new List<PropDatabase>();
//   SQLiteDataReader sqlite_datareader;
//   SQLiteCommand sqlite_cmd;
//   string createsql = "SELECT stdEMail, stdPassword FROM tblStudent;";
//   sqlite_cmd = conn.CreateCommand();
//   sqlite_cmd.CommandText = createsql;
//   sqlite_datareader = sqlite_cmd.ExecuteReader();

//   while (sqlite_datareader.Read())
//   {
//     var tmpobj = new PropDatabase();
//     tmpobj.stdEMail = sqlite_datareader.GetString(0);
//     tmpobj.stdPassword = sqlite_datareader.GetString(1);
//     dblist.Add(tmpobj);
//   }
//   conn.Close();
//   return dblist;
// }
// public void DeleteData(int id)
// {
//   SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
//   conn.Open();
//   SQLiteCommand sqlite_cmd;
//   string createsql = $"DELETE FROM user WHERE ID = {id}";
//   sqlite_cmd = conn.CreateCommand();
//   sqlite_cmd.CommandText = createsql;
//   sqlite_cmd.ExecuteNonQuery();
//   conn.Close();

// }

// public void Updatedata(string name, int id)
// {
//   SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
//   conn.Open();
//   SQLiteCommand sqlite_cmd;
//   string createsql = $"UPDATE user SET Name = '{name}' WHERE ID = {id}";
//   sqlite_cmd = conn.CreateCommand();
//   sqlite_cmd.CommandText = createsql;
//   sqlite_cmd.ExecuteNonQuery();
//   conn.Close();
// }
