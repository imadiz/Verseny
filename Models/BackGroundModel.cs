using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Verseny.Models
{
    public class BackGroundModel
    {
        ObservableCollection<OneGame> AllGames { get; set; } = new ObservableCollection<OneGame>();
        public void ReadGames(string filename)
        {
            StreamReader reader = new StreamReader("jatekok.txt");

        }
    }
}
