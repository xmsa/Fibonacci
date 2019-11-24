using System.Diagnostics;
using System.Windows.Forms;

namespace Fibonacci
{
    class CFibonacci
    {
        int number;

        public CFibonacci(int number)
        {
            this.number = number;
        }

        public void Recursive()
        {
            Stopwatch timer = new Stopwatch();
            string value;

            timer.Start();
            value = Recursive(number).ToString();
            timer.Stop();

            MessageBox.Show($"Run Time: {ConvertToTime(timer)}\n Value: {value}", "Recursive");

        }

        public void Loop()
        {
            Stopwatch timer = new Stopwatch();
            string value;

            timer.Start();
            value = Loop(number).ToString();
            timer.Stop();

            MessageBox.Show($"Run Time: {ConvertToTime(timer)}\n Value: {value}", "Loop");
        }

        public void MyAlgorithm()
        {
            Stopwatch timer = new Stopwatch();
            string value;
            decimal[] date = new decimal[2];
            date[0] = 1;
            date[1] = 0;

            timer.Start();
            value = MyAlgorithm(date, number).ToString();
            timer.Stop();

            MessageBox.Show($"Run Time: {ConvertToTime(timer)}\n Value: {value}", "MyAlgorithm");
        }

        long Recursive(int num)
        {
            if (num == 2 || num == 1)
                return 1;
            else
                return Recursive(num - 1) + Recursive(num - 2);
        }

        decimal Loop(int num)
        {
            decimal a = 1, b = 1, c = 1;
            for (int i = 3; i < num + 1; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        decimal MyAlgorithm(decimal[] date, int num)
        {
            if (num > 1)
                MyAlgorithm(date, num - 1);

            decimal temp = date[0] + date[1];
            date[0] = date[1];
            date[1] = temp;
            return temp;
        }

        string ConvertToTime(Stopwatch timer)
        {
            string min;
            string sec;
            string msec;

            string[] time = new string[3];
            time[0] = timer.Elapsed.Minutes.ToString();
            time[1] = ((timer.Elapsed.Minutes == 0) ? timer.Elapsed.Seconds : (timer.Elapsed.Seconds % 60)).ToString();
            time[2] = ((timer.Elapsed.Seconds == 0) ? timer.Elapsed.Milliseconds : (timer.Elapsed.Milliseconds % 1000)).ToString();

            min = ((time[0].Length == 1) ? "0" + time[0] : time[0]);
            sec = ((time[1].Length == 1) ? "0" + time[1] : time[1]);
            msec = ((time[2].Length == 3) ? time[2] : ((time[2].Length == 2) ? ("0" + time[2]) : "00" + time[2]));

            return ($"{min}: {sec} :{msec}");
        }
    }
}
