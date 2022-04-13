using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid
        {
            get { return Validate(); }
        }

        public abstract bool Validate();

        /*public bool Validate()
        {
            return true;
        }*/

        public EntityStateOption EntityState { get; set; }
    }
}
