using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verseny.Models
{
    public class BackGroundModel
    {
        ObservableCollection<OneGame> AllGames { get; set; } = new ObservableCollection<OneGame>();
        public void ReadGames(string filename)
        {
            
        }
    }
}
