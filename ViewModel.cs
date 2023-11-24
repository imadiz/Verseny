using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Verseny.Models;

namespace Verseny
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private BackGroundModel _model { get; set; } = new BackGroundModel();
        public BackGroundModel Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand<OneGame> _addBet;
        public ICommand AddBet
        {
            get
            {
                _addBet = new RelayCommand<OneGame>((game) =>
                {
                    if (Model.Pending.Events.Count != 0 || Model.Pending.NameOfSubjects.Count == 0 || Model.Pending.Name == "" || Model.Pending.Organizer == "")
                    {
                        MessageBox.Show("Töltsd ki mindegyik bemeneti adatot!", "Fogadó", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Model.AllGames.Add(Model.Pending);
                        Model.Pending = new OneGame();
                    }
                });
                return _addBet;
            }
        }

        private RelayCommand<string> _addparticipant;
        public ICommand AddParticipant
        {
            get
            {
                _addparticipant = new RelayCommand<string>((name) =>
                {
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Adj meg egy nevet!", "Fogadó", MessageBoxButton.OK);
                    }
                    else if (Model.Pending.NameOfSubjects.Contains(name))
                    {
                        MessageBox.Show("Már van ilyen alany a fogadásban!", "Fogadó", MessageBoxButton.OK);
                    }
                    else
                    {
                        Model.Pending.NameOfSubjects.Add(name);
                    }
                });
                return _addparticipant;
            }
        }

        private RelayCommand<string> _addevent;
        public ICommand AddEvent
        {
            get
            {
                _addevent = new RelayCommand<string>((name) =>
                {
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Adj meg egy eseményt!", "Fogadó", MessageBoxButton.OK);
                    }
                    if (Model.Pending.Events.Contains(name))
                    {
                        MessageBox.Show("Már van ilyen esemény a fogadásban!", "Fogadó", MessageBoxButton.OK);
                    }
                    else
                    {
                        Model.Pending.Events.Add(name);
                    }
                });
                return _addevent;
            }
        }
        public ViewModel()
        {
            Model.ReadGames();
        }
    }
}
