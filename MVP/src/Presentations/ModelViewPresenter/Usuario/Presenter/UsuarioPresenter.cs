using ModelViewPresenter.Usuario.View;
using ModelViewPresenter.Usuario.ViewModel;
using System.Collections.Generic;

namespace ModelViewPresenter.Usuario.Presenter
{
    //Esta classe é o controlador
    //Responsavel por ligar o model a View
    public class UsuarioPresenter
    {
        private IUsuarioView _view;

        //Dados Fakes
        public static List<UsuarioViewModel> _usuarios;

        public UsuarioPresenter(IUsuarioView view)
        {
            this._view = view;

            if (_usuarios == null)
                _usuarios = new List<UsuarioViewModel>();
        }

        public void CarregarUsuarios() {

            this._view.CarregarUsuario(_usuarios);
        }

        public void RemoverUsuario(UsuarioViewModel usuario)
        {
            _usuarios.Remove(usuario);
            CarregarUsuarios();
        }

        public void AdicionarUsuario(UsuarioViewModel usuario)
        {
            _usuarios.Add(usuario);
            CarregarUsuarios();
        }
    }
    
}
