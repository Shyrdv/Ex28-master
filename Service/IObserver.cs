using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IObserver
    {
        void Update(ISubject subject, string message);
    }
}
