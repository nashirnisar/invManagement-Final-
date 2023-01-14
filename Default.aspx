<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InventoryManagement1._1.Default" MasterPageFile="~/Default.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
                          
    <section class="vh-100">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card shadow-2-strong" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">
            <h2>ICSC Inventory Issuing System</h2><br />
            <h3 class="mb-5">Sign in</h3>

            <div class="form-outline mb-4">
                <asp:TextBox ID="txtUsername" runat="server" class="form-control form-control-lg" placeholder="Username"> </asp:TextBox>
                <label class="form-label" for="typePasswordX-2" ></label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Your Username First" ControlToValidate="txtUsername" ValidationGroup="d1" ForeColor="#FF5050"></asp:RequiredFieldValidator>
              </div>

            <div class="form-outline mb-4">
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control form-control-lg" placeholder="Password"></asp:TextBox>
              <label class="form-label" for="typePasswordX-2"></label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Your Password First" ControlToValidate="txtPassword" ValidationGroup="d1" ForeColor="#FF5050"></asp:RequiredFieldValidator>
              </div>
            </div>         
              <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-info" OnClick="Button1_Click1" ValidationGroup="d1" />
            <hr class="my-4">            
              <center> <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label></center>
          </div>
        </div>
      </div> 
    </div>
</section>
    </asp:Content>





