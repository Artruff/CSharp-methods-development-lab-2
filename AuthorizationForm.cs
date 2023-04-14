using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_methods_development_lab_2
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void CancleFunction(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InterFunction(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo("C:\\Users\\artur.ivanov.2021\\Documents\\TD\\TMP\\Lab2\\Users.txt");
            StreamReader sr = f.OpenText();
            while(!sr.EndOfStream)
            {
                string[] data = sr.ReadLine().Split(new char[1] { ' ' });
                if (userTextBox.Text != data[0] || passwordTextBox.Text != data[1])
                    continue;
                MenuApplicationForm ap = new MenuApplicationForm(data[2]);
                ap.Show();
                sr.Close();
                return;
            }
            sr.Close();
            MessageBox.Show("Неверное имя пользователя или пароль");
        }
    }
}
