namespace proyecto_Gato3D
{
    public partial class frmTablero : Form
    {
        private bool _isCpuOpponent;
        int turno = 0;
        Button[,] botones = new Button[3, 9];

        public frmTablero(bool isCpuOpponent)
        {
            InitializeComponent();
            _isCpuOpponent = isCpuOpponent;
            this.FormClosing += new FormClosingEventHandler(this.frmMenu_FormClosing);
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarPanelesYBotones();
        }

        private void InicializarPanelesYBotones()
        {
            for (int i = 0; i < 3; i++)
            {
                FlowLayoutPanel panel = CrearPanel(i);
                this.Controls.Add(panel);

                for (int j = 0; j < 9; j++)
                {
                    Button btn = CrearBoton(i, j);
                    panel.Controls.Add(btn);
                    botones[i, j] = btn;
                }
            }
        }

        private FlowLayoutPanel CrearPanel(int index)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Size = new Size(300, 300),
                Location = new Point(50 + (index * 300), 50 + (index * 300)),
                Name = "panel" + index,
                BackColor = Color.Black
            };
            return panel;
        }

        private Button CrearBoton(int panelIndex, int botonIndex)
        {
            Button btn = new Button
            {
                Size = new Size(100, 100),
                Name = "p" + panelIndex + "btn" + botonIndex,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Margin = new Padding(0),
                Font = new Font("Bauhaus 93", 40)
            };
            btn.Click += new EventHandler(this.Btn_Click);
            return btn;
        }

        void reiniciar()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    botones[i, j].Text = "";
                }
            }
            turno = 0;
            lblTurno.Text = "O";
        }

        private bool Validar(Button btn)
        {
            return btn.Text == "" && btn.Name != "p1btn4";
        }

        private string VerificarGanador()
        {
            int[][] combinacionesGanadoras = new int[][]
            {
                    new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 },//horizontales1
                    new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 },//verticales1
                    new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 }, //diagonales1
                    new int[] { 9, 10, 11 }, new int[] { 15, 16, 17 },//horizontales2
                    new int[] { 9, 12, 15 }, new int[] { 11, 14, 17 },//verticales2
                    new int[] { 18, 19, 20 }, new int[] { 21, 22, 23 },new int[] { 24, 25, 26 },//horizontales3
                    new int[] { 18, 21, 24 }, new int[] { 19, 22, 25 },new int[] {20, 23, 26 },//verticales3
                    new int[] { 18, 22, 26 },new int[] { 20, 22, 24 },//diagonales3
                    new int[] { 0, 10, 20 },//horizontal1Especial
                    new int[] { 0, 12, 24 },//vertical1Especial
                    new int[] { 2, 14, 26 },//vertical2Especial
                    new int[] { 6, 16, 26 }//horizontal2Especial
            };

            foreach (var combinacion in combinacionesGanadoras)
            {
                if (botones[combinacion[0] / 9, combinacion[0] % 9].Text != "" &&
                    botones[combinacion[0] / 9, combinacion[0] % 9].Text == botones[combinacion[1] / 9, combinacion[1] % 9].Text &&
                    botones[combinacion[1] / 9, combinacion[1] % 9].Text == botones[combinacion[2] / 9, combinacion[2] % 9].Text)
                {
                    return botones[combinacion[0] / 9, combinacion[0] % 9].Text;
                }
            }

            bool tableroLleno = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (botones[i, j].Text == "")
                    {
                        tableroLleno = false;
                        break;
                    }
                }
                if (!tableroLleno) break;
            }

            return tableroLleno ? "Empate" : null;
        }

        private void MovimientoCpu()
        {
            // Lógica simple para que la CPU haga un movimiento aleatorio
            Random rand = new Random();
            int panelIndex, botonIndex;
            do
            {
                panelIndex = rand.Next(0, 3);
                botonIndex = rand.Next(0, 9);
            } while (!Validar(botones[panelIndex, botonIndex]));

            botones[panelIndex, botonIndex].Text = "O";
            lblTurno.Text = "X";
            turno = 1;

            string resultado = VerificarGanador();
            if (resultado == "O")
            {
                MessageBox.Show("¡Jugador 1 (O) ha ganado!");
                reiniciar();
            }
            else if (resultado == "X")
            {
                MessageBox.Show("¡Jugador 2 (X) ha ganado!");
                reiniciar();
            }
            else if (resultado == "Empate")
            {
                MessageBox.Show("¡Es un empate!");
                reiniciar();
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (Validar(btn))
            {
                if (turno == 0)
                {
                    btn.Text = "O";
                    lblTurno.Text = "X";
                    turno = 1;

                    string resultado = VerificarGanador();
                    if (resultado == "O")
                    {
                        MessageBox.Show("¡Jugador 1 (O) ha ganado!");
                        reiniciar();
                        return;
                    }
                    else if (resultado == "Empate")
                    {
                        MessageBox.Show("¡Es un empate!");
                        reiniciar();
                        return;
                    }
                }
                else if (turno == 1)
                {
                    btn.Text = "X";
                    lblTurno.Text = "O";
                    turno = 0;

                    string resultado = VerificarGanador();
                    if (resultado == "X")
                    {
                        MessageBox.Show("¡Jugador 2 (X) ha ganado!");
                        reiniciar();
                        return;
                    }
                    else if (resultado == "Empate")
                    {
                        MessageBox.Show("¡Es un empate!");
                        reiniciar();
                        return;
                    }

                    if (_isCpuOpponent)
                    {
                        MovimientoCpu();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            Form menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}