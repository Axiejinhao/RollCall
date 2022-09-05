using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RollCall;

namespace RollCall
{
    public partial class Form1 : Form
    {
        //0:学号,1:姓名,2:班级,3:出勤率,4:总课时,5:出勤次数,6:本次是否旷课
        public string[] title = new string[7] { "学号", "姓名", "班级", "出勤率", "总课时", "出勤次数", "本次是否旷课" };
        public static string[,] classData = new string[1000,10];

        //获取csv的行数和列数
        public static int row = 0, col = 0;
        int rand;

        //顺序点名的下标位置
        int orderIndex = 0;
        //班级所有的学生数
        Dictionary<string, int> classToSumStudent = new Dictionary<string, int>();
        //班级所有出勤的学生数
        Dictionary<string, int> classToAttendance = new Dictionary<string, int>();

        //班级名称
        string[] className = new string[10];
        string[] videoURL = new string[3] { @"F:\MVS\RollCall\RollCall\Resources\mp4.mp4", @"F:\MVS\RollCall\RollCall\Resources\mp3.mp4",
                                            @"F:\MVS\RollCall\RollCall\Resources\mp1.mp4"};
        int cnt = 0;

        //窗体皮肤
        List<string> Skins = new List<string>();

        public Form1()
        {
            InitializeComponent();
            setTitle();
            setClass();
            setRecords();
            //隐藏视频播放器
            axWindowsMediaPlayer2.Hide();
            dataGridView1.Hide();
            richTextBoxWithRecords.Hide();
            richTextBoxWithClass.Hide();
            buttonSkip.Hide();
            label5.Hide();
        }

        /// <summary>
        /// 设置班级
        /// </summary>
        private void setClass() 
        {
            string name1 = "setClass.txt";
            StreamReader sr = new StreamReader(name1, Encoding.UTF8);
            string content = sr.ReadToEnd();
            string[] str = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            if (str.Length != 0)
            { 
                for (int i = 0; i < str.Length; i++)
                    comboBox1.Items.Add(str[i]);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(str[0]);
            }
            sr.Close();
        }

        /// <summary>
        /// 设置标题
        /// </summary>
        private void setTitle() 
        {
            string name1 = "setTitle.txt";
            StreamReader sr = new StreamReader(name1, Encoding.UTF8);
            string content = sr.ReadToEnd();
            string[] str = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            labelSource.Text = str[0];
            labelTeach.Text = str[1];
            sr.Close();
        }

