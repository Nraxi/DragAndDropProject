using Microsoft.AspNetCore.Components;

public class ImageModel : ContentModel
{
    public string ImageUrl { get; set; }
    public int Height { get; set; } = 100; // Default height
    public int Width { get; set; } = 100; // Default width
    public int BorderRadius { get; set; } = 0; // Default border radius

    public override MarkupString GetContent()
    {
        // Return as MarkupString
        return (MarkupString)$"<img src='{ImageUrl}' height='{Height}' width='{Width}' style='border-radius: {BorderRadius}px;' />";
    }
}
