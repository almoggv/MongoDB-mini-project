using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioCodes_First_Task___Almog_Geva
{
    public enum Extension
    {
        mp3
    }
    public static class ConcereteDirFileCreatorManager
    {
        public static DirFileCreator GetNewCreator(Extension i_Context)
        {
            DirFileCreator newCreator;

            switch (i_Context)
            {
                case Extension.mp3:
                    {
                        newCreator = new ConcreteMp3Creator();
                        break;
                    }

                default: throw new Exception("Extension Not Supported");
            }

            return newCreator;
        }

    }
}
