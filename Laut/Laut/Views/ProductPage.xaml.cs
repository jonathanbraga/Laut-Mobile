using Xamarin.Forms;

namespace Laut.Views
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void ItemSelectedColorBackground(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            ((ListView)sender).SelectedItem = null;
        }
    }
}
