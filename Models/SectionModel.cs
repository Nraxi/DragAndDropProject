using Microsoft.AspNetCore.Components;

using System.Collections.Generic;

namespace DragAndDropProject.Models
{
    public class SectionModel : ContentModel
    {
        public string Title { get; set; }
        public List<ContentModel> InnerBoxes { get; set; } = new List<ContentModel>(); // Lista över boxar i containern

        public override MarkupString GetContent()
        {
            return (MarkupString)Title; // Returnera titeln för containern som MarkupString
        }
    }

}