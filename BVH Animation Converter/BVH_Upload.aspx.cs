using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BVH_Animation_Converter
{
    public partial class BVH_Upload : System.Web.UI.Page
    {
        public static string file_name;

        protected void Page_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = 5;
            MyTimer.Tick += new EventHandler<System.EventArgs>(MyTimer_Tick);
            MyTimer.Enabled = true;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                btnUpload.Enabled = true;
            }
            else
            {
                btnUpload.Enabled = false;
            }
        }

        void saveFile(HttpPostedFile file)
        {
            //Specify the path to save the uploaded file to.
            string savePath = Server.MapPath("Files");

            //Get the name of the file to upload
            string fileName = FileUpload1.FileName;

            //Check the path and the file name to for duplicates.
            string pathToCheck = savePath + fileName;

            //Create a temporary file name to use for checking duplicates
            string tempfilename = "";

            //Check to see if a file already exists with the
            //same name as the file to upload
            if (System.IO.File.Exists(pathToCheck))
            {
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck))
                {
                    //if a file with this name already exists,
                    //sufix the filename with a number.
                    tempfilename = fileName + "_" + counter.ToString();
                    pathToCheck = savePath + tempfilename;
                    counter++;
                }

                fileName = tempfilename;

                //Notify the user that the file name was changed.
                lblMessage.Text = "A file with the same name already exists." + "<br />Your file was successfully saved as: " + fileName;
            }
            else
            {
                //Notify the user that the file was saved successfully
                lblMessage.Text = "Your file was uploaded successfully.";
            }

            //Append the name of the file to the upload path
            savePath += fileName;

            //Change the static file name to the uploaded filename for future reference
            file_name = fileName;

            FileUpload1.SaveAs(savePath);
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string temp_file = FileUpload1.FileName;

                List<string> types = new List<string>();
                types.Add(".xml");
                types.Add(".bvh");
                types.Add(".txt");

                if (types.Contains(System.IO.Path.GetExtension(Server.MapPath("Files") + "//" + temp_file)))
                {
                    saveFile(FileUpload1.PostedFile);

                    btnContinue.Visible = true;
                }
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Server.Transfer("Converter.aspx");
        }

        protected void btnChoose_Click(object sender, EventArgs e)
        {
            Server.Transfer("Community.aspx");
        }
    }
}