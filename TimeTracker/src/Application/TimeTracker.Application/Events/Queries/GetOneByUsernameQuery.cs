using TimeTracker.Application.Events.Queries.Abstractions;
using TimeTracker.Application.Models.Abstractions;

namespace TimeTracker.Application.Events.Queries;

public class GetOneByUsernameQuery<TModel>(string username) : GetOneQuery<TModel>
    where TModel : BaseModel
{
    public string Username { get; set; } = username;
}