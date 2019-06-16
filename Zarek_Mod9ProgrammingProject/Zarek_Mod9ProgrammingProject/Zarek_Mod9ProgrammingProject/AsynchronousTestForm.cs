using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Nicholas Zarek
 * Module 9 Programming Project
 * Part A
 * 
 * This program demonstrates using the return array from a Task.
 *
 */
namespace Zarek_Mod9ProgrammingProject
{
    public partial class AsynchronousTestForm : Form
    {
        public AsynchronousTestForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Starting Task to calculate Fibonacci(46)\r\n";

            Task<TimeData> task1 = Task.Run(() => StartFibonacci(46));

            txtOutput.AppendText("Starting Task to calculate Fibonacci(45)\r\n");

            Task<TimeData> task2 = Task.Run(() => StartFibonacci(45));

            TimeData[] results = await Task.WhenAll(task1, task2);

            DateTime startTime =
                (results[0].StartTime < results[1].StartTime) ?
                results[0].StartTime : results[1].StartTime;

            DateTime endTime =
                (results[0].EndTime < results[1].EndTime) ?
                results[0].EndTime : results[1].EndTime;

            double totalMinutes = (endTime - startTime).TotalMinutes;

            txtOutput.AppendText($"Total calculation time = {totalMinutes:F6} minutes\r\n");
        }

        TimeData StartFibonacci(int n)
        {
            var result = new TimeData();

            AppendText($"Calculating Fibonacci({n})");
            result.StartTime = DateTime.Now;
            long fibonacciValue = Fibonacci(n);
            result.EndTime = DateTime.Now;

            AppendText($"Fibonacci({n}) = {fibonacciValue}");
            double minutes =
                (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculation time = {minutes:F6} minutes\r\n");

            return result;
        }

        public long Fibonacci(long n)
        {
            if (n == 0 || n ==1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public void AppendText(String text)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else
            {
                txtOutput.AppendText(text + "\r\n");
            }
        }
    }
}
