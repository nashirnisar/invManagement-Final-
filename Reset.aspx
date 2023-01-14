<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reset.aspx.cs" MasterPageFile="~/Default.Master" Inherits="InventoryManagement1._1.Reset" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
     <section class="vh-100">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card shadow-2-strong" style="border-radius: 1rem;">
    <div class="card login-form">
	<div class="card-body">
		<h3 class="card-title text-center">Reset password</h3>
          <div class="bottom-left"></div>
            <asp:TextBox ID="txtText" runat="server" Width="274px"  placeholder="Enter Your Username or Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Username or Email First"  ControlToValidate="txtText" ValidationGroup="r1" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Send Password" Width="129px" ValidationGroup="r1" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
		        </div>			
             </div>
           </div>
        </div>
      </div>
    </div>
 
</section>
</asp:Content>