<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="PresentacionWeb.AltaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>INGRESO DE NUEVO ALUMNO</h2>
            <table cssClass="table" style="width:100%;">
        <tr>
            <td>DNI: </td>
            <td>
                <asp:TextBox ID="TxtDNI" runat="server" Height="16px" Width="245px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Apellido: </td>
            <td>
                <asp:TextBox ID="TxtApellido" runat="server" Height="16px" Width="245px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nombre: </td>
            <td>
                <asp:TextBox ID="TxtNombre" runat="server" Height="16px" Width="245px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td> <asp:Button ID="btn_enviar" CssClass="btn-primary" runat="server" Text="Enviar" OnClick="btn_enviar_Click" /></td>
            <td>  <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>  </td>
        </tr>
    </table>


            
        </div>
        
       
    </form>
    
</body>
</html>
