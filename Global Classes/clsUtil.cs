using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DVLD_MySolution.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            //Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            //Convert the GUID to a string
            return newGuid.ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            //Check if the folder exists
            if(!Directory.Exists(FolderPath))
            {
                try
                {
                    //IF it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " +  ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            //Full file name. Change your file name
            string FileName = SourceFile;
            FileInfo fi = new FileInfo(FileName);
            string extn = fi.Extension;

            return GenerateGUID() + extn;
        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            // this function will copy the image to the
            // project images folder after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"C:\DVLD-People-Images\";

            if(!CreateFolderIfDoesNotExist(DestinationFolder))
                return false;

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);

            try
            {
                File.Copy(sourceFile, DestinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = DestinationFile;
            return true;
        }
    }
}
