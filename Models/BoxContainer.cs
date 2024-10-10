using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace DragAndDropProject.Models
{
    public class BoxContainer : BoxBase
{
    public string Title { get; set; }
    public List<BoxBase> InnerBoxes { get; set; } = new List<BoxBase>(); // Lista över boxar i containern

    public override MarkupString GetContent()
    {
        return (MarkupString)Title; // Returnera titeln för containern som MarkupString
    }
}

}
