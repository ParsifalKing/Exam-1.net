using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class StudentService : IService<Student>
{
    private readonly DapperContext _context;

    public StudentService()
    {
        _context = new DapperContext();
    }

    public void Add(Student some)
    {
        var sql = @"insert into Students(FullName,Age)
                    values(@FullName,@Age)";
        _context.Connection().Execute(sql, some);
    }

    public void Delete(int id)
    {
        var sql = @"delete from Students where Id = @Id";
        _context.Connection().Execute(sql, new { Id = id });
    }

    public List<Student> Get()
    {
        var sql = @"select * from Students";
        return _context.Connection().Query<Student>(sql).ToList();
    }

    public void Update(Student some)
    {
        var sql = @"update Students set FullName=@FullName,Age=@Age where Id=@Id";
        _context.Connection().Execute(sql, some);
    }

}
