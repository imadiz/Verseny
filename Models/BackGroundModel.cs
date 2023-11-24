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
        public ObservableCollection<OneGame> AllGames { get; set; } = new ObservableCollection<OneGame>();
        public ObservableCollection<string> PendingParticipants { get; set; } = new ObservableCollection<string>();
        public OneGame Pending { get; set; } = new OneGame();
        public void ReadGames()
        {
            FileStream fs = new FileStream("jatekok.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            OneGame temp;
            while (!sr.EndOfStream)
            {
                string[] firstrow = sr.ReadLine().Trim().Split(';');
                temp = new OneGame(firstrow[0], firstrow[1], Convert.ToInt32(firstrow[2]), Convert.ToInt32(firstrow[3]));
                for (int i = 0; i < temp.NumberOfSubjects; i++)
                    temp.NameOfSubjects.Add(sr.ReadLine().Trim());

                for (int i = 0; i < temp.NumberOfEvents; i++)
                    temp.Events.Add(sr.ReadLine().Trim());

                AllGames.Add(temp);
            }
        }
    }
}
