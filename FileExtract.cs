using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioCodes_First_Task___Almog_Geva
{
    public static class FileExtract
    {
        //Utility class to Extract file info of *supported file types*  from a given folder
        public static List<IDirFile> GetDirFilesInfo(string i_DirectoryPath , Extension i_FileExtension)
        {
            //checkDirectoryPath(i_DirectoryPath);
            //checkFileExtension(i_FileExtension);

            IDirFile createdIDirFile;
            string extensionToLowerString = "." + i_FileExtension.ToString();
            List<IDirFile> outList = new List<IDirFile>();
            List<string> filesInfoList = new List<string>(System.IO.Directory.GetFiles(i_DirectoryPath));
            
            foreach (string fileName in filesInfoList)
            {
                var currFile = new System.IO.FileInfo(fileName);

                if(currFile.Exists && currFile.Extension == extensionToLowerString)
                {
                    createdIDirFile = createNewIDirFile(currFile ,i_FileExtension);
                    outList.Add(createdIDirFile);
                }
            }

            return outList;
        }

        private static IDirFile createNewIDirFile(System.IO.FileInfo i_File ,Extension i_ExtensionContext)
        {
            IDirFile newFile;
            DirFileCreator factory = ConcereteDirFileCreatorManager.GetNewCreator(i_ExtensionContext);

            newFile = factory.Create(i_File);

            return newFile;
        }

        
    }
}
