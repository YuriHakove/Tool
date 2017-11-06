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
using Newtonsoft.Json;
using System.Threading;
using System.Drawing.Imaging;

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
        public string SaveName = "新保存";


        KdGoldAPI.KdApiSearch KDApi = new KdGoldAPI.KdApiSearch();
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
            Openurl = OpenFile(System.Windows.Forms.Application.StartupPath);
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
            //MessageBox.Show("转换完成", "提示", MessageBoxButtons.OK);
            Saveurl = Saveurl.Split('.')[0];
            System.Diagnostics.Process.Start(Saveurl);
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            Saveurl = SaveFile(System.Windows.Forms.Application.StartupPath, SaveName);
            Saveurl = Saveurl.Split('.')[0];
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
            System.Diagnostics.Process.Start(savefile);
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
            System.Diagnostics.Process.Start(savefile);
        }

        private void btn_CheckKD_Click(object sender, EventArgs e)
        {
            if (cBx_DanHao.Text == "")
            {
                MessageBox.Show("请输入单号", "提示", MessageBoxButtons.OK);
                return;
            }
            if (cBx_ShipperCode.Text == "")
            {
                MessageBox.Show("请选择快递", "提示", MessageBoxButtons.OK);
                return;
            }
            KdGoldAPI.KdApiSearch.LosisticCode = cBx_DanHao.Text;
            dataGridView_KD.Rows.Clear();
          
            explainJson();
            //tBx_ShowKD.Text= KDApi.getOrderTracesByJson();
        }
        private void explainJson()
        {
            var Json = KDApi.getOrderTracesByJson();
            //将Json数据反序列化
            JsonParser jp = (JsonParser)JsonConvert.DeserializeObject<JsonParser>(Json);
            List<Traces> list = jp.Traces;
            if (jp.Success == false || list.Count == 0)
            {
                MessageBox.Show("请检查该订单是否为该物流\r\n" + jp.Reason, "查询失败", MessageBoxButtons.OK);
                return;
            }


            for (int i = 0; i < list.Count; i++)
            {
                dataGridView_KD.Rows.Add();
                dataGridView_KD.Rows[i].Cells[0].Value = list[i].AcceptTime.ToString();
                dataGridView_KD.Rows[i].Cells[1].Value = list[i].AcceptStation.ToString();
                if (list[i].Remark == null)
                    list[i].Remark = "无";
                dataGridView_KD.Rows[i].Cells[2].Value = list[i].Remark.ToString();

            }
            lb_KDN.Text = list[list.Count - 1].AcceptTime + " " + list[list.Count - 1].AcceptStation;
            //foreach (var i in list)
            //    dataGridView_KD.Columns[0]. = list;

            historyCheack();

        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (cBx_ShipperCode.Text)
            {
                case "EMS":
                    KdGoldAPI.KdApiSearch.ShipperCode = "EMS";
                    break;
                case "顺丰":
                    KdGoldAPI.KdApiSearch.ShipperCode = "SF";
                    break;
                case "圆通":
                    KdGoldAPI.KdApiSearch.ShipperCode = "YTO";
                    break;
                case "百世快递":
                    KdGoldAPI.KdApiSearch.ShipperCode = "HTKY";
                    break;
                case "中通":
                    KdGoldAPI.KdApiSearch.ShipperCode = "ZTO";
                    break;
                case "韵达":
                    KdGoldAPI.KdApiSearch.ShipperCode = "YD";
                    break;
                case "申通":
                    KdGoldAPI.KdApiSearch.ShipperCode = "STO";
                    break;
                case "德邦":
                    KdGoldAPI.KdApiSearch.ShipperCode = "DBL";
                    break;
                case "优速":
                    KdGoldAPI.KdApiSearch.ShipperCode = "UC";
                    break;
                case "宅急送":
                    KdGoldAPI.KdApiSearch.ShipperCode = "ZJS";
                    break;
                case "京东":
                    KdGoldAPI.KdApiSearch.ShipperCode = "JD";
                    break;
                case "信丰":
                    KdGoldAPI.KdApiSearch.ShipperCode = "XFEX";
                    break;
                case "全峰":
                    KdGoldAPI.KdApiSearch.ShipperCode = "QFKD";
                    break;
                case "跨越速运":
                    KdGoldAPI.KdApiSearch.ShipperCode = "KYSY";
                    break;
                case "安能":
                    KdGoldAPI.KdApiSearch.ShipperCode = "ANE";
                    break;
                case "快捷":
                    KdGoldAPI.KdApiSearch.ShipperCode = "FAST";
                    break;
                case "国通":
                    KdGoldAPI.KdApiSearch.ShipperCode = "GTO";
                    break;
                case "天天":
                    KdGoldAPI.KdApiSearch.ShipperCode = "HHTT";
                    break;
                case "邮政快递包裹":
                    KdGoldAPI.KdApiSearch.ShipperCode = "YZPY";
                    break;
            }
        }

        //查询订单记录
        private void historyCheack()
        {
            if (!File.Exists(System.Windows.Forms.Application.StartupPath + @"\cookie.txt"))
            { 
                FileInfo f = new FileInfo(System.Windows.Forms.Application.StartupPath + @"\cookie.txt");
                StreamWriter w = f.CreateText();
                w.Close();
            }

            SiuStreamReader m_StreamReader = new SiuStreamReader(System.Windows.Forms.Application.StartupPath + @"\cookie.txt");
            string line = cBx_ShipperCode.Text + ";" + cBx_DanHao.Text;
            string tmp;
            while ((tmp= m_StreamReader.ReadLine()) != null)
            {
                if (tmp == line)
                {
                    m_StreamReader.Close();
                    return;
                }
                
            }
            m_StreamReader.Close();
            try
            {
                //FileInfo f = new FileInfo(System.Windows.Forms.Application.StartupPath + @"\cookie.txt");
                //StreamWriter w = f.CreateText();
                StreamWriter w = new StreamWriter(System.Windows.Forms.Application.StartupPath + @"\cookie.txt", true);
                // string line = m_StreamReader.ReadLine();//为什么就是不能往里写数据呢？？？


                w.WriteLine(line);
                
                //label1.Text = line;
                w.Close();        
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void cBx_DanHao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SiuStreamReader m_StreamReader = new SiuStreamReader(System.Windows.Forms.Application.StartupPath + @"\cookie.txt");
            //string tmpReader;
            //while ((tmpReader = m_StreamReader.ReadLine()) != null)
            //{
            //    var tmpKD = tmpReader.Split(';');
            //    cBx_DanHao.Items.Add(tmpKD[1]);

            cBx_ShipperCode.Text = tmpKD[0];
            cBx_DanHao.Text = tmpKD[1];
            //}
        }
        static string lasttmpReader;
        static string[] tmpKD;
        private void cBx_DanHao_MouseClick(object sender, MouseEventArgs e)
        {

            SiuStreamReader m_StreamReader = new SiuStreamReader(System.Windows.Forms.Application.StartupPath + @"\cookie.txt");
            string tmpReader;
            foreach (var tmp in cBx_DanHao.Items)
            {
                if (tmp.ToString() ==lasttmpReader)
                {
                    m_StreamReader.Close();
                    return;
                }
            }
            while ((tmpReader = m_StreamReader.ReadLine()) != null)
            {
                 tmpKD = tmpReader.Split(';');
                cBx_DanHao.Items.Add(tmpKD[1]);
                lasttmpReader = tmpKD[1];
                //cBx_ShipperCode.Text = tmpKD[0];
                //cBx_DanHao.Text = tmpKD[1];
            }
            m_StreamReader.Close();
        }
        private void timer_Time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss");
        }

        private void btn_SaveScreen_Click(object sender, EventArgs e)
        {
            Saveurl = SaveFile(System.Windows.Forms.Application.StartupPath, SaveName);
            //Saveurl = Saveurl.Split('.')[0];
            lb_SaveScreen.Text = Saveurl;
        }

        private void btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (Saveurl == null)
            {
                MessageBox.Show("请选择保存位置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            Thread.Sleep(1000);//延时2秒
            Bitmap myImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(myImage);
            g.CopyFromScreen(new System.Drawing.Point(0, 0), new System.Drawing.Point(0, 0), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            IntPtr dc1 = g.GetHdc();
            g.ReleaseHdc(dc1);
            myImage.Save(@Saveurl);
            this.Show();
            DialogResult dr = MessageBox.Show("截图完成,是否查看", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Saveurl);
            }

        }

        //记录鼠标按下坐标，确定绘图起点  
        private System.Drawing.Point DownPoint = System.Drawing.Point.Empty;
        //截图完成  
        private bool CatchFinished = false;
        //截图开始  
        private bool CatchStart = false;
        //保存原始图像  
        private Bitmap originBmp;
        //保存截图的矩形  
        private Rectangle CatchRect;
        private void btn_ChooseScreen_Click(object sender, EventArgs e)
        {
     
            //隐藏当前窗体  
            this.Hide();
            //让线程睡眠一段时间，窗体消失需要一点时间  
            Thread.Sleep(50);
            //Catch catchForm = new Catch();
            //新建一个和屏幕大小相同的图片  
            Bitmap CatchBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            //在新图片上创建一个画布  
            Graphics g = Graphics.FromImage(CatchBmp);
            //保存全屏图片  
            g.CopyFromScreen(new System.Drawing.Point(0, 0), new System.Drawing.Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));
            //将Catch窗体的背景设为全屏时的图片  
            //catchForm.BackgroundImage = CatchBmp;

            //if (catchForm.ShowDialog() == DialogResult.OK)
            //{
            //    //如果Catch窗体结束，就将剪贴板中的图片放到信息发送框中  
            //    IDataObject iData = Clipboard.GetDataObject();
            //    DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            //    if (iData.GetDataPresent(DataFormats.Bitmap))
            //    {
            //        //strtxtMessage.Paste(myFormat);
            //        //清楚剪切板中的对象  
            //        Clipboard.Clear();
            //    }
            //    this.Show();
                //再次显示此窗体  

            //}

        }


        private void Catch_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            //BackgroundImage为全屏图片，我们另用变量来保存全屏图片  
            originBmp = new Bitmap(this.BackgroundImage);
        }

        private void Catch_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Catch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //如果捕捉没有开始  
                if (!CatchStart)
                {
                    CatchStart = true;
                    //保存鼠标按下坐标  
                    DownPoint = new System.Drawing.Point(e.X, e.Y);
                }
            }
        }

        private void Catch_MouseMove(object sender, MouseEventArgs e)
        {
            //如果捕捉开始  
            if (CatchStart)
            {
                //新建一个图片对象，并让它与原始图片相同  
                Bitmap destBmp = (Bitmap)originBmp.Clone();
                //获取鼠标的坐标  
                System.Drawing.Point newPoint = new System.Drawing.Point(DownPoint.X, DownPoint.Y);
                //在刚才新建的图片上新建一个画板  
                Graphics g = Graphics.FromImage(destBmp);
                //获取画笔对象  
                Pen pen = new Pen(Color.Blue, 1);
                //获取矩形的长和宽  
                int width = Math.Abs(e.X - DownPoint.X);
                int height = Math.Abs(e.Y - DownPoint.Y);
                //判断矩形的起始坐标  
                if (e.X < DownPoint.X)
                    newPoint.X = e.X;
                if (e.Y < DownPoint.Y)
                    newPoint.Y = e.Y;
                //保存矩形  
                CatchRect = new Rectangle(newPoint, new Size(width, height));
                //将矩形花在这个画板上  
                g.DrawRectangle(pen, CatchRect);
                //释放这个画板  
                g.Dispose();
                //重新创建一个Graphics类  
                Graphics g1 = this.CreateGraphics();
                //如果之前那个画板不释放，而直接g=this.CreateGraphics()这样的话无法释放掉第一次创建的g,因为只是把地址转到新的g了，如同string一样。  
                //将刚才所画的图片画到这个窗体上  
                g1.DrawImage(destBmp, new System.Drawing.Point(0, 0));
                //这个也可以属于二次缓冲技术，如果直接将矩形画在窗体上，会造成图片抖动并且会有无数个矩形  
                //释放这个画板  
                g1.Dispose();
                //释放掉Bmp对象。  
                destBmp.Dispose();
                //要及时释放不会再次使用的对象，不然内存将会被大量消耗  
            }
        }

        private void Catch_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //如果已经开始绘制  
                if (CatchStart)
                {
                    //将开始绘制设为false  
                    CatchStart = false;
                    //完成绘制设为true  
                    CatchFinished = true;
                }
            }
        }

        private void Catch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && CatchFinished)
            {
                if (CatchRect.Contains(new System.Drawing.Point(e.X, e.Y)))
                {
                    //新建一个与矩形等大的空白图片  
                    Bitmap catchedBmp = new Bitmap(CatchRect.Width, CatchRect.Height);
                    //在空白图片上新建一个画板  
                    Graphics g = Graphics.FromImage(catchedBmp);
                    //将origin中的指定部分按照指定大小画在画板上  
                    g.DrawImage(originBmp, new Rectangle(0, 0, CatchRect.Width, CatchRect.Height), CatchRect, GraphicsUnit.Pixel);
                    //将图片保存到剪贴板上  
                    Clipboard.SetImage(catchedBmp);
                    //释放Graphics对象  
                    g.Dispose();
                    //完成一次操作  
                    CatchFinished = false;
                    //将背景图片设置为originBmp中的图片  
                    this.BackgroundImage = originBmp;
                    //释放新图片对象  
                    catchedBmp.Dispose();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            captureScreen(DownPoint.X, DownPoint.Y, CatchRect.Width, CatchRect.Height);
        }




        public static Bitmap captureScreen(int x, int y, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new System.Drawing.Point(x, y), new System.Drawing.Point(0, 0), bmp.Size);
                g.Dispose();
            }
            //bit.Save(@"capture2.png");  
            return bmp;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void 开发者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("愈来喻好\nQQ3035608535", "开发者");
        }

        private void 功能介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如你所见~~~未完待续","温馨提示");
        }
    }

    public class JsonParser
    {
        public int EBusinessID;
        public int OrderCode;
        public string ShipperCode;
        public string LogisticCode;
        public bool Success;
        public string CallBack;
        public int State;
        public string Reason;
        public List<Traces> Traces;
    }
    public class Traces
    {
        public string AcceptTime;
        public string AcceptStation;
        public string Remark;
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
