using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stat_3
{
   

    public partial class Form1 : Form
    {
        public string OriginalData;
        public string name;
        double[] SumDat;
        char[] CharDat;
        bool Three;
         bool Four;
        bool Five;
         bool Ten;
       

        public Form1()
        {
            InitializeComponent();
        }

        Disp Dispersion;
       
        private void DatOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "ImageFilter(*.TXT) | *.TXT";

            if (Open.ShowDialog() == DialogResult.OK)
            {
                name = Open.FileName;
               tbData.Text = File.ReadAllText(name);
                CharDat = OriginalData.ToCharArray();
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if(rbThree.Checked) {
                Three = true;
            }
            if(rbFour.Checked) {
                Four = true;
            }
            if(rbFive.Checked) {
                Five = true;
            }
            if(rbTen.Checked) {
                Ten = true;
            }

   
            string[] Display = new string[8];

            
            Dispersion = new Disp(tbData.Text,
            rbThree.Checked, 
            rbFour.Checked,
            rbFive.Checked,
            rbTen.Checked);
            

            /*
            Display[0] = "Количество величин: {0} /n", Dispersion.Number();
            Display[1] = "Среднее значение: {0} /n", Dispersion.AverageValue();
            Display[2] = "Стандартное отклонение(СКО): {0} /n", Dispersion.StandardDeviation();
            Display[3] = "Среднее значение с учетом промахов: {0} /n", Dispersion.AverageValueWPenalties();
            Display[4] = "СКО с учетом промахов: {0} /n", Dispersion.StandardDeviationWPenalties();
            Display[5] = "Среднеквадратичное СКО: {0} /n", Dispersion.StandardDeviationMean();
            Display[6] = "Случайная погрешность: {0} /n", Dispersion.RandomError();
            Display[7] = "Суммарная погрешность: {0} /n", Dispersion.SumError();

            for(int i = 0; i < Display.Length; i++) {

                tbResult.Text = Display[i];
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> Data = new List<int>();
            
            double Average = Dispersion.AverageValue();
            double EdgeDeviation = Dispersion.StandardDeviation();
            double V = Dispersion.VPN(Three, Four, Five, Ten);
        
           
            for (int i = 0; i < CharDat.Length; i++)
            {
                Data.Add((int)CharDat[i]);
                chartDisp.Series[0].Points.AddXY(Data[i], Math.Abs((double)Data[i] - Average));
                chartDisp.Series[1].Points.AddXY(Data[i], V*EdgeDeviation);
               
            }
            chartDisp.ChartAreas[0].AxisX.ScaleView.Zoom(0, Data.Count);
            chartDisp.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartDisp.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartDisp.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartDisp.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chartDisp.ChartAreas[0].AxisY.ScaleView.Zoom(0, Dispersion.MaximY());
            chartDisp.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartDisp.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartDisp.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartDisp.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

         
        }
    }
}
