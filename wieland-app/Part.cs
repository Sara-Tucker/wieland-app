using System;

namespace wieland_app
{
	[Serializable]public class Part
	{
		public string PartNumber { get; set; }
		public float ThisPartsLy { get; set; }
		public int TotalQuantity { get; set; }
	    public float TotalYards { get; set; }


		public Part(string partNumber, float thisPartsLy)
		{
			PartNumber = partNumber;
			ThisPartsLy = thisPartsLy;
			TotalQuantity = 0;
		    TotalYards = 0f;
		}


		public void CalcThisPartsTotalYards()
		{
			TotalYards = ThisPartsLy * TotalQuantity;
		}
	}
}
