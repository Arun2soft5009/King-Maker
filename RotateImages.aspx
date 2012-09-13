<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RotateImages.aspx.cs" Inherits="RotateImages" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Rotate Images in ASP.Net</title>
</head>
<body>
  <form id="HowToRotateImages" runat="server">
    <asp:Image ID="ImageToRotate" runat="server" AlternateText="Image To Rotate" ImageUrl="~/images/OnlineSLA.jpg" />
    <br />
    <asp:Button ID="btnRotateImages" runat="server" OnClick="btnRotateImages_Click" Text="Rotate Image Using RotateFlip" />
    <asp:Button ID="btnRotateImage1" runat="server" OnClick="btnRotateImage1_Click" Text="Rotate Image Using RotateTransform" />
    <br />
    <asp:Image ID="ImageAfterRotation" runat="server" AlternateText="Image After Rotation" />
  </form>
</body>
</html> 