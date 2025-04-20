using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_MySolution.Global_Classes
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Userame, string Password)
        {
            try
            {
                //this will get the current project directory folder.
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                //Define the path to the text file where you want to save the data
                string filePathe = CurrentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if(Userame == "" && File.Exists(filePathe))
                {
                    File.Delete(filePathe);
                    return true;
                }

                //Concatonate username and password withe seperator.
                string dataToSave = Userame + "#//#" + Password;

                //Create a streamWriter to write to the file
                using(StreamWriter Writer = new StreamWriter(filePathe))
                {
                    //Writer the data to the file
                    Writer.WriteLine(dataToSave);

                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                //Path for the file that contains the credential.
                string filePath = CurrentDirectory + "\\data.txt";

                //Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    //Create a StreamReader to read from the file
                    using (StreamReader Reader = new StreamReader(filePath))
                    {
                        //Read data line by line until the end of the file
                        string line;
                        while ((line = Reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); //Output each line of data to the console
                            string[] Result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = Result[0];
                            Password = Result[1];
                        }

                        return true;
                    }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}