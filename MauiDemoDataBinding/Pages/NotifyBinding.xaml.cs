using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
    private Produto _produto = new Produto();

    public NotifyBinding()
    {
        InitializeComponent();
        _produto = new Produto
        {
            Nome = "IPhone 14",
            Preco = 1250.00m,
            Estoque = 5
        };

        BindingContext = _produto;
    }

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
        _produto.Nome = "Samsung Galaxy Fold5";
        _produto.Preco = 1500.00m;
        _produto.Estoque = 10;

        await DisplayAlert("Produto Atualizado", $"{_produto.Nome} - {_produto.Preco} - {_produto.Estoque}", "OK");
    }
}