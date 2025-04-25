namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl1 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            txt1 = new TextBox();
            txt3 = new TextBox();
            lbl5 = new Label();
            txt4 = new TextBox();
            b1 = new Button();
            b2 = new Button();
            dataGridViewInventario = new DataGridView();
            cb1 = new ComboBox();
            lbl6 = new Label();
            lbl3 = new Label();
            txt5 = new TextBox();
            lbl7 = new Label();
            txt2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(12, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(365, 38);
            lbl1.TabIndex = 0;
            lbl1.Text = "Formulario para Jugadores";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(25, 47);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(94, 27);
            lbl2.TabIndex = 1;
            lbl2.Text = "Jugador:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.Yellow;
            lbl4.Location = new Point(12, 91);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(205, 27);
            lbl4.TabIndex = 3;
            lbl4.Text = "Cantidad de Bloques:";
            // 
            // txt1
            // 
            txt1.Font = new Font("Corbel", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt1.Location = new Point(125, 47);
            txt1.Name = "txt1";
            txt1.ReadOnly = true;
            txt1.Size = new Size(137, 26);
            txt1.TabIndex = 4;
            txt1.TextAlign = HorizontalAlignment.Center;
            // 
            // txt3
            // 
            txt3.Font = new Font("Corbel", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt3.Location = new Point(223, 95);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(231, 23);
            txt3.TabIndex = 6;
            txt3.TextAlign = HorizontalAlignment.Center;
            txt3.TextChanged += txt3_TextChanged;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = Color.Transparent;
            lbl5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.Cyan;
            lbl5.Location = new Point(386, 68);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(313, 27);
            lbl5.TabIndex = 7;
            lbl5.Text = "Ingrese ID del jugador a buscar";
            // 
            // txt4
            // 
            txt4.Font = new Font("Corbel", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt4.Location = new Point(521, 98);
            txt4.Name = "txt4";
            txt4.Size = new Size(49, 27);
            txt4.TabIndex = 8;
            txt4.TextAlign = HorizontalAlignment.Center;
            // 
            // b1
            // 
            b1.Image = (Image)resources.GetObject("b1.Image");
            b1.Location = new Point(461, 138);
            b1.Name = "b1";
            b1.Size = new Size(75, 23);
            b1.TabIndex = 9;
            b1.Text = "Buscar";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.BackgroundImage = (Image)resources.GetObject("b2.BackgroundImage");
            b2.Location = new Point(556, 138);
            b2.Name = "b2";
            b2.Size = new Size(75, 23);
            b2.TabIndex = 10;
            b2.Text = "Limpiar";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Location = new Point(25, 138);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.Size = new Size(421, 227);
            dataGridViewInventario.TabIndex = 11;
            dataGridViewInventario.CellContentClick += dataGridViewInventario_CellContentClick;
            // 
            // cb1
            // 
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Comun", "Raro", "Epico" });
            cb1.Location = new Point(521, 235);
            cb1.Name = "cb1";
            cb1.Size = new Size(121, 26);
            cb1.TabIndex = 12;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.BackColor = Color.Transparent;
            lbl6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.White;
            lbl6.Location = new Point(30, 115);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(89, 23);
            lbl6.TabIndex = 13;
            lbl6.Text = "Inventario";
            lbl6.Click += lbl6_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.Yellow;
            lbl3.Location = new Point(452, 210);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(256, 22);
            lbl3.TabIndex = 14;
            lbl3.Text = "Elija Rareza de bloques a buscar:";
            // 
            // txt5
            // 
            txt5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt5.Location = new Point(461, 277);
            txt5.Name = "txt5";
            txt5.ReadOnly = true;
            txt5.Size = new Size(247, 25);
            txt5.TabIndex = 15;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.BackColor = Color.Transparent;
            lbl7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.Lime;
            lbl7.Location = new Point(268, 46);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(65, 27);
            lbl7.TabIndex = 16;
            lbl7.Text = "Nivel:";
            // 
            // txt2
            // 
            txt2.Font = new Font("Corbel", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt2.Location = new Point(340, 49);
            txt2.Name = "txt2";
            txt2.Size = new Size(40, 26);
            txt2.TabIndex = 17;
            txt2.TextAlign = HorizontalAlignment.Center;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(711, 368);
            Controls.Add(txt2);
            Controls.Add(lbl7);
            Controls.Add(txt5);
            Controls.Add(lbl3);
            Controls.Add(lbl6);
            Controls.Add(cb1);
            Controls.Add(dataGridViewInventario);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(txt4);
            Controls.Add(lbl5);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(lbl4);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Gestion de Jugadores e Inventario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private TextBox txt1;
        private TextBox txt3;
        private Label lbl5;
        private TextBox txt4;
        private Button b1;
        private Button b2;
        private DataGridView dataGridViewInventario;
        private ComboBox cb1;
        private Label lbl6;
        private Label lbl3;
        private TextBox txt5;
        private Label lbl7;
        private TextBox txt2;
    }
}
