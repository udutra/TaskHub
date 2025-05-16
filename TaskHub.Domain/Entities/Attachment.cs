namespace TaskHub.Domain.Entities;

public class Attachment : EntityBase{
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public Guid TaskItemId { get; set; }
    public TaskItem TaskItem { get; set; }
}