using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataLayer;

namespace AcademyWinFOrms
{
    public partial class Form1 : Form
    {
        private FullDataManager fullDataManager;
        public Form1()
        {
            InitializeComponent();
            fullDataManager = new FullDataManager();
            cpuChart.Series.Clear();
            cpuChart.Series.Add("cpu usage");
            cpuChart.Series[0].XValueType = ChartValueType.DateTime;
            cpuChart.ChartAreas[0].AxisX.LabelStyle.Format = "hh-mm-ss";
            RamChart.Series.Clear();
            RamChart.Series.Add("ram usage");
            RamChart.Series[0].XValueType = ChartValueType.DateTime;
            RamChart.ChartAreas[0].AxisX.LabelStyle.Format = "hh-mm-ss";
            
        }



        private void showButton_Click(object sender, EventArgs e)
        {
            var computerSummary = fullDataManager.GetComputerSummary();
            cpuBox.Text = computerSummary.Cpu;
            cpuUsageBox.Text = computerSummary.CpuUsage.ToString();
            gpuBox.Text = computerSummary.VideoCard;
            ramBox.Text = computerSummary.Ram.ToString();
            ramUsageBox.Text = computerSummary.RamUsage.ToString();
            nameBox.Text = computerSummary.Name;
            userBox.Text = computerSummary.User;
            ipBox.Text = computerSummary.Ip.ToString();
            averageQueueBox.Text = computerSummary.AverageDiskQueueLength.ToString();
            availableDiskBox.Text = computerSummary.AvailableDiskSpaceGb.ToString();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var computerSummary = fullDataManager.GetComputerSummary();
            
            cpuChart.Series.FindByName("cpu usage").Points.AddXY(DateTime.Now,computerSummary.CpuUsage);
            RamChart.Series.FindByName("ram usage").Points.AddXY(DateTime.Now, computerSummary.RamUsage);

        }
    }
}
