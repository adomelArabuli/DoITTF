using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class CustomResource : IDisposable
    {
        private bool isResourceOpen = false;

        public void OpenResource()
        {
            Console.WriteLine("Resource opened");
            isResourceOpen = true;
        }

        public void UseResource()
        {
            if(!isResourceOpen)
            {
                throw new InvalidOperationException("Resource is not open");
            }

            Console.WriteLine("Resource is being used");
        }

        public void CloseResource()
        {
            Console.WriteLine("Resource closed");
            isResourceOpen = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (isResourceOpen)
                {
                    CloseResource();
                }
            }
        }
    }
}
