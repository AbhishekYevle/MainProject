
/// <summary>
/// ViewModel - [ "The Connector" ]
/// ViewModel exposes data contained in the Model objects to the View. The ViewModel performs 
/// all modifications made to the Model data.
/// </summary>

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using MainProject.Model;

namespace MainProject.ViewModel
{
  class NavigationViewModel : INotifyPropertyChanged
  {
    // CollectionViewSource enables XAML code to set the commonly used CollectionView properties,
    // passing these settings to the underlying view.
    private CollectionViewSource MenuItemsCollection;

    // ICollectionView enables collections to have the functionalities of current record management,
    // custom sorting, filtering, and grouping.
    public ICollectionView SourceCollection => MenuItemsCollection.View;

    public NavigationViewModel()
    {
      // ObservableCollection represents a dynamic data collection that provides notifications when items
      // get added, removed, or when the whole list is refreshed.
      ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems { MenuName = "Student", MenuImage = @"C:/Users/yevlea/MainProject/Assets/Student.png" },
                new MenuItems { MenuName = "Teacher", MenuImage = @"C:/Users/yevlea/MainProject/Assets/Teacher4.png" },
                new MenuItems { MenuName = "Courses", MenuImage = @"C:/Users/yevlea/MainProject/Assets/Course.png" },
            };

      MenuItemsCollection = new CollectionViewSource { Source = menuItems };
      MenuItemsCollection.Filter += MenuItems_Filter;

      // Set Startup Page
      SelectedViewModel = new StartupViewModel();
    }

    // Implement interface member for INotifyPropertyChanged.
    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    // Text Search Filter.
    private string filterText;
    public string FilterText
    {
      get => filterText;
      set
      {
        filterText = value;
        MenuItemsCollection.View.Refresh();
        OnPropertyChanged("FilterText");
      }
    }

    private void MenuItems_Filter(object sender, FilterEventArgs e)
    {
      if (string.IsNullOrEmpty(FilterText))
      {
        e.Accepted = true;
        return;
      }

      MenuItems _item = e.Item as MenuItems;
      if (_item.MenuName.ToUpper().Contains(FilterText.ToUpper()))
      {
        e.Accepted = true;
      }
      else
      {
        e.Accepted = false;
      }
    }

    // Select ViewModel
    private object _selectedViewModel;
    public object SelectedViewModel
    {
      get => _selectedViewModel;
      set
      {
        _selectedViewModel = value;
        OnPropertyChanged("SelectedViewModel");
      }
    }

    // Switch Views
    public void SwitchViews(object parameter)
    {
      switch (parameter)
      {
        case "Student":
          SelectedViewModel = new StudentViewModel();
          break;

        case "Teacher":
          SelectedViewModel = new TeacherViewModel();
          break;

        default:
          SelectedViewModel = new StudentViewModel();
          break;
      }
    }

    // Menu Button Command
    private ICommand _menucommand;
    public ICommand MenuCommand
    {
      get
      {
        if (_menucommand == null)
        {
          _menucommand = new RelayCommand(param => SwitchViews(param));
        }
        return _menucommand;
      }
    }

    // Show StudentLogin View
    public void StudentLoginView()
    {
      SelectedViewModel = new StudentLoginViewModel();
    }

    // This StudentLogin button Command
    private ICommand _StudentLogincommand;
    public ICommand ThisStudentLoginCommand
    {
      get
      {
        if (_StudentLogincommand == null)
        {
          _StudentLogincommand = new RelayCommand(param => StudentLoginView());
        }
        return _StudentLogincommand;
      }
    }

    // Show Student View
    private void ShowStudent()
    {
      SelectedViewModel = new StudentViewModel();
    }

    // Back button Command
    private ICommand _backStudentCommand;
    public ICommand BackStudentCommand
    {
      get
      {
        if (_backStudentCommand == null)
        {
          _backStudentCommand = new RelayCommand(p => ShowStudent());
        }
        return _backStudentCommand;
      }
    }

    // <----------------------- Login Section ----------------------->

    // Show TeacherLogin View
    public void TeacherLoginView()
    {
      SelectedViewModel = new TeacherLoginViewModel();
    }

    // This StudentLogin button Command
    private ICommand _TeacherLogincommand;
    public ICommand ThisTeacherLoginCommand
    {
      get
      {
        if (_TeacherLogincommand == null)
        {
          _TeacherLogincommand = new RelayCommand(param => TeacherLoginView());
        }
        return _TeacherLogincommand;
      }
    }



    // Show Teacher View
    private void ShowTeacher()
    {
      SelectedViewModel = new TeacherViewModel();
    }

    // Back button Command
    private ICommand _backTeacherCommand;
    public ICommand BackTeacherCommand
    {
      get
      {
        if (_backTeacherCommand == null)
        {
          _backTeacherCommand = new RelayCommand(p => ShowTeacher());
        }
        return _backTeacherCommand;
      }
    }

    // Login Button Execute
    private void LoginStudent()
    {
      MessageBox.Show("Login Failed.");
    }

    // Login button Command
    private ICommand _loginStudentCommand;
    public ICommand LoginStudentCommand
    {
      get
      {
        if (_loginStudentCommand == null)
        {
          _loginStudentCommand = new RelayCommand(p => LoginStudent());
        }
        return _loginStudentCommand;
      }
    }


    // Login Button Execute
    private void LoginTeacher()
    {
      MessageBox.Show("Login Failed.");
    }

    // Login button Command
    private ICommand _loginTeacherCommand;
    public ICommand LoginTeacherCommand
    {
      get
      {
        if (_loginTeacherCommand == null)
        {
          _loginTeacherCommand = new RelayCommand(p => LoginTeacher());
        }
        return _loginTeacherCommand;
      }
    }


    // <--------------------- Close Command ----------------------->


    // Close App
    public void CloseApp(object obj)
    {
      MainWindow win = obj as MainWindow;
      win.Close();
    }

    // Close App Command
    private ICommand _closeCommand;
    public ICommand CloseApStudentLoginommand
    {
      get
      {
        if (_closeCommand == null)
        {
          _closeCommand = new RelayCommand(p => CloseApp(p));
        }
        return _closeCommand;
      }
    }

  }
}
