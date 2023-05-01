
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using MainProject.Database;
using MainProject.Model;
using System.Data.SQLite;

namespace MainProject.ViewModel
{
  public class StudentLoginViewModel : INotifyPropertyChanged
  {
    MainDatabase DBobj = MainDatabase.GetInstance();
    // ObservableCollection<StudentLoginItems> UIdata = new ObservableCollection<StudentLoginItems>();
    public StudentLoginViewModel()
    {
    }
    // private void LoginStudent()
    // {
    //   SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/Palak/Downloads/AllPracticals/MainProject/DataBase/Student_Portal.db;Version=3");
    //   conn.Open();
    //   SQLiteDataReader sqlite_datareader;
    //   SQLiteCommand sqlite_cmd;
    //   string createsql = "SELECT stdEMail, stdPassword FROM tblStudent;";
    //   sqlite_cmd = conn.CreateCommand();
    //   sqlite_cmd.CommandText = createsql;
    //   sqlite_datareader = sqlite_cmd.ExecuteReader();

    //   var y = new StudentLoginItems();

    //   while (sqlite_datareader.Read())
    //   {
    //     var tmpobj = new PropDatabase();
    //     tmpobj.EMail = sqlite_datareader.GetString(0);
    //     tmpobj.Password = sqlite_datareader.GetString(1);
    //     // dblist.Add(tmpobj);
    //     if (tmpobj.EMail == stdLoginEMail && tmpobj.Password == stdLoginPassword)
    //     {
    //       MessageBox.Show("Login Successful.");
    //       SelectedViewModel = new StartupViewModel();
    //       break;
    //     }
    //   }
    //   conn.Close();
    // }


    // // MessageBox.Show("Login Successfully.");


    // // <---------- Properties of Front-End ---------->
    // private string _stdLoginEMail;
    // public string stdLoginEMail
    // {
    //   get { return _stdLoginEMail; }
    //   set
    //   {
    //     _stdLoginEMail = value;
    //     OnPropertyChanged("stdLoginEMail");
    //   }
    // }
    // private string _stdLoginPassword;
    // public string stdLoginPassword
    // {
    //   get { return _stdLoginPassword; }
    //   set
    //   {
    //     _stdLoginPassword = value;
    //     OnPropertyChanged("stdLoginPassword");
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
    // private ICommand _LoginStudentCommand;
    // public ICommand LoginStudentCommand
    // {
    //   get
    //   {
    //     if (_LoginStudentCommand == null)
    //     {
    //       _LoginStudentCommand = new RelayCommand(p => LoginStudent());
    //     }
    //     return _LoginStudentCommand;
    //   }
    // }
    // private ObservableCollection<PropDatabase> _dataItems;
    // public ObservableCollection<PropDatabase> DataItems
    // {
    //   get { return _dataItems; }
    //   set
    //   {
    //     _dataItems = value;
    //     OnPropertyChanged(nameof(DataItems));
    //   }
    // }
    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }
}
