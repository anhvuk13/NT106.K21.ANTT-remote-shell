using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote_shell
{
    public partial class LogForm : Form
    {

 
        Dashboard parent = null;
        private string path = null;

        public LogForm(Dashboard parent)
        {
            InitializeComponent();
            this.parent = parent;
            path = parent.pathLogFolder;
        }


        private void LogForm_Load(object sender, EventArgs e)
        {
            // Tim den folder luu log
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            // load cac file
            // => dua vao listView
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                addToList(fileInfo.FullName);

        }

        private void addToList(string path)
        {
            FileInfo fileInfo = new FileInfo(path);

            ListViewItem item = new ListViewItem();
            item.Text = fileInfo.Name;

            item.SubItems.Add(fileInfo.CreationTime.ToString());
            item.SubItems.Add(fileInfo.LastWriteTime.ToString());
            item.SubItems.Add(fileInfo.Length.ToString());

            lstvLog.Items.Add(item);
        }

        private void lstvLog_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = lstvLog.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                lstvLog.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            lstvLog.Sort();
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void lstvLog_DoubleClick(object sender, EventArgs e)
        {
            string file = path + @"\" + lstvLog.SelectedItems[0].Text;
            Process.Start("notepad.exe", file);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            ServerForm server = new ServerForm(parent);
            server.Show();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm(parent);
            client.Show();
            this.Hide();
        }
    }
}
