using Xamarin.Forms;

namespace Laut.Views
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
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