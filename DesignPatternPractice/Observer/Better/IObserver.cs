using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer.Better
{
    public interface IObserver<T>
    {
        void HandleInfo(T info);
    }
}
