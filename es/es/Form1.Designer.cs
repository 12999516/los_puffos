namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbl_puffo = new System.Windows.Forms.TableLayoutPanel();
            this.btn_puffo_up = new System.Windows.Forms.Button();
            this.btn_puffo_left = new System.Windows.Forms.Button();
            this.btn_puffo_right = new System.Windows.Forms.Button();
            this.btn_puffo_down = new System.Windows.Forms.Button();
            this.tbl_garga = new System.Windows.Forms.TableLayoutPanel();
            this.btn_garga_up = new System.Windows.Forms.Button();
            this.btn_garga_left = new System.Windows.Forms.Button();
            this.btn_garga_down = new System.Windows.Forms.Button();
            this.btn_garga_right = new System.Windows.Forms.Button();
            this.pnl_campo = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pnl_puffo = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_garga_punti = new System.Windows.Forms.Label();
            this.lbl_puffo_punti = new System.Windows.Forms.Label();
            this.pnl_garga_img = new System.Windows.Forms.Panel();
            this.pnl_puffo_img = new System.Windows.Forms.Panel();
            this.tbl_puffo.SuspendLayout();
            this.tbl_garga.SuspendLayout();
            this.pnl_campo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_puffo
            // 
            this.tbl_puffo.ColumnCount = 3;
            this.tbl_puffo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_puffo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl_puffo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl_puffo.Controls.Add(this.btn_puffo_up, 1, 0);
            this.tbl_puffo.Controls.Add(this.btn_puffo_left, 0, 1);
            this.tbl_puffo.Controls.Add(this.btn_puffo_right, 2, 1);
            this.tbl_puffo.Controls.Add(this.btn_puffo_down, 1, 2);
            this.tbl_puffo.Location = new System.Drawing.Point(638, 288);
            this.tbl_puffo.Name = "tbl_puffo";
            this.tbl_puffo.RowCount = 3;
            this.tbl_puffo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_puffo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_puffo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_puffo.Size = new System.Drawing.Size(150, 150);
            this.tbl_puffo.TabIndex = 0;
            // 
            // btn_puffo_up
            // 
            this.btn_puffo_up.Location = new System.Drawing.Point(52, 3);
            this.btn_puffo_up.Name = "btn_puffo_up";
            this.btn_puffo_up.Size = new System.Drawing.Size(43, 43);
            this.btn_puffo_up.TabIndex = 8;
            this.btn_puffo_up.UseVisualStyleBackColor = true;
            this.btn_puffo_up.Click += new System.EventHandler(this.btn_puffo_up_Click);
            // 
            // btn_puffo_left
            // 
            this.btn_puffo_left.Location = new System.Drawing.Point(3, 52);
            this.btn_puffo_left.Name = "btn_puffo_left";
            this.btn_puffo_left.Size = new System.Drawing.Size(43, 43);
            this.btn_puffo_left.TabIndex = 5;
            this.btn_puffo_left.UseVisualStyleBackColor = true;
            this.btn_puffo_left.Click += new System.EventHandler(this.btn_puffo_left_Click);
            // 
            // btn_puffo_right
            // 
            this.btn_puffo_right.Location = new System.Drawing.Point(102, 52);
            this.btn_puffo_right.Name = "btn_puffo_right";
            this.btn_puffo_right.Size = new System.Drawing.Size(43, 43);
            this.btn_puffo_right.TabIndex = 7;
            this.btn_puffo_right.UseVisualStyleBackColor = true;
            this.btn_puffo_right.Click += new System.EventHandler(this.btn_puffo_right_Click);
            // 
            // btn_puffo_down
            // 
            this.btn_puffo_down.Location = new System.Drawing.Point(52, 101);
            this.btn_puffo_down.Name = "btn_puffo_down";
            this.btn_puffo_down.Size = new System.Drawing.Size(43, 43);
            this.btn_puffo_down.TabIndex = 6;
            this.btn_puffo_down.UseVisualStyleBackColor = true;
            this.btn_puffo_down.Click += new System.EventHandler(this.btn_puffo_down_Click);
            // 
            // tbl_garga
            // 
            this.tbl_garga.ColumnCount = 3;
            this.tbl_garga.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_garga.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_garga.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_garga.Controls.Add(this.btn_garga_up, 1, 0);
            this.tbl_garga.Controls.Add(this.btn_garga_left, 0, 1);
            this.tbl_garga.Controls.Add(this.btn_garga_down, 1, 2);
            this.tbl_garga.Controls.Add(this.btn_garga_right, 2, 1);
            this.tbl_garga.Location = new System.Drawing.Point(12, 288);
            this.tbl_garga.Name = "tbl_garga";
            this.tbl_garga.RowCount = 3;
            this.tbl_garga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_garga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_garga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_garga.Size = new System.Drawing.Size(150, 150);
            this.tbl_garga.TabIndex = 1;
            // 
            // btn_garga_up
            // 
            this.btn_garga_up.Location = new System.Drawing.Point(52, 3);
            this.btn_garga_up.Name = "btn_garga_up";
            this.btn_garga_up.Size = new System.Drawing.Size(43, 43);
            this.btn_garga_up.TabIndex = 0;
            this.btn_garga_up.UseVisualStyleBackColor = true;
            // 
            // btn_garga_left
            // 
            this.btn_garga_left.Location = new System.Drawing.Point(3, 52);
            this.btn_garga_left.Name = "btn_garga_left";
            this.btn_garga_left.Size = new System.Drawing.Size(43, 43);
            this.btn_garga_left.TabIndex = 1;
            this.btn_garga_left.UseVisualStyleBackColor = true;
            // 
            // btn_garga_down
            // 
            this.btn_garga_down.Location = new System.Drawing.Point(52, 101);
            this.btn_garga_down.Name = "btn_garga_down";
            this.btn_garga_down.Size = new System.Drawing.Size(43, 46);
            this.btn_garga_down.TabIndex = 3;
            this.btn_garga_down.UseVisualStyleBackColor = true;
            // 
            // btn_garga_right
            // 
            this.btn_garga_right.Location = new System.Drawing.Point(101, 52);
            this.btn_garga_right.Name = "btn_garga_right";
            this.btn_garga_right.Size = new System.Drawing.Size(46, 43);
            this.btn_garga_right.TabIndex = 4;
            this.btn_garga_right.UseVisualStyleBackColor = true;
            // 
            // pnl_campo
            // 
            this.pnl_campo.Controls.Add(this.panel14);
            this.pnl_campo.Controls.Add(this.pnl_puffo);
            this.pnl_campo.Controls.Add(this.panel13);
            this.pnl_campo.Controls.Add(this.panel11);
            this.pnl_campo.Controls.Add(this.panel10);
            this.pnl_campo.Controls.Add(this.panel7);
            this.pnl_campo.Controls.Add(this.panel8);
            this.pnl_campo.Controls.Add(this.panel9);
            this.pnl_campo.Controls.Add(this.panel6);
            this.pnl_campo.Controls.Add(this.panel4);
            this.pnl_campo.Controls.Add(this.panel5);
            this.pnl_campo.Controls.Add(this.panel3);
            this.pnl_campo.Controls.Add(this.panel2);
            this.pnl_campo.Controls.Add(this.panel1);
            this.pnl_campo.Location = new System.Drawing.Point(202, 12);
            this.pnl_campo.Name = "pnl_campo";
            this.pnl_campo.Size = new System.Drawing.Size(390, 390);
            this.pnl_campo.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(181, 150);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(30, 30);
            this.panel14.TabIndex = 4;
            // 
            // pnl_puffo
            // 
            this.pnl_puffo.BackColor = System.Drawing.Color.Blue;
            this.pnl_puffo.Location = new System.Drawing.Point(111, 150);
            this.pnl_puffo.Name = "pnl_puffo";
            this.pnl_puffo.Size = new System.Drawing.Size(30, 30);
            this.pnl_puffo.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Red;
            this.panel13.Location = new System.Drawing.Point(30, 150);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(30, 30);
            this.panel13.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(181, 150);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 0);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Green;
            this.panel10.Location = new System.Drawing.Point(181, 94);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 30);
            this.panel10.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(111, 94);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 30);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(217, 94);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 30);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Green;
            this.panel9.Location = new System.Drawing.Point(262, 94);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(30, 30);
            this.panel9.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(30, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 30);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(262, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(217, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 30);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(181, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(111, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(30, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 0;
            // 
            // lbl_garga_punti
            // 
            this.lbl_garga_punti.Location = new System.Drawing.Point(9, 200);
            this.lbl_garga_punti.Name = "lbl_garga_punti";
            this.lbl_garga_punti.Size = new System.Drawing.Size(150, 50);
            this.lbl_garga_punti.TabIndex = 3;
            // 
            // lbl_puffo_punti
            // 
            this.lbl_puffo_punti.Location = new System.Drawing.Point(638, 200);
            this.lbl_puffo_punti.Name = "lbl_puffo_punti";
            this.lbl_puffo_punti.Size = new System.Drawing.Size(150, 50);
            this.lbl_puffo_punti.TabIndex = 4;
            // 
            // pnl_garga_img
            // 
            this.pnl_garga_img.Location = new System.Drawing.Point(13, 35);
            this.pnl_garga_img.Name = "pnl_garga_img";
            this.pnl_garga_img.Size = new System.Drawing.Size(149, 133);
            this.pnl_garga_img.TabIndex = 5;
            // 
            // pnl_puffo_img
            // 
            this.pnl_puffo_img.Location = new System.Drawing.Point(638, 35);
            this.pnl_puffo_img.Name = "pnl_puffo_img";
            this.pnl_puffo_img.Size = new System.Drawing.Size(150, 133);
            this.pnl_puffo_img.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_puffo_img);
            this.Controls.Add(this.pnl_garga_img);
            this.Controls.Add(this.lbl_puffo_punti);
            this.Controls.Add(this.lbl_garga_punti);
            this.Controls.Add(this.pnl_campo);
            this.Controls.Add(this.tbl_garga);
            this.Controls.Add(this.tbl_puffo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbl_puffo.ResumeLayout(false);
            this.tbl_garga.ResumeLayout(false);
            this.pnl_campo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_puffo;
        private System.Windows.Forms.TableLayoutPanel tbl_garga;
        private System.Windows.Forms.Panel pnl_campo;
        private System.Windows.Forms.Label lbl_garga_punti;
        private System.Windows.Forms.Label lbl_puffo_punti;
        private System.Windows.Forms.Panel pnl_garga_img;
        private System.Windows.Forms.Panel pnl_puffo_img;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_puffo_down;
        private System.Windows.Forms.Button btn_puffo_left;
        private System.Windows.Forms.Button btn_garga_up;
        private System.Windows.Forms.Button btn_garga_left;
        private System.Windows.Forms.Button btn_garga_down;
        private System.Windows.Forms.Button btn_garga_right;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel pnl_puffo;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_puffo_up;
        private System.Windows.Forms.Button btn_puffo_right;
    }
}

