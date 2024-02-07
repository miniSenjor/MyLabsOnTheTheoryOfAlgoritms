
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
            this.btnChangeCountVertex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountVertex = new System.Windows.Forms.TextBox();
            this.dataGridBefore = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeCountVertex
            // 
            this.btnChangeCountVertex.Location = new System.Drawing.Point(137, 21);
            this.btnChangeCountVertex.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeCountVertex.Name = "btnChangeCountVertex";
            this.btnChangeCountVertex.Size = new System.Drawing.Size(81, 19);
            this.btnChangeCountVertex.TabIndex = 0;
            this.btnChangeCountVertex.Text = "Изменить";
            this.btnChangeCountVertex.UseVisualStyleBackColor = true;
            this.btnChangeCountVertex.Click += new System.EventHandler(this.btnChangeCountVertex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во вершин:";
            // 
            // txtCountVertex
            // 
            this.txtCountVertex.Location = new System.Drawing.Point(97, 21);
            this.txtCountVertex.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountVertex.Name = "txtCountVertex";
            this.txtCountVertex.Size = new System.Drawing.Size(37, 20);
            this.txtCountVertex.TabIndex = 2;
            // 
            // dataGridBefore
            // 
            this.dataGridBefore.AllowUserToAddRows = false;
            this.dataGridBefore.AllowUserToDeleteRows = false;
            this.dataGridBefore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBefore.Location = new System.Drawing.Point(9, 64);
            this.dataGridBefore.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBefore.Name = "dataGridBefore";
            this.dataGridBefore.RowHeadersWidth = 51;
            this.dataGridBefore.RowTemplate.Height = 24;
            this.dataGridBefore.Size = new System.Drawing.Size(258, 253);
            this.dataGridBefore.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(308, 21);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(81, 19);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chBxDirection
            // 
            this.chBxDirection.AutoSize = true;
            this.chBxDirection.Location = new System.Drawing.Point(-85, 496);
            this.chBxDirection.Margin = new System.Windows.Forms.Padding(2);
            this.chBxDirection.Name = "chBxDirection";
            this.chBxDirection.Size = new System.Drawing.Size(118, 17);
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
            this.dataGridView1.Location = new System.Drawing.Point(281, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(258, 253);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(223, 21);
            this.btnMirror.Margin = new System.Windows.Forms.Padding(2);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(81, 19);
            this.btnMirror.TabIndex = 7;
            this.btnMirror.Text = "Отзеркалить";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Краскал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Прим:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(554, 64);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(258, 253);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.Visible = false;
            // 
            // txtNumberVertex
            // 
            this.txtNumberVertex.Location = new System.Drawing.Point(581, 22);
            this.txtNumberVertex.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberVertex.Name = "txtNumberVertex";
            this.txtNumberVertex.Size = new System.Drawing.Size(37, 20);
            this.txtNumberVertex.TabIndex = 12;
            this.txtNumberVertex.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "№ вершины для ал. Прима";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 332);
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
            this.Controls.Add(this.dataGridBefore);
            this.Controls.Add(this.txtCountVertex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeCountVertex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "lr3AlPrim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeCountVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountVertex;
        private System.Windows.Forms.DataGridView dataGridBefore;
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

