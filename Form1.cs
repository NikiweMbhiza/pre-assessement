using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pre_assessement
{
    public partial class Form1 : Form
    {
        string word;
        private List<string> wordsList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                word = textBox1.Text;
                Names.Items.Add(word);
                MessageBox.Show($"'{word}' added to the list.");
                textBox1.Clear();

            }
            else
            {
                MessageBox.Show("enter a name");
            }
            

            

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           // word= textBox1.Text;
           foreach(var selectedItem in Names.SelectedItems.Cast<string>().ToList())
            {
                Names.Items.Remove(selectedItem);
                MessageBox.Show($"'{selectedItem}' removed from the list.");

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Names.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Names.SelectedIndex != -1)
            {
                string newWord = textBox1.Text;
                word = Names.SelectedItem.ToString();
                int index = Names.SelectedIndex;
                Names.Items[index] = newWord;
                MessageBox.Show($"'{word}'changed to {newWord}'.");
            }
            else
            {
                MessageBox.Show("Please select a word from the list");
            }
               
            
        }
    }
}
