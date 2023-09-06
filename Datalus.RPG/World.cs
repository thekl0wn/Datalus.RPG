using System;

namespace Datalus.RPG
{
    public static class World
    {
        public static int Iteration { get => _iteration; }
        private static int _iteration = 0;
        public static CampaignManager Campaigns { get; } = new CampaignManager();
        public static CharacterManager Characters { get; } = new CharacterManager();
        public static PlayerManager Players { get; } = new PlayerManager();

        public static bool Initialize()
        {
            // status
            UI.Status("Initializing world...");
            
            // initialize component manager
            if (!ComponentManager.Initialize()) return false;

            // initialize the managers
            if (!Managers.Initialize()) return false;

            // default
            return true;
        }
        public static void Update()
        {
            // increment the iteration
            _iteration++;

            // update processors in specific order
            HealthProcessor.Update();
            MetaProcessor.Update();

            // event
            GameLoopUpdate?.Invoke(null, EventArgs.Empty);
        }

        public static EventHandler GameLoopUpdate;
    }
}
