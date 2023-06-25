namespace RandomGenerator
{
    public partial class Home : Form
    {
        private int[] numbers;
        private int[] randomNumbers;
        private string generatorPass;

        public Home()
        {
            InitializeComponent();

            btnGenerator.Focus();
            btnCancel.Enabled = false;

            // Generar n�meros del 1 al 1,000 y guardar en una array.
            numbers = Enumerable.Range(1, 1000).ToArray();

            // Generar un arreglo de 40 n�meros aleatorios partiendo del arreglo anterior
            Random random = new Random();
            randomNumbers = numbers.OrderBy(x => random.Next()).Take(40).ToArray();
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            /* Generar la contrase�a utilizando la posici�n en el 
             * arreglo de los cuarenta n�meros.
            */
            int[] selectNumber = randomNumbers.Take(3).ToArray();
            generatorPass = string.Join("", selectNumber);

            MessageBox.Show($"Si deseas este c�digo ingr�salo en el campo correspondiente " +
                $"en conjunto de tu nombre de usuario, por favor. {generatorPass}");

            // Mostrar la contrase�a generada en la etiqueta
            lblClave.Text = $"C�digo: {generatorPass}";
            btnCancel.Enabled = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Obtener la contrase�a ingresada por el usuario
            string passUsuario = txtClave.Text;

            if (txtUsuer.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Debe generar un C�digo para registrar su Tarjeta");
                btnGenerator.Focus();
            }
            else
            {
                // Verificar si la contrase�a ingresada coincide con la contrase�a generada
                if (passUsuario == generatorPass)
                {
                    MessageBox.Show("C�digo solicitago generado exitoso.");

                    this.Hide();

                    Welcome welcome = new Welcome(txtUsuer.Text, txtClave.Text);
                    welcome.Show();
                }
                else
                {
                    MessageBox.Show("C�digo incorrecta. Int�ntelo de nuevo.");
                    txtClave.Text = "";
                    txtClave.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblClave.Text = string.Empty;
            txtUsuer.Text = string.Empty;
            txtClave.Text= string.Empty;
        }
    }
}