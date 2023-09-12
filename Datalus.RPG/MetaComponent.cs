using Datalus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalus.RPG
{
    public interface IMetaComponent : IDatalusComponent
    {
        string Name { get; set; }
        string Description { get; set; }
    }
    public sealed class MetaComponent : DatalusComponent, IMetaComponent
    {
        public string Description
        {
            get => _description;
            set
            {
                if (_description == value) return;
                _description = value;
                OnModified("Description");
            }
        }
        private string _description = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                OnModified("Name");
            }
        }
        private string _name = string.Empty;
    }
}
