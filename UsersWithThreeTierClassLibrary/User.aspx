<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="UsersWithThreeTierClassLibrary.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-2"></div>
        <div style="" class="col-sm-8">
            <div class="well">
                <div class="row">
                    <div class="col-sm-4">
                        <label class="control-label">ID:</label>
                        <asp:TextBox runat="server" ID="USERIDTextbox" CssClass="form-control" />
                    </div>
                    <div class="col-sm-8">
                        <label class="control-label">Username:</label>
                        <asp:TextBox runat="server" ID="USERNAMETextBox" CssClass="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label class="control-label">Email Address:</label>
                        <asp:TextBox runat="server" ID="EMAILTextBox" CssClass="form-control" />
                    </div>
                    <div class="col-sm-4">
                        <label class="control-label">Password: </label>
                        <asp:TextBox runat="server" ID="USERPASSTextBox" CssClass="form-control" />
                    </div>
                    <div class="col-sm-4">
                        <label class="control-label">User Type:</label>
                        <asp:DropDownList ID="_ddlstUserType" runat="server" DataSourceID="_dtsrcUserTypeDropDown" DataTextField="USERTYPENAME" DataValueField="USERTYPEID" CssClass="form-control"></asp:DropDownList>
                        <asp:SqlDataSource runat="server" ID="_dtsrcUserTypeDropDown" ConnectionString='<%$ ConnectionStrings:CnnctStrng %>' SelectCommand="SELECT [USERTYPEID], [USERTYPENAME] FROM [USERTYPE]"></asp:SqlDataSource>
                    </div>
                </div>
                <hr />
                <asp:Button ID="_btnInsert" runat="server" Text="Insert" CssClass="btn btn-success" OnClick="_btnInsert_Click" />
                <asp:Button ID="_btnUpdate" runat="server" Text="Update" CssClass="btn btn-info" OnClick="_btnUpdate_Click" />
                <asp:Button ID="_btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="_btnDelete_Click" />
                <%--<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" CssClass="btn btn-danger" OnClientClick="this.form.reset();return false;" />--%>
                <br />
            </div>
        </div>
        <div class="col-sm-2"></div>
    </div>
    <div class="row">
        <div class="well">
            <asp:GridView ID="_grdvwUser" runat="server" CssClass="table table-responsive table-condensed table-hover" HeaderStyle-CssClass="info" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="USERID" HeaderText="ID" />
                    <asp:BoundField DataField="USERNAME" HeaderText="Username" />
                    <asp:BoundField DataField="EMAIL" HeaderText="Email" />
                    <asp:BoundField DataField="USERPASS" HeaderText="Password" />
                    <asp:BoundField DataField="USERTYPENAME" HeaderText="User Type" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
