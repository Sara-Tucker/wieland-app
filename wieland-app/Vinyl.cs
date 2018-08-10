using System;
using System.Collections.Generic;

namespace wieland_app
{
	[Serializable]public class Vinyl
	{
		public string Color { get; set; }
		public string CustomerFabricNumber { get; set; }
		public string WielandFabricNumber { get; set; }
		public List<Part> VinylParts { get; set; }


		public Vinyl(string color, string customerFabricNumber, string wielandFabricNumber)
		{
			Color = color;
			CustomerFabricNumber = customerFabricNumber;
			WielandFabricNumber = wielandFabricNumber;
			VinylParts = new List<Part>();
		}


		public float CalcVinylTotalYards()
		{
			float vinylTotalYards = 0;
			foreach (var part in VinylParts)
			{
				vinylTotalYards += part.CalcThisPartsTotalYards();
			}
			return vinylTotalYards;
		}
	}
}
