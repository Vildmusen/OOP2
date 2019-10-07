using CustomCollections;
using CustomDatastructures.Core;
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
        ObservableList<string> list;
        Listener listener;

        public TestApp()
        {
            InitializeComponent();
            list = new ObservableList<string>();
            listener = new Listener();
            listener.Subscribe(list);
        }
        
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.TryAdd(input_txt.Text))
                {
                    updatelist();
                    Errormessage.Text = "Sucessful operation";
                }
            }
            catch (OperationRejectedException ex)
            {
                Errormessage.Text = ex.Message;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                list.Remove(input_txt.Text);             
                Errormessage.Text = "Sucessful operation";
            }
            catch (Exception ex)
            {
                Errormessage.Text = ex.Message;
            }
          
        }
        public void updatelist()
        {
            listview.Items.Clear();
            foreach (string item in list)
            {
                listview.Items.Add(item);
            }
        }

        private void reject_chk_CheckedChanged(object sender, EventArgs e)
        {
            if(reject_chk.Checked)
            {
                listener.isRejecting = true;
            }
            else
            {
                listener.isRejecting = false;
            }
        }

        private void Contains_btn_Click(object sender, EventArgs e)
        {
            if (list.Contains(input_txt.Text))
            {
                Errormessage.Text = input_txt.Text + " finns i listan";

            }
        }
    }
}
