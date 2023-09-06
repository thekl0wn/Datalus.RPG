namespace Datalus.RPG
{
    public sealed class CharacterManager : RpgManager
    {
        protected override void OnInitialize(Entity entity)
        {
            // base
            base.OnInitialize(entity);

            // add components
            entity.AddComponent<HealthComponent>();
        }
    }
    public sealed class RaceManager : RpgManager { }

    public sealed class HealthProcessor : Processor<HealthComponent> { }

    public sealed class CharacterListComponent : ListComponent<Entity> { }
    public sealed class HealthComponent : Component
    {
        public HealthComponent()
        {
            HealthProcessor.Register(this);
        }
    }
}
