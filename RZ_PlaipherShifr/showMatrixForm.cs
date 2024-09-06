using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RZ_PlaipherShifr
{
    public partial class showMatrixForm : Form
    {
        private int rows;
        private int cols;
        public showMatrixForm(char[,] matrix)
        {
            InitializeComponent();
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            for (int j = 0; j < cols; j++)
                matrixPlaifairShow.Columns.Add(" ", " ");

            for (int i = 0; i < rows; i++)
                matrixPlaifairShow.Rows.Add();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrixPlaifairShow[j, i].Value = matrix[i, j];
        }
    }
}
