using System;

namespace wieland_app
{
    [Serializable]public class CsvStool
    {
        public string Fabric { get; set; }
        public string PartNum { get; set; }
        public float Yards { get; set; }
    }
}