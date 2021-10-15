﻿using System;

namespace DocGuard_Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 6 || (args[0] != "--sourceFolder" && args[2] != "--destinationUrl" && args[4] != "--outputPath"))
            {
                Help();
                return;
            }

            DocFileUpload DFU = new DocFileUpload(args[1], args[3], args[5]);
            DFU.FolderList();

        }

        static void Help()
        {
            Console.WriteLine("[!] There is an error while giving arguman. Where are waiting like bellow");
            Console.WriteLine(@"cmd.exe : DocGuard_Desktop.exe --sourceFolder C:\Administrator\Desktop 
                    --destinationUrl https://example.com --outputPath C:\Administrator\Desktop");
        }
    }
}
