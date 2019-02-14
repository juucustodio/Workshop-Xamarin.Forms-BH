using Demo.Models;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Command SaveCommand { get; set; }


        public Pessoa Pessoa
        {
            get { return _pessoa; }
            set { SetProperty(ref _pessoa, value); }
        }
        Pessoa _pessoa = new Pessoa();


        public string Resultado
        {
            get { return _resultado; }
            set { SetProperty(ref _resultado, value); }
        }
        string _resultado = string.Empty;


        public HomeViewModel()
        {
            SaveCommand = new Command(ExecuteSaveCommand);

        }

        public void ExecuteSaveCommand()
        {
            Resultado = Pessoa.Nome;
        }
        

    }
}
