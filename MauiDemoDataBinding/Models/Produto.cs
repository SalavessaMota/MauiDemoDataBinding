using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoDataBinding.Models
{
    internal class Produto : INotifyPropertyChanged
    {
        private string _nome;
        private decimal _preco;
        private int _estoque;

        public string Nome 
        { 
            get => _nome; 
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
            
        }

        public decimal Preco 
        { 
            get => _preco; 
            set
            {
                _preco = value;
                OnPropertyChanged();
            } 
        }

        public int Estoque 
        { 
            get => _estoque; 
            set
            {
                _estoque = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
