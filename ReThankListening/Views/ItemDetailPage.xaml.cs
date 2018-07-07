using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ReThankListening.Models;
using ReThankListening.ViewModels;

namespace ReThankListening.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                tempURIspot = "URL here"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private void SetType_DirectDownload(object sender, EventArgs e)
        {
            viewModel.Item.Source = new Location
            {
                URL = new Uri(viewModel.Item.tempURIspot)
            };
        }

        private void SetType_Local(object sender, EventArgs e)
        {

        }
    }
}