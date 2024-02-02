
namespace alPrim
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangeNumberVertex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberVertex = new System.Windows.Forms.TextBox();
            this.dataGridPrim = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chBxDirection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeNumberVertex
            // 
            this.btnChangeNumberVertex.Location = new System.Drawing.Point(65, 79);
            this.btnChangeNumberVertex.Name = "btnChangeNumberVertex";
            this.btnChangeNumberVertex.Size = new System.Drawing.Size(108, 23);
            this.btnChangeNumberVertex.TabIndex = 0;
            this.btnChangeNumberVertex.Text = "Изменить";
            this.btnChangeNumberVertex.UseVisualStyleBackColor = true;
            this.btnChangeNumberVertex.Click += new System.EventHandler(this.btnChangeNumberVertex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во вершин:";
            // 
            // txtNumberVertex
            // 
            this.txtNumberVertex.Location = new System.Drawing.Point(179, 59);
            this.txtNumberVertex.Name = "txtNumberVertex";
            this.txtNumberVertex.Size = new System.Drawing.Size(48, 22);
            this.txtNumberVertex.TabIndex = 2;
            // 
            // dataGridPrim
            // 
            this.dataGridPrim.AllowUserToAddRows = false;
            this.dataGridPrim.AllowUserToDeleteRows = false;
            this.dataGridPrim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrim.Location = new System.Drawing.Point(257, 59);
            this.dataGridPrim.Name = "dataGridPrim";
            this.dataGridPrim.RowHeadersWidth = 51;
            this.dataGridPrim.RowTemplate.Height = 24;
            this.dataGridPrim.Size = new System.Drawing.Size(474, 271);
            this.dataGridPrim.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(65, 137);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chBxDirection
            // 
            this.chBxDirection.AutoSize = true;
            this.chBxDirection.Location = new System.Drawing.Point(65, 109);
            this.chBxDirection.Name = "chBxDirection";
            this.chBxDirection.Size = new System.Drawing.Size(150, 21);
            this.chBxDirection.TabIndex = 5;
            this.chBxDirection.Text = "есть направление";
            this.chBxDirection.UseVisualStyleBackColor = true;
            this.chBxDirection.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chBxDirection);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dataGridPrim);
            this.Controls.Add(this.txtNumberVertex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeNumberVertex);
            this.Name = "Form1";
            this.Text = "lr3AlPrim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeNumberVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberVertex;
        private System.Windows.Forms.DataGridView dataGridPrim;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox chBxDirection;
    }
}

