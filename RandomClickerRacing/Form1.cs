using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomClickerRacing
{
    public partial class Form1 : Form
    {
        //tracks the clicks
        int tracker;

        //player benchmarks for clicks
        const int BENCHMARK_ONE = 3;
        const int BENCHMARK_TWO = 6;
        const int BENCHMARK_THREE = 9;
        const int BENCHMARK_FOUR = 12;
        const int BENCHMARK_FIVE = 15;

        //CPU Racer object to play the cpu racer
        CPURacer cpu = new CPURacer();
        //Benchmarks for the cpu player in ms
        const int CPU_BENCHMARK_ONE = 3000;
        const int CPU_BENCHMARK_TWO = 6000;
        const int CPU_BENCHMARK_THREE = 9000;
        const int CPU_BENCHMARK_FOUR = 12000;
        const int CPU_BENCHMARK_FIVE = 15000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void beginbtn_Click(object sender, EventArgs e)
        {
            racebtn.Visible = true;

            //when you hit the begin button it resets the game
            tracker = 0;

            playerTrack1.Visible = false;
            playerTrack2.Visible = false;
            playerTrack3.Visible = false;
            playerTrack4.Visible = false;
            playerTrack5.Visible = false;

            cpu.StartCPU();
            cpu.CPURaceCounter(ref cpuTrack1, CPU_BENCHMARK_ONE);
            cpu.CPURaceCounter(ref cpuTrack2, CPU_BENCHMARK_TWO);
            cpu.CPURaceCounter(ref cpuTrack3, CPU_BENCHMARK_THREE);
            cpu.CPURaceCounter(ref cpuTrack4, CPU_BENCHMARK_FOUR);
            cpu.CPURaceCounter(ref cpuTrack5, CPU_BENCHMARK_FIVE);
            cpu.StopCPURace();
        }

        private void racebtn_Click(object sender, EventArgs e)
        {

            if (tracker <= BENCHMARK_ONE)
            {
                playerTrack1.Visible = ClickHandler.CanLoad(ref tracker, BENCHMARK_ONE);
            }
            else if (tracker <= BENCHMARK_TWO)
            {
                playerTrack2.Visible = ClickHandler.CanLoad(ref tracker, BENCHMARK_TWO);
            }
            else if (tracker <= BENCHMARK_THREE)
            {
                playerTrack3.Visible = ClickHandler.CanLoad(ref tracker, BENCHMARK_THREE);
            }
            else if(tracker <= BENCHMARK_FOUR)
            {
                playerTrack4.Visible = ClickHandler.CanLoad(ref tracker, BENCHMARK_FOUR);
            }
            else if(tracker <= BENCHMARK_FIVE)
            {
                playerTrack5.Visible = ClickHandler.CanLoad(ref tracker, BENCHMARK_FIVE);
            }

        }

        //precondition: takes a counter, a benchmark, whether it was clicked, and a textbox
        //postcondition: whenever the counter hits the benchmark, set the textbox to visible
        private void player_Race(ref int tempTracker, int benchmark, TextBox playertrack)
        {


            tempTracker = tempTracker + 1;

            if (tracker >= benchmark)
            {
                playertrack.Visible = true;
            }
        }


    }
}
