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
    class ProcessorWork
    {
        public void processorWork(Excel._Worksheet xlWorksheet1MLS, Excel._Worksheet xlWorksheet2MLS,
            Excel._Worksheet xlWorksheet3MLS, Dictionary<string, int> rangeCount, Dictionary<string, int> relevantCols)
        {
            Console.WriteLine("Reached processorWork() function!");
        }
    }
}
