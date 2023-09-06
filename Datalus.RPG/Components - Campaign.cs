using EMPC.Core;

namespace Datalus.Core
{
    public sealed class CampaignManager : RpgManager
    {
        protected override void OnInitialize(Entity entity)
        {
            // base
            base.OnInitialize(entity);

            // add components
            entity.AddComponent<CharacterListComponent>();
            entity.AddComponent<PlayerListComponent>();
        }
    }
}
