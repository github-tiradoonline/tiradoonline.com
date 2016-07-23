using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using tiradoonline.ClassLibrary;
using tiradoonline.DataAccess.tiradoonline.Models;


namespace tiradoonline.WebAPI.Controllers
{
    public class MediaController : Controller
    {
        private string eBooksDirectory = ConfigurationManager.AppSettings["eBooksDirectory"].ToString();
        private string moviesDirectory = ConfigurationManager.AppSettings["MoviesDirectory"].ToString();
        private string musicDirectory = ConfigurationManager.AppSettings["MusicDirectory"].ToString();

        [HttpPost]
        public JsonResult Music(string directory, string filter)
        {
            if (directory == null)
                directory = musicDirectory;

            if (filter == null)
                filter = ".mp3;.wma";

            List<string> importMediaList = new List<string>();
            List<modelMediaFile> mediaFilesList = new List<modelMediaFile>();
            string[] mediaExt = filter.Split(';');


            try
            {
                importMediaList = clsIO.RecurseDirectory(directory);

                foreach (string file in importMediaList)
                {
                    foreach (string ext in mediaExt)
                    {
                        if (file.ToLower().Contains(ext))
                        {
                            modelMediaFile objMedia = new modelMediaFile();
                            objMedia.MediaFileDirectory = directory;
                            objMedia.MediaFileName = file.Replace(directory + @"\", "");
                            objMedia.MediaFileExt = Path.GetExtension(file);
                            objMedia.MediaFileURL = Request.ServerVariables["SERVER_NAME"].ToString() + "/music/" + objMedia.MediaFileName.Replace("\\", "/");
                            mediaFilesList.Add(objMedia);
                            objMedia = null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                modelMediaFile objMedia = new modelMediaFile();
                objMedia.ErrorMessage = ex.ToString();
                mediaFilesList.Add(objMedia);
                objMedia = null;
            }

            return Json(mediaFilesList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Movies(string directory, string filter)
        {
            if (directory == null)
                directory = moviesDirectory;

            if (filter == null)
                filter = ".avi;.mp4;.wmv";

            List<string> importMediaList = new List<string>();
            List<modelMediaFile> mediaFilesList = new List<modelMediaFile>();
            string[] mediaExt = filter.Split(';');


            try
            {
                importMediaList = clsIO.RecurseDirectory(directory);

                foreach (string file in importMediaList)
                {
                    foreach (string ext in mediaExt)
                    {
                        if (file.ToLower().Contains(ext))
                        {
                            modelMediaFile objMedia = new modelMediaFile();
                            objMedia.MediaFileDirectory = directory;
                            objMedia.MediaFileName = file.Replace(directory + @"\", "");
                            objMedia.MediaFileExt = Path.GetExtension(file);
                            objMedia.MediaFileURL = Request.ServerVariables["SERVER_NAME"].ToString() + "/movies/" + objMedia.MediaFileName.Replace("\\", "/");
                            mediaFilesList.Add(objMedia);
                            objMedia = null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                modelMediaFile objMedia = new modelMediaFile();
                objMedia.ErrorMessage = ex.ToString();
                mediaFilesList.Add(objMedia);
                objMedia = null;
            }

            return Json(mediaFilesList, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult eBooks(string directory, string filter)
        {
            if (directory == null)
                directory = eBooksDirectory;

            if (filter == null)
                filter = ".pdf";

            List<string> importMediaList = new List<string>();
            List<modelMediaFile> mediaFilesList = new List<modelMediaFile>();
            string[] mediaExt = filter.Split(';');


            try
            {
                importMediaList = clsIO.RecurseDirectory(directory);

                foreach (string file in importMediaList)
                {
                    foreach (string ext in mediaExt)
                    {
                        if (file.ToLower().Contains(ext))
                        {
                            modelMediaFile objMedia = new modelMediaFile();
                            objMedia.MediaFileDirectory = directory;
                            objMedia.MediaFileName = file.Replace(directory + @"\", "");
                            objMedia.MediaFileExt = Path.GetExtension(file);
                            objMedia.MediaFileURL = Request.ServerVariables["SERVER_NAME"].ToString() + "/ebooks/" + objMedia.MediaFileName.Replace("\\", "/");
                            mediaFilesList.Add(objMedia);
                            objMedia = null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                modelMediaFile objMedia = new modelMediaFile();
                objMedia.ErrorMessage = ex.ToString();
                mediaFilesList.Add(objMedia);
                objMedia = null;
            }

            return Json(mediaFilesList, JsonRequestBehavior.AllowGet);
        }
    }
}