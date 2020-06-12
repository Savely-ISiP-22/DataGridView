namespace Матрица2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Размер:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(145, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 21);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Построить";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(64, 12);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(75, 20);
            this.txtSize.TabIndex = 6;
            // 
            // table1
            // 
            this.table1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.ColumnHeadersVisible = false;
            this.table1.Location = new System.Drawing.Point(12, 71);
            this.table1.Name = "table1";
            this.table1.RowHeadersVisible = false;
            this.table1.Size = new System.Drawing.Size(397, 245);
            this.table1.TabIndex = 5;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 45);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(56, 13);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "Разница: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 323);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.table1);
            this.Name = "Form1";
            this.Text = "Единичная матрица";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.DataGridView table1;
        private System.Windows.Forms.Label lb1;
    }
}

