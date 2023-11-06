using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 코딩온_C__프로젝트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // MessageBox.Show("안녕하시긔??????");
           /* 텍스트 출력*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBOBOx.Text = "이것은\r\n멀티라인\r\n텍스트박스";
       }
    }
}
