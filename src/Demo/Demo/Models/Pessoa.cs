using System;
namespace Demo.Models
{
    public class Pessoa : BaseModel
    {
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }
        string _nome = string.Empty;
    }
}
