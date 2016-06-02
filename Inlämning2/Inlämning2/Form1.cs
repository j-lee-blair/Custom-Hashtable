//Julian 14/09/22
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning2
{
    public partial class Form1 : Form
    {

        private object key, value;
        HashTable h = new HashTable(3);

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the txt_Box_Add control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txt_Box_Add_Click(object sender, EventArgs e)
        {

            key = txt_Box_Key.Text;                              //increments the index counter (key) for each new entry
            value = txt_Box_Value.Text;

            if ((txt_Box_Key.Text == string.Empty) || (txt_Box_Value.Text == string.Empty)) 
            {
                MessageBox.Show("Must enter key and value");
            }

            else
            {
                Entry entry = new Entry(key, value);
                h.AddValue(key, value);
                txt_Box_Value.Text = string.Empty;
                lbl_Element_Count.Text = h.Count.ToString();
            }
        }


        /// <summary>
        /// Handles the Click event of the btn_Remove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (txt_Box_Key.Text == "")
            {
                MessageBox.Show("To remove a value enter its key");
            }
            
            else
            {
                h.RemoveValue(key);
                txt_Box_Value.Text = string.Empty;
                txt_Box_Key.Text = string.Empty;
                lbl_Element_Count.Text = h.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_Trans control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Trans_Click(object sender, EventArgs e)
        {
            if (txt_Box_Key.Text == string.Empty)
            {
                MessageBox.Show("Please add your key to the dictionary before translating.");
            }

            if (h.Get(key) == null)
            {
                MessageBox.Show("Key not recognised. Please add a key and value before trying to translate.");
            }

            //else if (h.Get(key) == null)
            //{
            //    MessageBox.Show("Cannot translate a word which has no definition.");
            //}

            else h.Translate(key);
        }
    }
}
