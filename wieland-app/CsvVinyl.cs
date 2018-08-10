using System;

namespace wieland_app
{
	[Serializable]public class CsvVinyl
	{
		public string Pattern { get; set; }
		public string Color { get; set; }
		public string CustomerFabricNumber { get; set; }
		public string WielandNum { get; set; }
	}
}