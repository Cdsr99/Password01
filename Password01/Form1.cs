using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void senha()
        {
            String data;
            String dia;
            data = Convert.ToString(System.DateTime.Now);
            //DateTimePicker.time
            //data.System.DateTime.Today;
            //label1.Text = Convert.ToString(data);
            String pass01 = Convert.ToString(System.DateTime.Now.Hour);
            String pass02 = Convert.ToString(System.DateTime.Now.Minute);
            String part01 = "20";
            String part02 = "17";
            String passfull = part01 + pass02 + pass01 + part02;
            String admin = "Cdsr99";

           






            if (textBox1.Text == passfull)

            {
                chamar();
                Close();

            }
            else if(textBox1.Text == admin)
            {
                MessageBox.Show("Você entrou com a senha de Administrador!", "Admin", MessageBoxButtons.OK);
                chamar();
                Close();
            }
            else
            {
                MessageBox.Show("A senha não confere! ", "Erro", MessageBoxButtons.YesNo);
                ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            senha();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
        public void chamar()
        {
            String Google_Chrome = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            Process pr = new Process();
            pr.StartInfo.FileName = Google_Chrome;
            pr.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://www.microsoft.com");

        }
        
    }
}
