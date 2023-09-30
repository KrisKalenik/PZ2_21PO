using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Controls;

namespace Pz0920_WPF_Logger.DebugUtilities
{
    internal class Reader
    {
        static Semaphore sem = new Semaphore(3, 3);
        public Thread myThread;
        int count = 3;

        public Reader(int i, ListBox listBox)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Reader {i}";
            myThread.Start(listBox);
        }

        public void Read(Object? sender)
        {
            if(sender is ListBox)
            {
                ListBox listBox = sender as ListBox;
                string str = Thread.CurrentThread.Name;
                while (count > 0)
                {
                    sem.WaitOne();
                    listBox.Parent.Dispatcher.Invoke(()=>
                    {
                        listBox.Items.Add($"{str} enters library");
                        listBox.Items.Add($"{str} reads");
                    });
                    Thread.Sleep(1000);
                    listBox.Parent.Dispatcher.Invoke(() =>
                    {
                        listBox.Items.Add($"{str} leaves library");
                    });
                    sem.Release();
                    count--;
                    Thread.Sleep(1000);

                }
            }
        }
    }
}
