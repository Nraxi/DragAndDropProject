using Microsoft.AspNetCore.Components;

public abstract class ContentModel
{
    public int Id { get; set; }
    public int? SelectedContainerId { get; set; }

    public abstract MarkupString GetContent();
}