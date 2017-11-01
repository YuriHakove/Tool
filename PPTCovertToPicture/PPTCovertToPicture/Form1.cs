using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System.IO;
using SiuStream;  

namespace PPTCovertToPicture
{
    public partial class Form1 : Form
    {
        [DllImport("Comdlg32", CharSet = CharSet.Auto)]
        public static extern bool GetOpenFileName([In, Out] OpenFileName ofn);

        [DllImport("Comdlg32", CharSet = CharSet.Auto)]
        public static extern bool GetSaveFileName([In, Out] OpenFileName ofn);
        public string Openurl;
        public string Saveurl;
        public string SaveName="demo";
        public Form1()
        {

            InitializeComponent();

            bkWorker.WorkerReportsProgress = true;
            bkWorker.WorkerSupportsCancellation = true;
            bkWorker.DoWork += new DoWorkEventHandler(DoWork);
            bkWorker.ProgressChanged += new ProgressChangedEventHandler(ProgessChanged);
            bkWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompleteWork);
    
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            Openurl= OpenFile(System.Windows.Forms.Application.StartupPath);
        }
        public static string OpenFile(string path)
        {
            OpenFileName ofn = new OpenFileName();
            ofn.structSize = Marshal.SizeOf(ofn);
            ofn.filter = "PPTX(*.pptx)\0*.pptx\0;ppt(*.ppt)\0*.ppt\0";
            ofn.file = new String(new char[256]);
            ofn.maxFile = ofn.file.Length;
            ofn.fileTitle = new String(new char[64]);
            ofn.maxFileTitle = ofn.fileTitle.Length;
            ofn.initialDir = path;
            ofn.title = "打开";
            ofn.defExt = "pptx;ppt";
            if (GetOpenFileName(ofn))
            {
                //openFileFlat = 1;
                return ofn.file;
            }
            return "";
        }
        public static string SaveFile(string filepath, string filename)
        {
            OpenFileName ofn = new OpenFileName();
            ofn.structSize = Marshal.SizeOf(ofn);
            ofn.filter = "PNG(*.png)\0*.png\0";
            //ofn.file = new String(new char[256]);
            char[] name = new char[256];
            Array.Copy(filename.ToCharArray(), name, filename.Length);
            ofn.file = new String(name);
            ofn.maxFile = ofn.file.Length;
            ofn.fileTitle = new String(new char[64]);
            ofn.maxFileTitle = ofn.fileTitle.Length;
            ofn.initialDir = filepath;
            ofn.title = "保存";
            ofn.defExt = "PNG";
            if (GetSaveFileName(ofn))
            {
                return ofn.file;
            }
            return "";
        }
        private void btn_covert_Click(object sender, EventArgs e)
        {
            percentValue = 10;
            this.progressBar1.Maximum = 1000;
            // 执行后台操作  
            bkWorker.RunWorkerAsync();
            ApplicationClass pptApplication = new ApplicationClass();
            Presentation pptPresentation = pptApplication.Presentations.Open(Openurl, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
            pptPresentation.SaveAs(Saveurl, PpSaveAsFileType.ppSaveAsPNG);
            MessageBox.Show("转换完成", "提示", MessageBoxButtons.OK);
        }
      

        private void btn_save_Click(object sender, EventArgs e)
        {
            Saveurl = SaveFile(System.Windows.Forms.Application.StartupPath, SaveName);
            PPTSaveUrl.Text = Saveurl;
        }
        /// <summary>  
        /// 后台线程  
        /// </summary>  
        private BackgroundWorker bkWorker = new BackgroundWorker();

        /// <summary>  
        /// 步进值  
        /// </summary>  
        private int percentValue = 0;


        public void DoWork(object sender, DoWorkEventArgs e)
        {
            // 事件处理，指定处理函数  
            e.Result = ProcessProgress(bkWorker, e);
        }

        public void ProgessChanged(object sender, ProgressChangedEventArgs e)
        {
            // bkWorker.ReportProgress 会调用到这里，此处可以进行自定义报告方式  
            this.progressBar1.Value = e.ProgressPercentage;
            int percent = (int)(e.ProgressPercentage / percentValue);
            this.label1.Text = "处理进度:" + Convert.ToString(percent) + "%";
        }

        public void CompleteWork(object sender, RunWorkerCompletedEventArgs e)
        {
            this.label1.Text = "处理完毕!";
        }

        private int ProcessProgress(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (bkWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return -1;
                }
                else
                {
                    // 状态报告  
                    bkWorker.ReportProgress(i);

                    // 等待，用于UI刷新界面，很重要  
                    System.Threading.Thread.Sleep(1);
                }
            }

            return -1;
        }
        public static string openfile;
        public static string savefile;
        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    openfile = openFileDialog1.FileName;//得到选择的文件的完整路径
                    label3.Text = openfile;
                    //把读出来的数据显示在textbox中
                    // Insert code to read the stream here.
                    myStream.Close();
                }
            }
        }

        private void btn_jiami_Click(object sender, EventArgs e)
        {
            StreamReader m_StreamReader = new StreamReader(openfile);
            try
            {
                SiuStreamWriter w = new SiuStreamWriter(savefile);

                // string line = m_StreamReader.ReadLine();//为什么就是不能往里写数据呢？？？
                string line;
                while (null != (line = m_StreamReader.ReadLine()))
                {
                   
                    w.WriteLine(line);  
                }
                w.Close();
                m_StreamReader.Close();
            }
            catch (Exception ex)
            { return; }

            m_StreamReader.Close();
            MessageBox.Show("加密完成", "提示", MessageBoxButtons.OK);
        }

        private void btn_saveUrl_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    savefile = saveFileDialog1.FileName;//得到选择的文件的完整路径
                    lb_saveUrl.Text = savefile;
                    //把读出来的数据显示在textbox中
                    // Insert code to read the stream here.
                    myStream.Close();
                }
            }
        }

        private void btn_jiemi_Click(object sender, EventArgs e)
        {
            SiuStreamReader m_StreamReader = new SiuStreamReader(openfile);
            // string t;
            try
            {
                //StreamWriter writer = new StreamWriter(@"C:\work\2016-04-07\smkj\MD\Assets\s1.txt");
                //  SiuStreamWriter writer1 = new SiuStreamWriter(@"C:\work\2016-04-07\smkj\MD\Assets\s.txt");
                FileInfo f = new FileInfo(savefile);
                StreamWriter w = f.CreateText();
                // string line = m_StreamReader.ReadLine();//为什么就是不能往里写数据呢？？？
                string line;
                while (null != (line = m_StreamReader.ReadLine()))
                {
                    //writer1.WriteLine(line);
                    // writer.Write(line);
                    w.WriteLine(line);
                    //label1.Text = line;
                }
                w.Close();
                m_StreamReader.Close();
                //writer1.Close();
                //writer.Close();               
            }
            catch (Exception ex)
            { return; }

            m_StreamReader.Close();
            MessageBox.Show("解密完成", "提示", MessageBoxButtons.OK);
        }


      
    }
    

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class OpenFileName
    {
        public int structSize = 0;
        public IntPtr dlgOwner = IntPtr.Zero;
        public IntPtr instance = IntPtr.Zero;
        public string filter = null;
        public string customFilter = null;
        public int maxCustFilter = 0;
        public int filterIndex = 0;
        public string file = null;
        public int maxFile = 0;
        public String fileTitle = null;
        public int maxFileTitle = 0;
        public string initialDir = null;
        public string title = null;
        public int flags = 0;
        public short fileOffset = 0;
        public short fileExtension = 0;
        public string defExt = null;
        public IntPtr custData = IntPtr.Zero;
        public IntPtr hook = IntPtr.Zero;
        public string templateName = null;
        public IntPtr reservedPtr = IntPtr.Zero;
        public int reservedInt = 0;
        public int flagsEx = 0;

    }
}
