using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    interface IAppType : ITable
    {
        string Name { get; set; }
    }
}
