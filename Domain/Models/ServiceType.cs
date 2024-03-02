namespace Domain.Models;

public class ServiceType
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string GroupName { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
}
