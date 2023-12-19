using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SharpInjector
{


    public partial class Form1 : Form
    {
        [DllImport("C:\\Users\\forwa\\source\\repos\\InjectorLibrary\\Release\\InjectorLibrary.dll", EntryPoint = "InjectDLL")]
        public static extern bool InjectDLL(string path, int pid);

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InjectDLL("C:\\Users\\forwa\\source\\repos\\TestDllInject\\Release\\TestDllInject.dll", 26344);
        }
    }
}
