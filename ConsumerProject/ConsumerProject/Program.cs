using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using LibraryProject;

namespace ConsumerProject
{
    class Program
    {
        [DllImport("LibraryProject.dll")]
        public static extern void ShowMessage();
        static void Main(string[] args)
        {
            LibraryProject.Class1 c = new Class1();
            c.ShowMessage();
        }
    }
}
