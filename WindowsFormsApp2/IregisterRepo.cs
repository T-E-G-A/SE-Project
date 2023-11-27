using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public interface IregisterRepo
    {
        Task<bool> Insert(register user);
    }
}
