#pragma checksum "C:\Users\Mudassir Uddin\Downloads\OnlineStoreForJewellery-master\OnlineStoreForJewellery-master\Views\Home\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a0e0fe27aac920de77c5e92811b43e46be24a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Gallery), @"mvc.1.0.view", @"/Views/Home/Gallery.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mudassir Uddin\Downloads\OnlineStoreForJewellery-master\OnlineStoreForJewellery-master\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mudassir Uddin\Downloads\OnlineStoreForJewellery-master\OnlineStoreForJewellery-master\Views\_ViewImports.cshtml"
using OnlineStoreForJewellery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mudassir Uddin\Downloads\OnlineStoreForJewellery-master\OnlineStoreForJewellery-master\Views\_ViewImports.cshtml"
using OnlineStoreForJewellery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a0e0fe27aac920de77c5e92811b43e46be24a2", @"/Views/Home/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"788d3c8d1487e3de0479c0aeaf84cb5501aec9bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Mudassir Uddin\Downloads\OnlineStoreForJewellery-master\OnlineStoreForJewellery-master\Views\Home\Gallery.cshtml"
  
    ViewData["Title"] = "Gallery";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Gallery</h1>\n\n\n\n");
            DefineSection("Styles2", async() => {
                WriteLiteral("\n    <style type=\"text/css\">\n     .untitled {\n         position: absolute;\n         height: 100%;\n         width: 100%;\n         animation: rotateHue infinite 20s linear;\n         animation-delay: 0.625s;\n     }\n\n     ");
                WriteLiteral(@"@keyframes rotateHue {
         0% {
             filter: hue-rotate(0deg);
         }

         20% {
             filter: hue-rotate(0deg);
         }

         25% {
             filter: hue-rotate(90deg);
         }

         45% {
             filter: hue-rotate(90deg);
         }

         50% {
             filter: hue-rotate(180deg);
         }

         70% {
             filter: hue-rotate(180deg);
         }

         75% {
             filter: hue-rotate(270deg);
         }

         95% {
             filter: hue-rotate(270deg);
         }

         100% {
             filter: hue-rotate(360deg);
         }
     }

     .untitled__shutters {
         position: absolute;
         height: 150vmax;
         width: 150vmax;
         left: calc(50% - 75vmax);
         top: calc(50% - 75vmax);
         pointer-events: none;
         z-index: 2;
         animation: rotateFrame 10s linear infinite;
     }

     ");
                WriteLiteral(@"@keyframes rotateFrame {
         0% {
             transform: rotate(0deg);
         }

         100% {
             transform: rotate(180deg);
         }
     }

     .untitled__shutters:before, .untitled__shutters:after {
         content: '';
         position: absolute;
         height: 100%;
         width: 100%;
         left: 50%;
         transform: translate3d(-50%, 0, 0);
         background-color: #b3401a;
         pointer-events: auto;
     }

     .untitled__shutters:before {
         bottom: 50%;
         animation: openTop 5s infinite;
     }

     ");
                WriteLiteral(@"@keyframes openTop {
         0% {
             transform: translate3d(-50%, 0, 0);
             animation-timing-function: cubic-bezier(0.8, 0, 0.1, 1);
         }

         40% {
             transform: translate3d(-50%, -65vmax, 0);
             animation-timing-functon: cubic-bezier(0.6, 0.04, 0.98, 0.335);
         }

         70% {
             transform: translate3d(-50%, -65vmax, 0);
             animation-timing-functon: cubic-bezier(0.6, 0.04, 0.98, 0.335);
         }

         100% {
             transform: translate3d(-50%, 0, 0);
             animation-timing-function: cubic-bezier(0.6, 0.04, 0.98, 0.335);
         }
     }

     .untitled__shutters:after {
         top: 50%;
         animation: openBottom 5s infinite;
     }

     ");
                WriteLiteral(@"@keyframes openBottom {
         0% {
             transform: translate3d(-50%, 0, 0);
             animation-timing-function: cubic-bezier(0.8, 0, 0.1, 1);
         }

         40% {
             transform: translate3d(-50%, 65vmax, 0);
             animation-timing-functon: cubic-bezier(0.6, 0.04, 0.98, 0.335);
         }

         70% {
             transform: translate3d(-50%, 65vmax, 0);
             animation-timing-functon: cubic-bezier(0.6, 0.04, 0.98, 0.335);
         }

         100% {
             transform: translate3d(-50%, 0, 0);
             animation-timing-function: cubic-bezier(0.6, 0.04, 0.98, 0.335);
         }
     }

     .untitled__slides {
         position: absolute;
         height: 100%;
         width: 100%;
         top: 0;
         left: 0;
         background-color: #b3401a;
     }

     .untitled__slide {
         position: absolute;
         height: 100%;
         width: 100%;
         opacity: 0;
         animation: showHideSlide infinite 20s steps(1);
     }

     ");
                WriteLiteral(@"@keyframes showHideSlide {
         0% {
             opacity: 1;
             pointer-events: auto;
             z-index: 1;
         }

         25% {
             opacity: 0;
             pointer-events: none;
             z-index: -1;
         }

         100% {
             opacity: 0;
             pointer-events: none;
             z-index: -1;
         }
     }

     .untitled__slide:nth-child(1) {
         animation-delay: 0s;
     }

         .untitled__slide:nth-child(1) .untitled__slideBg {
             background-image: url(https://unsplash.it/g/1500/2200?image=838);
         }

     .untitled__slide:nth-child(2) {
         animation-delay: 5s;
     }

         .untitled__slide:nth-child(2) .untitled__slideBg {
             background-image: url(https://unsplash.it/g/1500/1000?image=1078);
         }

     .untitled__slide:nth-child(3) {
         animation-delay: 10s;
     }

         .untitled__slide:nth-child(3) .untitled__slideBg {
             background-image: url(https://unsplash.it/g/1500/1");
                WriteLiteral(@"000?image=1077);
         }

     .untitled__slide:nth-child(4) {
         animation-delay: 15s;
     }

         .untitled__slide:nth-child(4) .untitled__slideBg {
             background-image: url(https://unsplash.it/g/1500/1200?image=345);
         }

     .untitled__slideBg {
         position: relative;
         height: 100%;
         width: 100%;
         top: 0;
         left: 0;
         background-size: cover;
         background-position: center;
         background-color: #b3401a;
         background-blend-mode: hard-light;
         opacity: 1;
         z-index: -1;
         animation: bgInOut 5s infinite;
     }

     ");
                WriteLiteral(@"@keyframes bgInOut {
         0% {
             transform: rotate(-45deg) scale(1.1);
             animation-timing-function: cubic-bezier(0.165, 0.84, 0.44, 1);
         }

         33% {
             transform: rotate(0deg);
         }

         50% {
             transform: rotate(0deg);
         }

         66% {
             transform: rotate(0deg);
             animation-timing-function: cubic-bezier(0.895, 0.03, 0.685, 0.22);
         }

         100% {
             transform: rotate(45deg) scale(0.9);
         }
     }

     .untitled__slideContent {
         position: absolute;
         top: 50%;
         left: 50%;
         transform: translate3d(-50%, -50%, 0);
         color: white;
         font-family: 'Abril Fatface', sans-serif;
         line-height: 0.8;
         letter-spacing: -0.025em;
         z-index: 2;
         opacity: 1;
         text-shadow: 0 0 0.5em rgba(179, 64, 26, 0.25);
         mix-blend-mode: lighten;
     }

         .untitled__slideContent span {
             display: bloc");
                WriteLiteral(@"k;
             font-size: 15vmin;
         }

     .button {
         font-family: 'Roboto Mono', sans-serif;
         text-decoration: none;
         font-weight: 800;
         text-transform: uppercase;
         font-size: 2vmin;
         display: inline-block;
         position: relative;
         border: 3px solid white;
         box-shadow: -0.5vmin 0.5vmin 0 rgba(255, 255, 255, 0.5);
         background: transparent;
         margin-top: 5vmin;
         mix-blend-mode: lighten;
         color: white;
         padding: 2vmin 2vmin 1.8vmin 2vmin;
         letter-spacing: 0.1em;
         text-shadow: none;
         line-height: 1;
         transform: translate3d(0.5vmin, -0.5vmin, 0);
         transition: all 100ms linear;
     }

         .button:hover {
             transform: translate3d(1vmin, -1vmin, 0);
             box-shadow: -1vmin 1vmin 0 rgba(255, 255, 255, 0.5);
             background: white;
             color: black;
         }

         .button:active {
             transform: translate3d(");
                WriteLiteral("0px, 0px, 0);\n             box-shadow: 0px 0px 0 rgba(255, 255, 255, 0.5);\n         }\n\n     ");
            }
            );
            WriteLiteral(@"    </style>
    }

    <div class=""untitled"">
        <div class=""untitled__slides"">
            <div class=""untitled__slide"">
                <div class=""untitled__slideBg""></div>
                <div class=""untitled__slideContent"">
                    <span>London</span>
                    <span>Scout</span>
                    <a class=""button""");
            BeginWriteAttribute("href", " href=\"", 7729, "\"", 7771, 2);
            WriteAttributeValue("", 7736, "https://unsplash.com/", 7736, 21, true);
            WriteLiteral("@");
            WriteAttributeValue("", 7759, "scoutthecity", 7759, 12, true);
            EndWriteAttribute();
            WriteLiteral(@" target=""/black"">Unsplash Profile</a>
                </div>
            </div>
            <div class=""untitled__slide"">
                <div class=""untitled__slideBg""></div>
                <div class=""untitled__slideContent"">

                    <span>Vladimir</span>
                    <span>Kudinov</span>
                    <a class=""button""");
            BeginWriteAttribute("href", " href=\"", 8122, "\"", 8159, 2);
            WriteAttributeValue("", 8129, "https://unsplash.com/", 8129, 21, true);
            WriteLiteral("@");
            WriteAttributeValue("", 8152, "madbyte", 8152, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" target=""/black"">Unsplash Profile</a>
                </div>
            </div>
            <div class=""untitled__slide"">
                <div class=""untitled__slideBg""></div>
                <div class=""untitled__slideContent"">
                    <span>Macio</span>
                    <span>Amorim</span>
                    <a class=""button""");
            BeginWriteAttribute("href", " href=\"", 8505, "\"", 8546, 2);
            WriteAttributeValue("", 8512, "https://unsplash.com/", 8512, 21, true);
            WriteLiteral("@");
            WriteAttributeValue("", 8535, "maicoamorim", 8535, 11, true);
            EndWriteAttribute();
            WriteLiteral(@" target=""/black"">Unsplash Profile</a>
                </div>
            </div>
            <div class=""untitled__slide"">
                <div class=""untitled__slideBg""></div>
                <div class=""untitled__slideContent"">
                    <span>Mario</span>
                    <span>Calvo</span>
                    <a class=""button""");
            BeginWriteAttribute("href", " href=\"", 8891, "\"", 8931, 2);
            WriteAttributeValue("", 8898, "https://unsplash.com/", 8898, 21, true);
            WriteLiteral("@");
            WriteAttributeValue("", 8921, "mariocalvo", 8921, 10, true);
            EndWriteAttribute();
            WriteLiteral(" target=\"/black\">Unsplash Profile</a>\n                </div>\n            </div>\n        </div>\n        <div class=\"untitled__shutters\"></div>\n    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
