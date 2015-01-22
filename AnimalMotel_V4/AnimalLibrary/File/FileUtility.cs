//Farid Naisan
//Code Example
//Created:  sometimes in 2008

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalMotel
{
    public class FileUtility
    {
        //1.  Change file extension to desired file extension
        //fileName is the path+filename+filextension("d:\project\text.xxx")
        //desiredFileExt with or without the dot (".txt" or "txt")
        //The function works for all cases:
        //  a.  D:\TestFolder\test       no file extension
        //  b.  D:\TestFolder\test.      no file extension but with a dot
        //  c.  D:\TestFolder\test.dat

        public static string ChangeFileExtension(string fileName, string desiredFileExt)
        {
            //1.  find the last dot
            int dotPosition = fileName.LastIndexOf(".");

            //Delete the current file extension ( test.dat --> test)
            if (dotPosition > 0)
            {
                int numOfChars = dotPosition;  //"test.dat --> test
                fileName = fileName.Substring(0, numOfChars);
            }

            //add the new file extension
            fileName += "." + desiredFileExt;
            return fileName;
        }
    }
}
