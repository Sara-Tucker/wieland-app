using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace wieland_app
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			SerializeCsv.SerializeBacklogCsv(@"D:\zCsharp\New Wieland\backlog.csv", new DateTime(2018, 8, 10));
			SerializeCsv.SerializeVinylCsv();
			SerializeCsv.SerializeBasePartCsv();





			//Console.WriteLine($"{item.ITEM_NUM} {item.ORDER_LINE_QTY} {item.SHIP_DATE.ToShortDateString()}");

			//var backlog = SerializeCsv.OpenBinFile<CsvBacklogOrder>("\\BL-Aug8.bin", "Aug8");
			//foreach (var row in backlog)
			//{
			//	Debug.WriteLine($"{row.ITEM_NUM} {row.SHIP_DATE}");
			//}

			//var vinylData = CreateReportData.VinylQtyData(new DateTime(2018, 7, 1), new DateTime(2018, 8, 1), "\\BL-Aug8.bin", "Aug8");
			//foreach (VinylQty row in vinylData)
			//{
			//	Debug.WriteLine(row + " " + row);
			//}
		}
	}
}
