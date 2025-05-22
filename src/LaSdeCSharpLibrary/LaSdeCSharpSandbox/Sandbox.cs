using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaSdeCSharpLibrary.FilesAndFolders;
using LaSdeCSharpLibrary.Logger;

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

            // Create an instance of FileCompositionHelper
            FileCompositionHelper fileHelper = new FileCompositionHelper( ConsoleLogger.Instance);

            // Call the ConcatenateFiles method from the FileCompositionHelper instance
            fileHelper.ConcatenateFiles(files, outputFile);
        }
    }
}
