using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using NAudio.Wave;

namespace AudioCodes_First_Task___Almog_Geva
{
    //An Entity to represent an Mp3 File in a database
    //Provides file verification and checkup
    public class Mp3File : IDirFile
    {
        [BsonId]
        public string Id { get; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("extension")]
        public string Extension { get; }
        [BsonElement("byteSize")]
        public long ByteSize { get; }

        [BsonElement("isValid")]
        public bool IsValid { get; set; }
        [BsonElement("length")]
        public TimeSpan Length { get; }

        public string Path { get; }


        public Mp3File(System.IO.FileInfo i_File)
        {
            this.Id = i_File.Name + i_File.CreationTime.ToString();
            this.Extension = ".mp3";
            this.Name = i_File.Name;
            this.ByteSize = i_File.Length;
            this.Path = i_File.DirectoryName;

            this.Length = getFileLength(i_File);
            this.IsValid = isFileValid(i_File);
        }

        private TimeSpan getFileLength(System.IO.FileInfo i_File)
        {
            TimeSpan fileDuration;

            try
            {
                Mp3FileReader fileReader = new Mp3FileReader(i_File.FullName);
                fileDuration = fileReader.TotalTime;
            }
            catch(Exception e)
            {
                fileDuration = new TimeSpan();
            }

            return fileDuration;
        }

        private bool isFileValid(System.IO.FileInfo i_File)
        {
            bool isValidRes = false;
            //what is considered a valid mp3 file?

            if(i_File.Exists && i_File.Extension == ".mp3")
            {
                isValidRes = true;
            }

            try
            {
                Mp3FileReader fileReader = new Mp3FileReader(i_File.FullName);
            }
            catch (Exception e)
            {
                isValidRes = false;
            }
          
            return isValidRes;
        }
    }
}
