namespace proyecto_Gato3D
{
    public partial class frmTablero : Form
    {
        int turno = 0;
        Button[,] botones = new Button[3, 9];

        public frmTablero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            for (int i = 0; i < 3; i++)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = new Size(300, 300);
                panel.Location = new Point(50 + (i * 300), 50 + (i * 300));
                panel.Name = "panel" + i;
                panel.BackColor = Color.Black;
                this.Controls.Add(panel);

                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 100);
                    btn.Name = "p" + i + "btn" + j;
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                    btn.Margin = new Padding(0);
                    btn.Font = new Font("Bauhaus 93", 40);
                    btn.Click += new EventHandler(this.Btn_Click);
                    panel.Controls.Add(btn);
                    botones[i, j] = btn;
                }
            }

            btnReiniciar = new Button();
            btnReiniciar.Size = new Size(100, 50);
            btnReiniciar.Location = new Point(50, 950);
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.Click += new EventHandler(this.btnReiniciar_Click);
            btnReiniciar.Visible = false;
            this.Controls.Add(btnReiniciar);

            this.FormClosing += new FormClosingEventHandler(this.frmTablero_FormClosing);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Validar(btn))
            {
                if (turno == 0)
                {
                    btn.Text = "O";
                    turno = 1;
                }
                else if (turno == 1)
                {
                    btn.Text = "X";
                    turno = 0;
                }

                if (VerificarGanador())
                {
                    MessageBox.Show("¡Tenemos un ganador!");
                    // Reiniciar el juego o realizar alguna acción
                }
            }
        }

        private bool Validar(Button btn)
        {
            return btn.Text == "" && btn.Name != "p1btn4";
        }

        private bool VerificarGanador()
        {
            int[][] combinacionesGanadoras = new int[][]
            {
                new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 },
                new int[] { 9, 10, 11 }, new int[] { 9, 12, 15 }, new int[] { 11, 14, 17 },
                new int[] { 15, 16, 17 }, new int[] { 18, 19, 20 }, new int[] { 21, 22, 23 },
                new int[] { 18, 22, 26 }, new int[] { 19, 22, 25 }, new int[] { 20, 23, 26 },
                new int[] { 18, 22, 26 }, new int[] { 24, 22, 20 },
                new int[] { 0, 10, 20 }, new int[] { 0, 12, 24 }, new int[] { 2, 14, 26 },
                new int[] { 6, 16, 26 }
            };

            foreach (var combinacion in combinacionesGanadoras)
            {
                if (botones[combinacion[0] / 9, combinacion[0] % 9].Text != "" &&
                    botones[combinacion[0] / 9, combinacion[0] % 9].Text == botones[combinacion[1] / 9, combinacion[1] % 9].Text &&
                    botones[combinacion[1] / 9, combinacion[1] % 9].Text == botones[combinacion[2] / 9, combinacion[2] % 9].Text)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            Form menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void frmTablero_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    botones[i, j].Text = "";
                }
            }
            turno = 0;
            btnReiniciar.Visible = false;
        }
    }
}
