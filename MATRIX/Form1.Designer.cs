namespace MATRIX
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Result = new System.Windows.Forms.DataGridView();
			this.OperandB = new System.Windows.Forms.DataGridView();
			this.OperandA = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Rank = new System.Windows.Forms.Button();
			this.Mult = new System.Windows.Forms.Button();
			this.Det = new System.Windows.Forms.Button();
			this.Transpose = new System.Windows.Forms.Button();
			this.Sub = new System.Windows.Forms.Button();
			this.Cls = new System.Windows.Forms.Button();
			this.Inverse = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.Cp = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OperandB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OperandA)).BeginInit();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.Result, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.OperandB, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.OperandA, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 693);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// Result
			// 
			this.Result.AllowUserToAddRows = false;
			this.Result.AllowUserToDeleteRows = false;
			this.Result.AllowUserToResizeColumns = false;
			this.Result.AllowUserToResizeRows = false;
			this.Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Result.BackgroundColor = System.Drawing.Color.Gray;
			this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.Result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.Result.ColumnHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Result.DefaultCellStyle = dataGridViewCellStyle1;
			this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Result.Location = new System.Drawing.Point(3, 349);
			this.Result.Name = "Result";
			this.Result.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Result.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Result.RowHeadersVisible = false;
			this.Result.RowTemplate.Height = 23;
			this.Result.Size = new System.Drawing.Size(528, 341);
			this.Result.TabIndex = 90;
			this.Result.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OperandA_RowsAdded);
			this.Result.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OperandA_RowsRemoved);
			this.Result.Resize += new System.EventHandler(this.OperandA_Resize);
			// 
			// OperandB
			// 
			this.OperandB.AllowUserToAddRows = false;
			this.OperandB.AllowUserToDeleteRows = false;
			this.OperandB.AllowUserToResizeColumns = false;
			this.OperandB.AllowUserToResizeRows = false;
			this.OperandB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.OperandB.BackgroundColor = System.Drawing.Color.Gray;
			this.OperandB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.OperandB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.OperandB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.OperandB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.OperandB.ColumnHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.NullValue = "0";
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.OperandB.DefaultCellStyle = dataGridViewCellStyle3;
			this.OperandB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OperandB.Location = new System.Drawing.Point(537, 3);
			this.OperandB.Name = "OperandB";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.OperandB.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.OperandB.RowHeadersVisible = false;
			this.OperandB.RowTemplate.Height = 23;
			this.OperandB.Size = new System.Drawing.Size(528, 340);
			this.OperandB.TabIndex = 89;
			this.OperandB.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OperandA_RowsAdded);
			this.OperandB.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OperandA_RowsRemoved);
			this.OperandB.Resize += new System.EventHandler(this.OperandA_Resize);
			// 
			// OperandA
			// 
			this.OperandA.AllowUserToAddRows = false;
			this.OperandA.AllowUserToDeleteRows = false;
			this.OperandA.AllowUserToResizeColumns = false;
			this.OperandA.AllowUserToResizeRows = false;
			this.OperandA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.OperandA.BackgroundColor = System.Drawing.Color.Gray;
			this.OperandA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.OperandA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.OperandA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.OperandA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.OperandA.ColumnHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.NullValue = "0";
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.OperandA.DefaultCellStyle = dataGridViewCellStyle5;
			this.OperandA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OperandA.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.OperandA.Location = new System.Drawing.Point(3, 3);
			this.OperandA.Name = "OperandA";
			this.OperandA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.OperandA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.OperandA.RowHeadersVisible = false;
			this.OperandA.RowTemplate.Height = 23;
			this.OperandA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.OperandA.Size = new System.Drawing.Size(528, 340);
			this.OperandA.TabIndex = 88;
			this.OperandA.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OperandA_RowsAdded);
			this.OperandA.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OperandA_RowsRemoved);
			this.OperandA.Resize += new System.EventHandler(this.OperandA_Resize);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Rank);
			this.panel1.Controls.Add(this.Mult);
			this.panel1.Controls.Add(this.Det);
			this.panel1.Controls.Add(this.Transpose);
			this.panel1.Controls.Add(this.Sub);
			this.panel1.Controls.Add(this.Cls);
			this.panel1.Controls.Add(this.Inverse);
			this.panel1.Controls.Add(this.Add);
			this.panel1.Controls.Add(this.Cp);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(535, 347);
			this.panel1.Margin = new System.Windows.Forms.Padding(1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(532, 345);
			this.panel1.TabIndex = 91;
			// 
			// Rank
			// 
			this.Rank.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Rank.Location = new System.Drawing.Point(355, 230);
			this.Rank.Margin = new System.Windows.Forms.Padding(1);
			this.Rank.Name = "Rank";
			this.Rank.Size = new System.Drawing.Size(175, 112);
			this.Rank.TabIndex = 10;
			this.Rank.Text = "Rank L/R";
			this.Rank.UseVisualStyleBackColor = true;
			this.Rank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rank_MouseDown);
			// 
			// Mult
			// 
			this.Mult.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Mult.Location = new System.Drawing.Point(355, 116);
			this.Mult.Margin = new System.Windows.Forms.Padding(1);
			this.Mult.Name = "Mult";
			this.Mult.Size = new System.Drawing.Size(175, 112);
			this.Mult.TabIndex = 9;
			this.Mult.Text = "L×R\r\nR×L";
			this.Mult.UseVisualStyleBackColor = true;
			this.Mult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mult_MouseDown);
			// 
			// Det
			// 
			this.Det.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Det.Location = new System.Drawing.Point(355, 2);
			this.Det.Margin = new System.Windows.Forms.Padding(1);
			this.Det.Name = "Det";
			this.Det.Size = new System.Drawing.Size(175, 112);
			this.Det.TabIndex = 8;
			this.Det.Text = "det L/R";
			this.Det.UseVisualStyleBackColor = true;
			this.Det.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Det_MouseDown);
			// 
			// Transpose
			// 
			this.Transpose.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Transpose.Location = new System.Drawing.Point(179, 230);
			this.Transpose.Margin = new System.Windows.Forms.Padding(1);
			this.Transpose.Name = "Transpose";
			this.Transpose.Size = new System.Drawing.Size(175, 112);
			this.Transpose.TabIndex = 6;
			this.Transpose.Text = "Lᵀ/Rᵀ";
			this.Transpose.UseVisualStyleBackColor = true;
			this.Transpose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Transpose_MouseDown);
			// 
			// Sub
			// 
			this.Sub.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Sub.Location = new System.Drawing.Point(179, 116);
			this.Sub.Margin = new System.Windows.Forms.Padding(1);
			this.Sub.Name = "Sub";
			this.Sub.Size = new System.Drawing.Size(175, 112);
			this.Sub.TabIndex = 5;
			this.Sub.Text = "L-R\r\nR-L";
			this.Sub.UseVisualStyleBackColor = true;
			this.Sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sub_MouseDown);
			// 
			// Cls
			// 
			this.Cls.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cls.Location = new System.Drawing.Point(179, 2);
			this.Cls.Margin = new System.Windows.Forms.Padding(1);
			this.Cls.Name = "Cls";
			this.Cls.Size = new System.Drawing.Size(175, 112);
			this.Cls.TabIndex = 4;
			this.Cls.Text = "Clear L/R";
			this.Cls.UseVisualStyleBackColor = true;
			this.Cls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cls_MouseDown);
			// 
			// Inverse
			// 
			this.Inverse.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Inverse.Location = new System.Drawing.Point(2, 230);
			this.Inverse.Margin = new System.Windows.Forms.Padding(1);
			this.Inverse.Name = "Inverse";
			this.Inverse.Size = new System.Drawing.Size(175, 112);
			this.Inverse.TabIndex = 2;
			this.Inverse.Text = "L⁻¹/R⁻¹";
			this.Inverse.UseVisualStyleBackColor = true;
			this.Inverse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inverse_MouseDown);
			// 
			// Add
			// 
			this.Add.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add.Location = new System.Drawing.Point(2, 116);
			this.Add.Margin = new System.Windows.Forms.Padding(1);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(175, 112);
			this.Add.TabIndex = 1;
			this.Add.Text = "L+R\r\nR+l";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_MouseDown);
			// 
			// Cp
			// 
			this.Cp.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cp.Location = new System.Drawing.Point(2, 2);
			this.Cp.Margin = new System.Windows.Forms.Padding(1);
			this.Cp.Name = "Cp";
			this.Cp.Size = new System.Drawing.Size(175, 112);
			this.Cp.TabIndex = 0;
			this.Cp.Text = "Copy to L/R";
			this.Cp.UseVisualStyleBackColor = true;
			this.Cp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cp_MouseDown);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1068, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(43, 22);
			this.toolStripButton1.Text = "Resize";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1068, 693);
			this.panel2.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 718);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.toolStrip1);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OperandB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OperandA)).EndInit();
			this.panel1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView Result;
		private System.Windows.Forms.DataGridView OperandB;
		private System.Windows.Forms.DataGridView OperandA;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Rank;
		private System.Windows.Forms.Button Mult;
		private System.Windows.Forms.Button Det;
		private System.Windows.Forms.Button Transpose;
		private System.Windows.Forms.Button Sub;
		private System.Windows.Forms.Button Cls;
		private System.Windows.Forms.Button Inverse;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Cp;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Panel panel2;
	}
}

