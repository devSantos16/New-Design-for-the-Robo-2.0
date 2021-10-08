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

namespace DesignRobo_2._0
{
    public partial class Form1 : Form
    {
        private int WM_NCLBUTTONDOWN = 0xA1;
        private int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;

            button5.Text = "Aditamento Novo";
            button9.Text = "Extrair Informações";
            button10.Text = "Exportar DRS";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;

            button5.Text = "Aditamento Legado";
            button9.Text = "Executar DRI";
            button10.Text = "Exportar DRI";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = false;

            button5.Text = "Executar Parcela";
            
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://animaeducacao.com.br/");
        }

        private void panelMenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
