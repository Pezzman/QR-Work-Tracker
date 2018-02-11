using System;
namespace WorkTracker.Models
{
    public class ScanJobModel
    {
        public string WorkSite { get; set; }
        public string Job { get; set; }
        public string Fix { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
    }
}
