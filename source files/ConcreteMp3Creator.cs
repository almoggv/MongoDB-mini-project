using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioCodes_First_Task___Almog_Geva
{
    class ConcreteMp3Creator : DirFileCreator
    {
        public override IDirFile Create(System.IO.FileInfo i_File)
        {
            Mp3File newFile = new Mp3File(i_File);
            return newFile;
        }

    }
}
