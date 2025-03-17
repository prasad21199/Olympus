using ClosedXML.Excel;

namespace IceHRM.GenericUtils
{
    public class ExcelUtils
    {
        public CSharpUtils csharp;
        /// <summary>
        /// this method is to get the data from excel
        /// </summary>
        /// <param name="sheetname"></param>
        /// <param name="row"></param>
        /// <param name="cell"></param>
        /// <returns></returns>
        public string GetExcelData(string sheetname, int row, int cell)
        {
            csharp = new CSharpUtils();
            string path = csharp.GetFullPath(IPathConstant.EXCEL_PATH);
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet sheet = wb.Worksheet(sheetname);
            return sheet.Row(row).Cell(cell).GetValue<string>();
        }
        /// <summary>
        /// this method is to set the data into excel sheet
        /// </summary>
        /// <param name="sheetname"></param>
        /// <param name="row"></param>
        /// <param name="cell"></param>
        /// <param name="value"></param>
        public void SetExcelData(string sheetname, int row, int cell, string value)
        {
            string path = csharp.GetFullPath(IPathConstant.EXCEL_PATH);
            XLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet sheet = wb.Worksheet(sheetname);
            sheet.Row(row).Cell(cell).SetValue(value);
            wb.Save();
        }
    }
}
