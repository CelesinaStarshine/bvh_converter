<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BVH_Upload.aspx.cs" Inherits="BVH_Animation_Converter.BVH_Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
        Welcome to the BVH Animation Conversion System.<br />
        First, please upload your BVH file below and then click on &quot;Continue&quot; when prompted.<br />
        Otherwise, if you wish to use one of the community shared BVH files, then click on &quot;Choose&quot; instead.<br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
     
    </div>
    </form>
</body>
</html>
