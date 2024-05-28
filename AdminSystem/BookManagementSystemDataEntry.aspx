<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Book Data Entry</title>
    <style type="text/css">
        #form1 {
            height: 523px;
        }
    </style>
</head>
<body style="height: 21px">
    <form id="form1" runat="server">
    Book Management
           
        
        
        <asp:Label ID="LblBookId" runat="server" style="z-index: 1; left: 16px; top: 54px; position: absolute" Text="BookID" width="31px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TBBookid" runat="server" style="z-index: 1; left: 94px; top: 53px; position: absolute"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnFind" runat="server" style="z-index: 1; left: 274px; top: 53px; position: absolute" Text="Find" OnClick="BtnFind_Click" />
        </p>
    
        &nbsp;<asp:Label ID="LblTitle" runat="server" style="z-index: 1; left: 16px; top: 91px; position: absolute; bottom: 566px;" Text="Title" width="31px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBTitle" runat="server" style="z-index: 1; left: 94px; top: 91px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;<asp:Label ID="LblGenre" runat="server" style="z-index: 1; left: 16px; position: absolute" Text="Genre" width="31px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBGenre" runat="server" style="z-index: 1; left: 94px; top: 129px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 13px; position: absolute; bottom: 676px;" Text="Genre"></asp:Label>
        &nbsp;&nbsp;<br />
        <asp:Label ID="LblPublisher" runat="server" style="z-index: 1; left: 16px; top: 337px; position: absolute; height: 19px;" Text="Pulisher" width="31px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TBYear" runat="server" style="z-index: 1; left: 94px; top: 205px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LblYear" runat="server" style="z-index: 1; left: 16px; top: 199px; position: absolute" Text="Year" width="31px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBPrice" runat="server" style="z-index: 1; left: 94px; top: 243px; position: absolute" width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="LblPrice" runat="server" style="z-index: 1; left: 16px; top: 251px; position: absolute; height: 19px;" Text="Price" width="31px"></asp:Label>
        &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="LblQuantity" runat="server" style="z-index: 1; left: 16px; top: 297px; position: absolute; height: 19px;" Text="Quantity" width="31px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBQuantity" runat="server" style="z-index: 1; left: 94px; top: 300px; position: absolute" width="128px"></asp:TextBox>
&nbsp;<p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 27px; top: 419px; position: absolute" Text="Active" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnOk" runat="server" style="z-index: 1; left: 27px; top: 489px; position: absolute" Text="Ok" OnClick="BtnOk_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TBPublisher" runat="server" style="z-index: 1; left: 94px; top: 338px; position: absolute" width="128px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 140px; top: 492px; position: absolute" Text="Cancel" />
            &nbsp;</p>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    </body>
    </html>
