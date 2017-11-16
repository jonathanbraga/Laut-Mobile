using Xamarin.Forms;

namespace Laut.Views
{
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
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
