
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using MainProject.Model;

namespace MainProject.ViewModel
{
  public class CourseViewModel : INotifyPropertyChanged
  {
    private CollectionViewSource CourseItemsCollection;
    public ICollectionView CourseSourceCollection => CourseItemsCollection.View;

    public CourseViewModel()
    {
      ObservableCollection<CourseItems> CourseItems = new ObservableCollection<CourseItems>
            {

                new CourseItems { CourseName = "Angular", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Angular.png" },
                new CourseItems { CourseName = "C#", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/C#.png" },
                new CourseItems { CourseName = "Export", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Course.png" },
                new CourseItems { CourseName = "Print", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Course.png" },
                new CourseItems { CourseName = "Orders", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Course.png" },
                new CourseItems { CourseName = "Stocks", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Course.png" },
                new CourseItems { CourseName = "Invoice", CourseImage = @"C:/Users/Palak/Downloads/AllPracticals/MainProject/Assets/Course.png" }

            };

      CourseItemsCollection = new CollectionViewSource { Source = CourseItems };
      CourseItemsCollection.Filter += MenuItems_Filter;

    }

    private string filterText;
    public string FilterText
    {
      get => filterText;
      set
      {
        filterText = value;
        CourseItemsCollection.View.Refresh();
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

      CourseItems _item = e.Item as CourseItems;
      if (_item.CourseName.ToUpper().Contains(FilterText.ToUpper()))
      {
        e.Accepted = true;
      }
      else
      {
        e.Accepted = false;
      }
    }

    // <----------------------- Select Course Section ----------------------->
    // NavigationViewModel vmobj = new NavigationViewModel();
    // private ICommand _CourseCommand;
    // public ICommand CourseCommand
    // {
    //   get
    //   {
    //     if (_CourseCommand == null)
    //     {
    //       _CourseCommand = new RelayCommand(Par => vmobj.SelectCourse(Par));
    //     }
    //     return _CourseCommand;
    //   }
    // }
    // private void SelectCourse(object course)
    // {
    //   switch (course)
    //   {
    //     case "Angular":
    //       vmobj.SelectedViewModel = new StartupViewModel();
    //       break;

    //     case "C#":
    //       vmobj.SelectedViewModel = new StartupViewModel();
    //       break;
    //   }
    // }


    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

  }
}
