
using MainProject.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace MainProject.ViewModel
{
  public class StudentLoginViewModel : INotifyPropertyChanged
  {
    private readonly CollectionViewSource StudentLoginItemsCollection;
    public ICollectionView StudentLoginSourceCollection => StudentLoginItemsCollection.View;

    public StudentLoginViewModel()
    {
      ObservableCollection<StudentLoginItems> StudentLoginItems = new ObservableCollection<StudentLoginItems>
            {
                new StudentLoginItems { StudentLoginName = "Student 1", StudentLoginImage = @"C:/Users/yevlea/MainProject/Assets/Student.png" },
                new StudentLoginItems { StudentLoginName = "Student 2", StudentLoginImage = @"C:/Users/yevlea/MainProject/Assets/Student.png" },
                new StudentLoginItems { StudentLoginName = "Student 3", StudentLoginImage = @"C:/Users/yevlea/MainProject/Assets/Student.png" },
                new StudentLoginItems { StudentLoginName = "Student 4", StudentLoginImage = @"C:/Users/yevlea/MainProject/Assets/Student.png" }

            };

      StudentLoginItemsCollection = new CollectionViewSource { Source = StudentLoginItems };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }
}
