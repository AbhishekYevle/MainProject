
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using MainProject.Model;

namespace MainProject.ViewModel
{
  public class StudentInfoViewModel : INotifyPropertyChanged
  {
    private CollectionViewSource StudentInfoMenuItemsCollection;
    public ICollectionView StudentInfoMenuSourceCollection => StudentInfoMenuItemsCollection.View;

    public StudentInfoViewModel()
    {
      ObservableCollection<StudentInfoMenuItems> StudentInfoMenuItems = new ObservableCollection<StudentInfoMenuItems>
            {
                new StudentInfoMenuItems { StudentInfoMenu = "Courses", StudentInfoMenuImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Course.png" },
                new StudentInfoMenuItems { StudentInfoMenu = "Teachers", StudentInfoMenuImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Teacher64.png" },
                new StudentInfoMenuItems { StudentInfoMenu = "Account", StudentInfoMenuImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Student.png" },
            };

      StudentInfoMenuItemsCollection = new CollectionViewSource { Source = StudentInfoMenuItems };
    }


    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }

}