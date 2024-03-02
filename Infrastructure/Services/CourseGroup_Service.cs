using Domain.Models;
using Dapper;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class CourseGroup_Service
{
    private readonly DapperContext _context;

    public CourseGroup_Service()
    {
        _context = new DapperContext();
    }

    public void Add(CourseGroup some)
    {
        var sql = @"insert into Course_Group(CourseId,GroupId)
                    values(@CourseId,@GroupId)";
        _context.Connection().Execute(sql, some);
    }


    public List<CourseGroup> Get()
    {
        var sql = @"select * from Course_Group";
        return _context.Connection().Query<CourseGroup>(sql).ToList();
    }

    public void Update(CourseGroup some)
    {
        var sql = @"update Course_Group set CourseId=@CourseId,GroupId=@GroupId where Id=@Id";
        _context.Connection().Execute(sql, some);
    }

    public List<ServiceType> GetGroupsOfCourse()
    {
        var sql = @"select * from Groups as g
join Course_Group as cg on g.Id = cg.GroupId
        ";

        return _context.Connection().Query<ServiceType>(sql).ToList();
    }


}
