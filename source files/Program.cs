using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AudioCodes_First_Task___Almog_Geva
{
    class Program
    {
        //The Program:
        //Scans a given local folder path for mp3 files
        //Creates a data base of the files in mongoDB Atlas
        //with the following attributes
        //                  * Filename
        //                  * Size 
        //                  * Length
        //                  * IsValid
        //                  
        //  MongoDB chart URL:
        //  https://charts.mongodb.com/charts-project-0-hfuam/public/dashboards/61648567-ae01-4eb2-8c3f-3dea6a1ca504

        static void Main(string[] args)
        {            
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
