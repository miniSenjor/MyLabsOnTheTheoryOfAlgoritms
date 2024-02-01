using System;
using System.Windows.Forms;

namespace alPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int numVertex;

        private void btnChangeNumberVertex_Click(object sender, EventArgs e)
        {
            dataGridPrim.Rows.Clear();
            dataGridPrim.Columns.Clear();
            numVertex = int.Parse(txtNumberVertex.Text);
            for (int i=0; i<numVertex+1;i++)
            {
                dataGridPrim.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = i == 0 ? ("") : (Convert.ToChar(64 + i).ToString()),
                    Name = "Column" + Convert.ToString(i),
                    ValueType = typeof(int)
                });
                if (i>0) dataGridPrim.Rows.Add(Convert.ToChar(64 + i).ToString());
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[,] graph = new int[numVertex,numVertex];
            for (int i=0;i<graph.GetLength(0);i++)
                for (int j=0;j<graph.GetLength(0); j++)
                {
                    DataGridViewCell cell = dataGridPrim.Rows[i + 1].Cells[j + 1];

                    graph[i, j] = int.Parse(cell.Value.ToString());
                        //int.Parse(dataGridPrim.Rows[i + 1].Cells[j + 1].Value.ToString());
                }

            for (int i = 1; i < graph.GetLength(0); i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.WriteLine(i+" "+j);
                }
            }
        }
    }
}
