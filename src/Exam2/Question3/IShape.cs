using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public interface IShape<T>
    {
        double GetArea(T item);
    }
}
