#pragma checksum "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8b20525e90388aa30f68f33568b6141d975ce8"
// <auto-generated/>
#pragma warning disable 1591
namespace Syncfusion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Syncfusion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/buttons")]
    public partial class Button : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "button-section");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "button-control");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(12);
            __builder.AddAttribute(13, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(15, "Primary");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(19);
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(21, "Normal");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(27);
            __builder.AddAttribute(28, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "CssClass", "e-outline");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Outline");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(35);
            __builder.AddAttribute(36, "CssClass", "e-flat");
            __builder.AddAttribute(37, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "Flat");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(47);
            __builder.AddAttribute(48, "CssClass", "e-success");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(50, "Success");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(54);
            __builder.AddAttribute(55, "CssClass", "e-warning");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(57, "Warning");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(63);
            __builder.AddAttribute(64, "CssClass", "e-danger");
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(66, "Danger");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(70);
            __builder.AddAttribute(71, "CssClass", "e-info");
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(73, "Info");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "row");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(81);
            __builder.AddAttribute(82, "IconCss", "e-btn-sb-icons e-add-icon");
            __builder.AddAttribute(83, "CssClass", "e-small e-round");
            __builder.AddAttribute(84, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(88);
            __builder.AddAttribute(89, "CssClass", "e-flat");
            __builder.AddAttribute(90, "IsToggle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "Content", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                                                               content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "IconCss", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                                                                                  iconCss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                                                                                                     onToggleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-xs-6 col-sm-6 col-lg-6 col-md-6");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(100);
            __builder.AddAttribute(101, "IsPrimary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "IconCss", "e-btn-sb-icons e-open-icon");
            __builder.AddAttribute(103, "IconPosition", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Buttons.IconPosition>(
#nullable restore
#line 54 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
                                                                                                      IconPosition.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(105, "Open");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "col-xs-12 col-sm-12 col-lg-6 col-md-6");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(109);
            __builder.AddAttribute(110, "CssClass", "e-small");
            __builder.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(112, "Small");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
            __builder.AddMarkupContent(114, "<style>\r\n    #button-control {\r\n        width: 100%;\r\n        margin: 8% 0;\r\n        text-align: center;\r\n    }\r\n\r\n    @media only screen and (max-width: 500px) {\r\n        #button-control {\r\n            margin-left: -3%;\r\n        }\r\n    }\r\n\r\n    .button-section {\r\n        width: 80%;\r\n        margin: auto;\r\n    }\r\n\r\n    #button-control .col-xs-12 {\r\n        margin: 15px 0;\r\n    }\r\n\r\n    @font-face {\r\n        font-family: \'button-icons\';\r\n        src: url(data:application/x-font-ttf;charset=utf-8;base64,AAEAAAAKAIAAAwAgT1MvMj1uSf8AAAEoAAAAVmNtYXDOXM6wAAABtAAAAFRnbHlmcV/SKgAAAiQAAAJAaGVhZBNt0QcAAADQAAAANmhoZWEIUQQOAAAArAAAACRobXR4NAAAAAAAAYAAAAA0bG9jYQNWA+AAAAIIAAAAHG1heHABGQAZAAABCAAAACBuYW1lASvfhQAABGQAAAJhcG9zdFAouWkAAAbIAAAA2AABAAAEAAAAAFwEAAAAAAAD9AABAAAAAAAAAAAAAAAAAAAADQABAAAAAQAAYD3WXF8PPPUACwQAAAAAANgtxgsAAAAA2C3GCwAAAAAD9AP0AAAACAACAAAAAAAAAAEAAAANAA0AAgAAAAAAAgAAAAoACgAAAP8AAAAAAAAAAQQAAZAABQAAAokCzAAAAI8CiQLMAAAB6wAyAQgAAAIABQMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAUGZFZABA5wHnDQQAAAAAXAQAAAAAAAABAAAAAAAABAAAAAQAAAAEAAAABAAAAAQAAAAEAAAABAAAAAQAAAAEAAAABAAAAAQAAAAEAAAABAAAAAAAAAIAAAADAAAAFAADAAEAAAAUAAQAQAAAAAYABAABAALnCOcN//8AAOcB5wr//wAAAAAAAQAGABQAAAABAAMABAAHAAIACgAJAAgABQAGAAsADAAAAAAADgAkAEQAWgByAIoApgDAAOAA+AEMASAAAQAAAAADYQP0AAIAADcJAZ4CxP08DAH0AfQAAAIAAAAAA9QD9AADAAcAACUhESEBIREhAm4BZv6a/b4BZv6aDAPo/BgD6AAAAgAAAAADpwP0AAMADAAANyE1ISUBBwkBJwERI1kDTvyyAYH+4y4BeQGANv7UTAxNlwEIPf6eAWI9/ukDEwAAAAIAAAAAA/QDngADAAcAADchNSETAyEBDAPo/Bj6+gPo/gxipgFy/t0CRwAAAQAAAAAD9AP0AAsAAAEhFSERMxEhNSERIwHC/koBtnwBtv5KfAI+fP5KAbZ8AbYAAQAAAAAD9AP0AAsAAAEhFSERMxEhNSERIwHh/isB1T4B1f4rPgIfPv4rAdU+AdUAAgAAAAAD9AOlAAMADAAANyE1ISUnBxc3JwcRIwwD6PwYAcWjLO7uLKI/Wj+hoSvs6iyhAm0AAAABAAAAAAP0A/QACwAAAREhFSERMxEhNSERAeH+KwHVPgHV/isD9P4rPv4rAdU+AdUAAAAAAgAAAAADdwP0AAMADAAANyE1ISUBBwkBJwERI4kC7v0SAVj+0SkBdgF4Kf7RPgw+rQEJL/64AUgv/vgC/AAAAAEAAAAAA/QD9AALAAABIRUhETMRITUhESMB2v4yAc5MAc7+MkwCJkz+MgHOTAHOAAIAAAAAA/QDzQADAAcAADchNSE1KQEBDAPo/BgB9AH0/gwzpZUCYAACAAAAAAP0A80AAwAHAAA3ITUhNSkBAQwD6PwYAfQB9P4MM6WVAmAAAAASAN4AAQAAAAAAAAABAAAAAQAAAAAAAQAMAAEAAQAAAAAAAgAHAA0AAQAAAAAAAwAMABQAAQAAAAAABAAMACAAAQAAAAAABQALACwAAQAAAAAABgAMADcAAQAAAAAACgAsAEMAAQAAAAAACwASAG8AAwABBAkAAAACAIEAAwABBAkAAQAYAIMAAwABBAkAAgAOAJsAAwABBAkAAwAYAKkAAwABBAkABAAYAMEAAwABBAkABQAWANkAAwABBAkABgAYAO8AAwABBAkACgBYAQcAAwABBAkACwAkAV8gYnV0dG9uLWljb25zUmVndWxhcmJ1dHRvbi1pY29uc2J1dHRvbi1pY29uc1ZlcnNpb24gMS4wYnV0dG9uLWljb25zRm9udCBnZW5lcmF0ZWQgdXNpbmcgU3luY2Z1c2lvbiBNZXRybyBTdHVkaW93d3cuc3luY2Z1c2lvbi5jb20AIABiAHUAdAB0AG8AbgAtAGkAYwBvAG4AcwBSAGUAZwB1AGwAYQByAGIAdQB0AHQAbwBuAC0AaQBjAG8AbgBzAGIAdQB0AHQAbwBuAC0AaQBjAG8AbgBzAFYAZQByAHMAaQBvAG4AIAAxAC4AMABiAHUAdAB0AG8AbgAtAGkAYwBvAG4AcwBGAG8AbgB0ACAAZwBlAG4AZQByAGEAdABlAGQAIAB1AHMAaQBuAGcAIABTAHkAbgBjAGYAdQBzAGkAbwBuACAATQBlAHQAcgBvACAAUwB0AHUAZABpAG8AdwB3AHcALgBzAHkAbgBjAGYAdQBzAGkAbwBuAC4AYwBvAG0AAAAAAgAAAAAAAAAKAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAANAQIBAwEEAQUBBgEHAQgBCQEKAQsBDAENAQ4ACm1lZGlhLXBsYXkLbWVkaWEtcGF1c2UQLWRvd25sb2FkLTAyLXdmLQltZWRpYS1lbmQHYWRkLW5ldwtuZXctbWFpbC13ZhB1c2VyLWRvd25sb2FkLXdmDGV4cGFuZC0wMy13Zg5kb3dubG9hZC0wMi13ZgphZGQtbmV3XzAxC21lZGlhLWVqZWN0Dm1lZGlhLWVqZWN0LTAxAAA=) format(\'truetype\');\r\n        font-weight: normal;\r\n        font-style: normal;\r\n    }\r\n\r\n    .e-btn-sb-icons {\r\n        font-family: \'button-icons\';\r\n        line-height: 1;\r\n        font-style: normal;\r\n        font-weight: normal;\r\n        font-variant: normal;\r\n        text-transform: none;\r\n        -webkit-font-smoothing: antialiased;\r\n        -moz-osx-font-smoothing: grayscale;\r\n    }\r\n\r\n    .e-play-icon::before {\r\n        content: \'\\e701\';\r\n    }\r\n\r\n    .e-pause-icon::before {\r\n        content: \'\\e705\';\r\n    }\r\n\r\n    .e-open-icon::before {\r\n        content: \'\\e70d\';\r\n    }\r\n\r\n    .e-add-icon::before {\r\n        content: \'\\e70a\';\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\Button.razor"
       
    private string content = "Play";
    private string iconCss = "e-btn-sb-icons e-play-icon";
    private void onToggleClick(MouseEventArgs args)
    {
        if (content == "Play")
        {
            content = "Pause";
            iconCss = "e-btn-sb-icons e-pause-icon";
        }
        else
        {
            content = "Play";
            iconCss = "e-btn-sb-icons e-play-icon";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
