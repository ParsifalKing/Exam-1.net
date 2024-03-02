using Infrastructure.DataContext;
using Dapper;
using Domain.Models;

namespace Infrastructure.Services;

public class GroupStudent_Service
{
    private readonly DapperContext _context;

    public GroupStudent_Service()
    {
        _context = new DapperContext();
    }

    public void Add(GroupStudent some)
    {
        var sql = @"insert into Group_Student(GroupId,StudentId)
                    values(@GroupId,@StudentId)";
        _context.Connection().Execute(sql, some);
    }



    public List<CourseGroup> Get()
    {
        var sql = @"select * from Group_Student";
        return _context.Connection().Query<CourseGroup>(sql).ToList();
    }

    public void Update(CourseGroup some)
    {
        var sql = @"update Group_Student set GroupId=@GroupId,StudentId=@StudentId, where Id=@Id";
        _context.Connection().Execute(sql, some);
    }

    public List<ServiceType> GetStudentsById(int id)
    {
        var sql = @"select * from Students as s
join Group_Student as gs on s.Id = gs.StudentId
where gs.GroupId = @Id
          ";

        return _context.Connection().Query<ServiceType>(sql, new { Id = id }).ToList();
    }

    public List<ServiceType> GetStudents()
    {
        var sql = @"select * from Students as s
        join Group_Student as gs on s.Id = gs.StudentId
        ";

        return _context.Connection().Query<ServiceType>(sql).ToList();
    }

    public void Delete(int id)
    {
        var sql = @"delete from Group_Student where StudentId = @Id";
        _context.Connection().Execute(sql, new { Id = id });
    }






}
