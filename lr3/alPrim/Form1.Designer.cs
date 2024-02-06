
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
            this.txtQuantityVertex = new System.Windows.Forms.TextBox();
            this.dataGridPrim = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chBxDirection = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMirror = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtNumberVertex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeNumberVertex
            // 
            this.btnChangeNumberVertex.Location = new System.Drawing.Point(183, 26);
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
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во вершин:";
            // 
            // txtQuantityVertex
            // 
            this.txtQuantityVertex.Location = new System.Drawing.Point(129, 26);
            this.txtQuantityVertex.Name = "txtQuantityVertex";
            this.txtQuantityVertex.Size = new System.Drawing.Size(48, 22);
            this.txtQuantityVertex.TabIndex = 2;
            // 
            // dataGridPrim
            // 
            this.dataGridPrim.AllowUserToAddRows = false;
            this.dataGridPrim.AllowUserToDeleteRows = false;
            this.dataGridPrim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrim.Location = new System.Drawing.Point(12, 79);
            this.dataGridPrim.Name = "dataGridPrim";
            this.dataGridPrim.RowHeadersWidth = 51;
            this.dataGridPrim.RowTemplate.Height = 24;
            this.dataGridPrim.Size = new System.Drawing.Size(344, 311);
            this.dataGridPrim.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(411, 26);
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
            this.chBxDirection.Location = new System.Drawing.Point(-113, 611);
            this.chBxDirection.Name = "chBxDirection";
            this.chBxDirection.Size = new System.Drawing.Size(150, 21);
            this.chBxDirection.TabIndex = 5;
            this.chBxDirection.Text = "есть направление";
            this.chBxDirection.UseVisualStyleBackColor = true;
            this.chBxDirection.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 311);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(297, 26);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(108, 23);
            this.btnMirror.TabIndex = 7;
            this.btnMirror.Text = "Отзеркалить";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Краскал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Прим:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(738, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(344, 311);
            this.dataGridView2.TabIndex = 10;
            // 
            // txtNumberVertex
            // 
            this.txtNumberVertex.Location = new System.Drawing.Point(775, 27);
            this.txtNumberVertex.Name = "txtNumberVertex";
            this.txtNumberVertex.Size = new System.Drawing.Size(48, 22);
            this.txtNumberVertex.TabIndex = 12;
            this.txtNumberVertex.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "№ вершины для ал. Прима";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberVertex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMirror);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chBxDirection);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dataGridPrim);
            this.Controls.Add(this.txtQuantityVertex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeNumberVertex);
            this.Name = "Form1";
            this.Text = "lr3AlPrim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeNumberVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantityVertex;
        private System.Windows.Forms.DataGridView dataGridPrim;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox chBxDirection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtNumberVertex;
        private System.Windows.Forms.Label label5;
    }
}

