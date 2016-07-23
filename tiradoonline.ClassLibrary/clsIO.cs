using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace tiradoonline.ClassLibrary
{
    public class clsIO
    {
        private static List<string> _mediaFiles = new List<string>();

        public bool CreateDirectoryFromFileName(string stringFileName)
        {
            string vDirectory = Path.GetDirectoryName(stringFileName);
            try
            {
               if (!Directory.Exists(vDirectory))
                   Directory.CreateDirectory(vDirectory);

                return true;
            }
            catch (Exception ex)
            {
                clsLogs.Log("tiradoonline.ClassLibrary:clsIO:CreateDirectoryFromFileName()", vDirectory, ex.ToString());
                return false;
            }
        }

        public static string ReadFile(string stringFileName)
        {
            String stringBodyText = string.Empty;
            try
            {
                if (File.Exists(stringFileName))
                {
                    StreamReader objStreamReader = File.OpenText(stringFileName);
                    stringBodyText = objStreamReader.ReadToEnd();
                    objStreamReader.Close();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = String.Format("{0}\n\nError in ReadFile ({1})", ex.ToString(), stringFileName);
                clsLogs.Log("clsIO", Environment.CurrentDirectory, errorMessage);
            }

            return stringBodyText.ToString();
        }

        public static void WriteFile(string stringFileName, string stringFileText)
        {
            try
            {
                string directory = Path.GetDirectoryName(stringFileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                StreamWriter SW;
                SW = File.CreateText(stringFileName.ToString());
                SW.WriteLine(stringFileText.ToString());
                SW.Close();

                SW = null;
            }
            catch (Exception ex)
            {
                string errorMessage = String.Format("{0}\n\nError in WriteFile ({1})", ex.ToString(), stringFileName);
                clsLogs.Log("clsIO", Environment.CurrentDirectory, errorMessage);
            }
        }

        // THIS FUNCTION READS BINARY FROM A DATA FILE AND RETURNS A DATA TYPE OF BYTE[]
        public byte[] Read_Binary_From_File(string file_name)
        {
            FileStream objFileStream = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader objBinaryReader = new BinaryReader(objFileStream);
            byte[] objByte = objBinaryReader.ReadBytes((int)objFileStream.Length);
            objBinaryReader.Close();
            objFileStream.Close();
            return objByte;
        }

        // THIS FUNCTION WRITES BINARY TO A DATA FILE
        public void Write_Binary_To_File(string file_name, byte[] objByte)
        {
            FileStream objFileStream = new FileStream(file_name, FileMode.Create, FileAccess.Write);
            objFileStream.Write(objByte, 0, objByte.Length);
            objFileStream.Flush();
            objFileStream = null;
        }

        public int GetDirectoryListCount(string dir, ref DataTable table)
        {
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    table.Rows.Add(f);
                }

                foreach (string d in Directory.GetDirectories(dir))
                {
                    //table.Rows.Add(d);
                    GetDirectoryListCount(d, ref table);
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return table.Rows.Count;
        }

        public void GetDirectoryList(string dir, ref DataTable table)
        {
            List<string> listDirectory = new List<string>();

            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    table.Rows.Add(f);
                }

                foreach (string d in Directory.GetDirectories(dir))
                {
                    //table.Rows.Add(d);
                    GetDirectoryList(d, ref table);
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static List<string> GetSubDirectoriesList(string dir)
        {
            List<string> listDirectory = new List<string>();

            try
            {
                foreach (string f in Directory.GetDirectories(dir))
                {
                    listDirectory.Add(f.Replace(dir, "").Replace("\\", ""));
                }
                return listDirectory;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static string GetFolderName(string path)
        {
            var end = -1;
            for (var i = path.Length; --i >= 0;)
            {
                var ch = path[i];
                if (ch == System.IO.Path.DirectorySeparatorChar ||
                    ch == System.IO.Path.AltDirectorySeparatorChar ||
                    ch == System.IO.Path.VolumeSeparatorChar)
                {
                    if (end > 0)
                    {
                        return path.Substring(i + 1, end - i - 1);
                    }

                    end = i;
                }
            }

            if (end > 0)
            {
                return path.Substring(0, end);
            }

            return path;
        }

        public static List<string> RecurseDirectory(string path)
        {
            string[] files;
            string[] directories;

            files = Directory.GetFiles(path);
            foreach (string file in files)
            {

                _mediaFiles.Add(file);
            }

            directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                RecurseDirectory(directory);
            }

            return _mediaFiles;
        }
    }
}
