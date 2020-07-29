namespace INTMA_test
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
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.dataGrid3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(21, 26);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(217, 145);
            this.dataGrid1.TabIndex = 0;
            // 
            // dataGrid2
            // 
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(352, 26);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(217, 145);
            this.dataGrid2.TabIndex = 1;
            // 
            // dataGrid3
            // 
            this.dataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3.Location = new System.Drawing.Point(352, 271);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.Size = new System.Drawing.Size(217, 145);
            this.dataGrid3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ".csv - datagridview";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ".csv - database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = " database - .csv ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(711, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid3);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.DataGridView dataGrid3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

