
using System.Windows.Controls;
using MainProject.ViewModel;

namespace MainProject.View
{
  /// <summary>
  /// Interaction logic for CourseView.xaml
  /// </summary>
  public partial class CourseView : UserControl
  {
    CourseViewModel csobj = new CourseViewModel();
    public CourseView()
    {
      InitializeComponent();
      DataContext = csobj;
    }
  }
}
