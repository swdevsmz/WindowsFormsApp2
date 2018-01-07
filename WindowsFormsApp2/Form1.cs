using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public class Sample : INotifyPropertyChanged
        {
            public String _aaa;
            public String Aaa
            {
                set
                {
                    this._aaa = value;
                    OnPropertyChanged("Aaa");
                }
                get
                {
                    return this._aaa;
                }
                
            }

            public event PropertyChangedEventHandler PropertyChanged;
            // Create the OnPropertyChanged method to raise the event
            protected void OnPropertyChanged(string name)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }
        }

        private Sample abc = new Sample();
        private double i = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            c1DateEdit1.DataSource = abc;
            c1DateEdit1.DataField = "Aaa";
            */
            c1DateEdit1.DataBindings.Add("Value", abc,"Aaa");

            abc.Aaa = DateTime.Now.ToString();


        }

        private void c1DateEdit1_ValueChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(abc.Aaa);
        }
        

        private void c1DateEdit1_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(abc.Aaa);
        }


        private void c1DateEdit1_LostFocus(object sender, EventArgs e)
        {
            Console.WriteLine(abc.Aaa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abc.Aaa = DateTime.Now.AddDays(i).ToString();
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abc.Aaa = null;
        }
    }
}
