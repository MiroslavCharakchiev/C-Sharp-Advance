using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Interfaces
{
    public interface IBuyer
    {
        int Food { get;  set; }
        String Name { get; }

        void BuyFood();
    }
}
