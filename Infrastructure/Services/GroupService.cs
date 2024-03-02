using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class GroupService : IService<Group>
{
    private readonly DapperContext _context;

    public GroupService()
    {
        _context = new DapperContext();
    }

    public void Add(Group some)
    {
        var sql = @"insert into Groups(GroupName)
                    values(@GroupName)";
        _context.Connection().Execute(sql, some);
    }

    public void Delete(int id)
    {
        var sql = @"delete from Groups where Id = @Id";
        _context.Connection().Execute(sql, new { Id = id });
    }

    public List<Group> Get()
    {
        var sql = @"select * from Groups";
        return _context.Connection().Query<Group>(sql).ToList();
    }

    public void Update(Group some)
    {
        var sql = @"update Groups set GroupName=@GroupName where Id=@Id";
        _context.Connection().Execute(sql, some);
    }

    public int Get()
    {
        var sql = @"select Count(*) from Groups";
        return _context.Connection().Query<int>(sql);
    }

}
