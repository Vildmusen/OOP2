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
        bool isRejecting = false;

        public TestApp()
        {
            InitializeComponent();
            list = new ObservableList<string>();
            Subscribe(list);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.TryAdd(input_txt.Text))
                {
                    Errormessage.Text = "Sucessful operation";
                }
            }
            catch (Exception ex)
            {
                Errormessage.Text = ex.Message;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.TryRemove(input_txt.Text))
                {
                    Errormessage.Text = "Sucessful operation";
                }
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
        
        private void Contains_btn_Click(object sender, EventArgs e)
        {
            if (list.Contains(input_txt.Text))
            {
                Errormessage.Text = input_txt.Text + " finns i listan";
            }
            else
            {
                Errormessage.Text = input_txt.Text + " finns inte i listan";
            }
        }

        public void Subscribe<T>(ObservableList<T> observer)
        {
            observer.BeforeChange += List_BeforeChange;
            observer.Changed += List_Changed;
        }

        private void List_BeforeChange<T>(object sender, RejectArgs<T> e)
        {
            if (e.Value.ToString().Length > 7 ||
                e.Value.ToString().ToUpper() == e.Value.ToString() ||
                e.Value.ToString() == "" ||
                (e.Count >= 10 && e.Operation == Operation.Add))
            {
                e.RejectOperation();
            }
        }

        private void List_Changed<T>(object sender, ListChangedEventArgs<T> e)
        {
            updatelist();
        }
    }
}
