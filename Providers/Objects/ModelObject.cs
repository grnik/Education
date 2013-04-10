using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    abstract public class ModelObject
    {
        public Guid ID { get; set; }

        public virtual bool IsValid()
        {
            if(ID == Guid.Empty)
            {
                return false;
            }

            return true;
        }
    }
}
