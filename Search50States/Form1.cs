using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search50States
{
    public partial class Form1 : Form
    {
        string[] states = new string[50];
        IEnumerable<string> result;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "search type";
            label2.Text = "search text";
            label3.Text = "State results";
            states = getdata();
            comboBox1.Items.Add("Starts With");
            comboBox1.Items.Add("Ends With");
            comboBox1.Items.Add("Contains");

        }

        private void startupcode()
        {
            result = null;
            listBox1.Items.Clear();
            label3.Text = "State ";

            if (comboBox1.SelectedIndex == 0)
            {
                label4.Text = "StartsWith";
                result = StartsWith();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label4.Text = "EndsWith";
                result = EndsWith();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label4.Text = "Contains";
                result = Contains();
            }
            else
            {
                label4.Text = "None";
            }
            if (result != null)
            {
                
                foreach (var item in result)
                {
                    listBox1.Items.Add(item);
                    
                }
                label3.Text = result.Count().ToString();
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private IEnumerable<string> StartsWith()
        {
            IEnumerable<string> result = from state in states
                                         where state.StartsWith(textBox1.Text)
                                         select state;
            return result;
        }

        private IEnumerable<string> EndsWith()
        {
            IEnumerable<string> result = from state in states
                                         where state.EndsWith(textBox1.Text)
                                         select state;
            return result;
        }

        private IEnumerable<string> Contains()
        {
            IEnumerable<string> result = from state in states
                                         where state.Contains(textBox1.Text)
                                         select state;
            return result;
        }

        private string[] getdata()
        {
            string[] states = 
                {
                "Alabama",
                "Alaska",
                "Arizona",
                "Arkansas",
                "California",
                "Colorado",
                "Connecticut",
                "Delaware",
                "Florida",
                "Georgia",
                "Hawaii",
                "Idaho",
                "Illinois",
                "Indiana",
                "Iowa",
                "Kansas",
                "Kentucky",
                "Louisiana",
                "Maine",
                "Maryland",
                "Massachusetts",
                "Michigan",
                "Minnesota",
                "Mississippi",
                "Missouri",
                "Montana",
                "Nebraska",
                "Nevada",
                "New Hampshire",
                "New Jersey",
                "New Mexico",
                "New York",
                "North Carolina",
                "North Dakota",
                "Ohio",
                "Oklahoma",
                "Oregon",
                "Pennsylvania",
                "Rhode Island",
                "South Carolina",
                "South Dakota",
                "Tennessee",
                "Texas",
                "Utah",
                "Vermont",
                "Virginia",
                "Washington",
                "West Virginia",
                "Wisconsin",
                "Wyoming"
            };
            return states;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            startupcode();
        }
    }
}
