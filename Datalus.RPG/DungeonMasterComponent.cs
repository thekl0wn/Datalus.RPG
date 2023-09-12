using Datalus.Core;

namespace Datalus.RPG
{
    public interface IDungeonMasterComponent : IDatalusComponent
    {
        string PlayerCode { get; }
        IDatalusEntity Player { get; set; }
    }
    public sealed class DungeonMasterComponent : DatalusComponent
    {
        public DungeonMasterComponent() : base()
        {
            // no system
        }

        public string PlayerCode
        {
            get
            {
                if (Player == null) return string.Empty;
                else return Player.EntityCode;
            }
        }
        public IDatalusEntity Player { get; set; }
    }
}
