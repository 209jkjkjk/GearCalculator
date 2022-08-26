using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections;
using System.IO;

namespace GearCalculator
{
    public partial class Main : Form
    {
        #region 内部类定义
        // 运行时缓存类
        private class ConfigData
        {
            public string ConfigName { get; set; }
            public List<int> FlywheelData { get; set; }
            public List<int> CranksetData { get; set; }
        }
        // 运算缓存类
        private class CalcuationTemp
        {
            public ConfigData configData;
            public int flywheelNum;
            public int cranksetNum;
            public double gearRatio;

            public CalcuationTemp(ConfigData cd, int fnum, int cnum)
            {
                configData = cd;
                flywheelNum = fnum;
                cranksetNum = cnum;
                gearRatio = ((double)configData.CranksetData[cnum]) / configData.FlywheelData[fnum];
            }
        }
        #endregion

        private ConfigData configData;
        private IEnumerable<CalcuationTemp> displayTemp;
        public Main()
        {
            InitializeComponent();
            configData = new ConfigData();
        }



        #region 数据的双向绑定 
        private void UpdateDatatoTextBox()
        {
            FlyweelhDataTB.Clear();
            CranksetDataTB.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < configData.FlywheelData.Count(); ++i)
            {
                sb.Append(configData.FlywheelData[i] + "\r\n");
            }
            FlyweelhDataTB.Text = sb.ToString();
            sb.Clear();
            for (int i = 0; i < configData.CranksetData.Count(); ++i)
            {
                sb.Append(configData.CranksetData[i] + "\r\n");
            }
            CranksetDataTB.Text = sb.ToString();
        }
        // TextBox数据清洁
        private List<int> ValidateText(TextBox tb)
        {
            List<int> newData = new List<int>();
            if (tb.Text == "") return null;
            var ss = tb.Text.Split('\n');
            var sb = new StringBuilder();
            foreach (string s in ss)
            {
                try
                {
                    if (s.Trim() == "") continue;
                    newData.Add(int.Parse(s));
                }
                catch (Exception e)
                {
                    STDout.Text += e.Message;
                }
            }
            /*
             * 收集完成后重新排序，纠正用户错误
             * （当然也可能有魔幻现实发生，比如飞轮齿数变化确实不是不单调的，理论上可实现,
             * 但是这在本程序里并未考虑到，深感抱歉）
             */
            newData.Sort();
            foreach (int i in newData)
            {
                sb.Append(i + "\r\n");
            }
            tb.Text = sb.ToString();
            return newData;
        }
        private void UpdateFlywheelDatatoConfigData()
        {

            var newData = ValidateText(FlyweelhDataTB);
            if (newData == null) return;
            configData.FlywheelData = newData;
        }
        private void UpdateCranksetDatatoConfigData()
        {
            var newData = ValidateText(CranksetDataTB);
            if (newData == null) return;
            configData.CranksetData = newData;
        }
        #endregion


