namespace proyecto_Gato3D
{
    partial class frmTablero
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
            bntMenu = new Button();
            btnExit = new Button();
            btnReiniciar = new Button();
            label1 = new Label();
            lblTurno = new Label();
            SuspendLayout();
            // 
            // bntMenu
            // 
            bntMenu.BackColor = Color.Black;
            bntMenu.FlatStyle = FlatStyle.Flat;
            bntMenu.Font = new Font("Rockwell", 20F);
            bntMenu.ForeColor = Color.White;
            bntMenu.Location = new Point(11, 818);
            bntMenu.Name = "bntMenu";
            bntMenu.Size = new Size(309, 69);
            bntMenu.TabIndex = 2;
            bntMenu.Text = "Menu";
            bntMenu.UseVisualStyleBackColor = false;
            bntMenu.Click += bntMenu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Rockwell", 20F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(11, 893);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(309, 69);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Black;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Rockwell", 20F);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(11, 743);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(309, 69);
            btnReiniciar.TabIndex = 4;
            btnReiniciar.Text = "Restart";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(870, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 5;
            label1.Text = "Turno";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Bauhaus 93", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurno.ForeColor = Color.White;
            lblTurno.Location = new Point(884, 77);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(82, 76);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "O";
            // 
            // frmTablero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1032, 1003);
            Controls.Add(lblTurno);
            Controls.Add(label1);
            Controls.Add(btnReiniciar);
            Controls.Add(btnExit);
            Controls.Add(bntMenu);
            Name = "frmTablero";
            Text = "Gato 3D";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntMenu;
        private Button btnExit;
        private Button btnReiniciar;
        private Label label1;
        private Label lblTurno;
    }
}
