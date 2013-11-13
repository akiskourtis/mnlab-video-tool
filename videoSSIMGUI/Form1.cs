using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;
using ZedGraph;
using System.Xml;
using System.Xml.Linq;

namespace videoSSIMGUI
{
    public partial class Form1 : Form
    {

        csFunctions hsFunctions = new csFunctions();
        string excelPath = "", origFilename = "", decFilename = "", colorFilename = "";
        Boolean qpEnc = false;
        Boolean bitrateEnc = false;
        int ID = 0;
        BackgroundWorker bw = new BackgroundWorker();
        ArrayList MVExcelFiles;
        string output = "";

        List<Picture> pics;
        //List<Picture> sortedPics;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "yuv files (*.yuv)|*.yuv|All files (*.*)|*.*";
            openFileDialogEnc.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            openFileDialogXml.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialogXml.Title = "Select one .264 xml file";

            openFileDialogExcel.Filter = "Excel Files (*.xls)|*.xls|(*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialogExcel.Multiselect = true;
            openFileDialogExcel.Title = "Select on or more MV excels";

            widthTxt.SelectedValue = 1;
            heightTxt.SelectedValue = 1;


            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            //tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);


        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }


        }

        private void btnFileXml_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogXml.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string selected = openFileDialogXml.FileName;

                txtXmlFile.Text = selected;
            }
        }


        private void btnExcelMotion_Click(object sender, EventArgs e)
        {
            try
            {
                string dir = Path.GetDirectoryName(txtXmlFile.Text);
                string filename = Path.GetFileName(txtXmlFile.Text);
                filename = filename.Replace(".xml", "");

                double sumMVFrame = 0;
                int count = 1;
                int countFrameMvs = 0;
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                foreach (Picture pic in pics)
                {
                    foreach (MacroBlock macroblock in pic.macroBlocks)
                    {
                        if (macroblock.motionVectors.Count > 0)
                        {
                            foreach (MotionVector mv in macroblock.motionVectors)
                            {
                                sumMVFrame += Math.Sqrt(Math.Pow(mv.absX, 2) + Math.Pow(mv.absY, 2));
                                countFrameMvs++;
                            }
                        }
                        if (macroblock.hasSubMacroBlocks())
                        {
                            foreach (SubMacroBlock submacroblock in macroblock.subMacroBlocks)
                            {
                                foreach (MotionVector mv in submacroblock.motionVectors)
                                {
                                    int x2 = Convert.ToInt32(Math.Pow(mv.absX, 2));
                                    int y2 = Convert.ToInt32(Math.Pow(mv.absY, 2));
                                    sumMVFrame += Math.Sqrt(x2 + y2);
                                    countFrameMvs++;
                                }
                            }
                        }
                    }

                    xlWorkSheet.Cells[count, 1] = sumMVFrame;
                    xlWorkSheet.Cells[count, 2] = countFrameMvs;
                    countFrameMvs = 0;
                    sumMVFrame = 0;
                    count++;
                    txtXmlOut.AppendText(count + "\n");
                }


                xlWorkBook.SaveAs(dir + @"\" + filename + "_motion.xls",
                    Excel.XlFileFormat.xlWorkbookNormal, misValue,
                    misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                txtXmlOut.AppendText("Excel " + dir + filename + "_motion.xls" + " Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {


            XmlTextReader reader = new XmlTextReader(txtXmlFile.Text);
            XmlTextReader readerCount = new XmlTextReader(txtXmlFile.Text);

            Picture pic = new Picture();
            MacroBlock mb = new MacroBlock();
            SubMacroBlock smb = new SubMacroBlock();
            MotionVector mv = new MotionVector();
            int x = 0, y = 0;
            string mode = "", modeCord = "", modeMVType = "";
            int countPics = 0, currentPicNum = 0;

            pics = new List<Picture>();

            while (readerCount.Read())
            {
                switch (readerCount.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        if (readerCount.Name == "Picture")
                        {
                            countPics++;
                        }
                        break;
                }
            }


            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        if (reader.Name == "Picture")
                        {
                            pic = new Picture();

                            mode = "pic";
                            currentPicNum++;
                            pic.id = currentPicNum;
                            pic.poc = Convert.ToInt32(reader.GetAttribute("poc"));
                            int progress = (currentPicNum * 100) / countPics;
                            bw.ReportProgress(progress);

                        }
                        else if (reader.Name == "MacroBlock")
                        {
                            mb = new MacroBlock();
                            mode = "mb";
                        }
                        else if (reader.Name == "Position")
                        {
                            mode = "pos";
                        }
                        else if (reader.Name == "SubMacroBlock")
                        {
                            smb = new SubMacroBlock();
                            mode = "smb";
                        }
                        else if (reader.Name == "MotionVector")
                        {
                            mv = new MotionVector();
                            //mode = "mv";
                        }
                        else if (reader.Name == "Difference")
                        {
                            modeMVType = "diff";
                        }
                        else if (reader.Name == "Absolute")
                        {
                            modeMVType = "abs";
                        }
                        else if (reader.Name == "X")
                        {
                            modeCord = "x";
                        }
                        else if (reader.Name == "Y")
                        {
                            modeCord = "y";
                        }

                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        if (modeCord == "x")
                        {
                            x = Convert.ToInt32(reader.Value);
                            modeCord = "";
                        }
                        else if (modeCord == "y")
                        {
                            y = Convert.ToInt32(reader.Value);
                            modeCord = "";
                        }

                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        if (reader.Name == "Picture")
                        {
                            pics.Add(pic);

                        }
                        else if (reader.Name == "MacroBlock")
                        {
                            pic.macroBlocks.Add(mb);
                        }
                        else if (reader.Name == "Position")
                        {
                            mb.posX = x;
                            mb.posY = y;
                        }
                        else if (reader.Name == "SubMacroBlock")
                        {
                            mb.subMacroBlocks.Add(smb);
                        }
                        else if (reader.Name == "MotionVector")
                        {
                            if (mode == "mb")
                            {
                                mb.motionVectors.Add(mv);
                            }
                            else if (mode == "smb")
                            {
                                smb.motionVectors.Add(mv);
                            }
                        }
                        else if (reader.Name == "Difference")
                        {
                            mv.diffX = x;
                            mv.diffY = y;
                        }
                        else if (reader.Name == "Absolute")
                        {
                            mv.absX = x;
                            mv.absY = y;

                        }
                        /*output = ("</" + reader.Name);
                        output += (">");*/
                        break;
                }


            }

            //output = "Xml has been transformed to an array";
            pics = pics.OrderBy(p => p.poc).ToList();

            //Console.WriteLine(pics.ToString());


        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.txtXmlOut.Text = (e.ProgressPercentage.ToString() + "%\n");
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.txtXmlOut.AppendText(output);
            this.txtXmlOut.AppendText("Xml has been transformed to a ReSorted Array. Completed!");
            btnExcelMotion.Enabled = true;
        }
        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            //validate the current page, to cancel the select use:
            if (current.Text.Contains("SSIM&PSNR metrics"))
            {
                zedGraphControl1.Visible = true;
            }
            e.Cancel = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnGraph_Click(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl1);
            zedGraphControl1.Refresh();
        }

        // Build the Chart
        private void CreateGraph(ZedGraphControl zg1)
        {
            // Get a reference to the GraphPane
            GraphPane myPane = zg1.GraphPane;

            // Set the titles
            myPane.Title.Text = "My Test Date Graph";
            myPane.XAxis.Title.Text = "Date";
            myPane.XAxis.Title.Text = "My Y Axis";

            // Make up some random data points
            double x, y;
            PointPairList list = new PointPairList();
            for (int i = 0; i < 36; i++)
            {
                x = (double)new XDate(1995, 5, i + 11);
                y = Math.Sin((double)i * Math.PI / 15.0);
                list.Add(x, y);
            }

            // Generate a red curve with diamond
            // symbols, and "My Curve" in the legend
            CurveItem myCurve = myPane.AddCurve("My Curve",
                  list, Color.Red, SymbolType.Diamond);

            // Set the XAxis to date type
            myPane.XAxis.Type = AxisType.Date;

            // Tell ZedGraph to refigure the axes since the data 
            // have changed
            zg1.AxisChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process pr;
            string avsProgram = "";
            string origDecSSIMFilename = "", origColorSSIMFilename = "", decColorSSIMFilename = "";
            /*avsProgram = "orig = rawsource(\"" + OrigTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
            "decod = rawsource(\"" + DecTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
            "Compare(orig, decod, \"\", \"psnr.log\")";
       
            System.IO.File.WriteAllText(Path.GetDirectoryName(DecTxt.Text)+@"\psnr.avs", avsProgram);
            Process.Start(Path.GetDirectoryName(DecTxt.Text) + @"\psnr.avs").WaitForExit();
            */
            origFilename = hsFunctions.csSplit(OrigTxt.Text, hsFunctions.csWordCount(OrigTxt.Text, @"\"), @"\");
            decFilename = hsFunctions.csSplit(DecTxt.Text, hsFunctions.csWordCount(DecTxt.Text, @"\"), @"\");

            if (checkBoxWhiteSSIM.Checked)
            {
                colorFilename = hsFunctions.csSplit(ColorTxt.Text, hsFunctions.csWordCount(ColorTxt.Text, @"\"), @"\");
            }

            avsProgram = "orig = rawsource(\"" + OrigTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
            "decod = rawsource(\"" + DecTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
            "ssim(orig,decod,\"results_ssim_" + origFilename + "_" + decFilename + ".csv\",\"avgSSIM.txt\",lumimask=false)";

            System.IO.File.WriteAllText(Path.GetDirectoryName(DecTxt.Text) + @"\ssim.avs", avsProgram);
            Process.Start(Path.GetDirectoryName(DecTxt.Text) + @"\ssim.avs").WaitForExit();
            origDecSSIMFilename = readChangeExcel(origFilename, decFilename, DecTxt.Text);

            if (checkBoxWhiteSSIM.Checked)
            {
                avsProgram = "orig = rawsource(\"" + OrigTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
                "decod = rawsource(\"" + ColorTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
                "ssim(orig,decod,\"results_ssim_" + origFilename + "_" + colorFilename + ".csv\",\"avgSSIM.txt\",lumimask=false)";

                System.IO.File.WriteAllText(Path.GetDirectoryName(ColorTxt.Text) + @"\ssim.avs", avsProgram);
                Process.Start(Path.GetDirectoryName(ColorTxt.Text) + @"\ssim.avs").WaitForExit();
                origColorSSIMFilename = readChangeExcel(origFilename, colorFilename, ColorTxt.Text);

                avsProgram = "orig = rawsource(\"" + ColorTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
                "decod = rawsource(\"" + DecTxt.Text + "\"," + widthTxt.Text + "," + heightTxt.Text + ",\"I420\") \n" +
                "ssim(orig,decod,\"results_ssim_" + colorFilename + "_" + decFilename + ".csv\",\"avgSSIM.txt\",lumimask=false)";

                System.IO.File.WriteAllText(Path.GetDirectoryName(DecTxt.Text) + @"\ssim.avs", avsProgram);
                Process.Start(Path.GetDirectoryName(DecTxt.Text) + @"\ssim.avs").WaitForExit();
                decColorSSIMFilename = readChangeExcel(colorFilename, decFilename, DecTxt.Text);

                createExcelSSIMPrediction(origDecSSIMFilename, origColorSSIMFilename, decColorSSIMFilename, DecTxt.Text);

                MessageBox.Show("Prediction Excel Created Successfully!");
            }
        }

        private void createExcelSSIMPrediction(string origDecSSIMFilename, string origColorSSIMFilename, string decColorSSIMFilename, string dir)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                ArrayList origDecArray = excelToArrayList(origDecSSIMFilename);
                ArrayList origColorArray = excelToArrayList(origColorSSIMFilename);
                ArrayList decColorArray = excelToArrayList(decColorSSIMFilename);

                ArrayList predictedArray = new ArrayList();

                for (int i = 0; i < origColorArray.Count; i++)
                {
                    predictedArray.Add(Convert.ToDouble(origColorArray[i]) / Convert.ToDouble(decColorArray[i]));
                    xlWorkSheet.Cells[i + 1, 1] = predictedArray[i];
                    xlWorkSheet.Cells[i + 1, 2] = origDecArray[i];
                    xlWorkSheet.Cells[i + 1, 3] = ((Convert.ToDouble(predictedArray[i]) - Convert.ToDouble(origDecArray[i])) / Convert.ToDouble(predictedArray[i]) * 100) + "%";

                }


                xlWorkBook.SaveAs(Path.GetDirectoryName(dir) + @"\" + origFilename + "_" + decFilename + "_" + colorFilename + "_predictedSSIM_origSSIM.xls",
                    Excel.XlFileFormat.xlWorkbookNormal, misValue,
                    misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public ArrayList excelToArrayList(string filename)
        {
            try
            {
                ArrayList excelValues = new ArrayList();
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                xlApp = new Excel.Application();

                xlWorkBook = xlApp.Workbooks.Open(filename,
                    0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;

                if (range != null)
                    foreach (Excel.Range r in range)
                    {
                        excelValues.Add(r.Value2);
                    }


                xlWorkBook.Close(true, filename, null);
                xlApp.Quit();
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                return excelValues;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private string readChangeExcel(string filename1, string filename2, string dir)
        {
            try
            {

                ArrayList excelValues = new ArrayList();
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                string str;
                int rCnt = 0;
                int cCnt = 0;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(Path.GetDirectoryName(dir) + @"\results_ssim_" + filename1 + "_" + filename2 + ".csv",
                    0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                excelPath = Path.GetDirectoryName(dir) + @"\results_ssim_" + filename1 + "_" + filename2 + ".csv";
                range = xlWorkSheet.UsedRange;
                double sum = 0;

                xlWorkSheet.Cells.Replace(".", ",", Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, false, Type.Missing, false, false);

                if (range != null)
                    foreach (Excel.Range r in range)
                    {
                        excelValues.Add(r.Value2);
                        sum += Convert.ToDouble(r.Value2);
                    }

                double average = sum / range.Rows.Count;

                MessageBox.Show("Average SSIM  " + average.ToString());

                //File.WriteAllText(Path.GetDirectoryName(DecTxt.Text) + @"\avgSSIM.txt", "Average SSIM : " + average.ToString());
                //xlWorkSheet.Cells.Replace(".", ",", Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, false, Type.Missing, false, false); 

                xlWorkBook.Close(true, @"results_ssim_" + filename1 + "_" + filename2 + ".csv", null);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                //
                //Gia ton upologismo twn temporal timwn
                //
                if (chkTemp.Checked)
                {

                    temporal(filename1, filename2, xlApp, excelValues);
                }
                return excelPath;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        private void temporal(string origFilename, string decFilename, Excel.Application xlApp, ArrayList excelValues)
        {
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;

            xlApp = new Excel.Application();
            oWB = (Excel.Workbook)(xlApp.Workbooks.Add(Missing.Value));
            oSheet = (Excel.Worksheet)oWB.ActiveSheet;

            excelPath = Path.GetDirectoryName(DecTxt.Text) + @"\results_TemporalS_" + origFilename + "_" + decFilename + ".csv";
            //range = oSheet.UsedRange;


            //oSheet.Cells.Replace(".", ",", Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, false, Type.Missing, false, false);

            for (int i = 1; i <= excelValues.Count; i++)
            {
                oSheet.Cells[i, 1] = excelValues[i - 1];
                if (i > 1) oSheet.Cells[i, 2] = Math.Abs((double)excelValues[i - 1] - (double)excelValues[i - 2]);
                else oSheet.Cells[i, 2] = 0;

            }




            //File.WriteAllText(Path.GetDirectoryName(DecTxt.Text) + @"\avgSSIM.txt", "Average SSIM : " + average.ToString());
            //xlWorkSheet.Cells.Replace(".", ",", Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, false, Type.Missing, false, false); 
            oWB.SaveCopyAs(Path.GetDirectoryName(DecTxt.Text) + @"\results_TemporalSSIM_" + origFilename + "_" + decFilename + ".csv");
            //oWB.Close(true, @"results_TemporalSSIM_" + origFilename + "_" + decFilename + ".csv", null);
            xlApp.Quit();

            releaseObject(oSheet);
            releaseObject(oWB);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        private void flcolor_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                ColorTxt.Text = file;
            }
        }

        private void florig_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (tabControl1.SelectedIndex == 0)
            {
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog1.FileName;
                    OrigTxt.Text = file;
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog1.FileName;
                    txtOrigYUV.Text = file;
                }
            }
        }

        private void fldec_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (tabControl1.SelectedIndex == 0)
            {
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog1.FileName;
                    DecTxt.Text = file;
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (result == DialogResult.OK) // Test result.
                {
                    string file = openFileDialog1.FileName;
                    //txtConvertedYUV.Text = file;
                }
            }
        }

        private void btnTempCur_Click(object sender, EventArgs e)
        {

            string outputFile = "";
            char first = 'a';
            char nextChar = (char)((int)first + 1);
            string dir = "";
            char[] colors = { 'b', 'y', 'm', 'c', 'r' };

            for (int y = 0; y < checkedFoldersQP.Items.Count; y++)
            {
                if (checkedFoldersQP.GetItemChecked(y))
                {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    Excel.Range range;
                    List<double> excelItems = new List<double>();//also spatial values
                    string str;
                    int rCnt = 0;
                    int cCnt = 0;
                    dir = checkedFoldersQP.Items[y].ToString();

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(Path.GetFullPath(dir) + @"\results_ssim_hevc.csv", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    excelPath = Path.GetFullPath(dir) + @"\results_ssim_hevc.csv";
                    range = xlWorkSheet.UsedRange;


                    xlWorkSheet.Cells.Replace(".", ",", Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, false, Type.Missing, false, false);

                    if (range != null)
                        foreach (Excel.Range r in range)
                        {

                            excelItems.Add(Convert.ToDouble(r.Value2));
                        }

                    int previousIndex = 0;
                    int nextIndex = 0;
                    double sumPrevious = 0;
                    double sumNext = 0;
                    double avgCurrent = 0;
                    List<double> tempItems = new List<double>();
                    int count = 0;
                    int countPrevious = 0;
                    int countNext = 0;

                    for (int i = 0; i < excelItems.Count; i++)
                    {
                        count += 1;
                        previousIndex = i - 5;
                        nextIndex = i + 4;

                        if (previousIndex < 0)
                        {
                            nextIndex += -previousIndex;
                            if (previousIndex == -5) previousIndex = -1;
                            if (previousIndex > -5) previousIndex = 0;
                        }

                        if (nextIndex >= excelItems.Count)
                        {
                            previousIndex += -(nextIndex - excelItems.Count + 1);

                            nextIndex = excelItems.Count - 1;
                        }

                        //previous Values Compute
                        for (int j = previousIndex; j < i && j >= 0; j++)
                        {
                            countPrevious += 1;
                            sumPrevious += excelItems[j];
                        }
                        //Next Values Compute
                        for (int k = i; k <= nextIndex; k++)
                        {
                            countNext += 1;
                            sumNext += excelItems[k];
                        }

                        avgCurrent = (sumNext + sumPrevious) / 10;
                        tempItems.Add(avgCurrent);//temporal values

                        countPrevious = 0;
                        countNext = 0;
                        sumNext = 0;
                        sumPrevious = 0;
                        previousIndex = 0;
                        nextIndex = 0;
                    }

                    //MessageBox.Show(count.ToString());
                    string temporalOutput = "";

                    for (int i = 0; i < tempItems.Count; i++)
                    {
                        temporalOutput += " " + tempItems[i].ToString() + "\n";
                    }

                    File.WriteAllText(Path.GetFullPath(dir) + @"\avgTemporalSSIM.txt", temporalOutput.ToString());
                    //xlWorkSheet.Cells.Replace(".", ",", Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, false, Type.Missing, false, false); 

                    string outputVectors = "";
                    int counter = 0;
                    //spatial
                    for (int i = 0; i < excelItems.Count; i++)
                    {
                        counter = i + 1;
                        if (i == 0)
                        {
                            outputVectors = "\n" + first + " = [" + excelItems[i].ToString() + " ; ";
                        }
                        else if (i == excelItems.Count - 1)
                        {
                            outputVectors += " " + excelItems[i].ToString() + " ;];";
                        }
                        else
                        {
                            outputVectors += " " + excelItems[i].ToString() + " ; ";
                        }
                    }

                    //outputFile = outputFile.Replace(",", ".");
                    //File.WriteAllText(Path.GetDirectoryName(DecTxt.Text) + @"\MatlabSpatialSSIM.txt", outputFile.ToString());

                    for (int i = 0; i < tempItems.Count; i++)
                    {
                        counter = i + 1;
                        if (i == 0)
                        {
                            outputVectors += "\n " + nextChar + " = [" + tempItems[i].ToString() + "; ";
                        }
                        else if (i == tempItems.Count - 1)
                        {
                            outputVectors += " " + tempItems[i].ToString() + ";];";
                        }
                        else
                        {

                            outputVectors += " " + tempItems[i].ToString() + "; ";
                        }
                    }

                    outputVectors = outputVectors.Replace(",", ".");
                    outputFile += outputVectors + "\n hold on;";
                    outputFile += "\n subplot(3,2," + (y + 1) + ")";
                    outputFile += "\n scatter(" + first + "," + nextChar + ",'" + colors[y].ToString() + "','filled');";
                    first = (char)((int)nextChar + 1);
                    nextChar = (char)((int)first + 1);
                    //File.WriteAllText(Path.GetDirectoryName(DecTxt.Text) + @"\MatlabTemporalSSIM.txt", outputFile.ToString());
                    outputFile += "\n axis([0.25,1,0.25,1])";
                    xlWorkBook.Close(false, @"results_ssim_hevc.csv", null);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                }

            }
            try
            {
                File.WriteAllText(Path.GetDirectoryName(dir) + @"\graph.m", outputFile.ToString());
                Process.Start(Path.GetDirectoryName(dir) + @"\graph.m");
            }
            catch (Exception y)
            {
                Console.Write("exception");
            }
        }

        private void flroot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;
            txtRoot.Text = selected;

        }

        private void btnFindQps_Click(object sender, EventArgs e)
        {
            checkedFoldersQP.Items.Clear();
            Regex reg = new Regex(@"qp");
            if (flroot.Text == "")
            {
                MessageBox.Show("Please Select Root Folder");
                return;
            }

            string rootFl = txtRoot.Text;
            string[] folders = System.IO.Directory.GetDirectories(@rootFl, "*", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string f in folders)
            {
                if (reg.IsMatch(f)) checkedFoldersQP.Items.Add(f, true);
            }
        }

        private void checkedFoldersQP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string pathOriginal = txtOrigYUV.Text;

                string pattern = comboBoxPattern.Text;
                int width = Convert.ToInt32(comboBoxW.Text);
                int height = Convert.ToInt32(comboBoxH.Text);
                string nameConverted = hsFunctions.csSplit(pathOriginal, hsFunctions.csWordCount(pathOriginal, @"\"), @"\");
                nameConverted = Path.GetDirectoryName(pathOriginal) + @"\" + hsFunctions.csSplit(nameConverted, 1, ".") + pattern + ".yuv";



                ProcessStartInfo info = new ProcessStartInfo(@"java");
                info.UseShellExecute = false;
                info.Arguments = " -cp " + @"C:\readYUVjava " + " ReadYUV "
                    + " " + pathOriginal + " " + nameConverted + " " + width + " " + height + " " + pattern;
                Process.Start(info).WaitForExit();
                MessageBox.Show("Conversion to " + pattern + " completed!!");
                //txtConvertedYUV.Text = nameConverted;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }



        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEncodingScenario_Click(object sender, EventArgs e)
        {
            encodingScenario encodingScen = new encodingScenario();
            encodingScen.ID = ID++;
            encodingScen.encoderFile = txtEncoderFile.Text;
            encodingScen.framesToBeEncoded = Convert.ToInt32(txtFrames.Text);
            encodingScen.frameRate = Convert.ToInt32(txtFrameRate.Text);
            encodingScen.width = comboWidth.Text;
            encodingScen.height = comboHeight.Text;
            encodingScen.inputFile = txtOrigFile.Text;
            encodingScen.outputFile = "";
            encodingScen.reconFile = "";
            encodingScen.path = Path.GetDirectoryName(txtEncoderFile.Text);



            if (qpEnc)
            {
                if (txtQPISlice.Text != "")
                {
                    encodingScen.QPISlice = Convert.ToInt32(txtQPISlice.Text);
                    encodingScen.outputFile += "QPI" + txtQPISlice.Text;
                    encodingScen.reconFile += "QPI" + txtQPISlice.Text;
                }

                if (txtQPPSlice.Text != "")
                {
                    encodingScen.QPPSlice = Convert.ToInt32(txtQPPSlice.Text);
                    encodingScen.outputFile += "QPP" + txtQPPSlice.Text;
                    encodingScen.reconFile += "QPP" + txtQPPSlice.Text;
                }

                if (txtQPBSlice.Text != "")
                {
                    encodingScen.QPBSlice = Convert.ToInt32(txtQPBSlice.Text);
                    encodingScen.outputFile += "QPB" + txtQPBSlice.Text;
                    encodingScen.reconFile += "QPB" + txtQPBSlice.Text;
                }
            }

            if (bitrateEnc)
            {

                if (txtStartBitrate.Text != "")
                {
                    encodingScen.bitrate = Convert.ToDouble(txtStartBitrate.Text);
                    encodingScen.outputFile += "Bit" + txtStartBitrate.Text;
                    encodingScen.reconFile += "Bit" + txtStartBitrate.Text;
                }
            }

            encodingScen.outputFile += ".264";
            encodingScen.reconFile += ".yuv";

            listBoxEncodingScenarios.Items.Add(encodingScen);



            //qpEnc = false;
            //bitrateEnc = false;
            btnEncode.Enabled = true;

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listBoxEncodingScenarios.Items.Count; i++)
            {
                encodingScenario encScen = (encodingScenario)listBoxEncodingScenarios.Items[i];

                ProcessStartInfo info = new ProcessStartInfo(encScen.encoderFile);

                info.WorkingDirectory = encScen.path;

                info.Arguments = "";

                info.Arguments += " -p InputFile = " + encScen.inputFile;

                info.Arguments += " -p SourceWidth =" + encScen.width;
                info.Arguments += " -p SourceHeight =" + encScen.height;

                info.Arguments += " -p OutputWidth =" + encScen.width;
                info.Arguments += " -p OutputHeight =" + encScen.height;

                info.Arguments += " -p FramesToBeEncoded =" + encScen.framesToBeEncoded;
                info.Arguments += " -p FrameRate =" + encScen.frameRate;
                info.Arguments += " -p ReconFile =" + encScen.reconFile;
                info.Arguments += " -p OutputFile =" + encScen.outputFile;

                if (encScen.QPISlice > 0)
                {
                    info.Arguments += " -p QPISlice= " + encScen.QPISlice;
                }
                if (encScen.QPPSlice > 0)
                {
                    info.Arguments += " -p QPPSlice= " + encScen.QPPSlice;
                }
                if (encScen.QPBSlice > 0)
                {
                    info.Arguments += " -p QPBSlice = " + encScen.QPBSlice;
                }

                if (encScen.bitrate > 0.0)
                {
                    info.Arguments += " -p RateControlEnable = 1 -p Bitrate = " + encScen.bitrate * 1048576;
                }

                //MessageBox.Show(info.Arguments);

                Process proc = Process.Start(info);
                proc.WaitForExit();

            }

            listBoxEncodingScenarios.Items.Clear();
        }

        private void btnQPEncoding_Click(object sender, EventArgs e)
        {
            qpEnc = true;
            btnAddEncodingScenario.Enabled = true;
        }

        private void btnBitrateEncoding_Click(object sender, EventArgs e)
        {
            bitrateEnc = true;
            btnAddEncodingScenario.Enabled = true;
        }

        private void btnOrigFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string selected = openFileDialog1.FileName;

                txtOrigFile.Text = selected;
            }
        }

        private void btnFileEncoder_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogEnc.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string selected = openFileDialogEnc.FileName;
                txtEncoderFile.Text = selected;
            }
        }

        private void txtOrigFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCfgFile_Click(object sender, EventArgs e)
        {

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtXmlOut.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void btnExcelMVFiles_Click(object sender, EventArgs e)
        {
            MVExcelFiles = new ArrayList();

            DialogResult dr = this.openFileDialogExcel.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files 
                foreach (String file in openFileDialogExcel.FileNames)
                {
                    MVExcelFiles.Add(file);
                    txtExcelMVfiles.Text += file + "\n";
                }
            }

        }

        private void btnMatlabScr_Click(object sender, EventArgs e)
        {
            List<double> MVlengths = new List<double>();
            List<double> MVsums = new List<double>();
            double avgLength = 0, avgSum = 0, stdDevLength = 0, stdDevSum = 0;
            //string matlabScript = "";
            string[] colors = new string[8] { "b", "m", "c", "r", "g", "b", "w", "k" };
            txtMatlabScript.Text = "";
            int i = 0;
            foreach (string file in MVExcelFiles)
            {

                string filename = hsFunctions.csSplit(file, hsFunctions.csWordCount(file, @"\"), @"\");

                ExcelMVLengthSumArrays excelArrays = MVExcelTo2DoubleArrays(file);
                MVlengths = excelArrays.lengths;
                MVsums = excelArrays.sums;

                avgLength = MVlengths.Average();
                avgSum = MVsums.Average();

                double sumOfSquaresOfDifferencesLengths = MVlengths.Select(val => (val - avgLength) * (val - avgLength)).Sum();
                double sdLength = Math.Sqrt(sumOfSquaresOfDifferencesLengths / MVlengths.Count);

                double sumOfSquaresOfDifferencesSums = MVsums.Select(val => (val - avgSum) * (val - avgSum)).Sum();
                double sdSum = Math.Sqrt(sumOfSquaresOfDifferencesSums / MVsums.Count);

                txtMatlabScript.Text += "text(" + avgSum + "," + (avgLength / avgSum) * 100 + ", '" + filename.Substring(0, 7) + "', 'Color', '" + colors[i] + "')\nhold on\n";
                txtMatlabScript.Text += "circle(" + avgSum + "," + (avgLength / avgSum) * 100 + "," + 10 + ",'" + colors[i] + "')\nhold on\n";

                //color iterator
                i++;
                if(i==colors.Length) i = 0;
            }

        }

        private ExcelMVLengthSumArrays MVExcelTo2DoubleArrays(string filename)
        {
            try
            {
                ExcelMVLengthSumArrays excelArrays = new ExcelMVLengthSumArrays();
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                xlApp = new Excel.Application();

                xlWorkBook = xlApp.Workbooks.Open(filename,
                    0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;

                
                int rows_count = range.Rows.Count;
                string output = null;
                //String variable output is used to store value you've deleted in string format.

                for (int i = 1; i <= rows_count; i++)
                {
                    excelArrays.lengths.Add(xlWorkSheet.Cells[i, 1].value);
                }

                for (int i = 1; i <= rows_count; i++)
                {
                    excelArrays.sums.Add(xlWorkSheet.Cells[i, 2].value);
                }

                xlWorkBook.Close();
                xlApp.Quit();
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                return excelArrays;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void btnGenMotionExcel_Click(object sender, EventArgs e)
        {
            List<double> MVlengths = new List<double>();
            List<double> MVsums = new List<double>();
            double avgLength = 0, avgSum = 0, stdDevLength = 0, stdDevSum = 0;
            //string matlabScript = "";
            txtMatlabScript.Text = "";
            int i = 0;
            foreach (string file in MVExcelFiles)
            {

                string filename = hsFunctions.csSplit(file, hsFunctions.csWordCount(file, @"\"), @"\");

                ExcelMVLengthSumArrays excelArrays = MVExcelTo2DoubleArrays(file);
                MVlengths = excelArrays.lengths;
                MVsums = excelArrays.sums;

                avgLength = MVlengths.Average();
                avgSum = MVsums.Average();

                double sumOfSquaresOfDifferencesLengths = MVlengths.Select(val => (val - avgLength) * (val - avgLength)).Sum();
                double sdLength = Math.Sqrt(sumOfSquaresOfDifferencesLengths / MVlengths.Count);

                double sumOfSquaresOfDifferencesSums = MVsums.Select(val => (val - avgSum) * (val - avgSum)).Sum();
                double sdSum = Math.Sqrt(sumOfSquaresOfDifferencesSums / MVsums.Count);

                
                txtMatlabScript.Text += filename+"\n" + avgSum + "\n" + (avgLength / avgSum) * 100 +"\n";

                //color iterator
                i++;
                
            }
        }
    }
}