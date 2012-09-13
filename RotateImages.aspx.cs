using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class RotateImages : System.Web.UI.Page
{
    String pathToImagesFolder = HttpContext.Current.Request.PhysicalApplicationPath + "images\\";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRotateImages_Click(object sender, EventArgs e)
    {
        String imageToRotateFileName = "OnlineSLA.jpg";
        String imageAfterRotationFileName = "ImageAfterRotation.jpg";

        // Load 'Image To Rotate' into Memory
        using (System.Drawing.Image imageToRotate = System.Drawing.Image.FromFile(pathToImagesFolder + imageToRotateFileName))
        {
            // Now Rotate this Image by 90 degree without flipping
            // This method is used to 'Rotate Image' or 'Flip Image' or 'Rotate and Flip Image'
            imageToRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // Now Save the Rotated Image on File System
            imageToRotate.Save(pathToImagesFolder + imageAfterRotationFileName);
        }
        // Display the Rotated image
        ImageAfterRotation.ImageUrl = "~/images/" + imageAfterRotationFileName;  
    }
    protected void btnRotateImage1_Click(object sender, EventArgs e)
    {
          String imageToRotateFileName = "OnlineSLA.jpg";
        String imageAfterRotationFileName = "ImageAfterRotation.jpg";

        // Load 'Image To Rotate' into Memory
        using (System.Drawing.Image imageToRotate = System.Drawing.Image.FromFile(pathToImagesFolder + imageToRotateFileName))
        {
            // Now Rotate this Image by 90 degree without flipping
            // This method is used to 'Rotate Image' or 'Flip Image' or 'Rotate and Flip Image'
            imageToRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // Now Save the Rotated Image on File System
            imageToRotate.Save(pathToImagesFolder + imageAfterRotationFileName);
        }

        // Display the Rotated image
        ImageAfterRotation.ImageUrl = "~/images/" + imageAfterRotationFileName;  

    }
}