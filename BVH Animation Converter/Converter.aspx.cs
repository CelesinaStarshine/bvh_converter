using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BVH_Animation_Converter
{
    public partial class Converter : System.Web.UI.Page
    {
        public static string file_name;
        public bool radio_checked;
        public bool isSaved;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer.AbsoluteUri != null)
            {
                string referrer = Request.UrlReferrer.AbsoluteUri;
                string[] strFileParts = referrer.Split('/');
                if (strFileParts[strFileParts.Length - 1] == "BVH_Upload.aspx")
                {
                    file_name = BVH_Upload.file_name;
                }
                else if (strFileParts[strFileParts.Length - 1] == "Community.aspx")
                {
                    file_name = Community.file_name;
                }
            }
            lblFile.Text = file_name;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            Server.Transfer("BVH_Upload.aspx");
        }

        protected void btnChoose_Click(object sender, EventArgs e)
        {
            Server.Transfer("Community.aspx");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedItem.Value == "Save")
            {
                isSaved = true;
                btnConvert.Enabled = true;
            }
            else if(RadioButtonList1.SelectedItem.Value == "Delete")
            {
                isSaved = false;
                btnConvert.Enabled = true;
            }
        }
    }
}