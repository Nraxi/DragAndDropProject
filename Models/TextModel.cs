using Microsoft.AspNetCore.Components;

public class TextModel : ContentModel
{
    public string Text { get; set; }
    public bool IsBold { get; set; }
    public bool IsItalic { get; set; }

    public override MarkupString GetContent()
    {
        // Return as MarkupString
        var fontWeight = IsBold ? "bold" : "normal";
        var fontStyle = IsItalic ? "italic" : "normal";
        return (MarkupString)$"<span style='font-weight: {fontWeight}; font-style: {fontStyle};'>{Text}</span>";
    }
}
