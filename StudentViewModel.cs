
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using MainProject.Model;

namespace MainProject.ViewModel
{
  public class StudentViewModel : INotifyPropertyChanged
  {
    private CollectionViewSource StudentMenuItemsCollection;
    public ICollectionView StudentMenuSourceCollection => StudentMenuItemsCollection.View;

    public StudentViewModel()
    {
      ObservableCollection<StudentMenuItems> StudentMenuItems = new ObservableCollection<StudentMenuItems>
            {
                new StudentMenuItems { StudentMenu = "Login", StudentMenuImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/login1.png" },
                new StudentMenuItems { StudentMenu = "Register", StudentMenuImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/verify1.png" },
            };

      StudentMenuItemsCollection = new CollectionViewSource { Source = StudentMenuItems };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }

}