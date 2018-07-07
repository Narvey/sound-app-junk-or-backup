using System;

namespace ReThankListening.Models
{
    public enum ItemType
    {
        Memorization,
        Podcast,
        Ebook,
        Music
    }
    public class Item
    {
        public string Id { get; set; }
        public ItemType Type { get; set; }
        public string Text { get; set; }
        public string tempURIspot { get; set; }
        public Location Source { get; set; }
        public bool IsDownloaded { get; set; }

        private Location LocalCopyField;
        public Location LocalCopy { get => LocalCopyField; set => LocalCopyField = value; }
    }

}