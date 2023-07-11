namespace formsparcial1
{
    public partial class btnarea : Form
    {
        public btnarea()
        {
            InitializeComponent();
        }

        private void btnarea_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void texaltura_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtradio.Clear();
            txtaltura.Clear();
            txtradio.Focus();
        }


    }
}