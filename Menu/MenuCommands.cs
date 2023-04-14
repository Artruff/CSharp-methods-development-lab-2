using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    /// <summary>
    /// Класс команд для меню
    /// </summary>
    class MenuCommands
    {
        public void OpenDirectoryCity(object sender, EventArgs e)
        {
            MessageBox.Show("Открыли справочник городов");
        }
        public void OpenDirectoryHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Открыли помощь по справкам");
        }
        public void OpenDirectoryEmployee(object sender, EventArgs e)
        {
            MessageBox.Show("Открыли помощь по справкам");
        }
        public void Buy(object sender, EventArgs e)
        {
            MessageBox.Show("Купили товар");
        }
        public void Sell(object sender, EventArgs e)
        {
            MessageBox.Show("Продали товар");
        }
    }
}
