using ModelViewPresenter.Usuario.View;
using System;
using ModelViewPresenter.Usuario.ViewModel;
using System.Collections.Generic;
using ModelViewPresenter.Usuario.Presenter;

namespace WebForms
{
    public partial class CadastroUsuario 
        : System.Web.UI.Page,
        IUsuarioView
    {
        private UsuarioPresenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new UsuarioPresenter(this);
            _presenter.CarregarUsuarios();
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            //Se eu colocar toda a minha regra de adicionar usuario
            //Aqui, terei problemas se caso for reutilizar no windows forms
            var usuario = new UsuarioViewModel()
            {
                Email = txtEmail.Text,
                Nome = txtNome.Text,
                Id = Guid.NewGuid().ToString()

            };
            _presenter.AdicionarUsuario(usuario);
        }

        public void CarregarUsuario(List<UsuarioViewModel> vm)
        {
            rptUsuarios.DataSource = vm;
            rptUsuarios.DataBind();
        }
    }
}