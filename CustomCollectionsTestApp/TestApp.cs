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

        public TestApp()
        {
            InitializeComponent();
            list = new ObservableList<string>();
            Subscribe(list);
        }

        /// <summary>
        /// Tries to add an item to the list. If an exception is catched, a label text is updated to indicate this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(input_txt.Text);
                Errormessage.Text = "Sucessful operation";
            }
            catch (Exception ex)
            {
                Errormessage.Text = ex.Message;
            }
        }

        /// <summary>
        /// Tries to remove an item from the list. If an exception is catched, a label text is updated to indicate this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Clears the listview and then adds all items in "list".
        /// </summary>
        public void updatelist<T>(object sender, ListChangedEventArgs<T> e)
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

        /// <summary>
        /// Subscribes to the events "BeforeChange" and "Changed" from the argument "list"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void Subscribe<T>(ObservableList<T> list)
        {
            list.BeforeChange += List_BeforeChange;
            list.Changed += updatelist;
        }

        /// <summary>
        /// Method to run at event "BeforeChange". Rejects the operation according to the conditions in the if-statement.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_BeforeChange<T>(object sender, RejectableEventArgs<T> e)
        {
            if (e.Value.ToString().Length > 7 ||
                e.Value.ToString().ToUpper() == e.Value.ToString() ||
                e.Value.ToString() == "" ||
                (e.Count >= 10 && e.Operation == Operation.Add))
            {
                e.RejectOperation();
            }
        }
    }
}
