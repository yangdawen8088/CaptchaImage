using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texts = textBox1.Text;
            if (string.IsNullOrWhiteSpace(texts))
            {
                MessageBox.Show("请输入验证码内容。","系统提示");
            }
            pictureBox1.BackgroundImage = VerificationCodeHelp.DrawImage(texts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = VerificationCodeHelp.RandomVerificationCode(4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = VerificationCodeHelp.RandomVerificationCode(4);
            pictureBox1.BackgroundImage = VerificationCodeHelp.DrawImage(textBox1.Text);
        }
    }
}
