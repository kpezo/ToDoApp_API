using System.Security;

namespace ToDoApp_API.Models.Rresponse
{
    public record TaskReponse(
    int id,
    string Name,
    string Description,
    string Status,
    string Priority,
    DateTime DueDate
    );
}
