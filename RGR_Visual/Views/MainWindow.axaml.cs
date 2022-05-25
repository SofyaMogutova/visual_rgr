using Avalonia.Controls;
using RGR_Visual.ViewModels;
using RGR_Visual.Models;

namespace RGR_Visual.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("DeleteBtn").Click += delegate
            {
                Delete();
            };
        }
        public void Delete()
        {
            var context = new MainWindowViewModel();
            var tables = this.FindControl<TabControl>("Tables");
            int index = tables.SelectedIndex;
            switch (index)
            {
                case 0:
                    context.Db.Horses.Remove((Horse)this.FindControl<DataGrid>("Horses").SelectedItem);
                    break;
                case 1:
                    context.Db.Trainers.Remove((Trainer)this.FindControl<DataGrid>("Trainers").SelectedItem);
                    break;
                case 2:
                    context.Db.Jockeys.Remove((Jockey)this.FindControl<DataGrid>("Jockeys").SelectedItem);
                    break;
                case 3:
                    context.Db.Owners.Remove((Owner)this.FindControl<DataGrid>("Owners").SelectedItem);
                    break;
                case 4:
                    context.Db.Runs.Remove((Run)this.FindControl<DataGrid>("Races").SelectedItem);
                    break;
                case 5:
                    context.Db.Results.Remove((Result)this.FindControl<DataGrid>("Results").SelectedItem);
                    break;
                case 6:
                    context.Db.Racetracks.Remove((Racetrack)this.FindControl<DataGrid>("Racecourses").SelectedItem);
                    break;
            }
        }
    }
}