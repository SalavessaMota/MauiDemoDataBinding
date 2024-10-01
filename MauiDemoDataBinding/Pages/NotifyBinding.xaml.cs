using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
	Produto produto = new Produto();

	public NotifyBinding()
	{
		InitializeComponent();
		produto = new Produto
		{
			Nome = "IPhone 14",
			Preco = 1250.00m,
			Estoque = 5
		};

		BindingContext = produto;

	}

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
		produto.Nome = "Samsung Galaxy Fold5";
		produto.Preco = 1500.00m;
		produto.Estoque = 10;

		await DisplayAlert("Produto Atualizado", $"{produto.Nome} - {produto.Preco} - {produto.Estoque}", "OK");

    }
}