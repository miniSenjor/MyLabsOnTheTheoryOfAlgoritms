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
            try
            {
                dataGridPrim.Rows.Clear();
                dataGridPrim.Columns.Clear();
                numVertex = int.Parse(txtNumberVertex.Text);
                for (int i = 0; i < numVertex + 1; i++)
                {
                    dataGridPrim.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = i == 0 ? ("") : (Convert.ToChar(64 + i).ToString()),
                        Name = "Column" + Convert.ToString(i),
                        ValueType = typeof(int)
                    });
                    dataGridPrim.Columns[i].Width = 35;
                    if (i > 0) dataGridPrim.Rows.Add(Convert.ToChar(64 + i).ToString());
                }
                for (int i = 0; i < numVertex; i++)
                    for (int j = 0; j < numVertex; j++)
                        dataGridPrim.Rows[i].Cells[j + 1].Value = "";
            }
            catch
            {
                MessageBox.Show("Введите кол-во вершин графа");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[,] graph = new int[numVertex,numVertex];
            for (int i=0; i<graph.GetLength(0); i++)
                for (int j=0; j<graph.GetLength(1); j++)
                {
                    string cell = dataGridPrim.Rows[i].Cells[j+1].Value.ToString();
                    if (cell != "" && i!=j) graph[i, j] = int.Parse(cell);
                        else graph[i, j] = 0;
                }

            int sumMinRow = 0;
            int sumMinCol = 0;

            for (int i = 0; i < graph.GetLength(0)-1; i++)
            {
                int minFromRow=int.MaxValue;
                int countMinFromRow = 0;
                int[] rowFromGraph = new int[graph.GetLength(0)-i-1];
                for (int j = i+1; j < graph.GetLength(1); j++)
                {
                    rowFromGraph[j - i-1] = graph[i, j];
                    if (rowFromGraph[j - i - 1] == minFromRow)
                        countMinFromRow++;
                    if (rowFromGraph[j-i-1] != 0 && rowFromGraph[j-i-1]<minFromRow)
                    {
                        minFromRow = rowFromGraph[j - i - 1];
                        countMinFromRow = 1;
                    }
                }
                sumMinRow += minFromRow;

                int minFromCol=int.MaxValue;
                int countMinFromCol = 0;
                int[] colFromGraph = new int[i + 1];
                for (int j = 0; j < colFromGraph.Length; j++)
                {
                    colFromGraph[j] = graph[j, i + 1];
                    if (colFromGraph[j] == minFromCol)
                        countMinFromCol++;
                    if (colFromGraph[j] != 0 && colFromGraph[j]<minFromCol)
                    {
                        minFromCol = colFromGraph[j];
                        countMinFromCol = 1;
                    }
                }
                sumMinCol += minFromRow;

                
                    /*for (int j=0;j<rowFromGraph.Length;j++)
                    {
                        if (rowFromGraph[j] > minFromRow)
                            rowFromGraph[j] = 0;
                        if (rowFromGraph[j] == minFromRow && countMinFromRow > 1)
                        {
                            rowFromGraph[j] = 0;
                            countMinFromRow--;
                        }
                    }
                    for (int j=0; j<rowFromGraph.Length;j++)
                    {
                        graph[i,j+i+1] = rowFromGraph[j];
                        graph[j+1+i,i] = rowFromGraph[j];
                    }*/


                    for (int j = 0; j < colFromGraph.Length; j++)
                    {
                        if (colFromGraph[j] > minFromCol)
                            colFromGraph[j] = 0;
                        if (colFromGraph[j] == minFromCol && countMinFromCol > 1)
                        {
                            colFromGraph[j] = 0;
                            countMinFromCol--;
                        }
                    }
                    for (int j = 0; j < colFromGraph.Length; j++)
                    {
                        int c = colFromGraph[j];
                        graph[i, j + i + 1] = c;//над главной диагональю
                        graph[j + 1 + i, i] = c;
                    }
            }

            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                    dataGridPrim.Rows[i].Cells[j + 1].Value = graph[i, j].ToString();

            /*for (int i=0;i<graph.GetLength(0);i++)
            {
                for (int j=0;j<graph.GetLength(1);j++)
                    Console.Write(graph[i,j]+" ");
                Console.WriteLine();
            }*///Вывод массива
        }
    }
}
