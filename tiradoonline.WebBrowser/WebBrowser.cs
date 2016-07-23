using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiradoonline.WebBrowser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
            string xulrunnerPath = @"C:\Storage\xulrunner";
            Skybound.Gecko.Xpcom.Initialize(xulrunnerPath);
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            string url = @"http://intranet.tiradoonline.com/?SubmitButton=LOGIN&LoginUserName=teddy&LoginPassword=sixpak";
            tiradoonlineWebBrowser.Navigate(url);
        }
    }
}
