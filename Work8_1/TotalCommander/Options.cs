using System;
using System.IO;

namespace TotalCommander
{
    internal class TotalCommand
    {
        public string UserName { get; set; }
        public TotalCommand(string name) { UserName = name; }
        
        public void AddDirectory(string pathDir,string toDir)
        {
            if (!Directory.Exists(toDir) && Directory.Exists(pathDir)) 
            {
                Directory.CreateDirectory($"{toDir}/{pathDir}");
            }
            else if (!Directory.Exists(toDir))
            {
                Console.WriteLine($"Path {toDir} not exist!");
            }
            else
            {
                Console.WriteLine($"Such a folder exist!");
            }
        }

        public void MoveDirectory(string pathDir,string toDir)
        {
            if (!Directory.Exists(pathDir) && Directory.Exists(toDir))
            {
                Directory.Move(pathDir, toDir);
            }
            else if(!Directory.Exists(toDir))
            {
                Console.WriteLine($"Path {toDir} not exist!");
            }
            else
            {
                Console.WriteLine($"Such a folder exist!");
            }
        }

        public void CopyDirectory(string pathdir)
        {
            if (Directory.Exists(pathdir))
            {
                for (int i = 1; i < 100; i++)
                {
                    string newDirectory = pathdir + $"({i})";
                    if (!Directory.Exists(newDirectory))
                    {
                        Directory.CreateDirectory(newDirectory);
                        foreach (string s1 in Directory.GetFiles(pathdir))
                        {
                            string s2 = newDirectory + "\\" + Path.GetFileName(s1);
                            File.Copy(s1, s2);
                        }
                        foreach (string s in Directory.GetDirectories(pathdir))
                        {
                            CopyDirectory(s, newDirectory + "\\" + Path.GetFileName(s));
                        }
                        break;
                    }
                }
            }
            else if (!Directory.Exists(pathdir))
            {
                Console.WriteLine($"Path {pathdir} not exist!");
            }
            else
            {
                Console.WriteLine("Such a folder exist");
            }
        }

        public void CopyDirectory( string pathdir,string toDir)
        {
            if (!Directory.Exists(toDir))
            {
                Directory.CreateDirectory(toDir);
                foreach(string s1 in Directory.GetFiles(pathdir))
                {
                    string s2 = toDir + "\\" + Path.GetFileName(s1);
                    File.Copy(s1, s2);
                }
                foreach(string s in Directory.GetDirectories(pathdir))
                {
                    CopyDirectory(s, toDir + "\\" + Path.GetFileName(s));
                }
            }
            else if (!Directory.Exists(pathdir))
            {
                Console.WriteLine($"Path {pathdir} not exist!");
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void DeleteDirectory(string PathDir)
        {
            if (Directory.Exists(PathDir))
            {
                Directory.Delete(PathDir);
            }
            else
            {
                Console.WriteLine("Folder not exist!");
            }
        }

        public void AddFile(string pathFile)
        {
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
            }
        }

        public void RemoveFile(string PathFil) 
        {
            if (File.Exists(PathFil))
            {
                File.Delete(PathFil);
            }    
           
        }

        public void CopyFile(string fileName, string toDir)
        {
            if(File.Exists(fileName)) 
            {
                File.Copy(fileName, toDir);
            }
            else if(!File.Exists(toDir))
            {
                Console.WriteLine($"Path {toDir} not exist!");
            }
            else
            {
                Console.WriteLine("Such a file exist");
            }
            
        }

        public void CopyFile(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                for (int i = 1; i < 100; i++)
                {
                    int indexof= pathFile.LastIndexOf(".");
                    string newFile = pathFile.Insert(indexof, $"({i})");
                    if (!File.Exists(newFile))
                    {
                        File.Copy(pathFile, newFile);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Path {pathFile} not exist!");
            }
        }

        public void MoveFile(string fileName, string toDir)
        {
            if (File.Exists(fileName) && !File.Exists(toDir))
            {
                File.Move(fileName, toDir);
            }
            else if(!File.Exists(fileName))
            {
                Console.WriteLine($"Path {fileName} not exist!");
            }
            else
            {
                Console.WriteLine($"Directory {toDir} not exist or such a file exist in directory!");
            }
        }

    }
}
