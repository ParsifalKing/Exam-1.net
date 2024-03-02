
using Infrastructure.Services;

var gsServ = new GroupStudent_Service();
var cgServ = new CourseGroup_Service();
// foreach (var item in gsServ.GetStudentsById(1))
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.FullName);
//     System.Console.WriteLine(item.Age);
//     System.Console.WriteLine("--------------");
// }

// foreach (var item in gsServ.GetStudents())
// {
//     System.Console.WriteLine(item.GroupId);
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.FullName);
//     System.Console.WriteLine(item.Age); 
//     System.Console.WriteLine("--------------");
// }

// foreach (var item in cgServ.GetGroupsOfCourse())
// {
//     System.Console.WriteLine(item.CourseId);
//     System.Console.WriteLine(item.GroupName);
//     System.Console.WriteLine(item.GroupId);
//     System.Console.WriteLine("--------------");
// }

gsServ.Delete(6);