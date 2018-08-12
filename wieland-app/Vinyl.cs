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
	    public float TotalYards { get; set; }


		public Vinyl(string color, string customerFabricNumber, string wielandFabricNumber)
		{
			Color = color;
			CustomerFabricNumber = customerFabricNumber;
			WielandFabricNumber = wielandFabricNumber;
			VinylParts = new List<Part>();
		    TotalYards = 0f;
		}


		public void CalcVinylTotalYards()
		{
		    float total = 0f;
			foreach (var part in VinylParts)
			{
				total += part.TotalYards;
			}
		    TotalYards = total;
		}
	}
}
