namespace Game3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> rutaOrdenadas = new List<string>();
        List<string> movimientos = new List<string>();
        List<int> numbers = new List<int>([0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]);
        List<int> randomNumbers = new List<int>();
        int coincidencias = 0;


        public Form1()
        {
            InitializeComponent();
            chargeList();
            //movimientos = rutaOrdenadas;
            Shuffle(random);
            randomImages();
            chargeGame();
            originalPictureBox.ImageLocation = @"C:\Source\Game3\Game3\img\original.jpg";




        }
        public void chargeList()
        {
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\00.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\10.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\20.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\30.jpg");

            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\01.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\11.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\21.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\31.jpg");

            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\02.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\12.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\22.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\32.jpg");

            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\03.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\13.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\23.jpg");
            rutaOrdenadas.Add(@"C:\Source\Game3\Game3\img\Final.jpg");

        }
        public void chargeGame()
        {
            pic0.ImageLocation = movimientos[0];
            pic1.ImageLocation = movimientos[1];
            pic2.ImageLocation = movimientos[2];
            pic3.ImageLocation = movimientos[3];

            pic4.ImageLocation = movimientos[4];
            pic5.ImageLocation = movimientos[5];
            pic6.ImageLocation = movimientos[6];
            pic7.ImageLocation = movimientos[7];

            pic8.ImageLocation = movimientos[8];
            pic9.ImageLocation = movimientos[9];
            pic10.ImageLocation = movimientos[10];
            pic11.ImageLocation = movimientos[11];

            pic12.ImageLocation = movimientos[12];
            pic13.ImageLocation = movimientos[13];
            pic14.ImageLocation = movimientos[14];
            pic15.ImageLocation = movimientos[15];

        }

        private void pic0_Click(object sender, EventArgs e)
        {
            //Arriba
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[0];
                movimientos[0] = temporal;
                chargeGame();
            }

            //Abajo
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }

            //Izquierda
            if (movimientos[1] == rutaOrdenadas[15])
            {
                var temporal = movimientos[1];
                movimientos[1] = movimientos[0];
                movimientos[0] = temporal;
                chargeGame();
            }



        }

        private void pic1_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[1];
                movimientos[1] = temporal;
                chargeGame();
            }

            //Derecha
            if (movimientos[0] == rutaOrdenadas[15])
            {
                var temporal = movimientos[0];
                movimientos[0] = movimientos[1];
                movimientos[1] = temporal;
                chargeGame();
            }

            //Izquierda
            if (movimientos[2] == rutaOrdenadas[15])
            {
                var temporal = movimientos[2];
                movimientos[2] = movimientos[1];
                movimientos[1] = temporal;
                chargeGame();
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[1] == rutaOrdenadas[15])
            {
                var temporal = movimientos[1];
                movimientos[1] = movimientos[2];
                movimientos[2] = temporal;
                chargeGame();
            }

            //Izquierda
            if (movimientos[3] == rutaOrdenadas[15])
            {
                var temporal = movimientos[3];
                movimientos[3] = movimientos[2];
                movimientos[2] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[2];
                movimientos[2] = temporal;
                chargeGame();
            }

        }
        private void pic3_Click(object sender, EventArgs e)
        {

            //Derecha
            if (movimientos[2] == rutaOrdenadas[15])
            {
                var temporal = movimientos[2];
                movimientos[2] = movimientos[3];
                movimientos[3] = temporal;
                chargeGame();
            }

            //Arriba
            if (movimientos[7] == rutaOrdenadas[15])
            {
                var temporal = movimientos[7];
                movimientos[7] = movimientos[3];
                movimientos[3] = temporal;
                chargeGame();
            }
        }
        private void pic4_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[0] == rutaOrdenadas[15])
            {
                var temporal = movimientos[0];
                movimientos[0] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }

            //Derecha
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[4];
                movimientos[4] = temporal;
                chargeGame();
            }

        }

        private void pic5_Click_1(object sender, EventArgs e)
        {
            //Arriba
            if (movimientos[1] == rutaOrdenadas[15])
            {
                var temporal = movimientos[1];
                movimientos[1] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }

            //Derecha
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[5];
                movimientos[5] = temporal;
                chargeGame();
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[7] == rutaOrdenadas[15])
            {
                var temporal = movimientos[7];
                movimientos[7] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[10] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }

            //Arriba
            if (movimientos[2] == rutaOrdenadas[15])
            {
                var temporal = movimientos[2];
                movimientos[2] = movimientos[6];
                movimientos[6] = temporal;
                chargeGame();
            }

        }

        private void pic7_Click(object sender, EventArgs e)
        {
            //Derecha
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[7];
                movimientos[7] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[11] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[7];
                movimientos[7] = temporal;
                chargeGame();
            }

            //Abajo
            if (movimientos[3] == rutaOrdenadas[15])
            {
                var temporal = movimientos[3];
                movimientos[3] = movimientos[7];
                movimientos[7] = temporal;
                chargeGame();
            }



        }
        private void pic8_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[4] == rutaOrdenadas[15])
            {
                var temporal = movimientos[4];
                movimientos[4] = movimientos[8];
                movimientos[8] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[12] == rutaOrdenadas[15])
            {
                var temporal = movimientos[12];
                movimientos[12] = movimientos[8];
                movimientos[8] = temporal;
                chargeGame();
            }

            //Izquierda
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[8];
                movimientos[8] = temporal;
                chargeGame();
            }

        }

        private void pic9_Click(object sender, EventArgs e)
        {
            //Abajo
            if (movimientos[13] == rutaOrdenadas[15])
            {
                var temporal = movimientos[13];
                movimientos[13] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[5] == rutaOrdenadas[15])
            {
                var temporal = movimientos[5];
                movimientos[5] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
            //Derecha
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[10] = movimientos[9];
                movimientos[9] = temporal;
                chargeGame();
            }

        }
        private void pic10_Click(object sender, EventArgs e)
        {

            //Abajo
            if (movimientos[14] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }

            //Derecha
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }

            //Izquierda

            if (movimientos[11] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }

            //Arriba
            if (movimientos[6] == rutaOrdenadas[15])
            {
                var temporal = movimientos[6];
                movimientos[6] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }



        }

        private void pic11_Click(object sender, EventArgs e)
        {
            //Ariba
            if (movimientos[15] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[15];
                movimientos[15] = temporal;
                chargeGame();
            }
            //Abajo
            if (movimientos[7] == rutaOrdenadas[15])
            {
                var temporal = movimientos[7];
                movimientos[7] = movimientos[11];
                movimientos[11] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[10];
                movimientos[10] = temporal;
                chargeGame();
            }






        }
        private void pic12_Click(object sender, EventArgs e)
        {
            //derecha
            if (movimientos[13] == rutaOrdenadas[15])
            {
                var temporal = movimientos[13];
                movimientos[13] = movimientos[12];
                movimientos[12] = temporal;
                chargeGame();
            }
            //Izquierda

            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[11] = movimientos[10];
                movimientos[11] = temporal;
                chargeGame();
            }

            //Abajo
            if (movimientos[8] == rutaOrdenadas[15])
            {
                var temporal = movimientos[8];
                movimientos[8] = movimientos[12];
                movimientos[12] = temporal;
                chargeGame();
            }

        }
        private void pic13_Click(object sender, EventArgs e)
        {
            //Arriba
            if (movimientos[9] == rutaOrdenadas[15])
            {
                var temporal = movimientos[9];
                movimientos[9] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }

            //Derecha
            if (movimientos[14] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[12] == rutaOrdenadas[15])
            {
                var temporal = movimientos[12];
                movimientos[12] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }

        }
        private void pic14_Click(object sender, EventArgs e)
        {
            //derecha
            if (movimientos[13] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[13];
                movimientos[13] = temporal;
                chargeGame();
            }
            //Izquierda
            if (movimientos[15] == rutaOrdenadas[15])
            {
                var temporal = movimientos[15];
                movimientos[15] = movimientos[14];
                movimientos[14] = temporal;
                chargeGame();
            }

            //Arriba
            if (movimientos[10] == rutaOrdenadas[15])
            {
                var temporal = movimientos[10];
                movimientos[10] = movimientos[14];
                movimientos[14] = temporal;
                chargeGame();
            }


        }
        private void pic15_Click(object sender, EventArgs e)
        {
            //Izquieda
            if (movimientos[14] == rutaOrdenadas[15])
            {
                var temporal = movimientos[14];
                movimientos[14] = movimientos[15];
                movimientos[15] = temporal;
                chargeGame();
            }
            //Arriba
            if (movimientos[11] == rutaOrdenadas[15])
            {
                var temporal = movimientos[11];
                movimientos[11] = movimientos[15];
                movimientos[15] = temporal;
                chargeGame();
            }


        }



        public void randomImages()
        {
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                var pos = randomNumbers[i];
                movimientos.Add(rutaOrdenadas[pos]);

            }
            movimientos.Add(rutaOrdenadas[15]);


        }

        void Shuffle(Random random)
        {
            randomNumbers = numbers.OrderBy(x => random.Next()).ToList();
        }

        public void endGame()
        {

            for (int i = 0; rutaOrdenadas.Count > 0; i++)
            {
                if (movimientos[i] == rutaOrdenadas[i])
                {
                    coincidencias = coincidencias++;
                    if (coincidencias==15)
                    {
                        MessageBox.Show("Ha Ganado!!!!", "Felicitaciones");
                    }
                }

            }

        }
    }
}
