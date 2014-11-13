<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="BVH_Animation_Converter.Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome to the BVH Animation Conversion System.<br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        To convert a file you first need to either <asp:Button ID="btnUpload" runat="server" Font-Size="8.2pt" Height="22px" Text="Upload" Width="49px" OnClick="btnUpload_Click" />
&nbsp;one.<br />
        Or
        <asp:Button ID="btnChoose" runat="server" Font-Size="8.2pt" Height="22px" Text="Choose" Width="53px" OnClick="btnChoose_Click" style="margin-top: 1px; margin-bottom: 1px" />
&nbsp;one from the community shared BVH files.<br />
        <br />
        Once you have selected a file, click below to convert it for the Animation System to understand.<br />
        The file you have selected is:
        <asp:Label ID="lblFile" runat="server"></asp:Label>
        <br />
        Do you wish to save it after conversion and share with the community or delete it?<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
            <asp:ListItem Value="Save"></asp:ListItem>
            <asp:ListItem Value="Delete"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnConvert" runat="server" Enabled="False" OnClick="btnConvert_Click" style="margin-top: 2px; margin-left: 9px;" Text="Convert" />
        <br />
        <br />
        After the conversion is complete, your converted file will appear below:<br />
        <br />
        <asp:Label ID="lblConverted" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
