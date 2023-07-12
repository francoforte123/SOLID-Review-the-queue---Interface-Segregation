using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID__Review_the_queue___Interface_Segregation
{
    public interface FuncQueue<T>
    {
        void Queue(T value);
    }
}
