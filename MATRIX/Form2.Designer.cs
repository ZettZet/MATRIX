namespace MATRIX {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.LR = new System.Windows.Forms.CheckBox();
			this.row = new System.Windows.Forms.NumericUpDown();
			this.colm = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Cancel = new System.Windows.Forms.Button();
			this.Resize = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colm)).BeginInit();
			this.SuspendLayout();
			// 
			// LR
			// 
			this.LR.Appearance = System.Windows.Forms.Appearance.Button;
			this.LR.AutoSize = true;
			this.LR.BackColor = System.Drawing.SystemColors.ControlDark;
			this.LR.FlatAppearance.BorderSize = 0;
			this.LR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LR.Location = new System.Drawing.Point(12, 12);
			this.LR.Name = "LR";
			this.LR.Size = new System.Drawing.Size(30, 34);
			this.LR.TabIndex = 0;
			this.LR.Text = "L";
			this.LR.UseVisualStyleBackColor = false;
			this.LR.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// row
			// 
			this.row.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.row.Location = new System.Drawing.Point(124, 63);
			this.row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.row.Name = "row";
			this.row.Size = new System.Drawing.Size(120, 22);
			this.row.TabIndex = 1;
			this.row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// colm
			// 
			this.colm.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.colm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.colm.Location = new System.Drawing.Point(124, 97);
			this.colm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.colm.Name = "colm";
			this.colm.Size = new System.Drawing.Size(120, 22);
			this.colm.TabIndex = 2;
			this.colm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "ROWS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "COLUMNS";
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Cancel.FlatAppearance.BorderSize = 0;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Location = new System.Drawing.Point(12, 132);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Resize
			// 
			this.Resize.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Resize.FlatAppearance.BorderSize = 0;
			this.Resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Resize.Location = new System.Drawing.Point(169, 132);
			this.Resize.Name = "Resize";
			this.Resize.Size = new System.Drawing.Size(75, 23);
			this.Resize.TabIndex = 6;
			this.Resize.Text = "Resize";
			this.Resize.UseVisualStyleBackColor = false;
			this.Resize.Click += new System.EventHandler(this.Resize_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 170);
			this.Controls.Add(this.Resize);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.colm);
			this.Controls.Add(this.row);
			this.Controls.Add(this.LR);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colm)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Resize;
		public System.Windows.Forms.CheckBox LR;
		public System.Windows.Forms.NumericUpDown row;
		public System.Windows.Forms.NumericUpDown colm;
	}
}