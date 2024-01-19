using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenricContainer<T>
    {
        public T Data;

        public GenricContainer(T value)
        {
            Data = value;
        }

        public T GetData()
        {
            return Data;
        }

        public class NestedGenericType<U>
        {
            public U NestedData;

            public NestedGenericType(U nestedValue)
            {
                NestedData = nestedValue;
            }

            public U GetData()
            {
                return NestedData;
            }
        }
    }
}
