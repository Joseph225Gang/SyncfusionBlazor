// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 12 "D:\Visual Studio 2019\Syncfusion\Syncfusion\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\StockChart.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\StockChart.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart/crosshair")]
    public partial class StockChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Visual Studio 2019\Syncfusion\Syncfusion\Pages\StockChart.razor"
      
    private Theme Theme { get; set; }
    public List<CrosshairData> ChartPoints { get; set; } = new List<CrosshairData>
{
        new CrosshairData { Period = new DateTime(2013,03,27), Open = 85.97, High = 86.37, Low = 85.96, Close = 86.33 },
        new CrosshairData { Period = new DateTime(2013,03,29), Open = 85.97, High = 86.37, Low = 85.96, Close = 86.33 },
        new CrosshairData { Period = new DateTime(2013,04,01), Open = 86.1, High = 86.15, Low = 85.9, Close = 86.03 },
        new CrosshairData { Period = new DateTime(2013,04,03), Open = 85.93, High = 86.17, Low = 85.84, Close = 86.02 },
        new CrosshairData { Period = new DateTime(2013,04,05), Open = 85.74, High = 86, Low = 85.66, Close = 86 },
        new CrosshairData { Period = new DateTime(2013,04,07), Open = 85.71, High = 85.71, Low = 85.36, Close = 85.62 },
        new CrosshairData { Period = new DateTime(2013,04,09), Open = 85.3, High = 85.92, Low = 85.16, Close = 85.8 },
        new CrosshairData { Period = new DateTime(2013,04,11), Open = 84.23, High = 85.46, Low = 84.23, Close = 85.2 },
        new CrosshairData { Period = new DateTime(2013,04,13), Open = 84.51, High = 84.54, Low = 84.19, Close = 84.3 },
        new CrosshairData { Period = new DateTime(2013,04,15), Open = 84.44, High = 84.65, Low = 84.2, Close = 84.63 },
        new CrosshairData { Period = new DateTime(2013,04,17), Open = 84.6, High = 84.81, Low = 84.59, Close = 84.65 },
        new CrosshairData { Period = new DateTime(2013,04,19), Open = 84.52, High = 84.86, Low = 84.4, Close = 84.76 },
        new CrosshairData { Period = new DateTime(2013,04,21), Open = 84.17, High = 84.66, Low = 84.16, Close = 84.47 },
        new CrosshairData { Period = new DateTime(2013,04,23), Open = 84.22, High = 84.3, Low = 83.98, Close = 84.26 },
        new CrosshairData { Period = new DateTime(2013,04,25), Open = 83.75, High = 84.1, Low = 83.65, Close = 84 },
        new CrosshairData { Period = new DateTime(2013,04,27), Open = 84, High = 84.01, Low = 83.67, Close = 83.74 },
        new CrosshairData { Period = new DateTime(2013,04,29), Open = 84, High = 84.01, Low = 83.67, Close = 83.74 },
        new CrosshairData { Period = new DateTime(2013,05,01), Open = 84.3, High = 84.45, Low = 84.19, Close = 84.22 },
        new CrosshairData { Period = new DateTime(2013,05,03), Open = 83.79, High = 84.19, Low = 83.7, Close = 84.04 },
        new CrosshairData { Period = new DateTime(2013,05,05), Open = 84.02, High = 84.02, Low = 83.69, Close = 83.71 },
        new CrosshairData { Period = new DateTime(2013,05,07), Open = 84.01, High = 84.04, Low = 83.82, Close = 83.96 },
        new CrosshairData { Period = new DateTime(2013,05,09), Open = 83.9, High = 84.02, Low = 83.86, Close = 83.94 },
        new CrosshairData { Period = new DateTime(2013,05,11), Open = 84.09, High = 84.17, Low = 83.9, Close = 84.06 },
        new CrosshairData { Period = new DateTime(2013,05,13), Open = 83.89, High = 84.25, Low = 83.77, Close = 84.01 },
        new CrosshairData { Period = new DateTime(2013,05,15), Open = 84.05, High = 84.14, Low = 83.84, Close = 83.91 },
        new CrosshairData { Period = new DateTime(2013,05,17), Open = 84.49, High = 84.65, Low = 84.18, Close = 84.22 },
        new CrosshairData { Period = new DateTime(2013,05,19), Open = 84.99, High = 85.1, Low = 84.37, Close = 84.43 },
        new CrosshairData { Period = new DateTime(2013,05,21), Open = 84.96, High = 85.06, Low = 84.7, Close = 85.01 },
        new CrosshairData { Period = new DateTime(2013,05,23), Open = 84.68, High = 84.9, Low = 84.65, Close = 84.76 },
        new CrosshairData { Period = new DateTime(2013,05,25), Open = 84.35, High = 85.03, Low = 84.32, Close = 84.67 },
        new CrosshairData { Period = new DateTime(2013,05,27), Open = 84.19, High = 84.31, Low = 84.16, Close = 84.19 },
        new CrosshairData { Period = new DateTime(2013,05,29), Open = 84.19, High = 84.31, Low = 84.16, Close = 84.19 },
        new CrosshairData { Period = new DateTime(2013,06,01), Open = 84.2, High = 84.29, Low = 84.04, Close = 84.15 },
        new CrosshairData { Period = new DateTime(2013,06,03), Open = 84.21, High = 84.25, Low = 84.03, Close = 84.17 },
        new CrosshairData { Period = new DateTime(2013,06,05), Open = 84.72, High = 84.87, Low = 84.44, Close = 84.49 },
        new CrosshairData { Period = new DateTime(2013,06,07), Open = 84.85, High = 84.88, Low = 84.5, Close = 84.72 },
        new CrosshairData { Period = new DateTime(2013,06,09), Open = 84.53, High = 84.74, Low = 84.25, Close = 84.69 },
        new CrosshairData { Period = new DateTime(2013,06,11), Open = 84.4, High = 84.7, Low = 84.27, Close = 84.52 },
        new CrosshairData { Period = new DateTime(2013,06,13), Open = 84.96, High = 85.07, Low = 84.5, Close = 84.57 },
        new CrosshairData { Period = new DateTime(2013,06,15), Open = 85.28, High = 85.32, Low = 84.95, Close = 85.03 },
        new CrosshairData { Period = new DateTime(2013,06,17), Open = 85.35, High = 85.39, Low = 85.1, Close = 85.32 },
        new CrosshairData { Period = new DateTime(2013,06,19), Open = 85.65, High = 85.66, Low = 85.21, Close = 85.36 },
        new CrosshairData { Period = new DateTime(2013,06,21), Open = 85.38, High = 85.85, Low = 85.25, Close = 85.67 },
        new CrosshairData { Period = new DateTime(2013,06,23), Open = 85.8, High = 85.96, Low = 85.67, Close = 85.83 },
        new CrosshairData { Period = new DateTime(2013,06,25), Open = 86.07, High = 86.22, Low = 85.75, Close = 85.87 },
        new CrosshairData { Period = new DateTime(2013,06,27), Open = 86.05, High = 86.08, Low = 85.68, Close = 85.79 },
        new CrosshairData { Period = new DateTime(2013,06,29), Open = 86.05, High = 86.08, Low = 85.68, Close = 85.79 },
        new CrosshairData { Period = new DateTime(2013,07,01), Open = 85.85, High = 86.25, Low = 85.79, Close = 86.06 },
        new CrosshairData { Period = new DateTime(2013,07,03), Open = 85.6, High = 85.85, Low = 85.49, Close = 85.81 },
        new CrosshairData { Period = new DateTime(2013,07,05), Open = 85.94, High = 86, Low = 85.48, Close = 85.66 },
        new CrosshairData { Period = new DateTime(2013,07,07), Open = 86.55, High = 86.64, Low = 85.36, Close = 85.92 },
        new CrosshairData { Period = new DateTime(2013,07,09), Open = 86.46, High = 86.87, Low = 86.4, Close = 86.71 },
        new CrosshairData { Period = new DateTime(2013,07,11), Open = 86.3, High = 86.39, Low = 86.13, Close = 86.38 },
        new CrosshairData { Period = new DateTime(2013,07,13), Open = 85.74, High = 86.44, Low = 85.67, Close = 86.19 },
        new CrosshairData { Period = new DateTime(2013,07,15), Open = 85.56, High = 85.62, Low = 85.34, Close = 85.61 },
        new CrosshairData { Period = new DateTime(2013,07,17), Open = 85.79, High = 85.89, Low = 85.36, Close = 85.52 },
        new CrosshairData { Period = new DateTime(2013,07,19), Open = 85.54, High = 86, Low = 85.51, Close = 85.76 },
        new CrosshairData { Period = new DateTime(2013,07,21), Open = 85, High = 85.17, Low = 84.87, Close = 85.15 },
        new CrosshairData { Period = new DateTime(2013,07,23), Open = 85.1, High = 85.28, Low = 84.72, Close = 85.08 },
        new CrosshairData { Period = new DateTime(2013,07,25), Open = 85.46, High = 85.56, Low = 85.18, Close = 85.37 },
        new CrosshairData { Period = new DateTime(2013,07,27), Open = 85.42, High = 85.44, Low = 85.09, Close = 85.42 },
        new CrosshairData { Period = new DateTime(2013,07,29), Open = 85.42, High = 85.44, Low = 85.09, Close = 85.42 },
        new CrosshairData { Period = new DateTime(2013,08,01), Open = 85.79, High = 85.89, Low = 85.36, Close = 85.54 },
        new CrosshairData { Period = new DateTime(2013,08,03), Open = 85.83, High = 85.85, Low = 85.55, Close = 85.64 },
        new CrosshairData { Period = new DateTime(2013,08,05), Open = 86.19, High = 86.25, Low = 85.8, Close = 85.98 },
        new CrosshairData { Period = new DateTime(2013,08,07), Open = 86.17, High = 86.28, Low = 85.96, Close = 86.07 },
        new CrosshairData { Period = new DateTime(2013,08,09), Open = 86.19, High = 86.26, Low = 85.97, Close = 86.2 },
        new CrosshairData { Period = new DateTime(2013,08,11), Open = 85.98, High = 86.31, Low = 85.86, Close = 86.15 },
        new CrosshairData { Period = new DateTime(2013,08,13), Open = 85.82, High = 86.18, Low = 85.74, Close = 85.78 },
        new CrosshairData { Period = new DateTime(2013,08,15), Open = 85.45, High = 85.66, Low = 85.41, Close = 85.55 },
        new CrosshairData { Period = new DateTime(2013,08,17), Open = 85.53, High = 85.53, Low = 85.31, Close = 85.48 },
        new CrosshairData { Period = new DateTime(2013,08,19), Open = 85.6, High = 85.68, Low = 85.34, Close = 85.39 },
        new CrosshairData { Period = new DateTime(2013,08,21), Open = 85.6, High = 85.72, Low = 85.5, Close = 85.61 },
        new CrosshairData { Period = new DateTime(2013,08,23), Open = 85.34, High = 85.52, Low = 85.3, Close = 85.49 },
        new CrosshairData { Period = new DateTime(2013,08,25), Open = 85.66, High = 85.72, Low =85.38, Close = 85.41 },
        new CrosshairData { Period = new DateTime(2013,08,27), Open = 85.93, High = 85.95, Low =85.59, Close = 85.62 },
        new CrosshairData { Period = new DateTime(2013,08,29), Open = 85.91, High = 85.93, Low =85.63, Close = 85.58 },
        new CrosshairData { Period = new DateTime(2013,09,01), Open = 85.6, High = 85.87, Low =85.5, Close = 85.81 }
    };
    public class CrosshairData
    {
        public DateTime Period { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
