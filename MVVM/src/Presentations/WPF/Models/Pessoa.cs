using System.ComponentModel;

namespace WPF.Models
{
    //Queremos mapear a view com model
    //Para este precisamos ter um modo em que quando algo acontecer na view/ model
    //Algo seja disparado ou informado a ambos
    public class Pessoa : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));

        }

        private string _nome;
        public string Nome { get {

                return _nome;
            } set {
                //Toda vez que for mudado algo no meu modelo
                //devo informar para a view
                _nome = value;
                OnPropertyChange("Nome");
            }
        }

        private string _email;
        public string Email {
            get {
                return _email;
            } set {
                _email = value;
                OnPropertyChange("Email");
            }
        }
    }
}
