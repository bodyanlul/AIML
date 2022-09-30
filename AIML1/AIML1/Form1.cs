using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIML1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            A.Rows.Add();
            A.Rows.Add();

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
    }
}
