using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTXT.PasswordChar = '*';
        }
    }
}
