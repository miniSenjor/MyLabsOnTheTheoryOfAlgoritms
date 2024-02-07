using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace alPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int countVertex;

        private void btnChangeCountVertex_Click(object sender, EventArgs e)
        {
            try
            {
                countVertex = int.Parse(txtCountVertex.Text);
                if (countVertex > 1) generateDataGridView(dataGridBefore);
                else MessageBox.Show("Введите больше вершин");
            }
            catch 
            {
                MessageBox.Show("Некоректный ввод числа вершин");
            }
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] graph = new int[countVertex, countVertex];
                for (int i = 0; i < graph.GetLength(0); i++)
                    for (int j = 0; j < graph.GetLength(1); j++)
                    {
                        string cell = dataGridBefore.Rows[i].Cells[j + 1].Value.ToString();
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
                        dataGridBefore.Rows[i].Cells[j + 1].Value = graph[i, j].ToString();
            }
            catch 
            {
                if (txtNumberVertex.Text == "")
                    MessageBox.Show("Не введен размер графа");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            generateDataGridView(dataGridView1);
            List<Edge> resultGraph1;
            if (alPrim(out resultGraph1) == -1)
                return;
            for (int i = 0; i < resultGraph1.Count; i++)
            {
                int v1 = resultGraph1[i].ver1;
                int v2 = resultGraph1[i].ver2;
                dataGridView1.Rows[v1].Cells[v2+1].Value = resultGraph1[i].length;
                dataGridView1.Rows[v2].Cells[v1+1].Value = resultGraph1[i].length;
            }
            dataGridView1.Visible = true; 

            generateDataGridView(dataGridView2);
            List<Edge> resultGraph2 = alKrask();
            for (int i = 0; i < resultGraph2.Count; i++)
            {
                int v1 = resultGraph2[i].ver1;
                int v2 = resultGraph2[i].ver2;
                dataGridView2.Rows[v1].Cells[v2+1].Value = resultGraph2[i].length;
                dataGridView2.Rows[v2].Cells[v1+1].Value = resultGraph2[i].length;
            }
            dataGridView2.Visible = true;
        }

        private void generateDataGridView(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                for (int i = 0; i < countVertex + 1; i++)
                {
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = i == 0 ? ("") : (Convert.ToChar(64 + i).ToString()),
                        Name = "Column" + Convert.ToString(i),
                        ValueType = typeof(string)
                    });
                    dataGridView.Columns[i].Width = 35;
                    if (i > 0) dataGridView.Rows.Add(Convert.ToChar(64 + i).ToString());
                }
                for (int i = 0; i < countVertex; i++)
                    for (int j = 0; j < countVertex; j++)
                    {
                        dataGridView.Rows[i].Cells[j + 1].Value = "";
                        if (i == j) dataGridView.Rows[i].Cells[j + 1].Style.BackColor = Color.Coral;
                    }
            }
            catch
            {
                MessageBox.Show("Некоректный ввод");
            }
        }

        void graphConvertToListEdge(ref List<Edge> notUsedEdges, ref List<int> notUsedVertex)
        {
            int aboveD, underD;
            for (int i = 0; i < countVertex; i++)
            {
                notUsedVertex.Add(i);
                for (int j = i + 1; j < countVertex; j++)
                {
                    try { aboveD = int.Parse(dataGridBefore.Rows[i].Cells[j + 1].Value.ToString()); }
                    catch { aboveD = 0; }
                    try { underD = int.Parse(dataGridBefore.Rows[j].Cells[i+1].Value.ToString()); }
                    catch { underD = 0; }

                    if (aboveD>underD && underD>0)
                        aboveD = underD;
                    if (aboveD>0)
                    {
                        Edge edge = new Edge(i, j, aboveD);
                        notUsedEdges.Add(edge);
                    }
                }
            }
        }

        private int alPrim(out List<Edge> resultGraph)
        {
            List<Edge> notUsedEdges = new List<Edge>();
            List<int> notUsedVertex = new List<int>();
            List<int> usedVertex = new List<int>();
            graphConvertToListEdge(ref notUsedEdges, ref notUsedVertex);

            resultGraph = new List<Edge>();
            try
            {
                int ckeckVertex = int.Parse(txtNumberVertex.Text) - 1;
                if (ckeckVertex < countVertex && ckeckVertex > -1)
                {
                    usedVertex.Add(ckeckVertex);
                    notUsedVertex.RemoveAt(usedVertex[0]);
                }
                else
                {
                    MessageBox.Show("Начальная вершина слишком большая или маленькая");
                    return -1;
                }
            }
            catch
            {
                MessageBox.Show("Введите начальную вершину");
                return -1;
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
                if (nearEdge == -1)
                {
                    MessageBox.Show("Ошибка ввода массива");
                    return -1;
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
            }
            return 0;
        }

        private List<Edge> alKrask()
        {
            List<Edge> notUsedEdges = new List<Edge>();
            List<int> notUsedVertex = new List<int>();
            graphConvertToListEdge(ref notUsedEdges, ref notUsedVertex);
            
            notUsedEdges.Sort();

            List<SystemEdge> listOfSystem = new List<SystemEdge>() { new SystemEdge(notUsedEdges[0]) };
            notUsedEdges.RemoveAt(0);
            for (int i=0; i<notUsedEdges.Count;i++)
            {
                SystemEdge v1 = Find(listOfSystem, notUsedEdges[i].ver1);
                SystemEdge v2 = Find(listOfSystem, notUsedEdges[i].ver2);
                if (v1 == null && v2 == null)
                {
                    SystemEdge newSystemEdge = new SystemEdge(notUsedEdges[i]);
                    listOfSystem.Add(newSystemEdge);
                    continue;
                }

                if (v1 == null && v2 !=null)
                    v2.AddEdge(notUsedEdges[i]);
                else if (v1!=null && v2 == null)
                    v1.AddEdge(notUsedEdges[i]);
                else if (v1!=v2)
                {
                    foreach (Edge edge in v2.systemEdge)
                        v1.AddEdge(edge);
                    v1.AddEdge(notUsedEdges[i]);
                    listOfSystem.Remove(v2);
                }
            }
            return listOfSystem[0].systemEdge;
        }

        public SystemEdge Find(List<SystemEdge> systemEdge, int vertex)
        {
            foreach (SystemEdge system in systemEdge)
                if (system.Contains(vertex)) return system;
            return null;
        }
    }

    public class Edge : IComparable<Edge> 
    {
        public int ver1, ver2, length;
        public Edge(int ver1, int ver2, int length)
        {
            this.ver1 = ver1;
            this.ver2 = ver2;
            this.length = length;
        }
        public int CompareTo(Edge other)
        {
            if (other == null) return 1;
            return length.CompareTo(other.length);
        }
    }
    public class SystemEdge
    {
        public List<Edge> systemEdge;
        public List<int> systemVertex;

        public SystemEdge(Edge edge)
        {
            systemEdge = new List<Edge> { edge };
            systemVertex = new List<int>
            {
                edge.ver1,
                edge.ver2
            };
        }

        public void AddEdge(Edge edge)
        {
            systemEdge.Add(edge);
            if (!systemVertex.Contains(edge.ver1)) 
                systemVertex.Add(edge.ver1);
            if (!systemVertex.Contains(edge.ver2)) 
                systemVertex.Add(edge.ver2);
        }

        public bool Contains(int vertex)
        {
            return systemVertex.Contains(vertex);
        }
    }
}