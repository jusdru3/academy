namespace AcademyWinFOrms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.gpuLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.ramUsageLabel = new System.Windows.Forms.Label();
            this.availableDiskPlaceLabel = new System.Windows.Forms.Label();
            this.averageDiskQueueLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.cpuBox = new System.Windows.Forms.TextBox();
            this.ramBox = new System.Windows.Forms.TextBox();
            this.gpuBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.cpuUsageBox = new System.Windows.Forms.TextBox();
            this.ramUsageBox = new System.Windows.Forms.TextBox();
            this.availableDiskBox = new System.Windows.Forms.TextBox();
            this.averageQueueBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RamChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 42);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(29, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(12, 75);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(29, 13);
            this.cpuLabel.TabIndex = 2;
            this.cpuLabel.Text = "CPU";
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(12, 108);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(31, 13);
            this.ramLabel.TabIndex = 3;
            this.ramLabel.Text = "RAM";
            // 
            // gpuLabel
            // 
            this.gpuLabel.AutoSize = true;
            this.gpuLabel.Location = new System.Drawing.Point(12, 138);
            this.gpuLabel.Name = "gpuLabel";
            this.gpuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpuLabel.Size = new System.Drawing.Size(30, 13);
            this.gpuLabel.TabIndex = 4;
            this.gpuLabel.Text = "GPU";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 166);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(17, 13);
            this.ipLabel.TabIndex = 5;
            this.ipLabel.Text = "IP";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(12, 194);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(61, 13);
            this.cpuUsageLabel.TabIndex = 6;
            this.cpuUsageLabel.Text = "CPU usage";
            // 
            // ramUsageLabel
            // 
            this.ramUsageLabel.AutoSize = true;
            this.ramUsageLabel.Location = new System.Drawing.Point(12, 222);
            this.ramUsageLabel.Name = "ramUsageLabel";
            this.ramUsageLabel.Size = new System.Drawing.Size(63, 13);
            this.ramUsageLabel.TabIndex = 7;
            this.ramUsageLabel.Text = "RAM usage";
            // 
            // availableDiskPlaceLabel
            // 
            this.availableDiskPlaceLabel.AutoSize = true;
            this.availableDiskPlaceLabel.Location = new System.Drawing.Point(12, 250);
            this.availableDiskPlaceLabel.Name = "availableDiskPlaceLabel";
            this.availableDiskPlaceLabel.Size = new System.Drawing.Size(104, 13);
            this.availableDiskPlaceLabel.TabIndex = 8;
            this.availableDiskPlaceLabel.Text = "Available disk space";
            // 
            // averageDiskQueueLabel
            // 
            this.averageDiskQueueLabel.AutoSize = true;
            this.averageDiskQueueLabel.Location = new System.Drawing.Point(12, 281);
            this.averageDiskQueueLabel.Name = "averageDiskQueueLabel";
            this.averageDiskQueueLabel.Size = new System.Drawing.Size(105, 13);
            this.averageDiskQueueLabel.TabIndex = 9;
            this.averageDiskQueueLabel.Text = "Average disk queue ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(147, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(234, 20);
            this.nameBox.TabIndex = 10;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(147, 42);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(234, 20);
            this.userBox.TabIndex = 11;
            // 
            // cpuBox
            // 
            this.cpuBox.Location = new System.Drawing.Point(147, 75);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(234, 20);
            this.cpuBox.TabIndex = 12;
            // 
            // ramBox
            // 
            this.ramBox.Location = new System.Drawing.Point(147, 108);
            this.ramBox.Name = "ramBox";
            this.ramBox.Size = new System.Drawing.Size(234, 20);
            this.ramBox.TabIndex = 13;
            // 
            // gpuBox
            // 
            this.gpuBox.Location = new System.Drawing.Point(147, 138);
            this.gpuBox.Name = "gpuBox";
            this.gpuBox.Size = new System.Drawing.Size(234, 20);
            this.gpuBox.TabIndex = 14;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(147, 166);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(234, 20);
            this.ipBox.TabIndex = 15;
            // 
            // cpuUsageBox
            // 
            this.cpuUsageBox.Location = new System.Drawing.Point(147, 194);
            this.cpuUsageBox.Name = "cpuUsageBox";
            this.cpuUsageBox.Size = new System.Drawing.Size(234, 20);
            this.cpuUsageBox.TabIndex = 16;
            // 
            // ramUsageBox
            // 
            this.ramUsageBox.Location = new System.Drawing.Point(147, 222);
            this.ramUsageBox.Name = "ramUsageBox";
            this.ramUsageBox.Size = new System.Drawing.Size(234, 20);
            this.ramUsageBox.TabIndex = 17;
            // 
            // availableDiskBox
            // 
            this.availableDiskBox.Location = new System.Drawing.Point(147, 250);
            this.availableDiskBox.Name = "availableDiskBox";
            this.availableDiskBox.Size = new System.Drawing.Size(234, 20);
            this.availableDiskBox.TabIndex = 18;
            // 
            // averageQueueBox
            // 
            this.averageQueueBox.Location = new System.Drawing.Point(147, 281);
            this.averageQueueBox.Name = "averageQueueBox";
            this.averageQueueBox.Size = new System.Drawing.Size(234, 20);
            this.averageQueueBox.TabIndex = 19;
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showButton.Location = new System.Drawing.Point(15, 319);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 20;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // cpuChart
            // 
            chartArea5.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.cpuChart.Legends.Add(legend5);
            this.cpuChart.Location = new System.Drawing.Point(489, 9);
            this.cpuChart.Name = "cpuChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.cpuChart.Series.Add(series5);
            this.cpuChart.Size = new System.Drawing.Size(978, 333);
            this.cpuChart.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RamChart
            // 
            chartArea6.Name = "ChartArea1";
            this.RamChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.RamChart.Legends.Add(legend6);
            this.RamChart.Location = new System.Drawing.Point(489, 367);
            this.RamChart.Name = "RamChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.RamChart.Series.Add(series6);
            this.RamChart.Size = new System.Drawing.Size(978, 328);
            this.RamChart.TabIndex = 22;
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(489, 713);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(978, 328);
            this.chart1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 1053);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.RamChart);
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.averageQueueBox);
            this.Controls.Add(this.availableDiskBox);
            this.Controls.Add(this.ramUsageBox);
            this.Controls.Add(this.cpuUsageBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.gpuBox);
            this.Controls.Add(this.ramBox);
            this.Controls.Add(this.cpuBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.averageDiskQueueLabel);
            this.Controls.Add(this.availableDiskPlaceLabel);
            this.Controls.Add(this.ramUsageLabel);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.gpuLabel);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label gpuLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Label ramUsageLabel;
        private System.Windows.Forms.Label availableDiskPlaceLabel;
        private System.Windows.Forms.Label averageDiskQueueLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox cpuBox;
        private System.Windows.Forms.TextBox ramBox;
        private System.Windows.Forms.TextBox gpuBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox cpuUsageBox;
        private System.Windows.Forms.TextBox ramUsageBox;
        private System.Windows.Forms.TextBox availableDiskBox;
        private System.Windows.Forms.TextBox averageQueueBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart RamChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

