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
            if (txtNumberVertex.Text=="")
            {
                MessageBox.Show("Введите кол-во вершин графа");
                return;
            }
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
                dataGridPrim.Columns[i].Width = 40;
                if (i>0) dataGridPrim.Rows.Add(Convert.ToChar(64 + i).ToString());
            }
            for (int i=0;i<numVertex;i++)
                for (int j=0;j<numVertex;j++)
                    dataGridPrim.Rows[i].Cells[j + 1].Value = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[,] graph = new int[numVertex,numVertex];
            for (int i=0; i<graph.GetLength(0); i++)
                for (int j=0; j<graph.GetLength(1); j++)
                {
                    string cell = dataGridPrim.Rows[i].Cells[j+1].Value.ToString();
                    if (cell != "") graph[i, j] = int.Parse(cell);
                        else graph[i, j] = 0;
                }

            for (int i = 1; i < graph.GetLength(0); i++)
            {
                int[] mas = new int[graph.GetLength(0)-i];
                for (int j = i; j < graph.GetLength(1); j++)
                    mas[j - i] = graph[i, j];

                int min=int.MaxValue;
                for (int j=0;j<mas.Length;j++)
                    if (mas[j] != 0 && mas[j]<min)
                        min = mas[j];

                for (int j=0;j<mas.Length;j++)
                    if (mas[j] > min)
                        mas[j] = 0;
                /*for (int j=i-1;j<graph.GetLength(1);j++)
                    graph[j, i] = mas[j-i+1];*/
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
