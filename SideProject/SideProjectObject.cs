using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideProject
{
    public class SideProjectObject
    {
        public SideProjectObject()
        {
            this.AssemblyVersionLabel = typeof(SideProjectObject).Assembly.GetName().Version.ToString();
        }

        public string AssemblyVersionLabel { get; set; }
    }
}
