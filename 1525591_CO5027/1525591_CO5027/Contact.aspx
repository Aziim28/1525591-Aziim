<%@ Page Title="Contact|AA's Collection" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="_1525591_CO5027.Sites.ContactUs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--https://www.youtube.com/watch?v=ngldKCSXA6U tutorial on to create email and submit button-->
    <!--https://www.youtube.com/watch?v=Fw1X7HLZfos tutorial on to create email and submit button-->

    <link href="../CSS/Contact.css" rel="stylesheet" />

    <!--contact design-->

    <div id="wrap">
             <p>How to contact us? one of the way is by sending comments to us!</p>  
            <table>
                <tr>
                    <td>
                        <b>Name:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="fieldName" Width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter your name"
                        ControlToValidate="fieldName"
                        Text="*" 
                        ForeColor="Red"   
                        ></asp:RequiredFieldValidator>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <b>Email:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="fieldEmail" Width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter your Email" 
                            Display="Dynamic"    
                            Text="*"
                            ForeColor="Red"   
                        ControlToValidate="fieldEmail" ClientIDMode="Inherit"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Do enter a valid email" 
                            ControlToValidate="fieldEmail" 
                            ForeColor="Red"
                             Display="Dynamic"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                            >*</asp:RegularExpressionValidator>
                    </td>
                </tr>

                 <tr>
                    <td>
                        <b>Topic:</b>
                    </td>
                    <td>
                        <asp:TextBox ID="fieldTopic" Width="200px" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter your Topic"
                        ControlToValidate="fieldTopic"
                        Text="*" 
                        ForeColor="Red"   
                        ></asp:RequiredFieldValidator>
                    </td>
                </tr>

                 <tr>
                    <td style="vertical-align:top">
                        <b>Comments:</b>
                    </td>
                    <td style="vertical-align:top">
                        <asp:TextBox ID="fieldComments" Width="200px" runat="server" Rows="6" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td style="vertical-align:top">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter your comments"
                        ControlToValidate="fieldComments"
                        Text="*" 
                        ForeColor="Red"   
                        ></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td colspan="3">
                        <asp:ValidationSummary HeaderText="Please Fill in the blank" ForeColor="Red" ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td colspan="3">
                        <asp:Label ID="word" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="submitbtn" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
                </tr>

            </table>

        <!--map-->
        <!--where i got the location of map-https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3975.321466154953!2d114.92948051448694!3d4.885730896452569!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x32228ac8ee3f7d03%3A0xcacd96016959ec39!2sLaksamana+College+of+Business!5e0!3m2!1sen!2sbn!4v1491055498260-->
        <!--https://www.youtube.com/watch?v=zuklK5Ht56E inserting map-->
       <div id="headmap">
           <p>You can also come to our place by following this map!</p>
       </div>
        <div id="mymap">
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3975.321466154953!2d114.92948051448694!3d4.885730896452569!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x32228ac8ee3f7d03%3A0xcacd96016959ec39!2sLaksamana+College+of+Business!5e0!3m2!1sen!2sbn!4v1491055498260"></iframe>
        </div>

        </div>
</asp:Content>
