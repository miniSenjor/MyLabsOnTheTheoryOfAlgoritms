using System;
using System.Collections.Generic;
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
                numVertex = int.Parse(txtQuantityVertex.Text);
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
            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    string cell = dataGridPrim.Rows[i].Cells[j + 1].Value.ToString();
                    try { if (cell != "" && i != j) graph[i, j] = int.Parse(cell); }
                    catch { graph[i, j] = 0; }
                }


            List<Edge> notUsedEdges = new List<Edge>();
            List<int> notUsedVertex = new List<int>();
            List<int> usedVertex = new List<int>();
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                notUsedVertex.Add(i);
                for (int j = i + 1; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] > graph[j, i] && graph[j, i] != 0)
                        graph[i, j] = graph[j, i];
                    else if (graph[i, j] != 0)
                        graph[j, i] = graph[i, j];
                    if (graph[i, j] != 0)
                    {
                        Edge edge = new Edge(i, j, graph[i, j]);
                        notUsedEdges.Add(edge);
                    }
                }
            }



            for (int i = 0; i <= 0; i++)
            {
                /*long sumAbove = 0;
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

                for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = i + 1; j < graph.GetLength(1); j++)
                        if ( sumAbove<sumUnder) graph[j,i] = graph[i,j];
                        else graph[i, j] = graph[j, i];*/
            }

            generateResGraph1();
            List<Edge> resultGraph1 = alPrim(notUsedEdges, notUsedVertex, usedVertex);
            int[,] graph1 = new int[numVertex, numVertex];
            for (int i = 0; i < resultGraph1.Count; i++)
            {
                int v1 = resultGraph1[i].ver1;
                int v2 = resultGraph1[i].ver2;
                graph1[v1, v2] = resultGraph1[i].length;
                Console.WriteLine($"{v1} {v2} {resultGraph1[i].length}");
            }
            for (int i = 0; i < graph1.GetLength(0); i++)
                for (int j = i; j < graph1.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j + 1].Value = graph1[i, j].ToString();
                    dataGridView1.Rows[j].Cells[i + 1].Value = graph1[i, j].ToString();
                }

            generateResGraph2();
            int[,] graph2 = new int[numVertex, numVertex];
            for (int i = 0; i < graph2.GetLength(0); i++)
                for (int j = 0; j < graph2.GetLength(1); j++)
                    dataGridView2.Rows[i].Cells[j + 1].Value = graph[i, j].ToString();
            //Console.WriteLine(sumMinCol+" "+sumMinRow);
            /*for (int i=0;i<graph.GetLength(0);i++)
            {
                for (int j=0;j<graph.GetLength(1);j++)
                    Console.Write(graph[i,j]+" ");
                Console.WriteLine();
            }*///Вывод массива
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            int[,] graph = new int[numVertex, numVertex];
            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    string cell = dataGridPrim.Rows[i].Cells[j + 1].Value.ToString();
                    try { if (cell != "" && i != j) graph[i, j] = int.Parse(cell); }
                    catch { graph[i, j] = 0; }
                }


            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] > graph[j, i] && graph[j, i] != 0)
                        graph[i, j] = graph[j, i];
                    else if (graph[i, j] != 0)
                        graph[j, i] = graph[i, j];
                }
            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                    dataGridPrim.Rows[i].Cells[j + 1].Value = graph[i, j].ToString();
        }

        private void generateResGraph1()
        {
            try
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                for (int i = 0; i < numVertex + 1; i++)
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = i == 0 ? ("") : (Convert.ToChar(64 + i).ToString()),
                        Name = "Column" + Convert.ToString(i),
                        ValueType = typeof(string)
                    });
                    dataGridView1.Columns[i].Width = 35;
                    if (i > 0) dataGridView1.Rows.Add(Convert.ToChar(64 + i).ToString());
                }
                for (int i = 0; i < numVertex; i++)
                    for (int j = 0; j < numVertex; j++)
                        dataGridView1.Rows[i].Cells[j + 1].Value = "";
            }
            catch
            {
                MessageBox.Show("Некоректный ввод");
            }
        }

        private void generateResGraph2()
        {
            try
            {

                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                for (int i = 0; i < numVertex + 1; i++)
                {
                    dataGridView2.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = i == 0 ? ("") : (Convert.ToChar(64 + i).ToString()),
                        Name = "Column" + Convert.ToString(i),
                        ValueType = typeof(string)
                    });
                    dataGridView2.Columns[i].Width = 35;
                    if (i > 0) dataGridView2.Rows.Add(Convert.ToChar(64 + i).ToString());
                }
                for (int i = 0; i < numVertex; i++)
                    for (int j = 0; j < numVertex; j++)
                        dataGridView2.Rows[i].Cells[j + 1].Value = "";
            }
            catch
            {
                MessageBox.Show("Некоректный ввод");
            }
        }

        private List<Edge> alPrim(List<Edge> notUsedEdges, List<int> usedVertex, List<int> notUsedVertex)
        {
            List<Edge> resultGraph = new List<Edge>();
            try
            {
                int ckeckVertex = int.Parse(txtNumberVertex.Text) - 1;
                if (ckeckVertex < numVertex && ckeckVertex > -1)
                {
                    usedVertex.Add(ckeckVertex);
                    notUsedVertex.RemoveAt(usedVertex[0]);
                }
                else
                {
                    MessageBox.Show("Неверный ввод начальной вершины");
                }
            }
            catch
            {
                MessageBox.Show("Введите номер начальной вершины");
            }

            while (notUsedVertex.Count > 0)
            {
                int nearEdge = -1;
                for (int i = 0; i < notUsedEdges.Count; i++)
                    if ((usedVertex.IndexOf(notUsedEdges[i].ver1) != -1 && notUsedVertex.IndexOf(notUsedEdges[i].ver2) != -1)
                        || (usedVertex.IndexOf(notUsedEdges[i].ver2) != -1 && notUsedVertex.IndexOf(notUsedEdges[i].ver1) != -1))
                    {
                        if (nearEdge != -1)
                        {
                            if (notUsedEdges[i].length < notUsedEdges[nearEdge].length)
                                nearEdge = i;
                        }
                        else nearEdge = i;
                    }
                if (notUsedVertex.IndexOf(notUsedEdges[nearEdge].ver1) != -1)
                {
                    usedVertex.Add(notUsedEdges[nearEdge].ver1);
                    notUsedVertex.Remove(notUsedEdges[nearEdge].ver1);
                }
                else
                {
                    usedVertex.Add(notUsedEdges[nearEdge].ver2);
                    notUsedVertex.Remove(notUsedEdges[nearEdge].ver2);
                }
                resultGraph.Add(notUsedEdges[nearEdge]);
                notUsedEdges.RemoveAt(nearEdge);
                Console.WriteLine(nearEdge);
            }
            return resultGraph;
        }
    }

    public class Edge
    {
        public int ver1, ver2, length;
        public Edge(int ver1, int ver2, int length)
        {
            this.ver1 = ver1;
            this.ver2 = ver2;
            this.length = length;
        }
    }
}