using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RandomClickerRacing
{
    public class CPURacer
    {
        //backing fields
        //private int _seconds;
        //private TextBox _textBox;

        //stopwatch to keep track to of the time
        Stopwatch stopwatch = new Stopwatch();

        //constructor
        public CPURacer()
            //int seconds, TextBox textBox)
        {
            //_seconds = seconds;
            //_textBox = textBox;
        }

        //precondition: 
        //postcondition: starts the timer
        public void StartCPU()
        {
            stopwatch.Reset();
        }

        public void StopCPURace()
        {
            stopwatch.Stop();
        }

        public void CPURaceCounter(ref TextBox textBox, int benchmarkMS)
        {
            if(stopwatch.ElapsedMilliseconds >= benchmarkMS)
            {
                textBox.Visible = true;
            }
        }


    }
}
