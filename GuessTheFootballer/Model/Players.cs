using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Data.Json;
using Windows.Storage;
using Data;

namespace GuessTheFootballer.Model
{
    class Players
    {
        public List<ThePlayers> Teams { get; set; }
        public static List<ThePlayers> fTeamsList = new List<ThePlayers>();
        public String TeamName { get; set; }

        public Players()
        {
            LoadData();
            Teams = fTeamsList;
        }

        public static async Task LoadData()
        {
            await LoadLocalData();
        }

        public static async Task LoadLocalData()
        {
            var file = await Package.Current.InstalledLocation.GetFileAsync("Data\\Teams.txt");
            var result = await FileIO.ReadTextAsync(file);

            var sTeamsList = JsonArray.Parse(result);
            CreateTeamsList(sTeamsList);
        }

        private static void CreateTeamsList(JsonArray sTeamsList)
        {
            foreach (var item in sTeamsList)
            {
                var OneTeam = item.GetObject();
                ThePlayers dTeam = new ThePlayers();

                foreach (var key in OneTeam.Keys)
                {
                    IJsonValue value;
                    if (!OneTeam.TryGetValue(key, out value))
                        continue;

                    switch (key)
                    {
                        case "team":
                            dTeam.team = value.GetString();
                            break;
                        case "founded":
                            dTeam.founded = value.GetString();
                            break;
                        case "stadium":
                            dTeam.stadium = value.GetString();
                            break;
                        case "stadium built":
                            dTeam.stadium_built = value.GetString();
                            break;
                        case "image":
                            dTeam.image = value.GetString();
                            break;
                    } // end switch
                } // end foreach (var key in oneTeam.keys)
                fTeamsList.Add(dTeam);
            }// end foreach (var item in fTeamList

        }

    }
}
