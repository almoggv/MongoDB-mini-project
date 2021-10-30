using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioCodes_First_Task___Almog_Geva
{
    //An IDirFile factory method
    public abstract class DirFileCreator
    {
        public abstract IDirFile Create(System.IO.FileInfo i_File);
    }
}
