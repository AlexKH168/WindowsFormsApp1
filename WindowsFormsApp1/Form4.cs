using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load");

            taskRun();
        }

        private void taskRun()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(10000);
                return 42;
            });
            t.Wait();
            MessageBox.Show("Task run.");
        }
    }
}
