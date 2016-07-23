<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="tiradoonline.Upload.upload" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>

    </head>
    <body>
        <form id="form1" runat="server">
    <div>
        
        <asp:FileUpload ID="fileUploadFileName" runat="server" />

        <asp:Button ID="buttonFileUpload" runat="server" Text="Upload File" OnClick="buttonFileUpload_Click" />
    </div>
    </form>
</body>
</html>
