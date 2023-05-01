
using MainProject.Database;
using MainProject.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;


namespace MainProject.ViewModel
{
  public class StudentRegisterViewModel : INotifyPropertyChanged
  {
    MainDatabase DBobj = MainDatabase.GetInstance();

    // // <--------------------- register Button Command ----------------------->

    // // register Button Execute
    // private void RegisterStudent()
    // {
    //   DBobj.CreateStudentTable();
    //   DBobj.InsertStudentData(stdFirstName, stdLastName, stdEnrollNumber, stdMobileNumber, stdEMail, stdCollege, stdDispline, stdPassword);
    //   MessageBox.Show("Registration Done Successfully.");
    //   // LoginStudent.View.Refresh();
    // }

    // // register button Command
    // private ICommand _RegisterStudentCommand;
    // public ICommand RegisterStudentCommand
    // {
    //   get
    //   {
    //     if (_RegisterStudentCommand == null)
    //     {
    //       _RegisterStudentCommand = new RelayCommand(p => RegisterStudent());
    //     }
    //     return _RegisterStudentCommand;
    //   }
    // }

    // // Properties of Registration page
    // private string _stdFirstName;
    // public string stdFirstName
    // {
    //   get { return _stdFirstName; }
    //   set
    //   {
    //     _stdFirstName = value;
    //     OnPropertyChanged("stdFirstName");
    //   }
    // }
    // private string _stdLastName;
    // public string stdLastName
    // {
    //   get { return _stdLastName; }
    //   set
    //   {
    //     _stdLastName = value;
    //     OnPropertyChanged("stdLastName");
    //   }
    // }
    // private string _stdEnrollNumber;
    // public string stdEnrollNumber
    // {
    //   get { return _stdEnrollNumber; }
    //   set
    //   {
    //     _stdEnrollNumber = value;
    //     OnPropertyChanged("stdEnrollNumber");
    //   }
    // }
    // private string _stdMobileNumber;
    // public string stdMobileNumber
    // {
    //   get { return _stdMobileNumber; }
    //   set
    //   {
    //     _stdMobileNumber = value;
    //     OnPropertyChanged("stdMobileNumber");
    //   }
    // }
    // private string _stdEMail;
    // public string stdEMail
    // {
    //   get { return _stdEMail; }
    //   set
    //   {
    //     _stdEMail = value;
    //     OnPropertyChanged("stdEMail");
    //   }
    // }
    // private string _stdCollege;
    // public string stdCollege
    // {
    //   get { return _stdCollege; }
    //   set
    //   {
    //     _stdCollege = value;
    //     OnPropertyChanged("stdCollege");
    //   }
    // }
    // private string _stdDispline;
    // public string stdDispline
    // {
    //   get { return _stdDispline; }
    //   set
    //   {
    //     _stdDispline = value;
    //     OnPropertyChanged("stdDispline");
    //   }
    // }
    // private string _stdPassword;
    // public string stdPassword
    // {
    //   get { return _stdPassword; }
    //   set
    //   {
    //     _stdPassword = value;
    //     OnPropertyChanged("stdPassword");
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
