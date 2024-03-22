using proyecto.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace proyecto.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}