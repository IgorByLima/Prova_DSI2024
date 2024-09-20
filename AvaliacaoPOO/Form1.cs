namespace AvaliacaoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsCurso objcurso = new clsCurso();
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                objcurso.Curso = cbbcurso.Text;
                objcurso.sigla = txtSigla.Text;
                objcurso.nivel = cboNivel.Text;
                objcurso.periodo = txtPeríodo.Text;
            }
            catch (ArgumentException ex) {MessageBox.Show(ex.Message); }

            catch(FormatException ex) { MessageBox.Show(ex.Message); }



            // para recuperar a informacao do combobox e armazenar na propriedade

            // objeto. ___________ = $"{nomeCombobox.SelectedItem}";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objcurso.buscarRegistro();
        }
    }
}
