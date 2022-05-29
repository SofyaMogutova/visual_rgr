using Avalonia.Controls;
using RGR_Visual.ViewModels;
using RGR_Visual.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Subjects;

namespace RGR_Visual.Views
{
    public partial class MainWindow : Window
    {
        SQLRequestView editor;
        SQLRequestViewModel context;
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("ButtonDelete").Click += delegate
            {
                Delete();
            };
            this.FindControl<Button>("EditorBtn").Click += delegate
            {
                OpenEditor();
            };
            
            this.FindControl<Button>("test").Click += delegate
            {
                test1();
            };

        }
        
        public void Delete()
        {
            var context = this.DataContext as MainWindowViewModel;
            var tables = this.FindControl<TabControl>("Tables");
            int index = tables.SelectedIndex;
            switch (index)
            {
                case 0:
                    context.Db.Horses.Remove((Horse)this.FindControl<DataGrid>("Horses").SelectedItem);
                    break;
                case 1:
                    context.Db.Jockeys.Remove((Jockey)this.FindControl<DataGrid>("Jockeys").SelectedItem);
                    break;
                case 2:
                    context.Db.Trainers.Remove((Trainer)this.FindControl<DataGrid>("Trainers").SelectedItem);
                    break;
                case 3:
                    context.Db.Owners.Remove((Owner)this.FindControl<DataGrid>("Owners").SelectedItem);
                    break;
                case 4:
                    context.Db.Runs.Remove((Run)this.FindControl<DataGrid>("Runs").SelectedItem);
                    break;
                case 5:
                    context.Db.Racetracks.Remove((Racetrack)this.FindControl<DataGrid>("Racetracks").SelectedItem);
                    break;
                case 6:
                    context.Db.Results.Remove((Result)this.FindControl<DataGrid>("Results").SelectedItem);
                    break;
            }
        }
        public void OpenEditor()
        {
            var tmp = this.DataContext as MainWindowViewModel;
            context = new SQLRequestViewModel(tmp);
            editor = new SQLRequestView { DataContext = context };
            editor.Show();
        }
        public void CreateGrid(TabItemModel tab, List<List<string>> test)
        {
            var context = this.DataContext as MainWindowViewModel;
            DataGrid grid = new DataGrid();
            foreach (string header in tab.DataGridHeaders)
            {
                var column = new DataGridTextColumn();
                column.Header = header;
                grid.Columns.Add(column);
            }
            Tab item = new Tab();
            item.Header = tab.Header;
            item.Content = grid;
            context.Tabs.Add(item);
        }
        public void test1()
        {
            CreateGrid(new TabItemModel { Header = "aaa", DataGridHeaders = new List<string> { "test1", "test2" } }, new List<List<string>> { new List<string> { "test row 1", "test row 1" }, new List<string> { "test row 2", "test row 2" } });
        }
    }
}