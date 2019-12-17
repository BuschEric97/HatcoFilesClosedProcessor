using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HatcoFilesClosedProcessor
{
    class Processor
    {
        public void mainProcessor(string MLSFileName)
        {
            Application.UseWaitCursor = true; // set the cursor to waiting symbol

            // open all excel files for use
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbookMLS = null;
            try
            {
                xlWorkbookMLS = xlApp.Workbooks.Open(MLSFileName);
            }
            catch (Exception ex) // catch possible "file could not open" exception
            {
                throw ex;
            }

            if (xlWorkbookMLS != null)
            {
                // open worksheets and range in excel files for use
                Excel._Worksheet xlWorksheet1MLS = xlWorkbookMLS.Sheets[1];
                Excel._Worksheet xlWorksheet2MLS = xlWorkbookMLS.Sheets[2];
                Excel._Worksheet xlWorksheet3MLS = xlWorkbookMLS.Sheets[3];
                Excel.Range xlRange1MLS = xlWorksheet1MLS.UsedRange;
                Excel.Range xlRange2MLS = xlWorksheet2MLS.UsedRange;
                Excel.Range xlRange3MLS = xlWorksheet3MLS.UsedRange;

                Dictionary<string, int> rangeCount = new Dictionary<string, int>();
                Dictionary<string, int> relevantCols = new Dictionary<string, int>();

                try
                {
                    rangeCount.Add("rowCount1MLS", xlRange1MLS.Rows.Count);
                    rangeCount.Add("rowCount2MLS", xlRange2MLS.Rows.Count);
                    rangeCount.Add("rowCount3MLS", xlRange3MLS.Rows.Count);
                    rangeCount.Add("colCount1MLS", xlRange1MLS.Columns.Count);
                    rangeCount.Add("colCount2MLS", xlRange2MLS.Columns.Count);
                    rangeCount.Add("colCount3MLS", xlRange3MLS.Columns.Count);

                    Console.WriteLine("Worksheet 1: " + rangeCount["colCount1MLS"] + "x" + rangeCount["rowCount1MLS"]);
                    Console.WriteLine("Worksheet 2: " + rangeCount["colCount2MLS"] + "x" + rangeCount["rowCount2MLS"]);
                    Console.WriteLine("Worksheet 3: " + rangeCount["colCount3MLS"] + "x" + rangeCount["rowCount3MLS"]);

                    ///TO-DO: Write code to find relevant columns for all 3 worksheets

                    ProcessorWork proc = new ProcessorWork();
                    proc.processorWork(xlWorksheet1MLS, xlWorksheet2MLS, xlWorksheet3MLS, rangeCount, relevantCols);
                }
                catch (Exception ex) // if an exception is caught, close the excel files so they aren't held hostage
                {
                    Console.WriteLine("Problem with determiner processing. Closing excel files.");

                    // cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    // release com objects so the excel processes are
                    // fully killed from running in the background
                    Marshal.ReleaseComObject(xlRange1MLS);
                    Marshal.ReleaseComObject(xlRange2MLS);
                    Marshal.ReleaseComObject(xlRange3MLS);
                    Marshal.ReleaseComObject(xlWorksheet1MLS);
                    Marshal.ReleaseComObject(xlWorksheet2MLS);
                    Marshal.ReleaseComObject(xlWorksheet3MLS);

                    // save, close, and release workbooks
                    xlWorkbookMLS.Close();
                    Console.WriteLine("closed MLS workbook");
                    Marshal.ReleaseComObject(xlWorkbookMLS);

                    // quit and release excel app
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);

                    throw ex;
                }

                // cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // release com objects so the excel processes are
                // fully killed from running in the background
                Marshal.ReleaseComObject(xlRange1MLS);
                Marshal.ReleaseComObject(xlRange2MLS);
                Marshal.ReleaseComObject(xlRange3MLS);
                Marshal.ReleaseComObject(xlWorksheet1MLS);
                Marshal.ReleaseComObject(xlWorksheet2MLS);
                Marshal.ReleaseComObject(xlWorksheet3MLS);

                // save, close, and release workbooks
                xlWorkbookMLS.Save();
                Console.WriteLine("saved MLS workbook");
                xlWorkbookMLS.Close();
                Console.WriteLine("closed MLS workbook");
                Marshal.ReleaseComObject(xlWorkbookMLS);

                // quit and release excel app
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }

            Application.UseWaitCursor = false; // set the cursor back to default
        }
    }
}
