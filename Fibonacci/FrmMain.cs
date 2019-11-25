using System;
using System.Threading;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            fibonacci = new CFibonacci(0);

        }

        CFibonacci fibonacci;

        Thread tLoop ;
        Thread tRecursive ;
        Thread tMyAlgorithm ;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumber.Text.Length<1)
                {
                    throw new EmptyException("TextBox");
                }
                int number = Convert.ToInt32(txtNumber.Text);
                Start(number);
            }
            catch (FormatException)
            {
                MessageBox.Show("only number");
                txtNumber.Text = string.Empty;
                txtNumber.Focus();
            }
            catch (EmptyException ex)
            {
                MessageBox.Show(ex.Message);
                txtNumber.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        enum State
        {
            Loop,
            Recursive,
            MyAlgorithm,
            Loop_Recursive,
            Loop_MyAlgorithm,
            Recursive_MyAlgorithm,
            All,
            None
        }

        void Start(int number)
        {
            fibonacci.number = number;

            btnExit.Enabled = false;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            chBoxLoop.Enabled = false;
            chBoxMyAlgorithm.Enabled = false;
            chBoxRecursive.Enabled = false;

            tLoop = new Thread(fibonacci.Loop);
            tRecursive = new Thread(fibonacci.Recursive);
            tMyAlgorithm = new Thread(fibonacci.MyAlgorithm);

            State s = Switch();
            switch (s)
            {
                case State.Loop:
                    tLoop.Start();

                    tLoop.Join();
                    break;
                case State.Recursive:
                    tRecursive.Start();

                    tRecursive.Join();
                    break;
                case State.MyAlgorithm:
                    tMyAlgorithm.Start();

                    tMyAlgorithm.Join();
                    break;
                case State.Loop_Recursive:
                    tLoop.Start();
                    tRecursive.Start();

                    tRecursive.Join();
                    tLoop.Join();
                    break;
                case State.Loop_MyAlgorithm:
                    tLoop.Start();
                    tMyAlgorithm.Start();

                    tMyAlgorithm.Join();
                    tLoop.Join();
                    break;
                case State.Recursive_MyAlgorithm:
                    tRecursive.Start();
                    tMyAlgorithm.Start();

                    tRecursive.Join();
                    tMyAlgorithm.Join();
                    break;
                case State.All:
                    tLoop.Start();
                    tRecursive.Start();
                    tMyAlgorithm.Start();

                    tRecursive.Join();
                    tMyAlgorithm.Join();
                    tLoop.Join();
                    break;
                case State.None:
                    try
                    {
                        throw new CheckBoxException();
                    }
                    catch (CheckBoxException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
            btnExit.Enabled = true;
            btnStart.Enabled = true;
            chBoxLoop.Enabled = true;
            chBoxMyAlgorithm.Enabled = true;
            chBoxRecursive.Enabled = true;
            btnStop.Enabled = false;

        }

        private State Switch()
        {
            if (chBoxLoop.Checked && chBoxRecursive.Checked && chBoxMyAlgorithm.Checked) 
            {
                return State.All;
            }
            else if (chBoxLoop.Checked && !chBoxRecursive.Checked && !chBoxMyAlgorithm.Checked) 
            {
                return State.Loop;
            }
            else if (!chBoxLoop.Checked && chBoxRecursive.Checked && !chBoxMyAlgorithm.Checked) 
            {
                return State.Recursive;
            }
            else if (chBoxLoop.Checked && chBoxRecursive.Checked && !chBoxMyAlgorithm.Checked) 
            {
                return State.Loop_Recursive;
            }
            else if (!chBoxLoop.Checked && !chBoxRecursive.Checked && chBoxMyAlgorithm.Checked) 
            {
                return State.MyAlgorithm;
            }
            else if (chBoxLoop.Checked && !chBoxRecursive.Checked && chBoxMyAlgorithm.Checked) 
            {
                return State.Loop_MyAlgorithm;
            }
            else if (!chBoxLoop.Checked && chBoxRecursive.Checked && chBoxMyAlgorithm.Checked) 
            {
                return State.Recursive_MyAlgorithm;
            }
            else
            {
                return State.None;
            }
            
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            tLoop.Abort();
            tMyAlgorithm.Abort();
            tLoop.Abort();

            btnExit.Enabled = true;
            btnStart.Enabled = true;
            chBoxLoop.Enabled = true;
            chBoxMyAlgorithm.Enabled = true;
            chBoxRecursive.Enabled = true;
            btnStop.Enabled = false;
            
        }
    }

    class EmptyException : Exception
    {
        public EmptyException()
            : base("Object is Empty")
        {

        }
        public EmptyException(string obj)
           : base($"{obj} is Empty")
        {

        }
    }
    class CheckBoxException : Exception
    {
        public CheckBoxException()
            : base("CheckBox Not selected")
        {

        }
    }
}
