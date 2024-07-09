using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives) 
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if(drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
                Console.ReadKey();
            }
        }
    }
}
