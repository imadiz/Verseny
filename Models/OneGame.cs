using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Verseny.Models
{
    public class OneGame : INotifyPropertyChanged
    {
        private string _organizer;
        public string Organizer
        {
            get => _organizer;
            set
            {
                _organizer = value;
                OnPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private int _numberofsubjects;
        public int NumberOfSubjects
        {
            get=> _numberofsubjects;
            set
            {
                _numberofsubjects = value;
                OnPropertyChanged();
            }
        }

        private int _numberofEvents;
        public int NumberOfEvents
        {
            get => _numberofEvents;
            set
            {
                _numberofEvents = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _nameofsubjects = new ObservableCollection<string>();
        public ObservableCollection<string> NameOfSubjects
        {
            get => _nameofsubjects;
            set
            {
                _nameofsubjects = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _events = new ObservableCollection<string>();
        public ObservableCollection<string> Events
        {
            get => _events;
            set
            {
                _events = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public OneGame(string organizer, string gamename, int numberofsubjects, int numberofevents)
        {
            Organizer = organizer;
            Name = gamename;
            NumberOfSubjects = numberofsubjects;
            NumberOfEvents = numberofevents;
        }
    }
}
