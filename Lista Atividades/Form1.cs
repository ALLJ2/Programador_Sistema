namespace Lista_Atividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.Id > 0)
            {
                txtAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id}-{atividadeEmAndamento.Título}";
            }

            var AtividadesPendentes = atividade.ListarAtividadesPendentes();
            dgvAtividades.DataSource = atividadesPendentes;
        }
    }
}
