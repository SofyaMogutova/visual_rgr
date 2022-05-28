using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RGR_Visual.Views
{
    public partial class SQLRequestView : Window
    {
        public SQLRequestView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
