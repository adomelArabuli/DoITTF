using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IGenericInterface<T>
    {
        T GetData();
    }

    class IntData : IGenericInterface<int>
    {
        public int GetData()
        {
            throw new NotImplementedException();
        }
    }

    class StringData : IGenericInterface<string>
    {
        public string GetData()
        {
            throw new NotImplementedException();
        }
    }
}
