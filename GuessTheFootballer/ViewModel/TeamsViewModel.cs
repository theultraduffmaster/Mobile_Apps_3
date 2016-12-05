using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace GuessTheFootballer.ViewModel
{
    public class TeamsViewModel : NotificationBase
    {
        public List<ThePlayers> _AllPlayers = new List<ThePlayers>();
        //This might be lowercase
        Model.Players teams;

        public TeamsViewModel()
        {
            //Model.Players test = new Model.Players();

            //foreach (var player in test.Teams)
            //{
            // var np = new PlayerViewModel(player);
            // _player.Add(np);
            //}
            LoadData();
        }

        public async void LoadData()
        {
            _AllPlayers = await GuessTheFootballer.Model.Players.LoadData();
            foreach (var player in _AllPlayers)
            {
                var np = new PlayerViewModel(player);
                _player.Add(np);
            }
        }

        ObservableCollection<PlayerViewModel> _player
            = new ObservableCollection<PlayerViewModel>();

        public ObservableCollection<PlayerViewModel> Player
        {
            get { return _player; }
            set { SetProperty(ref _player, value); }
        }

        String _Name;
        public String Name
        {
            get { return teams.TeamName; }
        }

        int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                { RaisePropertyChanged(nameof(SelectedPlayer)); }

            }
        }

        public PlayerViewModel SelectedPlayer
        {
            get { return (_SelectedIndex >= 0) ? _player[_SelectedIndex] : null; }
        }
    }
}
