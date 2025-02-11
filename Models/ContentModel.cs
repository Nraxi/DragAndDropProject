using Microsoft.AspNetCore.Components;

public abstract class ContentModel
{
    public int Id { get; set; }
    public int? SelectedContainerId { get; set; }
    public bool IsEditing { get; set; } = false; 
    public bool ShowEditButton { get; set; }
    public abstract MarkupString GetContent();
    public string TextAlign { get; set; } = "left"; // Default alignment
}
