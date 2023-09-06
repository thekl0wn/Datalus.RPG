using EMPC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalus.RPG
{
    public abstract class RpgManager : Manager
    {
        protected override void OnInitialize(Entity entity)
        {
            // base
            base.OnInitialize(entity);

            // add components
            entity.AddComponent<MetaComponent>();
        }
    }
}
