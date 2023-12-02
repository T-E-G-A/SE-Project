using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDashboard
{
    public interface IregisterRepo
    {
        Task<bool> Insert(Reg user);
    }
}