        /// <summary>
        /// 设置抽答记录
        /// </summary>
        private void setRecords()
        {
            string name1 = "setRecords.txt";
            StreamReader sr = new StreamReader(name1, Encoding.UTF8);
            string content = sr.ReadToEnd();
            string[] str = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == "")
                {
                    continue;
                }
                if(i == str.Length - 1)
                {
                    richTextBoxWithRecords.AppendText(str[i]);
                }
                else
                {
                    richTextBoxWithRecords.AppendText(str[i] + System.Environment.NewLine);
                }
            }
            sr.Close();
        }

        /// <summary>
        /// 导入名单按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("导入班级为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("是否导入名单！", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //获取RollCall.exe同目录下的csv文件
                string name = "class" + (comboBox1.SelectedIndex).ToString() + ".csv";
                ImportListAndInitData(name);
            }
        }

        /// <summary>
        /// 选择文件并打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string file;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "文件(*.csv)|*.csv";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
                ImportListAndInitData(file);
            }
        }

        /// <summary>
        /// 导入名单与初始化数据
        /// </summary>
        /// <param name="filePath"></param>
        private void ImportListAndInitData(string filePath)
        {
            string name = "testOutput" + (comboBox1.SelectedIndex).ToString() + ".csv";
            //先将数据保存到csv
            saveClassDataToCSV(name);

            //清空
            classToSumStudent.Clear();
            classToAttendance.Clear();
            for (int i = 0; i < className.Length; i++)
            {
                className[i] = "";
            }

            cnt = 0;
            DataTable dt = new DataTable();
            dt = CSVFileHelper.OpenCSV(filePath);
            //默认不记录第一行
            col = dt.Columns.Count;
            row = dt.Rows.Count;

            Console.WriteLine("row:" + row + "---" + "col:" + col);

            string[,] array = new string[row, col];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //获取所有班级名称
                string crtClassName = dt.Rows[i][2].ToString().ToUpper().Trim();

                if (i == 0)
                {
                    className[cnt] = crtClassName;
                    cnt++;
                }
                else if (className[cnt - 1].CompareTo(crtClassName) != 0)
                {
                    className[cnt] = crtClassName;
                    cnt++;
                }

                //获取班级人数
                if (!classToSumStudent.ContainsKey(crtClassName))
                {
                    classToSumStudent.Add(crtClassName, 1);
                }
                else
                {
                    classToSumStudent[crtClassName] = classToSumStudent[crtClassName] + 1;
                }

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    array[i, j] = dt.Rows[i][j].ToString().ToUpper().Trim();
                    classData[i, j] = dt.Rows[i][j].ToString().ToUpper().Trim();

                    //默认每个学生来上课了
                    if (j == 4 || j == 5)
                    {
                        classData[i, j] = (Int32.Parse(classData[i, j]) + 1).ToString();
                    }
                    //当次课没有被记录为旷课
                    if (j == 6)
                    {
                        classData[i, j] = "0";
                    }
                }
            }

            Console.WriteLine(cnt);
            //默认所有人已到
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(className[i]);
                classToAttendance[className[i]] = classToSumStudent[className[i]];
            }

            LabelDataInit();

            //更新班级签到率
            UpdateClassAttendance();
        }

        /// <summary>
        /// 开始随机点名事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                MessageBox.Show("请先导入名单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            orderIndex = 0;
            timer1.Enabled = true;
            timer1.Start();
        }

        /// <summary>
        /// 停止随机点名事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                MessageBox.Show("请先导入名单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Random rd = new Random();
            int n = rd.Next(0, videoURL.Length);
            //显示视频播放器并播放视频
            axWindowsMediaPlayer2.URL = videoURL[n];
            axWindowsMediaPlayer2.Show();
            buttonSkip.Show();
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
            axWindowsMediaPlayer2.Size = new System.Drawing.Size(this.Width, this.Height);

            ShowStopResult();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
            axWindowsMediaPlayer2.Size = new System.Drawing.Size(this.Width, this.Height);
        }

        /// <summary>
        /// 显示随机点名暂停后的结果
        /// </summary>
        public void ShowStopResult()
        {
            timer1.Stop();
            timer1.Enabled = false;
            Random ran = new Random();
            int n = ran.Next(0, row);
            //textBox3.Text = Convert.ToString(n + 1);
            rand = n + 1;
            labelNumber.Text = classData[n, 0];
            labelName.Text = classData[n, 1];
            labelClass.Text = classData[n, 2];
            labelAttendance.Text = classData[n, 3]+"%";

            UpdateSetRecordsTXT(labelName.Text);
        }

        /// <summary>
        /// 更新抽答记录文本
        /// </summary>
        public void UpdateSetRecordsTXT(string name)
        {
            //写入文本文件
            StreamWriter sw = File.AppendText("setRecords.txt");
            sw.Write(name + "\n");
            sw.Close();

            richTextBoxWithRecords.AppendText(name + System.Environment.NewLine);
        }

        /// <summary>
        /// 延时函数
        /// </summary>
        /// <param name="milliSecond"></param>
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                continue;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                MessageBox.Show("请先导入名单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("是否将此同学列入翘课名单？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int index = GetStudentInClassIndex(labelNumber.Text);
                string isCut = classData[index, 6];
                if (labelNumber.Text != "" && index != -1 && isCut.CompareTo("0")==0)
                {
                    StreamWriter sw = File.AppendText("Result.txt");

                    sw.Write(labelClass.Text);
                    sw.Write("\t");
                    sw.Write(labelNumber.Text);
                    sw.Write("\t");
                    sw.WriteLine(labelName.Text);
                    sw.Close();

                    //班级出勤人数-1
                    classToAttendance[labelClass.Text] = classToAttendance[labelClass.Text] - 1;

                    //更新个人出勤率
                    //出勤次数-1
                    classData[index, 5] = (Int32.Parse(classData[index, 5]) - 1).ToString();
                    float res = Int32.Parse(classData[index, 5]) * 1f / Int32.Parse(classData[index, 4]) * 10000;
                    res = (int)res * 1f / 100;
                    labelAttendance.Text = res.ToString() + "%";
                    classData[index, 3] = res.ToString();

                    //更新是否旷课
                    classData[index, 6] = "1";
                }
                else if(isCut.CompareTo("1") == 0)
                {
                    MessageBox.Show("保存错误，该同学已经被记录过", "警告");
                }
                else {
                    MessageBox.Show("保存错误，保存数据不能为空或者不存在", "警告");
                }

                //更新班级签到率
                UpdateClassAttendance();
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if(row==0)
            {
                MessageBox.Show("请先导入名单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(orderIndex>=row)
            {
                if (MessageBox.Show("该班级所有学生点名完毕!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    LabelDataInit();
                }
            }
            else
            {
                labelNumber.Text = classData[orderIndex, 0];
                labelName.Text = classData[orderIndex, 1];
                labelClass.Text = classData[orderIndex, 2];
                labelAttendance.Text = classData[orderIndex, 3] + "%";
                orderIndex++;
            }
        }

        /// <summary>
        /// 通过学号查询学生在表格中的下标
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int GetStudentInClassIndex(string id)
        {
            for (int i = 0; i < row; i++)
            {
                if(classData[i,0].CompareTo(id)==0)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 随机生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int n = rd.Next(0,row);
            n = n + 1;
            labelNumber.Text = classData[n, 0];
            labelName.Text = classData[n, 1];
            labelClass.Text = classData[n, 2];
            labelAttendance.Text = classData[n, 3];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(axWindowsMediaPlayer2.playState) == 1)
            {
                axWindowsMediaPlayer2.Hide();
                buttonSkip.Hide();
            }
            
        }

        private void UpdateClassAttendance()
        {
            //班级出勤率
            richTextBoxWithClass.Text = "";
            string cn;
            int sumSt;
            int attendSt;
            for (int i = 0; i < cnt; i++)
            {
                cn = className[i];
                sumSt = classToSumStudent[cn];
                attendSt = classToAttendance[cn];
                float attendClass = (int)(attendSt * 1.0f / sumSt * 10000) * 1.0f / 100;
                richTextBoxWithClass.AppendText(cn + "出勤率:" + attendClass.ToString() + "%" + System.Environment.NewLine);
            }
        }

        /// <summary>
        /// Label初始化
        /// </summary>
        private void LabelDataInit()
        {
            labelNumber.Text = " ";
            labelName.Text = " ";
            labelClass.Text = " ";
            labelAttendance.Text = " ";
            orderIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                //加载皮肤
                skinEngine1.SkinFile = Skins[dataGridView1.CurrentRow.Index];
                skinEngine1.Active = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载所有皮肤列表
            foreach (string item in Directory.GetFiles(Application.StartupPath + @"\Skins\", "*.ssk"))
            {
                Skins.Add(item);
            }
            Skins.ForEach(x =>
            {
                dataGridView1.Rows.Add(Path.GetFileNameWithoutExtension(x));
            });
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                MessageBox.Show("请先导入名单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Hide();//隐藏主窗口
            Form2 form2 = new Form2(this);//利用子窗口的构造函数传入主窗口
            form2.ShowDialog();//显示子窗口
        }

        private void buttonShowStyle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                dataGridView1.Hide();
            }
            else
            {
                dataGridView1.Show();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string name = "testOutput" + (comboBox1.SelectedIndex).ToString() + ".csv";
            saveClassDataToCSV(name);
        }

        /// <summary>
        /// 将数据保存到csv
        /// </summary>
        /// <param name="filepath"></param>
        private void saveClassDataToCSV(string filepath)
        {
            Console.WriteLine(filepath);
            if(filepath == null || !filepath.EndsWith(".csv"))
            {
                return;
            }

            if (row == 0)
            {
                return;
            }

            DataTable dt = new DataTable();
            dt = arraysConvertToDataTable();
            if (dt == null)
            {
                return;
            }
            CSVFileHelper.SaveCSV(dt, filepath);
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                MessageBox.Show("请先导入名单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string fullPath = "";
            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            dialog.Filter = "文件(*.csv)|*.csv";//设置对话框保存的文件类型
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//将ok返回默认用户公共对话框
            {
                fullPath = dialog.FileName;//获取文件路径和文件名
            }
            if (fullPath != "" && fullPath.EndsWith(".csv"))
            {
                File.Create(fullPath).Close();

                saveClassDataToCSV(fullPath);
            }

        }

        /// <summary>
        /// 将数组转成DataTable
        /// </summary>
        /// <returns></returns>
        private DataTable arraysConvertToDataTable()
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < title.Length; i++)
            {
                dt.Columns.Add(title[i], typeof(string));
            }

            if(row==0 || col==0)
            {
                return null;
            }

            for (int i = 0; i < row; i++)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < col; j++)
                {
                    if (classData[i, j] == null)
                    {
                        continue;
                    }
                    dr[j] = classData[i, j].ToString();
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private void buttonShowHideRecords_Click(object sender, EventArgs e)
        {
            if (richTextBoxWithRecords.Visible)
            {
                richTextBoxWithRecords.Hide();
            }
            else
            {
                richTextBoxWithRecords.Show();
            }
        }

        private void buttonShowHideClass_Click(object sender, EventArgs e)
        {
            if (richTextBoxWithClass.Visible)
            {
                richTextBoxWithClass.Hide();
            }
            else
            {
                richTextBoxWithClass.Show();
            }
        }

        private void buttonImport_MouseEnter(object sender, EventArgs e)
        {
            label5.Show();
        }

        private void buttonImport_MouseLeave(object sender, EventArgs e)
        {
            label5.Hide();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
