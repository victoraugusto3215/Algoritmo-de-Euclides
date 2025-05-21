namespace AlgoritmoEstendidoEuclides
{
    partial class fm_euclides
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_euclides));
            btn_calcular = new Button();
            num_a = new NumericUpDown();
            num_b = new NumericUpDown();
            lbl_numa = new Label();
            lbl_numb = new Label();
            ltx_resultado = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)num_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_calcular.Image = Properties.Resources.btn_Calcular_2;
            btn_calcular.Location = new Point(38, 74);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(301, 27);
            btn_calcular.TabIndex = 2;
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // num_a
            // 
            num_a.Location = new Point(109, 16);
            num_a.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_a.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_a.Name = "num_a";
            num_a.Size = new Size(65, 23);
            num_a.TabIndex = 0;
            num_a.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // num_b
            // 
            num_b.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num_b.Location = new Point(109, 45);
            num_b.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_b.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_b.Name = "num_b";
            num_b.Size = new Size(65, 23);
            num_b.TabIndex = 1;
            num_b.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_numa
            // 
            lbl_numa.AutoSize = true;
            lbl_numa.Location = new Point(38, 20);
            lbl_numa.Name = "lbl_numa";
            lbl_numa.Size = new Size(65, 15);
            lbl_numa.TabIndex = 4;
            lbl_numa.Text = "Número A:";
            // 
            // lbl_numb
            // 
            lbl_numb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_numb.AutoSize = true;
            lbl_numb.Location = new Point(39, 49);
            lbl_numb.Name = "lbl_numb";
            lbl_numb.Size = new Size(64, 15);
            lbl_numb.TabIndex = 5;
            lbl_numb.Text = "Número B:";
            // 
            // ltx_resultado
            // 
            ltx_resultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ltx_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltx_resultado.FormattingEnabled = true;
            ltx_resultado.HorizontalScrollbar = true;
            ltx_resultado.ItemHeight = 32;
            ltx_resultado.Location = new Point(38, 109);
            ltx_resultado.Name = "ltx_resultado";
            ltx_resultado.SelectionMode = SelectionMode.None;
            ltx_resultado.Size = new Size(301, 292);
            ltx_resultado.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 64);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // fm_euclides
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(377, 416);
            Controls.Add(pictureBox1);
            Controls.Add(ltx_resultado);
            Controls.Add(lbl_numb);
            Controls.Add(lbl_numa);
            Controls.Add(num_b);
            Controls.Add(num_a);
            Controls.Add(btn_calcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(393, 455);
            Name = "fm_euclides";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algoritmo Estendido de Euclides";
            ((System.ComponentModel.ISupportInitialize)num_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_b).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_calcular;
        private NumericUpDown num_a;
        private NumericUpDown num_b;
        private Label lbl_numa;
        private Label lbl_numb;
        private ListBox ltx_resultado;
        private PictureBox pictureBox1;
    }
}
