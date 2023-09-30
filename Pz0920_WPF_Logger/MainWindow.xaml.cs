using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pz0920_WPF_Logger.DebugUtilities;
using System.Threading;

namespace Pz0920_WPF_Logger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTestLogger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new CustomException("Error Message", 
                    "Extended Error Description");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message} saved to {Logger.LogFilePath}");
            }

        }

        private void btnTestCurrentThreadInfo_Click(object sender, RoutedEventArgs e)
        {
            Thread currentThread = Thread.CurrentThread;
            lbResult.Items.Add($"Main Method:\n" +
                $"\tName: {currentThread.Name}\n" +
                $"\tAlive: {currentThread.IsAlive}\n" +
                $"\tId: {currentThread.ManagedThreadId}\n" +
                $"\tPriority: {currentThread.Priority}\n" +
                $"\tStatus: {currentThread.ThreadState}\n");
        }

        private void btnTestThreads_Click(object sender, RoutedEventArgs e)
        {
            Thread thread1 = new Thread(PrintThreads);
            Thread thread2 = new Thread(new ParameterizedThreadStart(PrintThreads));
            
            thread1.Start(new ThreadTest(lbResult, 1));
            thread2.Start(new ThreadTest(lbResult, 2));
        }

        void PrintThreads(object? sender)
        {
            if(sender is ThreadTest)
            {
                ThreadTest threadTest = (ThreadTest)sender;
                for(int i = 0; i < 5; i++)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        threadTest.listBox.Items.Add($"Tread N{threadTest.ThreadN}: {i}");
                    }
                        );
                    Thread.Sleep(400);
                }
            }
        }

        private void btnTestReader_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i, lbResult);
            }
        }
    }
}
