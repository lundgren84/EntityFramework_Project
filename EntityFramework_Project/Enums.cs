using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project
{
    public enum Genre
    {
        Drama = 1, Comedy, Horror, Action, Love, Cartoon,
    }
    public enum MemberStatus
    {
        Open = 1, Locked
    }
    public enum MovieStatus
    {
        InStore = 1, Rented,
    }
}
