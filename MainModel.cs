

using System.Collections.ObjectModel;
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

  // Error Message Items
  public class ErrorItem
  {
    public string ErrorMessage { get; set; }
  }

  // Student Page
  public class StudentMenuItems
  {
    public string StudentMenu { get; set; }
    public string StudentMenuImage { get; set; }

  }
  // Student Login Page
  public class StudentLoginItems
  {
    public string stdLoginEMail { get; set; }
    public string stdLoginPassword { get; set; }
  }

  // Student Information Page 
  public class StudentInfoMenuItems
  {
    public string StudentInfoMenu { get; set; }
    public string StudentInfoMenuImage { get; set; }
  }

  // Teacher login Items
  public class TeacherLoginItems
  {
    public string tchrLoginEMail { get; set; }
    public string tchrLoginPassword { get; set; }
  }


  // TeacherLogin Page
  public class TeacherItems
  {
    public string TeacherName { get; set; }
    public string TeacherImage { get; set; }
  }

  // <----------------------- Database Section ----------------------->
  public class PropDatabase
  {
    public string EMail { get; set; }
    public string Password { get; set; }
  }

  // <----------------------- Student Table Section ----------------------->
  public class StudentRegisterItems
  {
    public string stdFirstName { get; set; }
    public string stdLastName { get; set; }
    public string stdEnrollNumber { get; set; }
    public string stdMobileNumber { get; set; }
    public string stdEMail { get; set; }
    public string stdCollege { get; set; }
    public string stdDispline { get; set; }
    public string stdPassword { get; set; }
    public string stdConfirmPassword { get; set; }
  }

  // <----------------------- Teacher Table Section ----------------------->
  public class TeacherRegisterItems
  {
    public string tchrFirstName { get; set; }
    public string tchrLastName { get; set; }
    public string tchrEmployeeNumber { get; set; }
    public string tchrMobileNumber { get; set; }
    public string tchrEMail { get; set; }
    public string tchrCollege { get; set; }
    public string tchrSubject { get; set; }
    public string tchrPassword { get; set; }
    public string tchrConfirmPassword { get; set; }

  }

  // Course Page
  public class CourseItems
  {
    public string CourseName { get; set; }
    public string CourseImage { get; set; }
  }

}
