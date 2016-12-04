using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheFootballer.ViewModel
{
    public class PlayerViewModel : NotificationBase<Data.ThePlayers>
    {
        public PlayerViewModel(Data.ThePlayers player = null) : base(player) { }

        public String Team
        {
            get { return This.team; }
            set { SetProperty(This.team, value, () => This.team = value); }
        }

        public String Founded
        {
            get { return This.founded; }
            set { SetProperty(This.founded, value, () => This.founded = value); }
        }

        public String Stadium
        {
            get { return This.stadium; }
            set { SetProperty(This.stadium, value, () => This.stadium = value); }
        }

        public String Stadium_Built
        {
            get { return This.stadium_built; }
            set { SetProperty(This.stadium_built, value, () => This.stadium_built = value); }
        }

        public String Image
        {
            get { return This.image; }
            set { SetProperty(This.image, value, () => This.image = value); }
        }

        public String Question
        {
            get { return This.question; }
            set { SetProperty(This.question, value, () => This.question = value); }
        }
    }
}
