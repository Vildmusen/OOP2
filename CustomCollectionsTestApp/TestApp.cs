using CustomCollections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCollectionsTestApp
{
    /// <summary>
    /// Test application for ObservableList.
    /// </summary>
    public partial class TestApp : Form
    {
        ObservableList<string> _list;
        public TestApp()
        {
            InitializeComponent();
            _list = new ObservableList<string>();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _list.Add(input_txt.Text);
            updatelist();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            _list.Remove(input_txt.Text);
            updatelist();
        }
        private void updatelist()
        {
            listview.Items.Clear();
            foreach (string item in _list)
            {
                listview.Items.Add(item);

            }
        }

        
    }
}
