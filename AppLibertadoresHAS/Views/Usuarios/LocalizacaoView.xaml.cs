using AppLibertadoresHAS.ViewModels;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System;
using System.Collections.Generic;
using System.Text;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace AppLibertadoresHAS.Views.Usuarios;

public partial class LocalizacaoView : ContentPage
{
	LocalizacaoViewModel viewModel;
	public LocalizacaoView()
	{
		InitializeComponent();

		viewModel = new LocalizacaoViewModel();
		//viewModel.InicializarMapa();
		viewModel.ChecarLocalizacao();
		viewModel.ExibirUsuariosNoMapa();

		BindingContext = viewModel;
	}
}