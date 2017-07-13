using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace Runge
{
    public partial class Form1 : Form
    {
        double F1(double[] y, double x)
        {
            return -(55 + y[2]) * y[0] + 65 * y[1];
        }

        double F2(double[] y, double x)
        {
            return 0.0785 * (y[0] - y[1]);
        }

        double F3(double[] y, double x)
        {
            return 0.1 * y[0];
        }

        double F(double[] y, double x, int i)
        {
            switch (i)
            {
                case 0:
                    return F1(y, x);
                 
                case 1:
                    return F2(y, x);
                   
                case 2:
                    return F3(y, x);
                default:
                    return 0;
            }
        }
   
        private CancellationTokenSource _cts;
        const int c = 3;
        const double KOEF = 0.166666667;
        const double TAU = 0.001;
        double Tst = 0, Tfn;
        double t;
        double x = 0;
        double[] y,ans;
        double[] R1, R2, R3, R4, Help1, Help2, Help3;

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (_cts == null) return;
            else _cts.Cancel();
        }

        private async void Calc()
        {
            R1 = new double[3];
            R2 = new double[3];
            R3 = new double[3];
            R4 = new double[3];
            Help1 = new double[3];
            Help2 = new double[3];
            Help3 = new double[3];
            Progress<int> prog = new Progress<int>();
            prog.ProgressChanged += prog_ProgressChanged;
            y = new double[] { Convert.ToDouble(y1st.Text), Convert.ToDouble(y2st.Text), Convert.ToDouble(y3st.Text)};
            t = Tst;
            Tfn = Convert.ToDouble(Tftb.Text);
            Stopwatch time = new Stopwatch();
            time.Start();
            if (Parallelcb.Checked)
            {
                _cts = new CancellationTokenSource();
                try
                {
                    ans = await RungeCuttaFourParallel(y, Tst, Tfn, _cts.Token, prog);
                    time.Stop();
                    rtb.AppendText("y1:" + ans[0] + "; " + "y2:" + ans[1] + "; " + "y3:" + ans[2] + ";" + Environment.NewLine + "Time:" + ((double)time.ElapsedMilliseconds / 1000).ToString() + Environment.NewLine);

                }
                catch (OperationCanceledException)
                {
                    time.Stop();
                    MessageBox.Show("Операция была отменена");
                }
                catch
                {
                    time.Stop();
                    MessageBox.Show("Ошибка!");
                }

            }
            else
            {
                ans = RungeCuttaFour(Tst, Tfn, y);
                time.Stop();
                rtb.AppendText("y1:" + ans[0] + "; " + "y2:" + ans[1] + "; " + "y3:" + ans[2] + ";" + Environment.NewLine + "Time:" + ((double)time.ElapsedMilliseconds / 1000).ToString() + Environment.NewLine);
            }
        }
        private Task<double[]> RungeCuttaFourParallel(double[] y, double Tst, double Tfn,CancellationToken token, IProgress<int> prog)
        {
            Task<double[]> t = new Task<double[]>(() => {
                double[] ans = new double[y.Length];
                Array.Copy(y, ans, y.Length);
                int pr =0;
                var time = Tst;
                while (time < Tfn)
                {
                    for (int i = 0; i < c; i++)
                    {
                        R1[i] = TAU * F(ans, x, i);
                        Help1[i] = ans[i] + 0.5 * R1[i];
                    }
                    for (int i = 0; i < c; i++)
                    {
                        R2[i] = TAU * F(Help1, x, i);
                        Help2[i] = ans[i] + 0.5 * R2[i];
                    }
                    for (int i = 0; i < c; i++)
                    {
                        R3[i] = TAU * F(Help2, x, i);
                        Help3[i] = ans[i] + R3[i];
                    }
                    for (int i = 0; i < c; i++)
                    {
                        R4[i] = TAU * F(Help3, x, i);
                    }
                    Parallel.For(0, c, new ParallelOptions { CancellationToken = token }, (i, state) =>
                       {
                           //
                          // ((int)(time / Tfn)) * 100
                           ans[i] = ans[i] + KOEF * (R1[i] + 2 * R2[i] + 2 * R3[i] + R4[i]);
                           token.ThrowIfCancellationRequested();
                          // Interlocked.Increment(ref count);
                       });
                    pr = (int)((time / Tfn) * 100 +1);
                    prog.Report(pr);

                    time += TAU;
                }
                return ans;
            }, token);
            t.Start();
            return t;
        }
        private double[] RungeCuttaFour(double Tst,double Tfn, double[] y)
        {
            double[] res = new double[y.Length];
            Array.Copy(y, res, y.Length);
            var time = Tst;
            while (time < Tfn)
            {
                for (int i = 0; i < c; i++)
                {
                    R1[i] = TAU * F(res, x, i);
                    Help1[i] = res[i] + 0.5 * R1[i];
                }
                for (int i = 0; i < c; i++)
                {
                    R2[i] = TAU * F(Help1, x, i);
                    Help2[i] = res[i] + 0.5 * R2[i];
                }
                for (int i = 0; i < c; i++)
                {
                    R3[i] = TAU * F(Help2, x, i);
                    Help3[i] = res[i] + R3[i];
                }
                for (int i = 0; i < c; i++)
                {
                    R4[i] = TAU * F(Help3, x, i);
                }
                for (int i = 0; i < c; i++)
                {
                    res[i] = res[i] + KOEF * (R1[i] + 2 * R2[i] + 2 * R3[i] + R4[i]);
                }
                time += TAU;
            }
            return res;
        }
        void prog_ProgressChanged(object sender, int e)
        {
            pgb.Value = e;
        }
        public Form1()
        {
            InitializeComponent();
        }

    }
}


/*      Task<double[]> tsl =  RungeCuttaFourParallel(y, Tst, Tfn, _cts.Token, prog);
                tsl.ContinueWith((origin) => 
                {
                    if (origin.IsCanceled)
                    {
                        time.Stop();
                        MessageBox.Show("Операция была отменена");
                    }
                    if (origin.IsFaulted)
                    {
                        origin.Exception.Handle((ex) => {
                            time.Stop();
                            MessageBox.Show(ex.Message);
                            return true;
                        });
                    }
                    if(origin.IsCompleted)
                    {
                        time.Stop();
                        rtb.AppendText("y1:" + y[0] + "; " + "y2:" + y[1] + "; " + "y3:" + y[2] + "; Time:" + ((double)time.ElapsedMilliseconds / 1000).ToString() + Environment.NewLine);
                    }
                },TaskScheduler.FromCurrentSynchronizationContext());*/
