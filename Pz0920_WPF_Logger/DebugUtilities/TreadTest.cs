using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pz0920_WPF_Logger.DebugUtilities
{
    internal class ThreadTest
    {
        ListBox lb;
        int n;

        public ThreadTest(ListBox lb, int n)
        {
            this.lb = lb;
            this.n = n;
        }

        public ListBox listBox { get => lb; } 

        public int ThreadN { get => n; }
    }
}
