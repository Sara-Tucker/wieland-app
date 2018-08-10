using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace wieland_app
{
	public static class CreateReportData
	{





		public static List<VinylQty> VinylQtyData(DateTime startDate, DateTime endDate, string fileName, string creationDate = "")
		{
			var backlog = SerializeCsv.OpenBinFile<CsvBacklogOrder>(fileName, creationDate);
			backlog.RemoveAll(Order => Order.SHIP_DATE < startDate);
			backlog.RemoveAll(Order => Order.SHIP_DATE > endDate);

			List<VinylQty> mainList = new List<VinylQty>();
			List<CsvVinyl> vinylList = SerializeCsv.OpenBinFile<CsvVinyl>("vinyl_color_ids.bin");
			List<CsvBasePart> partList = SerializeCsv.OpenBinFile<CsvBasePart>("yards.bin");
			foreach (var row in vinylList)
			{
				mainList.Add(new VinylQty(row.Color, row.CustomerFabricNumber, row.WielandNum, 0, 0));
			}

			foreach (VinylQty row in mainList)
			{
				foreach (CsvBacklogOrder blrow in backlog)
				{
					foreach (var yardrow in partList)
					{
						
					}
					if (blrow.ITEM_NUM == row.CustomerFabricNumber)
					{
						row.TotalQuantity += blrow.ORDER_LINE_QTY;
					}
				}
			}

			foreach (VinylQty row in mainList)
			{
				foreach (var VARIABLE in COLLECTION)
				{
					
				}
			}

			return mainList;
		}



	}
}
