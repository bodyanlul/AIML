using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AIML1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            A.Rows.Add();
            A.Rows.Add();

            chart1.Series["Series1"].LegendText = "A";
            chart1.Series.Add("B");
            chart1.Series.Add("C");

            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["B"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["C"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            A.Rows[0].Cells["index"].Value = 0;
            A.Rows[0].Cells["lower"].Value = 1;
            A.Rows[0].Cells["upper"].Value = 9;
            
            A.Rows[1].Cells["index"].Value = 0.5;
            A.Rows[1].Cells["lower"].Value = 2;
            A.Rows[1].Cells["upper"].Value = 8;

            A.Rows[2].Cells["index"].Value = 1;
            A.Rows[2].Cells["lower"].Value = 3;
            A.Rows[2].Cells["upper"].Value = 4;

            B.Rows.Add();
            B.Rows.Add();
            B.Rows.Add();

            B.Rows[0].Cells["indexB"].Value = 0;
            B.Rows[0].Cells["lowerB"].Value = 1;
            B.Rows[0].Cells["upperB"].Value = 9;

            B.Rows[1].Cells["indexB"].Value = 0.5;
            B.Rows[1].Cells["lowerB"].Value = 3;
            B.Rows[1].Cells["upperB"].Value = 6;

            B.Rows[2].Cells["indexB"].Value = 1;
            B.Rows[2].Cells["lowerB"].Value = 4;
            B.Rows[2].Cells["upperB"].Value = 5;

            B.Rows[3].Cells["indexB"].Value = 0.2;
            B.Rows[3].Cells["lowerB"].Value = 2;
            B.Rows[3].Cells["upperB"].Value = 7;

            C.Rows.Add();
            C.Rows.Add();
            C.Rows.Add();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            C.Rows[0].Cells["indexC"].Value = B.Rows[0].Cells["indexB"].Value;
            C.Rows[0].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[0].Cells["lower"].Value) + Convert.ToDouble(B.Rows[0].Cells["lowerB"].Value);
            C.Rows[0].Cells["upperC"].Value = Convert.ToDouble(A.Rows[0].Cells["upper"].Value) + Convert.ToDouble(B.Rows[0].Cells["upperB"].Value);

            C.Rows[1].Cells["indexC"].Value = B.Rows[1].Cells["indexB"].Value;
            C.Rows[1].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[1].Cells["lower"].Value) + Convert.ToDouble(B.Rows[1].Cells["lowerB"].Value);
            C.Rows[1].Cells["upperC"].Value = Convert.ToDouble(A.Rows[1].Cells["upper"].Value) + Convert.ToDouble(B.Rows[1].Cells["upperB"].Value);

            C.Rows[2].Cells["indexC"].Value = B.Rows[2].Cells["indexB"].Value;
            C.Rows[2].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[2].Cells["lower"].Value) + Convert.ToDouble(B.Rows[2].Cells["lowerB"].Value);
            C.Rows[2].Cells["upperC"].Value = Convert.ToDouble(A.Rows[2].Cells["upper"].Value) + Convert.ToDouble(B.Rows[2].Cells["upperB"].Value);


           


            double missingLowerA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * (Convert.ToDouble(A.Rows[1].Cells["lower"].Value) - Convert.ToDouble(A.Rows[0].Cells["lower"].Value))/ (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["lower"].Value);
            double missingUpperA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * ((Convert.ToDouble(A.Rows[1].Cells["upper"].Value) - Convert.ToDouble(A.Rows[0].Cells["upper"].Value))) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["upper"].Value);
            
            
            C.Rows[3].Cells["indexC"].Value = B.Rows[3].Cells["indexB"].Value;
            C.Rows[3].Cells["lowerC"].Value = missingLowerA + Convert.ToDouble(B.Rows[3].Cells["lowerB"].Value);
            C.Rows[3].Cells["upperC"].Value = missingUpperA + Convert.ToDouble(B.Rows[3].Cells["upperB"].Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            C.Rows[0].Cells["indexC"].Value = B.Rows[0].Cells["indexB"].Value;
            C.Rows[0].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[0].Cells["lower"].Value) - Convert.ToDouble(B.Rows[0].Cells["upperB"].Value);
            C.Rows[0].Cells["upperC"].Value = Convert.ToDouble(A.Rows[0].Cells["upper"].Value) - Convert.ToDouble(B.Rows[0].Cells["lowerB"].Value);

            C.Rows[1].Cells["indexC"].Value = B.Rows[1].Cells["indexB"].Value;
            C.Rows[1].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[1].Cells["lower"].Value) - Convert.ToDouble(B.Rows[1].Cells["upperB"].Value);
            C.Rows[1].Cells["upperC"].Value = Convert.ToDouble(A.Rows[1].Cells["upper"].Value) - Convert.ToDouble(B.Rows[1].Cells["lowerB"].Value);

            C.Rows[2].Cells["indexC"].Value = B.Rows[2].Cells["indexB"].Value;
            C.Rows[2].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[2].Cells["lower"].Value) - Convert.ToDouble(B.Rows[2].Cells["upperB"].Value);
            C.Rows[2].Cells["upperC"].Value = Convert.ToDouble(A.Rows[2].Cells["upper"].Value) - Convert.ToDouble(B.Rows[2].Cells["lowerB"].Value);



            double missingLowerA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * (Convert.ToDouble(A.Rows[1].Cells["lower"].Value) - Convert.ToDouble(A.Rows[0].Cells["lower"].Value)) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["lower"].Value);
            double missingUpperA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * ((Convert.ToDouble(A.Rows[1].Cells["upper"].Value) - Convert.ToDouble(A.Rows[0].Cells["upper"].Value))) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["upper"].Value);


            C.Rows[3].Cells["indexC"].Value = B.Rows[3].Cells["indexB"].Value;
            C.Rows[3].Cells["lowerC"].Value = missingLowerA - Convert.ToDouble(B.Rows[3].Cells["upperB"].Value);
            C.Rows[3].Cells["upperC"].Value = missingUpperA - Convert.ToDouble(B.Rows[3].Cells["lowerB"].Value);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            C.Rows[0].Cells["indexC"].Value = B.Rows[0].Cells["indexB"].Value;
            C.Rows[0].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[0].Cells["lower"].Value) * Convert.ToDouble(B.Rows[0].Cells["lowerB"].Value);
            C.Rows[0].Cells["upperC"].Value = Convert.ToDouble(A.Rows[0].Cells["upper"].Value) * Convert.ToDouble(B.Rows[0].Cells["upperB"].Value);

            C.Rows[1].Cells["indexC"].Value = B.Rows[1].Cells["indexB"].Value;
            C.Rows[1].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[1].Cells["lower"].Value) * Convert.ToDouble(B.Rows[1].Cells["lowerB"].Value);
            C.Rows[1].Cells["upperC"].Value = Convert.ToDouble(A.Rows[1].Cells["upper"].Value) * Convert.ToDouble(B.Rows[1].Cells["upperB"].Value);

            C.Rows[2].Cells["indexC"].Value = B.Rows[2].Cells["indexB"].Value;
            C.Rows[2].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[2].Cells["lower"].Value) * Convert.ToDouble(B.Rows[2].Cells["lowerB"].Value);
            C.Rows[2].Cells["upperC"].Value = Convert.ToDouble(A.Rows[2].Cells["upper"].Value) * Convert.ToDouble(B.Rows[2].Cells["upperB"].Value);





            double missingLowerA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * (Convert.ToDouble(A.Rows[1].Cells["lower"].Value) - Convert.ToDouble(A.Rows[0].Cells["lower"].Value)) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["lower"].Value);
            double missingUpperA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * ((Convert.ToDouble(A.Rows[1].Cells["upper"].Value) - Convert.ToDouble(A.Rows[0].Cells["upper"].Value))) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["upper"].Value);


            C.Rows[3].Cells["indexC"].Value = B.Rows[3].Cells["indexB"].Value;
            C.Rows[3].Cells["lowerC"].Value = missingLowerA * Convert.ToDouble(B.Rows[3].Cells["lowerB"].Value);
            C.Rows[3].Cells["upperC"].Value = missingUpperA * Convert.ToDouble(B.Rows[3].Cells["upperB"].Value);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            C.Rows[0].Cells["indexC"].Value = B.Rows[0].Cells["indexB"].Value;
            C.Rows[0].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[0].Cells["lower"].Value) / Convert.ToDouble(B.Rows[0].Cells["upperB"].Value);
            C.Rows[0].Cells["upperC"].Value = Convert.ToDouble(A.Rows[0].Cells["upper"].Value) / Convert.ToDouble(B.Rows[0].Cells["lowerB"].Value);

            C.Rows[1].Cells["indexC"].Value = B.Rows[1].Cells["indexB"].Value;
            C.Rows[1].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[1].Cells["lower"].Value) / Convert.ToDouble(B.Rows[1].Cells["upperB"].Value);
            C.Rows[1].Cells["upperC"].Value = Convert.ToDouble(A.Rows[1].Cells["upper"].Value) / Convert.ToDouble(B.Rows[1].Cells["lowerB"].Value);

            C.Rows[2].Cells["indexC"].Value = B.Rows[2].Cells["indexB"].Value;
            C.Rows[2].Cells["lowerC"].Value = Convert.ToDouble(A.Rows[2].Cells["lower"].Value) / Convert.ToDouble(B.Rows[2].Cells["upperB"].Value);
            C.Rows[2].Cells["upperC"].Value = Convert.ToDouble(A.Rows[2].Cells["upper"].Value) / Convert.ToDouble(B.Rows[2].Cells["lowerB"].Value);



            double missingLowerA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * (Convert.ToDouble(A.Rows[1].Cells["lower"].Value) - Convert.ToDouble(A.Rows[0].Cells["lower"].Value)) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["lower"].Value);
            double missingUpperA = ((0.2 - Convert.ToDouble(A.Rows[0].Cells["index"].Value)) * ((Convert.ToDouble(A.Rows[1].Cells["upper"].Value) - Convert.ToDouble(A.Rows[0].Cells["upper"].Value))) / (Convert.ToDouble(A.Rows[1].Cells["index"].Value) - Convert.ToDouble(A.Rows[0].Cells["index"].Value))) + Convert.ToDouble(A.Rows[0].Cells["upper"].Value);


            C.Rows[3].Cells["indexC"].Value = B.Rows[3].Cells["indexB"].Value;
            C.Rows[3].Cells["lowerC"].Value = missingLowerA / Convert.ToDouble(B.Rows[3].Cells["upperB"].Value);
            C.Rows[3].Cells["upperC"].Value = missingUpperA / Convert.ToDouble(B.Rows[3].Cells["lowerB"].Value);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           double sumA = 0;
           for(int i = 0;i<3;i++)
           {
                sumA += Convert.ToDouble(A.Rows[i].Cells["lower"].Value) + Convert.ToDouble(A.Rows[i].Cells["upper"].Value);
           }

           double sumB = 0;
           for (int i = 0; i < 4; i++)
           {
               sumB += Convert.ToDouble(B.Rows[i].Cells["lowerB"].Value) + Convert.ToDouble(B.Rows[i].Cells["upperB"].Value);
           }
            sumA /= 3;
            sumB /= 4;
            if(sumA > sumB)
            {
                bigger.BackColor = Color.Green;
            }
            else
            {
                bigger.BackColor = Color.Red;
            }

            if (sumA >= sumB)
            {
                biggerorequals.BackColor = Color.Green;
            }
            else
            {
                biggerorequals.BackColor = Color.Red;
            }

            if (sumA < sumB)
            {
                less.BackColor = Color.Green;
            }
            else
            {
                less.BackColor = Color.Red;
            }

            if (sumA <= sumB)
            {
                lessorequals.BackColor = Color.Green;
            }
            else
            {
                lessorequals.BackColor = Color.Red;
            }

            if (sumA == sumB)
            {
                equals.BackColor = Color.Green;
            }
            else
            {
                equals.BackColor = Color.Red;
            }

            if (sumA != sumB)
            {
                notequals.BackColor = Color.Green;
            }
            else
            {
                notequals.BackColor = Color.Red;
            }
        }

        struct PointD
        {
            public double X;
            public double Y;
            public PointD(double _x,double _y)
            {
                X = _x;
                Y = _y;
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            List<PointD> list = new List<PointD>();

            for(int i = 0; i<A.RowCount;i++)
            {
                list.Add(new PointD(Convert.ToDouble(A.Rows[i].Cells["lower"].Value), Convert.ToDouble(A.Rows[i].Cells["index"].Value)));
            }

            for (int i = 0; i < A.RowCount; i++)
            {
                list.Add(new PointD(Convert.ToDouble(A.Rows[i].Cells["upper"].Value), Convert.ToDouble(A.Rows[i].Cells["index"].Value)));
            }

            var sorted = list.OrderBy(x => x.X).ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(sorted[i].X,sorted[i].Y);
            }
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            List<PointD> list = new List<PointD>();

            for (int i = 0; i < B.RowCount; i++)
            {
                list.Add(new PointD(Convert.ToDouble(B.Rows[i].Cells["lowerB"].Value), Convert.ToDouble(B.Rows[i].Cells["indexB"].Value)));
            }

            for (int i = 0; i < B.RowCount; i++)
            {
                list.Add(new PointD(Convert.ToDouble(B.Rows[i].Cells["upperB"].Value), Convert.ToDouble(B.Rows[i].Cells["indexB"].Value)));
            }

            var sorted = list.OrderBy(x => x.X).ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                chart1.Series["B"].Points.AddXY(sorted[i].X, sorted[i].Y);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            List<PointD> list = new List<PointD>();

            for (int i = 0; i < C.RowCount; i++)
            {
                list.Add(new PointD(Convert.ToDouble(C.Rows[i].Cells["lowerC"].Value), Convert.ToDouble(C.Rows[i].Cells["indexC"].Value)));
            }

            for (int i = 0; i < C.RowCount; i++)
            {
                list.Add(new PointD(Convert.ToDouble(C.Rows[i].Cells["upperC"].Value), Convert.ToDouble(C.Rows[i].Cells["indexC"].Value)));
            }

            var sorted = list.OrderBy(x => x.X).ToList();
            for (int i = 0; i < sorted.Count; i++)
            {
                chart1.Series["C"].Points.AddXY(sorted[i].X, sorted[i].Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            chart1.Series["B"].Points.Clear();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            chart1.Series["C"].Points.Clear();
        }
    }
}
