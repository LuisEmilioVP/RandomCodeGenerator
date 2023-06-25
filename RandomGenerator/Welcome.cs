
namespace RandomGenerator
{
    public partial class Welcome : Form
    {
        public Welcome(string txtUser, string txtCod)
        {
            InitializeComponent();

            // Obtener usuario y código
            lblInfo.Text = $"Tu cógo de tarjeta sera: {txtCod} " + "\n" +
                $"y el usuario que solicito el mismo es: {txtUser}";
        }
    }
}
