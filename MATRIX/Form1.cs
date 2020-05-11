using System;
using System.Drawing;
using Mapack;
using System.Windows.Forms;

namespace MATRIX {
	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
			OperandA.Init();
			OperandB.Init();
			Result.Init();
		}

		private void OperandA_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
			OperandA.RowFill();
			OperandB.RowFill();
			Result.RowFill();
		}

		private void OperandA_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
			OperandA.RowFill();
			OperandB.RowFill();
			Result.RowFill();
		}

		private void Cp_MouseDown(object sender, MouseEventArgs e) {
			switch(e.Button) {
				case MouseButtons.Left:
					OperandA.Rows.Clear();
					OperandA.Columns.Clear();
					OperandA.Init(Result.RowCount, Result.ColumnCount);
					for(int x = 0; x < Result.ColumnCount; x++) {
						for(int y = 0; y < Result.RowCount; y++) {
							OperandA[x, y].Value = Result[x, y].Value;
						}
					}
					break;
				case MouseButtons.Right:
					OperandB.Rows.Clear();
					OperandB.Columns.Clear();
					OperandB.Init(Result.RowCount, Result.ColumnCount);
					for(int x = 0; x < Result.ColumnCount; x++) {
						for(int y = 0; y < Result.RowCount; y++) {
							OperandB[x, y].Value = Result[x, y].Value;
						}
					}
					break;
			}
		}

		private void Cls_MouseDown(object sender, MouseEventArgs e) {
			switch(e.Button) {
				case MouseButtons.Left:
					OperandA.Rows.Clear();
					OperandA.Columns.Clear();
					OperandA.Init();
					break;
				case MouseButtons.Right:
					OperandB.Rows.Clear();
					OperandB.Columns.Clear();
					OperandB.Init();
					break;
			}
		}

		private void Det_MouseDown(object sender, MouseEventArgs e) {
			try {
				Matrix temp;
				double det = 0;
				switch(e.Button) {
					case MouseButtons.Left:
						temp = new Matrix(OperandA.ToDoubleArray());
						det = temp.Determinant;
						break;
					case MouseButtons.Right:
						temp = new Matrix(OperandB.ToDoubleArray());
						det = temp.Determinant;
						break;
				}
				Result.ToDisplay(det);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}
		}

		private void Add_MouseDown(object sender, MouseEventArgs e) {
			//try {
				Matrix L = new Matrix(OperandA.ToDoubleArray());
				Matrix R = new Matrix(OperandB.ToDoubleArray());
				Matrix res = new Matrix(1, 1);
				switch(e.Button) {
					case MouseButtons.Left:
						res = L + R;
						break;
					case MouseButtons.Right:
						res = R + L;
						break;
				}
				Result.ToDisplay(res);
			//}
			//catch(Exception A) {
			//	MessageBox.Show(A.Message);
			//}
		}

		private void Sub_MouseDown(object sender, MouseEventArgs e) {
			try {
				Matrix L = new Matrix(OperandA.ToDoubleArray());
				Matrix R = new Matrix(OperandB.ToDoubleArray());
				Matrix res = new Matrix(1, 1);
				switch(e.Button) {
					case MouseButtons.Left:
						res = L - R;
						break;
					case MouseButtons.Right:
						res = R - L;
						break;
				}
				Result.ToDisplay(res);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}
		}

		private void Mult_MouseDown(object sender, MouseEventArgs e) {
			try {
				Matrix L = new Matrix(OperandA.ToDoubleArray());
				Matrix R = new Matrix(OperandB.ToDoubleArray());
				Matrix res = new Matrix(1, 1);
				switch(e.Button) {
					case MouseButtons.Left:
						res = L * R;
						break;
					case MouseButtons.Right:
						res = R * L;
						break;
				}
				Result.ToDisplay(res);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}
		}

		private void Inverse_MouseDown(object sender, MouseEventArgs e) {
			try {
				Matrix temp = new Matrix(1, 1);
				switch(e.Button) {
					case MouseButtons.Left:
						temp = new Matrix(OperandA.ToDoubleArray());
						temp = temp.Inverse;
						break;
					case MouseButtons.Right:
						temp = new Matrix(OperandB.ToDoubleArray());
						temp = temp.Inverse;
						break;
				}
				Result.ToDisplay(temp);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}

		}

		private void Transpose_MouseDown(object sender, MouseEventArgs e) {
			try {
				Matrix temp = new Matrix(1, 1);
				switch(e.Button) {
					case MouseButtons.Left:
						temp = new Matrix(OperandA.ToDoubleArray());
						temp = temp.Transpose();
						break;
					case MouseButtons.Right:
						temp = new Matrix(OperandB.ToDoubleArray());
						temp = temp.Transpose();
						break;
				}
				Result.ToDisplay(temp);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}
		}

		private void Rank_MouseDown(object sender, MouseEventArgs e) {
			try {
				Matrix temp = new Matrix(1, 1);
				int r = 0;
				switch(e.Button) {
					case MouseButtons.Left:
						temp = new Matrix(OperandA.ToDoubleArray());
						r = temp.Rank();
						break;
					case MouseButtons.Right:
						temp = new Matrix(OperandB.ToDoubleArray());
						r = temp.Rank();
						break;
				}
				Result.ToDisplay(r);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}
		}

		private void OperandA_Resize(object sender, EventArgs e) {
			OperandA.RowFill();
			OperandB.RowFill();
			Result.RowFill();
		}

		private void toolStripButton1_Click(object sender, EventArgs e) {
			Form2 dialog = new Form2();
			if(dialog.ShowDialog() == DialogResult.OK) {
				if(dialog.LR.Checked) {
					OperandB.Rows.Clear();
					OperandB.Columns.Clear();
					OperandB.Init((int)dialog.row.Value, (int)dialog.colm.Value);
				}
				else {
					OperandA.Rows.Clear();
					OperandA.Columns.Clear();
					OperandA.Init((int)dialog.row.Value, (int)dialog.colm.Value);
				}
			}
		}
	}

	public static class DTVExtension {
		public static void RowFill(this DataGridView view) {
			foreach(DataGridViewRow row in view.Rows) {
				row.Height = view.Size.Height / view.Rows.Count;
			}
			view.Font = new Font(view.Font.FontFamily, 0.3f * view.Size.Height / (view.Rows.Count == 0 ? 1 : view.Rows.Count), FontStyle.Regular);
		}
		public static void Init(this DataGridView view, int r = 3, int c = 3) {
			for(int i = 0; i < c; i++) {
				view.Columns.Add("", "");
			}
			view.Rows.Add(r);
			for(int x = 0; x < view.ColumnCount; x++) {
				for(int y = 0; y < view.RowCount; y++) {
					view[x, y].Value = 0;
				}
			}
		}
		public static double[][] ToDoubleArray(this DataGridView view) {
			double[][] ret = new double[view.Rows.Count][];
			for(int x = 0; x < view.Rows.Count; x++) {
				ret[x] = new double[view.Columns.Count];
				for(int y = 0; y < view.Columns.Count; y++)
					if(!double.TryParse(view.Rows[x].Cells[y].Value.ToString(), out ret[x][y]))
						throw new Exception($"Isn't numeric value at [{x + 1},{y + 1}]");
			}

			return ret;
		}

		public static void ToDisplay(this DataGridView view, Matrix twoD) {
			view.Clear();

			int height = twoD.Rows;
			int width = twoD.Columns;

			view.ColumnCount = width;

			for(int r = 0; r < height; r++) {
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(view);

				for(int c = 0; c < width; c++) {
					row.Cells[c].Value = twoD[r, c].ToString();
				}

				view.Rows.Add(row);
			}
		}
		public static void ToDisplay(this DataGridView view, double arr) {
			view.Rows.Clear();
			view.Columns.Clear();
			view.Columns.Add("", "");
			view.Rows.Add(1);
			view[0, 0].Value = arr;
		}
		public static void Clear(this DataGridView view) {
			view.Rows.Clear();
			view.Columns.Clear();
		}
	}
	public static class Extension {
		public static int Rank(this Matrix m) {
			int rank = 0;
			bool haveZero = true;
			for(int workRow = 1; workRow < m.Rows; workRow++) {
				for(int otherRow = workRow; otherRow < m.Rows; otherRow++) {
					for(int colm = 0; colm < m.Columns; colm++) {
						m[otherRow, colm] *= -m[workRow - 1, workRow - 1] / m[otherRow, workRow - 1];
						m[otherRow, colm] += m[workRow - 1, colm];
					}
				}
			}
			for(int r = m.Rows - 1; r >= 0 && haveZero; r--) {
				for(int c = 0; c < m.Columns && haveZero; c++) {
					haveZero = m[r, c] == 0;
				}
				rank++;
			}
			return m.Rows - rank;

		}
	}
}

