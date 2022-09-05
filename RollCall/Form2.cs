using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RollCall
{
    public partial class Form2 : Form
    {
        Form parentForm;
        //0:学号,1:姓名,2:班级,3:出勤率,4:总课时,5:出勤次数,6:本次是否旷课
        public string[,] crtClassData = new string[1000, 10];
        int rowForm2, colForm2;

        public Form2(Form pa)
        {
            this.parentForm = pa;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            crtClassData = Form1.classData;
            rowForm2 = Form1.row;
            colForm2 = Form1.col;

            Console.WriteLine(rowForm2);
            Console.WriteLine(colForm2);

            //dataGridView1.Columns.Clear();
            //dataGridView1.Rows.Clear();

            List<string> str = new List<string>();
            for(int i=0;i<rowForm2;i++)
            {
                str.Clear();
                for(int j=0;j<colForm2;j++)
                {
                    str.Add(crtClassData[i,j]);
                }
                dataGridView1.Rows.Add(str.ToArray());
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();//显示主窗口
            this.Close();//关闭子窗口
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parentForm.Show();//显示主窗口
            this.Close();//关闭子窗口
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
