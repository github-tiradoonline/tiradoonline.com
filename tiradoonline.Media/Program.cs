using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiradoonline.DataAccess.Models;

namespace tiradoonline.Media
{
    public class MediaFiles
    {
        public string FolderName { get; set; }
        public string MediaFile { get; set; }
        public string MediaFileExt { get; set; }
    }

    class Program
    {

        public static int Counter = 1;
        public static int UserID = 1001;
        public static MediaFiles mediaFiles = new MediaFiles();
        public static List<MediaFiles> listMediaFiles = new List<MediaFiles>();

        static void Main(string[] args)
        {
            ProcessFiles(@"c:\storage\music");
            ProcessFiles(@"c:\storage\movies");
            ProcessFiles(@"c:\storage\documents");
            ProcessFiles(@"c:\storage\software");
            ProcessFiles(@"c:\storage\photos");
            ProcessFiles(@"e:\Storage\Movies");

            InsertIntoDatabase();

            Environment.Exit(0);

        }

        private static void InsertIntoDatabase()
        {
            MediaFile objMediaFile = new MediaFile();

            objMediaFile.MediaFileTruncate(UserID);

            foreach(var mediafile in listMediaFiles)
            {
                //string con = String.Format("objMediaFile.MediaFileInsert({0}, '{1}', '{2}', '{3}');", UserID, "Music", mediafile.FolderName, mediafile.MediaFile);
                //Console.WriteLine(con);
                objMediaFile.MediaFileInsert(UserID, mediafile.FolderName, mediafile.MediaFile, mediafile.MediaFileExt);
                Console.WriteLine(Counter.ToString() + ") " + mediafile.MediaFile);
                Counter++;
            }
        }

        static void ProcessFiles(string path)
        {
            string[] files;
            string[] directories;

            files = Directory.GetFiles(path);
            foreach (string file in files)
            {

                MediaFiles objMedia = new MediaFiles();
                objMedia.FolderName = path;
                objMedia.MediaFile = file.Replace(path + @"\", "");
                objMedia.MediaFileExt = Path.GetExtension(file);
                listMediaFiles.Add(objMedia);

            }

            directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                ProcessFiles(directory);
            }
        }
    }
}
