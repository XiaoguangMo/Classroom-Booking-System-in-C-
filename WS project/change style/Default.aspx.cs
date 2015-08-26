using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

//xml导出Excel文件，作者51aspx
namespace XML2Excel
{
    //该源码下载自www.51aspx.com(５１ａｓｐｘ．ｃｏｍ)
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                //要转换的XML文件
                string XMLFileName = Path.Combine(Request.PhysicalApplicationPath, "51aspx.xml");
                DataSet dsBook = new DataSet();
                dsBook.ReadXml(XMLFileName);
                int rows = dsBook.Tables[0].Rows.Count + 1;
                int cols = dsBook.Tables[0].Columns.Count;

                //将要生成的Excel文件
                string ExcelFileName = Path.Combine(Request.PhysicalApplicationPath, "51aspx.xls");
                if (File.Exists(ExcelFileName))
                {
                    File.Delete(ExcelFileName);
                }
                StreamWriter writer = new StreamWriter(ExcelFileName, false);
                writer.WriteLine("<?xml version=\"1.0\"?>");
                writer.WriteLine("<?mso-application progid=\"Excel.Sheet\"?>");
                writer.WriteLine("<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"");
                writer.WriteLine(" xmlns:o=\"urn:schemas-microsoft-com:office:office\"");
                writer.WriteLine(" xmlns:x=\"urn:schemas-microsoft-com:office:excel\"");
                writer.WriteLine(" xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\"");
                writer.WriteLine(" xmlns:html=\"http://www.w3.org/TR/REC-html40/\">");
                writer.WriteLine(" <DocumentProperties xmlns=\"urn:schemas-microsoft-com:office:office\">");
                writer.WriteLine("  <Author>Automated Report Generator Example</Author>");
                writer.WriteLine(string.Format("  <Created>{0}T{1}Z</Created>", DateTime.Now.ToString("yyyy-mm-dd"), DateTime.Now.ToString("HH:MM:SS")));
                writer.WriteLine("  <Company>51aspx.com</Company>");
                writer.WriteLine("  <Version>11.6408</Version>");
                writer.WriteLine(" </DocumentProperties>");
                writer.WriteLine(" <ExcelWorkbook xmlns=\"urn:schemas-microsoft-com:office:excel\">");
                writer.WriteLine("  <WindowHeight>8955</WindowHeight>");
                writer.WriteLine("  <WindowWidth>11355</WindowWidth>");
                writer.WriteLine("  <WindowTopX>480</WindowTopX>");
                writer.WriteLine("  <WindowTopY>15</WindowTopY>");
                writer.WriteLine("  <ProtectStructure>False</ProtectStructure>");
                writer.WriteLine("  <ProtectWindows>False</ProtectWindows>");
                writer.WriteLine(" </ExcelWorkbook>");
                writer.WriteLine(" <Styles>");
                writer.WriteLine("  <Style ss:ID=\"Default\" ss:Name=\"Normal\">");
                writer.WriteLine("   <Alignment ss:Vertical=\"Bottom\"/>");
                writer.WriteLine("   <Borders/>");
                writer.WriteLine("   <Font/>");
                writer.WriteLine("   <Interior/>");
                writer.WriteLine("   <Protection/>");
                writer.WriteLine("  </Style>");
                writer.WriteLine("  <Style ss:ID=\"s21\">");
                writer.WriteLine("   <Alignment ss:Vertical=\"Bottom\" ss:WrapText=\"1\"/>");
                writer.WriteLine("  </Style>");
                writer.WriteLine(" </Styles>");
                writer.WriteLine(" <Worksheet ss:Name=\"MyReport\">");
                writer.WriteLine(string.Format("  <Table ss:ExpandedColumnCount=\"{0}\" ss:ExpandedRowCount=\"{1}\" x:FullColumns=\"1\"", cols.ToString(), rows.ToString()));
                writer.WriteLine("   x:FullRows=\"1\">");

                //生成标题
                writer.WriteLine("<Row>");
                foreach (DataColumn eachCloumn in dsBook.Tables[0].Columns)
                {
                    writer.Write("<Cell ss:StyleID=\"s21\"><Data ss:Type=\"String\">");
                    writer.Write(eachCloumn.ColumnName.ToString());
                    writer.WriteLine("</Data></Cell>");
                }
                writer.WriteLine("</Row>");

                //生成数据记录
                foreach (DataRow eachRow in dsBook.Tables[0].Rows)
                {
                    writer.WriteLine("<Row>");
                    for (int currentRow = 0; currentRow != cols; currentRow++)
                    {
                        writer.Write("<Cell ss:StyleID=\"s21\"><Data ss:Type=\"String\">");
                        writer.Write(eachRow[currentRow].ToString());
                        writer.WriteLine("</Data></Cell>");
                    }
                    writer.WriteLine("</Row>");
                }
                writer.WriteLine("  </Table>");
                writer.WriteLine("  <WorksheetOptions xmlns=\"urn:schemas-microsoft-com:office:excel\">");
                writer.WriteLine("   <Selected/>");
                writer.WriteLine("   <Panes>");
                writer.WriteLine("    <Pane>");
                writer.WriteLine("     <Number>3</Number>");
                writer.WriteLine("     <ActiveRow>1</ActiveRow>");
                writer.WriteLine("    </Pane>");
                writer.WriteLine("   </Panes>");
                writer.WriteLine("   <ProtectObjects>False</ProtectObjects>");
                writer.WriteLine("   <ProtectScenarios>False</ProtectScenarios>");
                writer.WriteLine("  </WorksheetOptions>");
                writer.WriteLine(" </Worksheet>");
                writer.WriteLine(" <Worksheet ss:Name=\"Sheet2\">");
                writer.WriteLine("  <WorksheetOptions xmlns=\"urn:schemas-microsoft-com:office:excel\">");
                writer.WriteLine("   <ProtectObjects>False</ProtectObjects>");
                writer.WriteLine("   <ProtectScenarios>False</ProtectScenarios>");
                writer.WriteLine("  </WorksheetOptions>");
                writer.WriteLine(" </Worksheet>");
                writer.WriteLine(" <Worksheet ss:Name=\"Sheet3\">");
                writer.WriteLine("  <WorksheetOptions xmlns=\"urn:schemas-microsoft-com:office:excel\">");
                writer.WriteLine("   <ProtectObjects>False</ProtectObjects>");
                writer.WriteLine("   <ProtectScenarios>False</ProtectScenarios>");
                writer.WriteLine("  </WorksheetOptions>");
                writer.WriteLine(" </Worksheet>");
                writer.WriteLine("</Workbook>");
                writer.Close();
                Response.Write("<script language=\"javascript\">" + "alert('" + "转换成功! 转换后的Excel文件名为: 51aspx.xls')" + "</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script language=\"javascript\">" + "alert('" + "操作失败! 出错信息: " + ex.Message + "')" + "</script>");
            }

        }
    }
}