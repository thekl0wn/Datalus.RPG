using Datalus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalus.RPG
{
    public interface IUnitTypeComponent : IDatalusComponent
    {
        string TypeCode { get; }
    }
    public class UnitTypeComponent : DatalusComponent, IUnitTypeComponent
    {
        public UnitTypeComponent() : base()
        {

        }

        public string TypeCode { get; }
    }
}
