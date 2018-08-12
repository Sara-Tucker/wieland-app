using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace wieland_app
{
    public static class CreateReportData
    {
        // maybe make ReportData object and return that??
        public static List<Vinyl> CreateReport(string blFileName, DateTime startDate, DateTime endDate)
        {
            var backlog = SerializeCsv.OpenBinFile<CsvBacklogOrder>(blFileName);
            var vinyls = SerializeCsv.OpenBinFile<Vinyl>("default_vinyl_list.bin");

            backlog.RemoveAll(order => order.SHIP_DATE < startDate || order.SHIP_DATE > endDate);

            foreach (var vinyl in vinyls)
            {
                foreach (var part in vinyl.VinylParts)
                {
                    foreach (var order in backlog)
                    {
                        if (order.ITEM_NUM == part.PartNumber)
                        {
                            part.TotalQuantity += order.ORDER_LINE_QTY;
                        }
                    }

                    part.CalcThisPartsTotalYards();
                }

                vinyl.VinylParts.RemoveAll(part => part.TotalQuantity == 0);
                vinyl.CalcVinylTotalYards();
            }

            vinyls.Sort((x, y) => y.TotalYards.CompareTo(x.TotalYards));

            return vinyls;
        }
    }
}