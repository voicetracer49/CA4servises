<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CA4Client.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!--<style type="text/css">
        #form1 {
            height: 491px;
        }
    </style> -->
</head>
<body style="height: 476px; width: 648px">
    <form id="form1" runat="server">

        <asp:Label ID="Label2" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="Archers" Width=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="Find a Nick and Prizes by name:" Width=""></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1NameIn" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="find Alias & Prizes" />
        <br />
        <br />
&nbsp;<br />
        Prizes<br />
&nbsp;<asp:ListBox ID="ListBox1Prizes" runat="server" Height="83px" Width="384px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="Calculation" Width=""></asp:Label>
&nbsp;<br />
        <asp:Label ID="Label7" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="Sum of nr. divided by &quot;,&quot;" Width=""></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2InputSum" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button2Sum" runat="server"  OnClick="Button2Sum_Click"  Text="Calculate" />
        &nbsp;
        <asp:Label ID="Label8" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="result" Width=""></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox3ResultSum" runat="server" Width="91px" ReadOnly="True"></asp:TextBox>
        <br />
     &nbsp;<br />
        <asp:Label ID="Label1" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="Average of nr. divided by &quot;,&quot;" Width=""></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server"  OnClick="Button2_Click"  Text="Calculate" />
        &nbsp;
        <asp:Label ID="Label4" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="result" Width=""></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="91px" ReadOnly="True"></asp:TextBox>
        <br />
       &nbsp;<br />
        <asp:Label ID="Label6" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="Sorting of nr. divided by &quot;,&quot;" Width=""></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server"  OnClick="Button3_Click"  Text="Calculate" />
        &nbsp;
        <asp:Label ID="Label9" runat="server" BackColor="" BorderColor="" BorderWidth="" ForeColor="" Height="" Text="result" Width=""></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="91px" ReadOnly="True"></asp:TextBox>
        <br />
    

    </form>
</body>
</html>
