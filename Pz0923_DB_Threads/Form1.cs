using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pz0923_DB_Threads
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=DESKTOP-7IHQ5JA\\SQLEXPRESS;Initial Catalog=DBLibrary;Integrated Security=True";
        string qrSelect = @"SELECT TOP 10000 e.id,
                                e.code,
                                e.firstName,
                                e.lastName
                                FROM dbo.employees e";
        readonly object databaseLock = new object();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(qrSelect, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(ds);

                    dgvData.ReadOnly = true;
                    dgvData.DataSource = ds.Tables[0];

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}");
            }
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Cklicked");
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("BgWorker Finished Work");
            btnRefreshInBack.Enabled = true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                prgProgress.Value = e.ProgressPercentage - 1;
            }
            catch { }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(qrSelect, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(ds);

                    if (dgvData.InvokeRequired)
                    {
                        Invoke(new MethodInvoker(
                            delegate
                            {
                                dgvData.ReadOnly = true;
                                dgvData.DataSource = ds.Tables[0];
                            }));
                    }
                    else
                    {
                        dgvData.ReadOnly = true;
                        dgvData.DataSource = ds.Tables[0];
                    }

                    int progress = 0;
                    int rowCount = ds.Tables[0].Rows.Count;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        progress = (int)((( (double)rowCount / ds.Tables[0].Rows.Count) ) * 100);
                        Thread.Sleep(500);
                        bgWorker.ReportProgress(progress);
                    }



                }
            }

            catch (Exception ex)
            {
                if (this.InvokeRequired)
                {
                    Invoke(new MethodInvoker(
                        delegate
                        {
                            MessageBox.Show($"Connection Error: {ex.Message}");
                        }
                ));
                }
                else
                {
                    MessageBox.Show($"Connection Error: {ex.Message}");
                }
            }
        }

        private void btnRefreshInBack_Click(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            btnRefreshInBack.Enabled = false;

            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(WriteToDB);
            thread1.Name = "Thread1";

            Thread thread2 = new Thread(WriteToDB);
            thread2.Name = "Thread2";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            MessageBox.Show("Saved");
        }

        void WriteToDB()
        {
            try
            {
                //lock (databaseLock)
                {
                    using (SqlConnection connection = 
                        new SqlConnection(connString))
                    {
                        connection.Open();

                        for(int i = 0; i < 100; i++)
                        {
                            string qrInsert =
                                $@"INSERT INTO dbo.Empl 
                                VALUES({i}, '{Thread.CurrentThread.Name}')";
                            SqlCommand command = new SqlCommand(qrInsert, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
