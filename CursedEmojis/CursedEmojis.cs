using System.Linq;
using System.IO;

namespace DuckGame.CursedEmojis
{
    public class CursedEmojis : ClientMod
    {
        public override Priority priority
        {
            get
            {
                return Priority.HatPack;
            }
        }

        protected override void OnPostInitialize()
        {
            foreach (string file in Directory.GetFiles(configuration.contentDirectory + "/hats"))
            {
                Team team = Team.Deserialize(file);
                if (team != null) Teams.AddExtraTeam(team);
            }

            base.OnPostInitialize();
        }
    }
}