namespace EntityExample_v1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.localDBDataSet = new EntityExample_v1.localDBDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new EntityExample_v1.localDBDataSetTableAdapters.GameTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ballDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.player1DataGridViewTextBoxColumn,
            this.ballDataGridViewTextBoxColumn,
            this.player2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(893, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "localDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.localDBDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // player1DataGridViewTextBoxColumn
            // 
            this.player1DataGridViewTextBoxColumn.DataPropertyName = "player1";
            this.player1DataGridViewTextBoxColumn.HeaderText = "player1";
            this.player1DataGridViewTextBoxColumn.Name = "player1DataGridViewTextBoxColumn";
            // 
            // ballDataGridViewTextBoxColumn
            // 
            this.ballDataGridViewTextBoxColumn.DataPropertyName = "ball";
            this.ballDataGridViewTextBoxColumn.HeaderText = "ball";
            this.ballDataGridViewTextBoxColumn.Name = "ballDataGridViewTextBoxColumn";
            // 
            // player2DataGridViewTextBoxColumn
            // 
            this.player2DataGridViewTextBoxColumn.DataPropertyName = "player2";
            this.player2DataGridViewTextBoxColumn.HeaderText = "player2";
            this.player2DataGridViewTextBoxColumn.Name = "player2DataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Игрок1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Игрок2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Балл";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private localDBDataSet localDBDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private localDBDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn player1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ballDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn player2DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

