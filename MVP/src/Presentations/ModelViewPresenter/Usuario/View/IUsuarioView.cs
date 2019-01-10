using ModelViewPresenter.Usuario.ViewModel;
using System.Collections.Generic;

namespace ModelViewPresenter.Usuario.View
{
    public interface IUsuarioView
    {
        //Vou carregar o repeater das views/ telas 
        //com o vm do método abaixo:
        void CarregarUsuario(List<UsuarioViewModel> vm);
    }
}
