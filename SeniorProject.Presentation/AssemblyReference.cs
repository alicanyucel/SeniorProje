using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Presentation
{
   public static class AssemblyReference
    {
        public static  Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}
