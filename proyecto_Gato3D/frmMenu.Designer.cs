namespace proyecto_Gato3D
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bntUvU = new Button();
            btnUvC = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Bauhaus 93", 50F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(658, 104);
            label1.TabIndex = 0;
            label1.Text = "Gato 3D";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntUvU
            // 
            bntUvU.BackColor = Color.Black;
            bntUvU.FlatStyle = FlatStyle.Flat;
            bntUvU.Font = new Font("Rockwell", 20F);
            bntUvU.ForeColor = Color.White;
            bntUvU.Location = new Point(362, 419);
            bntUvU.Name = "bntUvU";
            bntUvU.Size = new Size(308, 70);
            bntUvU.TabIndex = 1;
            bntUvU.Text = "User Vs User";
            bntUvU.UseVisualStyleBackColor = false;
            bntUvU.Click += bntUvU_Click;
            // 
            // btnUvC
            // 
            btnUvC.BackColor = Color.Black;
            btnUvC.FlatStyle = FlatStyle.Flat;
            btnUvC.Font = new Font("Rockwell", 20F);
            btnUvC.ForeColor = Color.White;
            btnUvC.Location = new Point(362, 495);
            btnUvC.Name = "btnUvC";
            btnUvC.Size = new Size(308, 70);
            btnUvC.TabIndex = 2;
            btnUvC.Text = "User Vs CPU";
            btnUvC.UseVisualStyleBackColor = false;
            btnUvC.Click += btnUvC_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Rockwell", 20F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(362, 571);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(308, 70);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(682, 653);
            Controls.Add(btnExit);
            Controls.Add(btnUvC);
            Controls.Add(bntUvU);
            Controls.Add(label1);
            Name = "frmMenu";
            Text = "Menú";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button bntUvU;
        private Button btnUvC;
        private Button btnExit;
    }
}