#pragma checksum "C:\Users\user\Desktop\TengizPataraia\Day_52\UrlShortener\UrlShortener\Views\UrlShortener\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee63373043ba8e407c3a28e623a59a1af434b248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UrlShortener_Index), @"mvc.1.0.view", @"/Views/UrlShortener/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee63373043ba8e407c3a28e623a59a1af434b248", @"/Views/UrlShortener/Index.cshtml")]
    public class Views_UrlShortener_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UrlShortener.ViewModels.Url>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Paste the URL to be shortened</h1>
<form action=""/"" method=""post"">
    <div id=""formurl"">
        <input type=""text"" name=""DestinationUrl"" placeholder=""Enter the link here"">
        <div id=""formbutton"">
            <input type=""submit"" value=""Shorten URL"">
        </div>
    </div>
</form>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UrlShortener.ViewModels.Url> Html { get; private set; }
    }
}
#pragma warning restore 1591
