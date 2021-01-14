using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdt.Domain.Entities;

namespace Sdt.Data.Contracts
{
    public interface ISpruchRepository : IRepository<Spruch, int>
    {
        Spruch GetSpruchDesTages();
    }
}
