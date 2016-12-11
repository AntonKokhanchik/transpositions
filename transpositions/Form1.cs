using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transpositions
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			try
			{
				lexicographyc();
				minChange();
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка, в поле нужно ввести число (лучше,если не больше 9)");
			}
		}


		private void lexicographyc()
		{
			textBoxLexOut.Clear();

			int[] tr = new int[Int32.Parse(textBoxNumber.Text)+1];

			for (int k = 0; k < tr.Length; k++)
				tr[k] = k;

			int i = 1;

			while(i!=0)
			{
				printTransposition(textBoxLexOut, tr, tr.Length-1);

				i = tr.Length-2;
				while (tr[i] >= tr[i + 1])
					i--;

				int j = tr.Length-1;
				while (tr[i] >= tr[j])
					j--;

				int tmp = tr[i];
				tr[i] = tr[j];
				tr[j] = tmp;

				int r = tr.Length - 1;
				int s = i + 1;

				while(s<= r)
				{
					tmp = tr[s];
					tr[s] = tr[r];
					tr[r] = tmp;
					r--;
					s++;
				}
			}
		}

		private void minChange()
		{
			textBoxMinOut.Clear();
			int n = Int32.Parse(textBoxNumber.Text);
			int[] tr = new int[n + 2]; // перестановка
			int[] direction = new int[tr.Length]; // направление движения элементов перестановки
			int[] ind = new int[tr.Length]; // индексы элементов перестановки

			for (int k = 1; k <= n; k++)
			{
				tr[k] = k;
				direction[k] = -1;
				ind[k] = k;
			}
			tr[0] = tr[n+1] = n+1;

			direction[1] = 0;

			int m = n;
			while (m != 1)
			{
				printTransposition(textBoxMinOut, tr, n);

				m = n;
				while (tr[ind[m] + direction[m]] > m)
				{
					direction[m] = -direction[m];
					m--;
				}

				// меняем перестановку
				int tmp = tr[ind[m]];  //tr[ind[m]] -  m в перестановке
				tr[ind[m]] = tr[ind[m] + direction[m]]; // tr[ind[m] + direction[m]] - соседний с m слева или справа в зависимости от направления в перестановке				tr[ind[m] + direction[m]] = tmp;
				tr[ind[m] + direction[m]] = tmp;

				// меняем обратную перестановку
				tmp = ind[tr[ind[m]]]; // ind[tr[ind[m]]] - индекс того, что встало на место m
				ind[tr[ind[m]]] = ind[m]; // индекс m
				ind[m] = tmp;
			}
		}

		private void printTransposition(TextBox outBox, int[] tr, int n)
		{
			for (int i = 1; i <= n; i++)
				outBox.AppendText(tr[i].ToString() + " ");
			outBox.AppendText("\n");
		}
	}
}
