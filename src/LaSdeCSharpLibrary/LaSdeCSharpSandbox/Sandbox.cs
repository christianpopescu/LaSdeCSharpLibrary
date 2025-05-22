using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaSdeCSharpLibrary.FilesAndFolders;

namespace LaSdeCSharpSandbox
{
    /// <summary>
    /// This class is used to contains the different methods used to test objects from the LaSdeCSharpLibrary
    /// </summary>
    public class Sandbox
    {
        public static void ConcatenateFiles()
        {
            // Create a list of files to concatenate
            List<string> files = new List<string>
            {
                @"D:\Temp\TempToDelete\WindowsDesktopApp\WindowsDesktopApp\framework.h",
                @"D:\Temp\TempToDelete\WindowsDesktopApp\WindowsDesktopApp\Resource.h",
                @"D:\Temp\TempToDelete\WindowsDesktopApp\WindowsDesktopApp\targetver.h"
            };
            // Specify the output file
            string outputFile = @"D:\Temp\TempToDelete\WindowsDesktopApp\WindowsDesktopApp\output.txt";
            // Call the ConcatenateFiles method from the FileCompositionHelper class
            FileCompositionHelper.ConcatenateFiles(files, outputFile);
        }
    }
}
