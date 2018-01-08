<%@ Page Language="C#" AutoEventWireup="true" Inherits="main,maindll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="description" content="節能減碳愛地球，綠色革命，雲端節電，eco" />
    <title>節能技術查詢系統</title>
    <!-- InstanceBeginEditable name="doctitle" -->
    <!-- InstanceEndEditable -->
    <style type="text/css">
        @import url(http://fonts.googleapis.com/earlyaccess/notosanstc.css);

        body
        {
            font-family: 'Noto Sans TC', sans-serif;
        }
    </style>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/css3menu_style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        ._css3m
        {
            display: none;
        }

        }
        </style > <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js" > </script > <script langage="JavaScript" SRC="js/banner.js" > </script >
        <!-- InstanceBeginEditable name="head" -->
        <meta name="description" content="全球唯一專業智能天賦檢測機構，為您專業解析，學習升學、就業轉職、提升個人魅力、發揮才能，讓您發掘天賦、取得優勢，登上卓越！"/ > <style type="text/css" >
    </style>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/sidebar.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
    <script langage="JavaScript" src="js/banner.js"></script>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceEndEditable -->
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
        }

            table td
            {
                font-size: 18px;
            }

        .auto-style3
        {
            width: 113px;
        }

        .auto-style4
        {
            height: 39px;
            width: 113px;
        }

        .auto-style5
        {
            width: 106px;
        }

        .auto-style6
        {
            height: 39px;
            width: 106px;
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

                <div id="wrap">
                    <div id="header">
                        <p class="logo_en">
                            <img src="img/中華電信橫式logo.jpg" />
                        </p>
                    </div>
                    <!-- Start css3menu.com BODY section -->
                    <div id="nav_area">
                        &nbsp;
                <div id="nav">
                </div>
                    </div>
                    <!-- End css3menu.com BODY section -->
                    <!-- InstanceBeginEditable name="can edit" -->
                    <!--banner start-->
                    <div id="banner">
                        <br />
                        <table style="color: white;">
                            <tr>
                                <td align="right">資料最後接收時間：</td>
                                <td>
                                    <asp:Label ID="LUploadScan" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right">資料上傳時間：</td>
                                <td>
                                    <asp:Label ID="LUploadAns" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td align="right">資料接收時間：</td>
                                <td>
                                    <asp:Label ID="Lreceive" runat="server"></asp:Label></td>
                            </tr>
                        </table>

                    </div>
                    <!--banner end-->
                    <!--content01 start-->
                    <div id="content">
                        <ul class="main_content">
                            <li class="news">
                                <img src="./img/title_03.jpg" alt="再生能源新聞" border="0" /><br />
                                <table style="width: 313px">
                                    <tr>
                                        <td colspan="3">
                                            <img src="img/door_logo.png" />
                                        </td>
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
                                            <a href="#" onclick="window.open('report/reportdi.aspx?di=di1&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                                <asp:Label ID="Ldi1name" runat="server"></asp:Label>
                                            </a>
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
                                            <a href="#" onclick="window.open('report/reportdi.aspx?di=di2&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                                <asp:Label ID="Ldi2name" runat="server"></asp:Label>
                                            </a>
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
                                            <a href="#" onclick="window.open('report/reportdi.aspx?di=di3&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                                <asp:Label ID="Ldi3name" runat="server"></asp:Label>
                                            </a>
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
                                            <a href="#" onclick="window.open('report/reportdi.aspx?di=di4&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                                <asp:Label ID="Ldi4name" runat="server"></asp:Label>
                                            </a>
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
                                            <a href="#" onclick="window.open('report/reportdi.aspx?di=di5&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                                <asp:Label ID="Ldi5name" runat="server"></asp:Label>
                                            </a>
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

                            </li>
                            <li class="real_time">
                                <img src="./img/title_01.jpg" alt="再生能源即時發電統計" border="0" /></a>
               <table style="width: 314px">
                   <tr>
                       <td colspan="4">
                           <img src="img/TRMP_logo.png" />
                       </td>
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
                           <a href="#" onclick="window.open('report/humidity.aspx?ai=ai1&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                <asp:Label ID="Lai1name" runat="server"></asp:Label>
                           </a>
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
                           <a href="#" onclick="window.open('report/temp.aspx?ai=ai2&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                <asp:Label ID="Lai2name" runat="server"></asp:Label>
                           </a>
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
                           <a href="#" onclick="window.open('report/temp.aspx?ai=ai3&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                <asp:Label ID="Lai3name" runat="server"></asp:Label>
                           </a>
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
                           <a href="#" onclick="window.open('report/temp.aspx?ai=ai4&ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>','','channelmode,scrollbars')">
                                <asp:Label ID="Lai4name" runat="server"></asp:Label>
                           </a>
                       </td>
                       <td class="auto-style5">
                           <asp:Label ID="Lai4" runat="server">0.00</asp:Label>
                       </td>
                       <td>℃</td>
                   </tr>

               </table>
                            </li>
                            <li class="greenpower_info">
                                <a href="TimeControl.aspx?ewatch=<%=DateTime.Now.ToString("yyyyMMddHHmmss")%>">
                                <img src="./img/title_02.jpg" alt="綠色電力認購資訊" border="0" /></a>
                        <br />
                                <table style="width: 318px">
                                    <tr>
                                        <td colspan="3">
                                            <img src="img/air_logo.png" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td></td>
                                        <td>
                                            <asp:Label ID="Ldo1name" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="do1start" runat="server" Text="啟動" OnClientClick="return confirm('確定開啟設備嗎?');" OnClick="do1start_Click" />
                                            <asp:Button ID="do1stop" runat="server" Text="停止" OnClientClick="return confirm('確定停止設備嗎?');" OnClick="do1stop_Click" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td></td>
                                        <td>
                                            <asp:Label ID="Ldo2name" runat="server"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="do2start" runat="server" Text="啟動" OnClientClick="return confirm('確定開啟設備嗎?');" OnClick="do2start_Click" />
                                            <asp:Button ID="do2stop" runat="server" Text="停止" OnClientClick="return confirm('確定停止設備嗎?');" OnClick="do2stop_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </li>
                        </ul>
                    </div>
                    <div id="copyright">
                        <p><a href="#">中華電信(南崗服務中心)│</a> <a href="#">電話：049-226-1410│</a> <a href="#">地址：南投市南崗三路26號│</a> <a href="#">關於│ </a><a href="#">隱私權聲明│</a></p>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
