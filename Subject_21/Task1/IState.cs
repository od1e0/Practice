using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IState
    {
        void Handle(Context context);
    }
}
