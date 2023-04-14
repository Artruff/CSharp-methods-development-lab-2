using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu;

namespace CSharp_methods_development_lab_2
{
    public partial class MenuApplicationForm : Form
    {
        public MenuApplicationForm(string menuPath)
        {
            InitializeComponent();

            MenuReader menuReader = new MenuReader(menuPath, menuStrip);
            menuReader.CreateMenu();
        }
    }
}
