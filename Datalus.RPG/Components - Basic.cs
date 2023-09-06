using EMPC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalus.RPG
{
    public sealed class MetaProcessor : Processor<MetaComponent> { }

    public sealed class MetaComponent : Component
    {
        public MetaComponent()
        {
            MetaProcessor.Register(this);
        }

        [Displayable, Savable]
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                ObjectModified("Name");
            }
        }
        private string _name = string.Empty;

        [Displayable, Savable]
        public string Description
        {
            get => _description;
            set
            {
                if (_description == value) return;
                _description = value;
                ObjectModified("Description");
            }
        }
        private string _description = string.Empty;

        [Displayable]
        public bool Test { get; set; } = true;
    }
}
