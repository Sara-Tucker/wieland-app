using System;

namespace wieland_app
{
	[Serializable]public class Part
	{
		public string PartNumber { get; set; }
		public float ThisPartsLy { get; set; }
		public int TotalQuantity { get; set; }


		public Part(string partNumber, float thisPartsLy, int totalQuantity)
		{
			PartNumber = partNumber;
			ThisPartsLy = thisPartsLy;
			TotalQuantity = totalQuantity;
		}


		public float CalcThisPartsTotalYards()
		{
			return ThisPartsLy * TotalQuantity;
		}
	}
}
