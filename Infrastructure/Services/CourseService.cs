using Infrastructure.DataContext;
using Dapper;
using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
    private readonly DapperContext _context;

    public CourseService()
    {
        _context = new DapperContext();
    }

    public void Add(Course some)
    {
        var sql = @"insert into Courses(CourseName)
                    values(@CourseName)";
        _context.Connection().Execute(sql, some);
    }

    public void Delete(int id)
    {
        var sql = @"delete from Courses where Id = @Id";
        _context.Connection().Execute(sql, new { Id = id });
    }

    public List<Course> Get()
    {
        var sql = @"select * from Courses";
        return _context.Connection().Query<Course>(sql).ToList();
    }

    public void Update(Course some)
    {
        var sql = @"update Courses set CourseName=@CourseName where Id=@Id";
        _context.Connection().Execute(sql, some);
    }
}
