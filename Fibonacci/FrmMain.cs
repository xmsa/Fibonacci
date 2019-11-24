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

namespace Fibonacci
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            fibonacci = new CFibonacci(0);
            tLoop = new Thread(fibonacci.Loop);
            tRecursive = new Thread(fibonacci.Recursive);
            tMyAlgorithm = new Thread(fibonacci.MyAlgorithm);
        }

        CFibonacci fibonacci;

        Thread tLoop ;
        Thread tRecursive ;
        Thread tMyAlgorithm ;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumber.TextLength<1)
                {
                    throw new Exception();
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
            catch (Exception)
            {
                MessageBox.Show("Enter a Number");
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
                    tMyAlgorithm.Join();
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

                    tLoop.Join();
                    tMyAlgorithm.Join();
                    tLoop.Join();
                    break;
                case State.None:
                    MessageBox.Show("Plase Enter one item");
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
}
