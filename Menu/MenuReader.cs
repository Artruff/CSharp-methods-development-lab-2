using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    class MenuReader
    {
        private string _filePath;
        private ToolStrip _strip;
        public MenuReader(string pathFile, ToolStrip strip)
        {
            _filePath = pathFile;
            _strip = strip;
        }

        public void CreateMenu()
        {
            FileInfo f = new FileInfo(_filePath);
            StreamReader sr = new StreamReader(f.OpenRead(), Encoding.Default);

            CreateMenuItem(sr, null);

            sr.Close();
        }
        private void CreateMenuItem(StreamReader sr, ToolStripMenuItem topItem = null, int prevLevel = 0)
        {
            if (sr.EndOfStream)
                return;
            string[] dataItem = sr.ReadLine().Split(new char[] { ' ' });
            ToolStripMenuItem downItem = new ToolStripMenuItem();
            int level = Convert.ToInt32(dataItem[0]);

            if (level != 0)
            {
                ToolStripMenuItem tmpItem = topItem == null ? (ToolStripMenuItem)_strip.Items[_strip.Items.Count - 1] : topItem;
                while (level != prevLevel-- + 1)
                    tmpItem = tmpItem.OwnerItem == null ? (ToolStripMenuItem)_strip.Items[_strip.Items.Count - 1] : (ToolStripMenuItem)tmpItem.OwnerItem;
                tmpItem.DropDownItems.Add(downItem);
            }
            else
                _strip.Items.Add(downItem);

            downItem.Name = dataItem[1];
            downItem.Text = dataItem[1];

            switch (Convert.ToInt32(dataItem[2]))
            {
                case (int)AccessEnum.VisibleAndNotAccessible:
                    downItem.Enabled = false;
                    break;
                case (int)AccessEnum.NotVisible:
                    downItem.Visible = false;
                    break;
            }

            if (dataItem.Length == 4)
            {
                MenuCommands mc = new MenuCommands();
                EventHandler command = (EventHandler)mc.GetType().GetMethod(dataItem[3]).CreateDelegate(typeof(EventHandler), mc);
                downItem.Click += command;
            }

            CreateMenuItem(sr, downItem, level);
        }
    }
}
