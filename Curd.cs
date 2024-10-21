<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="_24August.crud" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRUD Operations</title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <h3>Add New Student</h3>
            <label>First Name:</label>
            <asp:TextBox ID="txtFirstNameInsert" runat="server"></asp:TextBox><br />
            <label>Last Name:</label>
            <asp:TextBox ID="txtLastNameInsert" runat="server"></asp:TextBox><br />
            <label>City:</label>
            <asp:TextBox ID="txtCityInsert" runat="server"></asp:TextBox><br />
            <label>Phone:</label>
            <asp:TextBox ID="txtPhoneInsert" runat="server"></asp:TextBox><br />
            <label>Address:</label>
            <asp:TextBox ID="txtAddressInsert" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
        
        <div>
            <asp:GridView ID="grd_view" runat="server" AutoGenerateColumns="false" DataKeyNames="id" OnRowEditing="grd_view_RowEditing" OnRowUpdating="grd_view_RowUpdating" OnRowCancelingEdit="grd_view_RowCancelingEdit" OnRowDeleting="grd_view_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="S.No.">
                        <ItemTemplate>
                            <%# Container.DataItemIndex + 1 %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="First Name">
                        <ItemTemplate>
                            <asp:Label ID="txtfirst" runat="server" Text='<%# Bind("Firstname") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtfirstEdit" runat="server" Text='<%# Bind("Firstname") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Last Name">
                        <ItemTemplate>
                            <asp:Label ID="txtlast" runat="server" Text='<%# Bind("Lastname") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtlastEdit" runat="server" Text='<%# Bind("Lastname") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="txtcity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtcityEdit" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Phone">
                        <ItemTemplate>
                            <asp:Label ID="txtphone" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtphoneEdit" runat="server" Text='<%# Bind("Phone") %>'></asp:TextBox>
                        </EditItemTemplate>  
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Address">
                        <ItemTemplate>
                            <asp:Label ID="lbladdress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                        </ItemTemplate> 
                        <EditItemTemplate>
                            <asp:TextBox ID="lbladdressEdit" runat="server" Text='<%# Bind("Address") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
