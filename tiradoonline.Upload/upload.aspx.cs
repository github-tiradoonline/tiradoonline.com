using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tiradoonline.ClassLibrary;

namespace tiradoonline.Upload
{
    public partial class upload : System.Web.UI.Page
    {
        private string UploadDirectory = @"c:\storage\uploads\tiradoonline";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonFileUpload_Click(object sender, EventArgs e)
        {
            if (fileUploadFileName.HasFile)
            {
                clsIO objIO = new clsIO(); 
               
                string filename = String.Format(@"{0}\{1}", UploadDirectory, fileUploadFileName.FileName);
                if (objIO.CreateDirectoryFromFileName(filename))
                {
                    fileUploadFileName.SaveAs(filename);
                }
                //hypUpload.Text = fileUpload.FileName;
                //hypUpload.NavigateUrl = fileUpload.FileName;
            }
            else
            {
                //hypUpload.Text = "No file uploaded";
            }
        }
    }
}