using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using RGR_Visual.Models;
using ReactiveUI;

namespace RGR_Visual.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public BDContext Db { get; }
        public MainWindowViewModel()
        {
            
            Db = new BDContext();
            Db.Horses.Load<Horse>();
            Horses = Db.Horses.Local.ToObservableCollection();
            Db.Jockeys.Load<Jockey>();
            Jockeys = Db.Jockeys.Local.ToObservableCollection();
            Db.Trainers.Load<Trainer>();
            Trainers = Db.Trainers.Local.ToObservableCollection();
            Db.Owners.Load<Owner>();
            Owners = Db.Owners.Local.ToObservableCollection();
            Db.Runs.Load<Run>();
            Runs = Db.Runs.Local.ToObservableCollection();
            Db.Racetracks.Load<Racetrack>();
            Racetracks = Db.Racetracks.Local.ToObservableCollection();
            Db.Results.Load<Result>();
            Results = Db.Results.Local.ToObservableCollection();
            Tabs = new ObservableCollection<Tab>();
        }
        public ObservableCollection<Tab> Tabs { get; }
        public ObservableCollection<Horse> Horses { get; }
        public ObservableCollection<Jockey> Jockeys { get; }
        public ObservableCollection<Trainer> Trainers { get; }
        public ObservableCollection<Owner> Owners { get; }
        public ObservableCollection<Run> Runs { get; }
        public ObservableCollection<Racetrack> Racetracks { get; }
        public ObservableCollection<Result> Results { get; }
        public List<List<object>> QueryList { get; set; }
        public void Save()
        {
            Db.SaveChanges();
        }
        
        public void AddRow(int index)
        {
                switch (index)
                {
                    case 0:
                        Db.Horses.Add(new Horse());
                        break;
                    case 1:
                        Db.Jockeys.Add(new Jockey());
                        break;
                    case 2:
                        Db.Trainers.Add(new Trainer());
                        break;
                    case 3:
                        Db.Owners.Add(new Owner());
                        break;
                    case 4:
                        Db.Runs.Add(new Run());
                        break;
                    case 5:
                        Db.Racetracks.Add(new Racetrack());
                        break;
                    case 6:
                        Db.Results.Add(new Result());
                        break;
                }
             
        }
        
    }
}
