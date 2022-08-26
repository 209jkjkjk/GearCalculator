
namespace GearCalculator
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FlyweelhDataTB = new System.Windows.Forms.TextBox();
            this.DefaultImportMB = new System.Windows.Forms.MenuStrip();
            this.ConfigImportMB = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigExportMB = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigOpenFD = new System.Windows.Forms.OpenFileDialog();
            this.FlywheelLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.STDout = new System.Windows.Forms.TextBox();
            this.CranksetDataTB = new System.Windows.Forms.TextBox();
            this.牙盘数据 = new System.Windows.Forms.Label();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.OneChangeDownBT = new System.Windows.Forms.Button();
            this.OneWayUpBT = new System.Windows.Forms.Button();
            this.OrderCalculateBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.LowCadenceTB = new System.Windows.Forms.TextBox();
            this.WheelPerimeterTB = new System.Windows.Forms.TextBox();
            this.踏频 = new System.Windows.Forms.Label();
            this.WheelPerimeter = new System.Windows.Forms.Label();
            this.LowCadence = new System.Windows.Forms.Label();
            this.XCrossChainBanNum = new System.Windows.Forms.Label();
            this.XCrossChainBanTB = new System.Windows.Forms.TextBox();
            this.ConfigSaveFD = new System.Windows.Forms.SaveFileDialog();
            this.ReverseDisplayBT = new System.Windows.Forms.Button();
            this.HaiCadence = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HighCadenceTB = new System.Windows.Forms.TextBox();
            this.HelpBT = new System.Windows.Forms.Button();
            this.DefaultImportMB.SuspendLayout();
            this.ToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlyweelhDataTB
            // 
            this.FlyweelhDataTB.Location = new System.Drawing.Point(43, 89);
            this.FlyweelhDataTB.Multiline = true;
            this.FlyweelhDataTB.Name = "FlyweelhDataTB";
            this.FlyweelhDataTB.Size = new System.Drawing.Size(65, 188);
            this.FlyweelhDataTB.TabIndex = 0;
            this.FlyweelhDataTB.Leave += new System.EventHandler(this.FlyweelhDataTB_Leave);
            // 
            // DefaultImportMB
            // 
            this.DefaultImportMB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigImportMB,
            this.ConfigExportMB});
            this.DefaultImportMB.Location = new System.Drawing.Point(0, 0);
            this.DefaultImportMB.Name = "DefaultImportMB";
            this.DefaultImportMB.Size = new System.Drawing.Size(800, 25);
            this.DefaultImportMB.TabIndex = 1;
            this.DefaultImportMB.Text = "menuStrip1";
            // 
            // ConfigImportMB
            // 
            this.ConfigImportMB.Name = "ConfigImportMB";
            this.ConfigImportMB.Size = new System.Drawing.Size(68, 21);
            this.ConfigImportMB.Text = "导入配置";
            this.ConfigImportMB.Click += new System.EventHandler(this.ConfigImportMB_Click);
            // 
            // ConfigExportMB
            // 
            this.ConfigExportMB.Name = "ConfigExportMB";
            this.ConfigExportMB.Size = new System.Drawing.Size(68, 21);
            this.ConfigExportMB.Text = "导出配置";
            this.ConfigExportMB.Click += new System.EventHandler(this.ConfigExportMB_Click);
            // 
            // ConfigOpenFD
            // 
            this.ConfigOpenFD.FileName = "openFileDialog1";
            // 
            // FlywheelLabel
            // 
            this.FlywheelLabel.AutoSize = true;
            this.FlywheelLabel.Location = new System.Drawing.Point(41, 60);
            this.FlywheelLabel.Name = "FlywheelLabel";
            this.FlywheelLabel.Size = new System.Drawing.Size(53, 12);
            this.FlywheelLabel.TabIndex = 2;
            this.FlywheelLabel.Text = "飞轮齿数";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessageLabel.Location = new System.Drawing.Point(312, 412);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 27);
            this.MessageLabel.TabIndex = 3;
            // 
            // STDout
            // 
            this.STDout.Location = new System.Drawing.Point(688, 38);
            this.STDout.Multiline = true;
            this.STDout.Name = "STDout";
            this.STDout.Size = new System.Drawing.Size(100, 239);
            this.STDout.TabIndex = 4;
            // 
            // CranksetDataTB
            // 
            this.CranksetDataTB.Location = new System.Drawing.Point(133, 89);
            this.CranksetDataTB.Multiline = true;
            this.CranksetDataTB.Name = "CranksetDataTB";
            this.CranksetDataTB.Size = new System.Drawing.Size(65, 188);
            this.CranksetDataTB.TabIndex = 5;
            this.CranksetDataTB.Leave += new System.EventHandler(this.CranksetDataTB_Leave);
            // 
            // 牙盘数据
            // 
            this.牙盘数据.AutoSize = true;
            this.牙盘数据.Location = new System.Drawing.Point(131, 60);
            this.牙盘数据.Name = "牙盘数据";
            this.牙盘数据.Size = new System.Drawing.Size(53, 12);
            this.牙盘数据.TabIndex = 6;
            this.牙盘数据.Text = "牙盘齿数";
            // 
            // ToolBox
            // 
            this.ToolBox.Controls.Add(this.HelpBT);
            this.ToolBox.Controls.Add(this.OneChangeDownBT);
            this.ToolBox.Controls.Add(this.OneWayUpBT);
            this.ToolBox.Controls.Add(this.OrderCalculateBT);
            this.ToolBox.Location = new System.Drawing.Point(12, 298);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(200, 100);
            this.ToolBox.TabIndex = 7;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "工具箱";
            // 
            // OneChangeDownBT
            // 
            this.OneChangeDownBT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OneChangeDownBT.Location = new System.Drawing.Point(105, 64);
            this.OneChangeDownBT.Name = "OneChangeDownBT";
            this.OneChangeDownBT.Size = new System.Drawing.Size(89, 30);
            this.OneChangeDownBT.TabIndex = 2;
            this.OneChangeDownBT.Text = "单向换盘↓";
            this.OneChangeDownBT.UseVisualStyleBackColor = true;
            this.OneChangeDownBT.Click += new System.EventHandler(this.OneWayDownBT_Click);
            // 
            // OneWayUpBT
            // 
            this.OneWayUpBT.Location = new System.Drawing.Point(105, 20);
            this.OneWayUpBT.Name = "OneWayUpBT";
            this.OneWayUpBT.Size = new System.Drawing.Size(89, 30);
            this.OneWayUpBT.TabIndex = 1;
            this.OneWayUpBT.Text = "单向换盘↑";
            this.OneWayUpBT.UseVisualStyleBackColor = true;
            this.OneWayUpBT.Click += new System.EventHandler(this.OneWayUpBT_Click);
            // 
            // OrderCalculateBT
            // 
            this.OrderCalculateBT.Location = new System.Drawing.Point(7, 20);
            this.OrderCalculateBT.Name = "OrderCalculateBT";
            this.OrderCalculateBT.Size = new System.Drawing.Size(89, 30);
            this.OrderCalculateBT.TabIndex = 0;
            this.OrderCalculateBT.Text = "顺序计算";
            this.OrderCalculateBT.UseVisualStyleBackColor = true;
            this.OrderCalculateBT.Click += new System.EventHandler(this.OrderCalculate_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(220, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 423);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(242, 44);
            this.ResultTB.Multiline = true;
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(250, 376);
            this.ResultTB.TabIndex = 9;
            // 
            // LowCadenceTB
            // 
            this.LowCadenceTB.Location = new System.Drawing.Point(582, 44);
            this.LowCadenceTB.Name = "LowCadenceTB";
            this.LowCadenceTB.Size = new System.Drawing.Size(100, 21);
            this.LowCadenceTB.TabIndex = 11;
            this.LowCadenceTB.Text = "85";
            this.LowCadenceTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LowCadenceTB_KeyUp);
            this.LowCadenceTB.Leave += new System.EventHandler(this.LowCadenceTB_Leave);
            // 
            // WheelPerimeterTB
            // 
            this.WheelPerimeterTB.Location = new System.Drawing.Point(582, 98);
            this.WheelPerimeterTB.Name = "WheelPerimeterTB";
            this.WheelPerimeterTB.Size = new System.Drawing.Size(100, 21);
            this.WheelPerimeterTB.TabIndex = 12;
            this.WheelPerimeterTB.Text = "2103";
            this.WheelPerimeterTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WheelPerimeterTB_KeyUp);
            this.WheelPerimeterTB.Leave += new System.EventHandler(this.WheelPerimeterTB_Leave);
            // 
            // 踏频
            // 
            this.踏频.AutoSize = true;
            this.踏频.Location = new System.Drawing.Point(504, 47);
            this.踏频.Name = "踏频";
            this.踏频.Size = new System.Drawing.Size(59, 12);
            this.踏频.TabIndex = 13;
            this.踏频.Text = "踏频(rpm)";
            // 
            // WheelPerimeter
            // 
            this.WheelPerimeter.AutoSize = true;
            this.WheelPerimeter.Location = new System.Drawing.Point(498, 101);
            this.WheelPerimeter.Name = "WheelPerimeter";
            this.WheelPerimeter.Size = new System.Drawing.Size(65, 12);
            this.WheelPerimeter.TabIndex = 14;
            this.WheelPerimeter.Text = "轮周长(mm)";
            // 
            // LowCadence
            // 
            this.LowCadence.AutoSize = true;
            this.LowCadence.Location = new System.Drawing.Point(498, 47);
            this.LowCadence.Name = "LowCadence";
            this.LowCadence.Size = new System.Drawing.Size(83, 12);
            this.LowCadence.TabIndex = 13;
            this.LowCadence.Text = "最低踏频(rpm)";
            // 
            // XCrossChainBanNum
            // 
            this.XCrossChainBanNum.AutoSize = true;
            this.XCrossChainBanNum.Location = new System.Drawing.Point(12, 423);
            this.XCrossChainBanNum.Name = "XCrossChainBanNum";
            this.XCrossChainBanNum.Size = new System.Drawing.Size(77, 12);
            this.XCrossChainBanNum.TabIndex = 15;
            this.XCrossChainBanNum.Text = "交叉链禁用数";
            // 
            // XCrossChainBanTB
            // 
            this.XCrossChainBanTB.Location = new System.Drawing.Point(95, 422);
            this.XCrossChainBanTB.Name = "XCrossChainBanTB";
            this.XCrossChainBanTB.Size = new System.Drawing.Size(37, 21);
            this.XCrossChainBanTB.TabIndex = 10;
            this.XCrossChainBanTB.Text = "2";
            this.XCrossChainBanTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.XCrossChainBanTB_KeyUp);
            this.XCrossChainBanTB.Leave += new System.EventHandler(this.XCrossChainBanTB_Leave);
            // 
            // ReverseDisplayBT
            // 
            this.ReverseDisplayBT.Location = new System.Drawing.Point(242, 426);
            this.ReverseDisplayBT.Name = "ReverseDisplayBT";
            this.ReverseDisplayBT.Size = new System.Drawing.Size(75, 23);
            this.ReverseDisplayBT.TabIndex = 16;
            this.ReverseDisplayBT.Text = "倒序";
            this.ReverseDisplayBT.UseVisualStyleBackColor = true;
            this.ReverseDisplayBT.Click += new System.EventHandler(this.ReverseDisplayBT_Click);
            // 
            // HaiCadence
            // 
            this.HaiCadence.AutoSize = true;
            this.HaiCadence.Location = new System.Drawing.Point(498, 74);
            this.HaiCadence.Name = "HaiCadence";
            this.HaiCadence.Size = new System.Drawing.Size(83, 12);
            this.HaiCadence.TabIndex = 19;
            this.HaiCadence.Text = "最高踏频(rpm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "踏频(rpm)";
            // 
            // HighCadenceTB
            // 
            this.HighCadenceTB.Location = new System.Drawing.Point(582, 71);
            this.HighCadenceTB.Name = "HighCadenceTB";
            this.HighCadenceTB.Size = new System.Drawing.Size(100, 21);
            this.HighCadenceTB.TabIndex = 17;
            this.HighCadenceTB.Text = "100";
            this.HighCadenceTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HighCadenceTB_KeyUp);
            this.HighCadenceTB.Leave += new System.EventHandler(this.HighCadenceTB_Leave);
            // 
            // HelpBT
            // 
            this.HelpBT.Location = new System.Drawing.Point(7, 64);
            this.HelpBT.Name = "HelpBT";
            this.HelpBT.Size = new System.Drawing.Size(89, 30);
            this.HelpBT.TabIndex = 3;
            this.HelpBT.Text = "帮助说明";
            this.HelpBT.UseVisualStyleBackColor = true;
            this.HelpBT.Click += new System.EventHandler(this.HelpBT_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HaiCadence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HighCadenceTB);
            this.Controls.Add(this.ReverseDisplayBT);
            this.Controls.Add(this.XCrossChainBanNum);
            this.Controls.Add(this.WheelPerimeter);
            this.Controls.Add(this.LowCadence);
            this.Controls.Add(this.踏频);
            this.Controls.Add(this.WheelPerimeterTB);
            this.Controls.Add(this.LowCadenceTB);
            this.Controls.Add(this.XCrossChainBanTB);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolBox);
            this.Controls.Add(this.牙盘数据);
            this.Controls.Add(this.CranksetDataTB);
            this.Controls.Add(this.STDout);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.FlywheelLabel);
            this.Controls.Add(this.FlyweelhDataTB);
            this.Controls.Add(this.DefaultImportMB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.DefaultImportMB;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "齿比计算器";
            this.DefaultImportMB.ResumeLayout(false);
            this.DefaultImportMB.PerformLayout();
            this.ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FlyweelhDataTB;
        private System.Windows.Forms.MenuStrip DefaultImportMB;
        private System.Windows.Forms.ToolStripMenuItem ConfigImportMB;
        private System.Windows.Forms.OpenFileDialog ConfigOpenFD;
        private System.Windows.Forms.Label FlywheelLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox STDout;
        private System.Windows.Forms.TextBox CranksetDataTB;
        private System.Windows.Forms.Label 牙盘数据;
        private System.Windows.Forms.GroupBox ToolBox;
        private System.Windows.Forms.Button OrderCalculateBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.TextBox LowCadenceTB;
        private System.Windows.Forms.TextBox WheelPerimeterTB;
        private System.Windows.Forms.Label 踏频;
        private System.Windows.Forms.Label WheelPerimeter;
        private System.Windows.Forms.Label LowCadence;
        private System.Windows.Forms.Label XCrossChainBanNum;
        private System.Windows.Forms.TextBox XCrossChainBanTB;
        private System.Windows.Forms.ToolStripMenuItem ConfigExportMB;
        private System.Windows.Forms.SaveFileDialog ConfigSaveFD;
        private System.Windows.Forms.Button OneWayUpBT;
        private System.Windows.Forms.Button OneChangeDownBT;
        private System.Windows.Forms.Button ReverseDisplayBT;
        private System.Windows.Forms.Label HaiCadence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HighCadenceTB;
        private System.Windows.Forms.Button HelpBT;
    }
}

