﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GalleryApp
{
    public partial class ImageUpload : System.Web.UI.Page
    {

        void Page_PreRender()
        {
            string uploadfolder = MapPath("~/Resources/");

            DirectoryInfo dir = new DirectoryInfo(uploadfolder);

            DataList1.DataSource = dir.GetFiles();

            DataList1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool CheckFileType(String fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch(ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }

        protected void ClickToUpload(object sender, EventArgs e)
        {
            if(FileUpload1.HasFiles)
            {
                if(CheckFileType(FileUpload1.FileName))
                {
                    FileUpload1.SaveAs(MapPath("~/Resources/" + FileUpload1.FileName));
                }
            }
        }
    }
}