using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowlers { get; }
    }
}
