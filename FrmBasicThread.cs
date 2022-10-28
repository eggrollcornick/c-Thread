using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrmBasicThreadManalo
{
    public partial class FrmBasicThread : Form
    {
        private Thread threadA, threadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting THread-");
            MyThreadClass threadClass = new MyThreadClass();
            ThreadStart NewThread = new ThreadStart(MyThreadClass.Thread1);

            Thread threadA = new Thread(NewThread);
            threadA.Name = "Tjread A Process";

            Thread threadB = new Thread(NewThread);
            threadB.Name = "Tjread B Process";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
