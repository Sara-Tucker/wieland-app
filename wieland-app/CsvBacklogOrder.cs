using System;

namespace wieland_app
{
	[Serializable]public class CsvBacklogOrder
	{
		public string ITEM_NUM { get; set; }
		public int ORDER_LINE_QTY { get; set; }
		public DateTime SHIP_DATE { get; set; }
	}
}