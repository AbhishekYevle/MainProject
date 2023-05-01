
using MainProject.Database;
using MainProject.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;


namespace MainProject.ViewModel
{
  public class TeacherRegisterViewModel : INotifyPropertyChanged
  {
    MainDatabase DBobj = MainDatabase.GetInstance();

    // <--------------------- register Button Command ----------------------->

    // register Button Execute
    // private void RegisterTeacher()
    // {
    //   DBobj.CreateTeacherTable();
    //   DBobj.InsertTeacherData(tchrFirstName, tchrLastName, tchrEmployeeNumber, tchrMobileNumber, tchrEMail, tchrCollege, tchrSubject, tchrPassword);
    //   MessageBox.Show("Registration Done Successfully.");
    //   // LoginTeacher.View.Refresh();
    // }

    // // register button Command
    // private ICommand _RegisterTeacherCommand;
    // public ICommand RegisterTeacherCommand
    // {
    //   get
    //   {
    //     if (_RegisterTeacherCommand == null)
    //     {
    //       _RegisterTeacherCommand = new RelayCommand(p => RegisterTeacher());
    //     }
    //     return _RegisterTeacherCommand;
    //   }
    // }

    // // Properties of Registration page
    // private string _tchrFirstName;
    // public string tchrFirstName
    // {
    //   get { return _tchrFirstName; }
    //   set
    //   {
    //     _tchrFirstName = value;
    //     OnPropertyChanged("tchrFirstName");
    //   }
    // }
    // private string _tchrLastName;
    // public string tchrLastName
    // {
    //   get { return _tchrLastName; }
    //   set
    //   {
    //     _tchrLastName = value;
    //     OnPropertyChanged("tchrLastName");
    //   }
    // }
    // private string _tchrEmployeeNumber;
    // public string tchrEmployeeNumber
    // {
    //   get { return _tchrEmployeeNumber; }
    //   set
    //   {
    //     _tchrEmployeeNumber = value;
    //     OnPropertyChanged("tchrEmployeeNumber");
    //   }
    // }
    // private string _tchrMobileNumber;
    // public string tchrMobileNumber
    // {
    //   get { return _tchrMobileNumber; }
    //   set
    //   {
    //     _tchrMobileNumber = value;
    //     OnPropertyChanged("tchrMobileNumber");
    //   }
    // }
    // private string _tchrEMail;
    // public string tchrEMail
    // {
    //   get { return _tchrEMail; }
    //   set
    //   {
    //     _tchrEMail = value;
    //     OnPropertyChanged("tchrEMail");
    //   }
    // }
    // private string _tchrCollege;
    // public string tchrCollege
    // {
    //   get { return _tchrCollege; }
    //   set
    //   {
    //     _tchrCollege = value;
    //     OnPropertyChanged("tchrCollege");
    //   }
    // }
    // private string _tchrSubject;
    // public string tchrSubject
    // {
    //   get { return _tchrSubject; }
    //   set
    //   {
    //     _tchrSubject = value;
    //     OnPropertyChanged("tchrSubject");
    //   }
    // }
    // private string _tchrPassword;
    // public string tchrPassword
    // {
    //   get { return _tchrPassword; }
    //   set
    //   {
    //     _tchrPassword = value;
    //     OnPropertyChanged("tchrPassword");
    //   }
    // }



    // Implement interface member for INotifyPropertyChanged.
    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

  }
}
