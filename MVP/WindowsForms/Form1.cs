using ModelViewPresenter.Usuario.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewPresenter.Usuario.ViewModel;
using ModelViewPresenter.Usuario.Presenter;

namespace WindowsForms
{
    public partial class Form1 : Form,
        IUsuarioView
    {
        private UsuarioPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new UsuarioPresenter(this);
            _presenter.CarregarUsuarios();
        }

        public void CarregarUsuario(List<UsuarioViewModel> vm)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = vm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var usuario = new UsuarioViewModel()
            {
                Email = txtEmail.Text,
                Nome = txtNome.Text,
                Id = Guid.NewGuid().ToString()

            };
            _presenter.AdicionarUsuario(usuario);
        }
    }
}
