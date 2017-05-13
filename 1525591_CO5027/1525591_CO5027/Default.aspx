<%@ Page Title="Home|AA's Collection" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1525591_CO5027.Sites.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/Default.css" rel="stylesheet" />
    <!--http://www.jssor.com/demos/banner-rotator.slider where i got the slideshow code-->

    <!-- start of jssorslideshow-->
    <script src="JavaScript.js"></script>
    <link href="CSS/SliderSheet.css" rel="stylesheet" />
    <script src="js/jquery-1.11.3.min.js"></script>
    <script src="js/jssor.slider-23.0.0.mini.js"></script>
   
    <div id="jssor_1">
        <!-- Loading Screen -->
        <div id="screen" data-u="loading"> </div>
            <div id="filter"></div>
            <div id="position"></div>
       
        <div id="sliding" data-u="slides">
             <div>
                <img data-u="image" src="swatch/AApng2.png" alt="" />
            </div>
            <div>
               <img data-u="image" src="swatch/slide1.jpg" alt=""/><!--pic extract from-https://www.wired.com/tag/magazine-22-08/-->
            </div>
           <div>
                <img data-u="image" src="swatch/slide2.jpg" alt=""/><!--pic extract from-https://donghochonam.wordpress.com/2015/10/02/top-3-mau-dong-ho-cho-nam-dung-phong-cach-quy-toc/-->
            </div>
            <div>
                <img data-u="image" src="swatch/slide3.jpg" alt=""/><!--pic extract from-http://www.mobilmania.cz/s-hodinkami-swatch-pujde-platit-pres-nfc-na-bezkontaktnich-terminalech/a-1332815/default.aspx-->
            </div>
           
        </div>

        <!-- Bullet Navigator -->
        <div data-u="navigator" class="jssorb01">

            <div id="bulpro" data-u="prototype"></div>
        </div>
        <!-- Arrow Navigator -->
        <span data-u="arrowleft" class="jssora05l" data-autocenter="2"></span>
        <span data-u="arrowright" class="jssora05r" data-autocenter="2"></span>
    </div>
    <script type="text/javascript">jssor_1_slider_init();</script>

    <!-- #endregion Jssor Slider End -->

    <div id="prodakku">
    <table>
        <tr>
          <td><img src="swatch/w1.jpg" alt=""/> <p>BLACKER</p> <p>$55</p></td><!--pic extract from-https://www.chic-time.co.uk/74_swatch-->
          <td><img src="swatch/w2.jpg" alt=""/> <p>SPAINER</p> <p>$65</p></td><!--pic extract from-http://sunarloji.com/jam-tangan-swatch-original/20225-jam-tangan-original-swatch-petroleuse-gg222-swatch.html-->
          <td><img src="swatch/w3.jpg" alt=""/> <p>ROTAR</p> <p>$65</p></td><!--pic extract from-http://www.newswisswatches.co.uk/swatch-suow133-originals-new-gent-wall-paint-unisex-watch-->
          <!-- <td><img src="swatch/w10.jpg" alt=""/></td>pic extract from-https://www.chic-time.co.uk/men-s-watches/39119-men-s-watches-swatch-suon703-0054362632430.html-->
        </tr>
          
        <tr>
            <td><img src="swatch/w4.jpg" alt="" /> <p>SMILO</p> <p>$80</p></td><!--pic extract from-https://www.chic-time.co.uk/men-s-watches/40131-men-s-watches-swatch-yts713-7610522567542.html-->
            <td><img src="swatch/w5.jpg" alt="" /> <p>SHILO</p> <p>$82</p></td><!--pic extract from-https://www.chic-time.co.uk/ladies-watches/42309-ladies-watches-swatch-ycs580g--7610522286405.html-->
            <td><img src="swatch/w6.jpg" alt=""/> <p>SNAVO</p> <p>$85</p></td><!--pic extract from-https://www.chic-time.co.uk/men-s-watches/47703-men-s-watches-swatch-yvs410g-7610522286399.html-->
            <!--<td><img src="swatch/w11.jpg" alt=""/></td>pic extract from-http://www.laikrodziai.lt/en/watches/swatch-ycs569.12056--> 
        </tr>
    </table>
        </div>
</asp:Content>
