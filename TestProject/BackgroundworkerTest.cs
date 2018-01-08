using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject
{
    public class BackgroundworkerTest
    {
        BackgroundWorker bg1 = null;
        bool g_bFlag = true;
        public void Test()
        {
            bg1 = new BackgroundWorker();
            bg1.DoWork += Bg1_DoWork;
            bg1.RunWorkerCompleted += Bg1_RunWorkerCompleted;
            bg1.RunWorkerAsync();
            Console.ReadLine();
            g_bFlag = false;
        }

        private void Bg1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Background worker finished task");
        }

        private void Bg1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(g_bFlag)
            {
                Console.WriteLine("background worker doing work");
                Thread.Sleep(1000);
            }
        }
    }
}
