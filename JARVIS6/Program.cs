﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JARVIS6
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool ProgramRunning = true;
            string UserInput = "";
            string DefaultStartupMethod = "console";
            
            if (args.Length > 0)
            {
                
            }
            if(DefaultStartupMethod == "console")
            {
                while (ProgramRunning)
                {
                    try
                    {
                        Console.Write("Enter Command: ");
                        UserInput = Console.ReadLine();
                        if (UserInput != "exit")
                        {
                            List<string> CommandParameters = UserInput.Split(' ').ToList();
                            string PrimaryCommand = CommandParameters.ElementAtOrDefault(0);
                            if (PrimaryCommand == "cryptography")
                            {
                                string SecondaryCommand = CommandParameters.ElementAtOrDefault(1);
                                if (SecondaryCommand == "generatescripts")
                                {
                                    string FirstCharacter = CommandParameters.ElementAtOrDefault(2);
                                    string WordLength = CommandParameters.ElementAtOrDefault(3);
                                    JARVISCryptography cryptotools = new JARVISCryptography();
                                    StatusObject SO_GenerateInsertScripts = cryptotools.GenerateInsertScripts(FirstCharacter, WordLength);
                                    if (SO_GenerateInsertScripts.Status == StatusCode.FAILURE)
                                    {
                                        Console.WriteLine(SO_GenerateInsertScripts.ErrorStackTrace);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("{0} is an invalid command", UserInput);
                            }
                        }
                        else
                        {
                            ProgramRunning = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        ProgramRunning = true;
                        UserInput = "";
                    }
                }
            }
            else if (DefaultStartupMethod == "form")
            {
                
            }
        }
    }
}
