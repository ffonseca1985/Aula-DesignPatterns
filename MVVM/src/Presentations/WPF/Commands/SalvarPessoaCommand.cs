using System;
using System.Windows.Input;
using WPF.Models;

namespace WPF.Commands
{
    //Existem frameworks como o MVVM ligth que facilita o uso do pattern MVVM
    public class SalvarPessoaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<Pessoa> _executeMethod;

        public SalvarPessoaCommand(Action<Pessoa> executeMethod)
        {
            _executeMethod = executeMethod;
        }
        //Isto é usado bastante em paralelismo
        public bool CanExecute(object parameter)
        {
            return true;
        }
        //é o evento do command
        public void Execute(object parameter)
        {
            _executeMethod.Invoke((Pessoa)parameter);
        }
    }
}
