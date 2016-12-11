namespace transpositions
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
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.textBoxLexOut = new System.Windows.Forms.TextBox();
			this.textBoxMinOut = new System.Windows.Forms.TextBox();
			this.buttonRun = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Количество элементов в перестановке";
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(12, 25);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
			this.textBoxNumber.TabIndex = 1;
			// 
			// textBoxLexOut
			// 
			this.textBoxLexOut.Location = new System.Drawing.Point(12, 95);
			this.textBoxLexOut.Multiline = true;
			this.textBoxLexOut.Name = "textBoxLexOut";
			this.textBoxLexOut.ReadOnly = true;
			this.textBoxLexOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLexOut.Size = new System.Drawing.Size(120, 201);
			this.textBoxLexOut.TabIndex = 2;
			// 
			// textBoxMinOut
			// 
			this.textBoxMinOut.Location = new System.Drawing.Point(164, 95);
			this.textBoxMinOut.Multiline = true;
			this.textBoxMinOut.Name = "textBoxMinOut";
			this.textBoxMinOut.ReadOnly = true;
			this.textBoxMinOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxMinOut.Size = new System.Drawing.Size(123, 201);
			this.textBoxMinOut.TabIndex = 2;
			// 
			// buttonRun
			// 
			this.buttonRun.Location = new System.Drawing.Point(47, 51);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(190, 23);
			this.buttonRun.TabIndex = 3;
			this.buttonRun.Text = "Сгенерировать перестановки";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Лексикографически";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(152, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Минимальным изменением";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 305);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonRun);
			this.Controls.Add(this.textBoxMinOut);
			this.Controls.Add(this.textBoxLexOut);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Генератор перестановок";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.TextBox textBoxLexOut;
		private System.Windows.Forms.TextBox textBoxMinOut;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

