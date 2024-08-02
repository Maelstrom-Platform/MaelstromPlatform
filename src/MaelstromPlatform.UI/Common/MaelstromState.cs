namespace MaelstromPlatform.UI.Common
{
    public class MaelstromState
    {
        public string Account { get; set; } = string.Empty;
        public string Organization { get; set; } = string.Empty;
        public string ActiveService { get; set; } = "Home";
        public List<MaelstromMenuItem> ServiceMenuItems { get; set; } = new();
        public List<MaelstromMenuItem> ServiceItemMenuItems { get; set; } = new();
        public Action StateChanged;
    }
}
