
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using MainProject.Model;

namespace MainProject.ViewModel
{
  public class StudentViewModel : INotifyPropertyChanged
  {
    private CollectionViewSource StudentItemsCollection;
    public ICollectionView StudentSourceCollection => StudentItemsCollection.View;

    public StudentViewModel()
    {
      ObservableCollection<StudentItems> StudentItems = new ObservableCollection<StudentItems>
            {
                new StudentItems { StudentName = "Login", StudentImage = @"C:/Users/yevlea/MainProject/Assets/login1.png" },
                new StudentItems { StudentName = "Register", StudentImage = @"C:/Users/yevlea/MainProject/Assets/verify1.png" },
            };

      StudentItemsCollection = new CollectionViewSource { Source = StudentItems };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }

}