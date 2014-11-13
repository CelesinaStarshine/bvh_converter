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
        <br />
        Please upload your file here:<br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Enabled="False" OnClick="btnUpload_Click" Text="Upload" />
        <br />
        <br />
        <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_Click" Text="Continue" Visible="False" />
        <br />
        <br />
        Click below in order to select from the community shared BVH files:<br />
        <asp:Button ID="btnChoose" runat="server" OnClick="btnChoose_Click" Text="Choose" />
     
    </div>
    </form>
</body>
</html>
