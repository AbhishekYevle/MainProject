
/// <summary>
/// Model [ "The Content Creator" ]
/// The model class holds the data. The model can be referred to as the data file for the front-end of the application.
/// </summary>

namespace MainProject.Model
{
  // Main Menu Items
  public class MenuItems
  {
    public string MenuName { get; set; }
    public string MenuImage { get; set; }
  }

  // Student Page
  public class StudentItems
  {
    public string StudentName { get; set; }
    public string StudentImage { get; set; }
  }

  // StudentLogin Page
  public class StudentLoginItems
  {
    public string StudentLoginName { get; set; }
    public string StudentLoginImage { get; set; }
  }

  // StudentLogin Page
  public class TeacherItems
  {
    public string TeacherName { get; set; }
    public string TeacherImage { get; set; }
  }
  public class TeacherLoginItems
  {
    public string TeacherLoginName { get; set; }
    public string TeacherLoginImage { get; set; }
  }

  // <----------------------- Database Section ----------------------->

}
