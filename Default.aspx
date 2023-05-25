<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SubirImagenes._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">Descripción
                <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
            </p>
            <p class="lead">Subir Imagen
                <asp:FileUpload ID="FileUploadImagen" class="btn btn-secondary" runat="server" />
            </p>
            <p class="lead">
                <asp:Button ID="ButtonSubir" runat="server" class="btn btn-primary" Text="Subir" OnClick="ButtonSubir_Click" />
            &nbsp;<asp:Label ID="LabelEstado" runat="server"></asp:Label>
            </p>
            <p class="lead">&nbsp;</p>
        </section>
    </main>

</asp:Content>
