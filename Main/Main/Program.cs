using System;
using System.IO;
using System.Linq;

namespace FileScaner
{
    class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives.Where(d => d.DriveType == DriveType.Fixed))
            {
                WriteDriveInfo( drive);
                DirectoryInfo root = drive.RootDirectory;
                var folders = root.GetDirectories();

                WriteFolderInfo(folders);

                Console.WriteLine();
                Console.ReadKey();
            }
        }

        public static void WriteDriveInfo(DriveInfo drive)
        {
            Console.WriteLine($"Название: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"Объем: {drive.TotalSize}");
                Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка: {drive.VolumeLabel}");
            }
        }

        public static void WriteFolderInfo(DirectoryInfo[] folders)
        {
            Console.WriteLine();
            Console.WriteLine("Папки: ");
            Console.WriteLine();

            foreach (var folder in folders) 
            {
                Console.WriteLine(folder.Name);
            }
        }
    }
}

