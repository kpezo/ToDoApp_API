namespace ToDoApp_API.Models.Rresponse
{
    public record TodoNumeratorResponse(
    int Inprogress,
    int Done,
    int Late,
    int Total
    );
}
