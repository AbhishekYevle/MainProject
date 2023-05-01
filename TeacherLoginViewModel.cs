
using System.Collections.ObjectModel;
using System.ComponentModel;
using MainProject.Database;
using MainProject.Model;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Input;

namespace MainProject.ViewModel
{
  public class TeacherLoginViewModel : INotifyPropertyChanged
  {
    MainDatabase DBobj = MainDatabase.GetInstance();


    // private void LoginTeacher()
    // {
    //   if (tchrLoginEMail == null || tchrLoginPassword == null)
    //   {
    //     MessageBox.Show("Please Enter Details!!");
    //   }
    //   else
    //   {
    //     SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Teacher_Portal.db;Version=3");
    //     conn.Open();
    //     SQLiteDataReader sqlite_datareader;
    //     SQLiteCommand sqlite_cmd;
    //     string createsql = "SELECT tchrEMail, tchrPassword FROM tblTeacher;";
    //     sqlite_cmd = conn.CreateCommand();
    //     sqlite_cmd.CommandText = createsql;
    //     sqlite_datareader = sqlite_cmd.ExecuteReader();

    //     while (sqlite_datareader.Read())
    //     {
    //       var tmpobj = new PropDatabase();
    //       tmpobj.EMail = sqlite_datareader.GetString(0);
    //       tmpobj.Password = sqlite_datareader.GetString(1);

    //       while (tmpobj.EMail == tchrLoginEMail && tmpobj.Password == tchrLoginPassword)
    //       {
    //         MessageBox.Show("Login Successful.");
    //         SelectedViewModel = new StartupViewModel();
    //         break;
    //       }
    //     }
    //     conn.Close();
    //   }
    // }


    // // <---------- Properties of Front-End ---------->
    // private string _tchrLoginEMail;
    // public string tchrLoginEMail
    // {
    //   get { return _tchrLoginEMail; }
    //   set
    //   {
    //     _tchrLoginEMail = value;
    //     OnPropertyChanged("tchrLoginEMail");
    //   }
    // }
    // private string _tchrLoginPassword;
    // public string tchrLoginPassword
    // {
    //   get { return _tchrLoginPassword; }
    //   set
    //   {
    //     _tchrLoginPassword = value;
    //     OnPropertyChanged("tchrLoginPassword");
    //   }
    // }

    // // <---------- Select ViewModel ---------->
    // private object _selectedViewModel;
    // public object SelectedViewModel
    // {
    //   get => _selectedViewModel;
    //   set
    //   {
    //     _selectedViewModel = value;
    //     OnPropertyChanged("SelectedViewModel");
    //   }
    // }

    // // <---------- Login Button Commands ---------->
    // private ICommand _LoginTeacherCommand;
    // public ICommand LoginTeacherCommand
    // {
    //   get
    //   {
    //     if (_LoginTeacherCommand == null)
    //     {
    //       _LoginTeacherCommand = new RelayCommand(p => LoginTeacher());
    //     }
    //     return _LoginTeacherCommand;
    //   }
    // }


    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }
}