        #region 数据更新，失去焦点处理 
        private void FlyweelhDataTB_Leave(object sender, EventArgs e)
        {
            UpdateFlywheelDatatoConfigData();
        }
        private void CranksetDataTB_Leave(object sender, EventArgs e)
        {
            UpdateCranksetDatatoConfigData();
        }
        private void LowCadenceTB_Leave(object sender, EventArgs e)
        {
            TempProcessAndDisplay();
        }
        private void HighCadenceTB_Leave(object sender, EventArgs e)
        {
            TempProcessAndDisplay();
        }
        private void XCrossChainBanTB_Leave(object sender, EventArgs e)
        {
            TempProcessAndDisplay();
        }
        private void WheelPerimeterTB_Leave(object sender, EventArgs e)
        {
            TempProcessAndDisplay();
        }
        private void ReverseDisplayBT_Click(object sender, EventArgs e)
        {
            if (displayTemp == null) return;
            displayTemp = displayTemp.Reverse();
            TempProcessAndDisplay();
        }
        #endregion
        #region 数据输入，回车键处理 
        private void WheelPerimeterTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReverseDisplayBT.Focus();
            }
        }
        private void XCrossChainBanTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OrderCalculateBT.Focus();
            }
        }
        private void LowCadenceTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HighCadenceTB.Focus();
            }
        }
        private void HighCadenceTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WheelPerimeterTB.Focus();
            }
        }
        #endregion


        #region 配置文件的导入导出
        private void LoadGearConfig(String filename)
        {
            using (System.IO.StreamReader file = System.IO.File.OpenText(filename))
            {
                configData = JsonConvert.DeserializeObject<ConfigData>(file.ReadToEnd());
                configData.FlywheelData.Sort();
                configData.CranksetData.Sort();
                UpdateDatatoTextBox();
                this.Text += " - " + configData.ConfigName;
            }
        }
        private void ConfigImportMB_Click(object sender, EventArgs e)
        {
            if (ConfigOpenFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadGearConfig(ConfigOpenFD.FileName);
                    MessageLabel.Text = "";
                } catch (Exception)
                {
                    MessageLabel.Text = "读取失败";
                }
            }
        }
        private void ConfigExportMB_Click(object sender, EventArgs e)
        {
            if (configData == null) return;
            if (ConfigSaveFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = JsonConvert.SerializeObject(configData);
                    using (StreamWriter sw = new StreamWriter(ConfigSaveFD.FileName)) {
                        sw.Write(jsonString);
                    }
                }
                catch (Exception)
                {
                    MessageLabel.Text = "保存失败";
                }
            }
        }
        #endregion


        #region 业务操作
        // 通用处理计算结果并输出
        private void TempProcessAndDisplay()
        {
            if (displayTemp == null) return;
            ResultTB.Clear();
            int num = 0;
            double layoutRatio = -1;
            // 齿比*速度因子=速度
            double lowSpeedFactor = int.Parse(LowCadenceTB.Text) * int.Parse(WheelPerimeterTB.Text) * 60.0 / 1000000;
            double highSpeedFactor = int.Parse(HighCadenceTB.Text) * int.Parse(WheelPerimeterTB.Text) * 60.0 / 1000000;
            double meanSpeedFactor = (lowSpeedFactor + highSpeedFactor) / 2;

            // 表格输出
            ResultTB.Text += "序号\t齿比\t组合\t速度区间(km\\h)\r\n";
            foreach (var temp in displayTemp)
            {
                if (temp.gearRatio != layoutRatio) ++num;
                var speed = int.Parse(LowCadenceTB.Text) * temp.gearRatio * int.Parse(WheelPerimeterTB.Text) * 60 / 1000000;
                ResultTB.Text += $"{num}.\t{temp.gearRatio:f2}\t" +
                    $"{temp.cranksetNum+1}盘{temp.flywheelNum+1}飞\t" +
                    $"{lowSpeedFactor * temp.gearRatio:f2} - {highSpeedFactor * temp.gearRatio:f2}\r\n";
                layoutRatio = temp.gearRatio;
            }

            // 平均间隙
            ResultTB.Text += $"平均齿比差：{Math.Abs(displayTemp.First().gearRatio - displayTemp.Last().gearRatio) / displayTemp.Count():f2}\t\r\n平均速度差:{Math.Abs(meanSpeedFactor * displayTemp.First().gearRatio - meanSpeedFactor * displayTemp.Last().gearRatio) / displayTemp.Count():f2}";
            
        }
        // 通用预处理
        private void DefaultCalculate()
        {
            var temps = new List<CalcuationTemp>();
            // 交叉链禁用值
            int XCrossChainBanNum = int.Parse(XCrossChainBanTB.Text);
            // 防止飞轮数量 <= 交叉链禁用值
            if (XCrossChainBanNum >= configData.FlywheelData.Count())
            {
                XCrossChainBanNum = configData.FlywheelData.Count() - 1;
                XCrossChainBanTB.Text = XCrossChainBanNum.ToString();
            }
            int CranksetCount = configData.CranksetData.Count();

            // 处理单盘特殊情况
            if (CranksetCount == 1)
            {
                for (int flywheelNum = 0;flywheelNum < configData.FlywheelData.Count();++flywheelNum)
                {
                    temps.Add(new CalcuationTemp(configData, flywheelNum, 0));
                }
            } else
            {
                for (int cranksetNum = 0; cranksetNum < CranksetCount; ++cranksetNum)
                {
                    // 根据交叉链禁用数量*盘片序号/盘片总数，来求得实际交叉链禁用情况
                    for (int flywheelNum = 0 + (int)(XCrossChainBanNum * (1 - (float)cranksetNum / (CranksetCount - 1)));
                        flywheelNum < configData.FlywheelData.Count() - (XCrossChainBanNum * ((float)cranksetNum / (CranksetCount - 1)));
                        ++flywheelNum)
                    {
                        temps.Add(new CalcuationTemp(configData, flywheelNum, cranksetNum));
                    }
                }
            }
            displayTemp = from temp in temps orderby temp.gearRatio select temp;
        }

        // 顺序计算
        private void OrderCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 普通预处理后直接输出
                DefaultCalculate();
                TempProcessAndDisplay();
            } catch(Exception ee)
            {
                STDout.Text += ee.Message;
            }
        }
        // 单次向上换盘
        private void OneWayUpBT_Click(object sender, EventArgs e)
        {
            try
            {
                // 普通预处理后进行筛选
                DefaultCalculate();
                var temps = new List<CalcuationTemp>();
                CalcuationTemp layout = null;
                foreach (var temp in displayTemp)
                {
                    if (layout == null) layout = temp;
                    if (temp.cranksetNum >= layout.cranksetNum)
                    {
                        temps.Add(temp);
                        layout = temp;
                    }
                }
                displayTemp = from temp in temps select temp;
                TempProcessAndDisplay();
            }
            catch (Exception ee)
            {
                STDout.Text += ee.Message;
            }
        }
        // 单次向下换盘
        private void OneWayDownBT_Click(object sender, EventArgs e)
        {
            try
            {
                // 普通预处理后进行筛选
                DefaultCalculate();
                var temps = new List<CalcuationTemp>();
                CalcuationTemp layout = null;
                // 此处逆序一下
                foreach (var temp in displayTemp.Reverse())
                {
                    if (layout == null) layout = temp;
                    if (temp.cranksetNum <= layout.cranksetNum)
                    {
                        temps.Add(temp);
                        layout = temp;
                    }
                }
                displayTemp = from temp in temps select temp;
                TempProcessAndDisplay();
            }
            catch (Exception ee)
            {
                STDout.Text += ee.Message;
            }
        }
        // 帮助说明
        private void HelpBT_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }
        #endregion
    }
}
