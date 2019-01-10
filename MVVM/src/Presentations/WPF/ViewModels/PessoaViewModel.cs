using System.Collections.ObjectModel;
using System.ComponentModel;
using WPF.Commands;
using WPF.Models;

namespace WPF.ViewModels
{
    public class PessoaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }

        private Pessoa _pessoa;
        public Pessoa Pessoa { get {
                return _pessoa;
            } set {
                _pessoa = value;
                OnPropertyChange("Pessoa");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public SalvarPessoaCommand SalvarPessoaCommand { get; set; }

        public PessoaViewModel()
        {
            Pessoa = new Pessoa();
            Pessoas = new ObservableCollection<Pessoa>();
            SalvarPessoaCommand = new SalvarPessoaCommand(this.SalvarPessoa);
        }

        public void SalvarPessoa(Pessoa pessoa)
        {
            var pessoaLocal = new Pessoa()
            {
                Email = pessoa.Email,
                Nome = pessoa.Nome
            };

            this.Pessoas.Add(pessoaLocal);

            Pessoa = new Pessoa();
        }
    }
}
