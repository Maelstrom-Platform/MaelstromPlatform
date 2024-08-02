using Radzen;

namespace MaelstromPlatform.UI.Components.Common
{
    public class MaelstromDataGridColumn
    {
        public string Property { get; set; }
        public bool Filterable { get; set; }
        public string Title { get; set; }
        public bool Frozen { get; set; }
        public ushort Width { get; set; }
        public TextAlign TextAlign { get; set; }
    }
}