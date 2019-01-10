using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.ViewModels;

namespace WPF
{
    public partial class MainWindow : Window
    {
        private PessoaViewModel _vm; 
        public MainWindow()
        {
            InitializeComponent();

            //Estou dizendo que o contexto da minha View é a Pessoa VieWModel
            _vm = new PessoaViewModel();
            this.DataContext = _vm;
        }
    }
}
