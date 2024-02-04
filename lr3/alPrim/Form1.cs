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
                        ValueType = typeof(string)
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
                MessageBox.Show("Некоректный ввод");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[,] graph = new int[numVertex, numVertex];
            for (int i=0; i<graph.GetLength(0); i++)
                for (int j=0; j<graph.GetLength(1); j++)
                {
                    string cell = dataGridPrim.Rows[i].Cells[j+1].Value.ToString();
                    try { if (cell != "" && i != j) graph[i, j] = int.Parse(cell); }
                    catch { graph[i, j] = 0; }
                    }

            
            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] > graph[j,i] && graph[j,i]!=0)
                        graph[i,j] = graph[j,i];
                    else if (graph[i,j]!=0) 
                        graph[j,i] = graph[i,j];
                }

            
            long sumAbove = 0;
            long sumUnder = 0;

            for (int i =0; i < graph.GetLength(0)-1; i++)
            {
                int[] arrAboveFromGraph = new int[numVertex - i - 1];
                int[] arrUnderDiagonalFromGraph = new int[numVertex - i - 1];
                int minAbove = int.MaxValue;
                int minUnder = int.MaxValue;
                for (int j = 0; j < graph.GetLength(1)-i-1; j++)
                {
                    arrAboveFromGraph[j] = graph[i, j + i + 1];
                    arrUnderDiagonalFromGraph[j] = graph[numVertex-i-1, j];

                    if (graph[i, j + i + 1] < minAbove && graph[i,j + i + 1]!=0)
                        minAbove = graph[i, j + i + 1];
                    if (graph[numVertex-i-1,j]<minUnder && graph[numVertex-i-1,j]!=0)
                        minUnder = graph[numVertex-i-1,j];
                }
                sumAbove += minAbove;
                sumUnder += minUnder;

                bool isFirstMinA=true;
                bool isFirstMinU=true;
                for (int j = 0;j < graph.GetLength(1)-i-1;j++)
                {
                    if (arrAboveFromGraph[j] > minAbove)
                        arrAboveFromGraph[j] = 0;
                    if (!isFirstMinA && arrAboveFromGraph[j] == minAbove)
                    {
                        isFirstMinA=false;
                        arrAboveFromGraph[j] = 0;
                    }
                    if (arrUnderDiagonalFromGraph[j] > minUnder)
                        arrUnderDiagonalFromGraph[j] = 0;
                    if (!isFirstMinU && arrUnderDiagonalFromGraph[j] == minUnder)
                    {
                        isFirstMinU = false;
                        arrUnderDiagonalFromGraph[j]=0;
                    }
                }

                for (int j = 0;j<graph.GetLength(1)-i-1; j++)
                {
                    graph[i, j + i + 1] = arrAboveFromGraph[j];
                    graph[numVertex - i - 1, j] = arrUnderDiagonalFromGraph[j];
                }
            }

            if (sumAbove<sumUnder)
                for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = i + 1; j < graph.GetLength(1); j++)
                        graph[j,i] = graph[i,j];
            else for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = i + 1; j < graph.GetLength(1); j++)
                        graph[i, j] = graph[j, i];

            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                    dataGridPrim.Rows[i].Cells[j + 1].Value = graph[i, j].ToString();
            //Console.WriteLine(sumMinCol+" "+sumMinRow);
            /*for (int i=0;i<graph.GetLength(0);i++)
            {
                for (int j=0;j<graph.GetLength(1);j++)
                    Console.Write(graph[i,j]+" ");
                Console.WriteLine();
            }*///Вывод массива
        }
    }
}
