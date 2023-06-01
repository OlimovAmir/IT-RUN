using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedAndUnmanaged
{
    internal class FileManager : IDisposable
    {
        StreamWriter StreamWriter;
        public FileManager()
        {
            StreamWriter = new StreamWriter("store.txt", true);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        bool disposed;
        protected void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                //Clean up managed code
                StreamWriter.Dispose();
            }
            //clean up unmanaged code
            disposed = true;
        }

        ~FileManager()
        {
            Dispose(false);
        }

        public void WriteProduct(string name, int count)
        {
            StreamWriter.WriteLine($"{name} {count}");
            StreamWriter.Flush();
        }
    }
}
