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
            Excel._Worksheet xlWorksheet3MLS, Excel.Range xlRange1MLS, Excel.Range xlRange2MLS,
            Excel.Range xlRange3MLS, Dictionary<string, int> rangeCount, Dictionary<string, int> relevantCols)
        {
            Console.WriteLine("Reached processorWork() function!");

            xlRange1MLS.Cells[2, relevantCols["MLSSellAgentCol1"]].Value = relevantCols["MLSSellAgentCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSSellOfficeCol1"]].Value = relevantCols["MLSSellOfficeCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSListAgentCol1"]].Value = relevantCols["MLSListAgentCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSListOfficeCol1"]].Value = relevantCols["MLSListOfficeCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSOwnerCol1"]].Value = relevantCols["MLSOwnerCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSCityCol1"]].Value = relevantCols["MLSCityCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSAddressCol1"]].Value = relevantCols["MLSAddressCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSCloseDateCol1"]].Value = relevantCols["MLSCloseDateCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSPriceCol1"]].Value = relevantCols["MLSPriceCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSGFCol1"]].Value = relevantCols["MLSGFCol1"];
            xlRange1MLS.Cells[2, relevantCols["MLSEscrowCol1"]].Value = relevantCols["MLSEscrowCol1"];

            xlRange2MLS.Cells[2, relevantCols["MLSAgentCol2"]].Value = relevantCols["MLSAgentCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSOfficeCol2"]].Value = relevantCols["MLSOfficeCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSOtherAgentCol2"]].Value = relevantCols["MLSOtherAgentCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSOtherOfficeCol2"]].Value = relevantCols["MLSOtherOfficeCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSOwnerCol2"]].Value = relevantCols["MLSOwnerCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSCityCol2"]].Value = relevantCols["MLSCityCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSAddressCol2"]].Value = relevantCols["MLSAddressCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSCloseDateCol2"]].Value = relevantCols["MLSCloseDateCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSPriceCol2"]].Value = relevantCols["MLSPriceCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSGFCol2"]].Value = relevantCols["MLSGFCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSEscrowCol2"]].Value = relevantCols["MLSEscrowCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSAsSACol2"]].Value = relevantCols["MLSAsSACol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSClosingsCol2"]].Value = relevantCols["MLSClosingsCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSTCCloseCol2"]].Value = relevantCols["MLSTCCloseCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSBSClosingCol2"]].Value = relevantCols["MLSBSClosingCol2"];
            xlRange2MLS.Cells[2, relevantCols["MLSBSTCCloseCol2"]].Value = relevantCols["MLSBSTCCloseCol2"];

            xlRange3MLS.Cells[2, relevantCols["MLSAgentCol3"]].Value = relevantCols["MLSAgentCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSOfficeCol3"]].Value = relevantCols["MLSOfficeCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSOwnerCol3"]].Value = relevantCols["MLSOwnerCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSCityCol3"]].Value = relevantCols["MLSCityCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSAddressCol3"]].Value = relevantCols["MLSAddressCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSCloseDateCol3"]].Value = relevantCols["MLSCloseDateCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSPriceCol3"]].Value = relevantCols["MLSPriceCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSGFCol3"]].Value = relevantCols["MLSGFCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSEscrowCol3"]].Value = relevantCols["MLSEscrowCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSAsSACol3"]].Value = relevantCols["MLSAsSACol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSClosingsCol3"]].Value = relevantCols["MLSClosingsCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSTCCloseCol3"]].Value = relevantCols["MLSTCCloseCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSBSClosingCol3"]].Value = relevantCols["MLSBSClosingCol3"];
            xlRange3MLS.Cells[2, relevantCols["MLSBSTCCloseCol3"]].Value = relevantCols["MLSBSTCCloseCol3"];
        }
    }
}
