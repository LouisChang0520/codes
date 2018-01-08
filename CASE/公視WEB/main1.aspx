<%@ Page Language="C#" AutoEventWireup="true" Inherits="main1,main1dll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        <!--
        a:link
        {
            text-decoration: none;
            color: #666666;
        }

        a:visited
        {
            text-decoration: none;
        }

        a:hover
        {
            text-decoration: none;
            color: #000000;
        }

        a:active
        {
            text-decoration: none;
        }

        .auto-style2
        {
            height: 39px;
        }
        -->
        table
        {
            font-size:200%;
        }

        @media (min-width: 600px) and (max-width: 900px)
        {
            table
            {
                font-size: 400%;
            }
        }

        @media (min-width: 901px)
        {
            table
            {
                font-size: 800%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server">
                </asp:Timer>
                <img src="img/中華電信橫式logo.jpg" /><br />
                資料最後接收時間：<asp:Label ID="LUploadScan" runat="server"></asp:Label><br />
                資料上傳時間：<asp:Label ID="LUploadAns" runat="server"></asp:Label><br />
                資料接收時間：<asp:Label ID="Lreceive" runat="server"></asp:Label>

                <table border="1">
                    <tr>
                        <td colspan="3" align="center">門禁狀態</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>地點</td>
                        <td>狀態</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Idi1" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td>
                            <asp:Label ID="Ldi1name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Ldi1status" runat="server">未知</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Idi2" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td>
                            <asp:Label ID="Ldi2name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Ldi2status" runat="server">未知</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Idi3" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td>
                            <asp:Label ID="Ldi3name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Ldi3status" runat="server">未知</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Idi4" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td>
                            <asp:Label ID="Ldi4name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Ldi4status" runat="server">未知</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Idi5" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td>
                            <asp:Label ID="Ldi5name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Ldi5status" runat="server">未知</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Idi6" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td>
                            <asp:Label ID="Ldi6name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Ldi6status" runat="server">未知</asp:Label>
                        </td>
                    </tr>
                </table>

                <table border="1">
                    <tr>
                        <td colspan="4" align="center">環境溫溼度</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style3">狀態點位</td>
                        <td class="auto-style5">數值</td>
                        <td>單位</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Iai1" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td class="auto-style3">
                            <asp:Label ID="Lai1name" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Lai1" runat="server">0.00</asp:Label>
                        </td>
                        <td>RH</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Iai2" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td class="auto-style3">
                            <asp:Label ID="Lai2name" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Lai2" runat="server">0.00</asp:Label>
                        </td>
                        <td>℃</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Image ID="Iai3" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td class="auto-style4">
                            <asp:Label ID="Lai3name" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:Label ID="Lai3" runat="server">0.00</asp:Label>
                        </td>
                        <td class="auto-style2">℃</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Iai4" runat="server" ImageUrl="~/img/green.png" />
                        </td>
                        <td class="auto-style3">
                            <asp:Label ID="Lai4name" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Lai4" runat="server">0.00</asp:Label>
                        </td>
                        <td>℃</td>
                    </tr>
                </table>

                <table border="1">
                    <tr>
                        <td colspan="3" align="center">
                            <a href="TimeControl1.aspx?ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>">冷氣狀態點位
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Ldo1name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="do1start" runat="server" Text="啟動" OnClientClick="return confirm('確定開啟設備嗎?');" OnClick="do1start_Click" style="font-size:100%;" />
                            <asp:Button ID="do1stop" runat="server" Text="停止" OnClientClick="return confirm('確定停止設備嗎?');" OnClick="do1stop_Click" style="font-size:100%;" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Ldo2name" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="do2start" runat="server" Text="啟動" OnClientClick="return confirm('確定開啟設備嗎?');" OnClick="do2start_Click" style="font-size:100%;" />
                            <asp:Button ID="do2stop" runat="server" Text="停止" OnClientClick="return confirm('確定停止設備嗎?');" OnClick="do2stop_Click" style="font-size:100%;" />
                        </td>
                    </tr>
                </table>
                <p><a href="#">中華電信(南崗服務中心)│</a> <a href="#">電話：049-226-1410│</a> <a href="#">地址：南投市南崗三路26號│</a> <a href="#">關於│ </a><a href="#">隱私權聲明│</a></p>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
