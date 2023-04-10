
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using MainProject.Model;

namespace MainProject.ViewModel
{
  public class TeacherViewModel : INotifyPropertyChanged
  {
    private CollectionViewSource TeacherItemsCollection;
    public ICollectionView TeacherSourceCollection => TeacherItemsCollection.View;

    public TeacherViewModel()
    {
      ObservableCollection<TeacherItems> TeacherItems = new ObservableCollection<TeacherItems>
            {
                new TeacherItems { TeacherName = "Login", TeacherImage = @"C:/Users/yevlea/MainProject/Assets/login1.png" },
                new TeacherItems { TeacherName = "Register", TeacherImage = @"C:/Users/yevlea/MainProject/Assets/verify1.png" },
            };

      TeacherItemsCollection = new CollectionViewSource { Source = TeacherItems };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
  }

}