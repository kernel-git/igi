// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WEB_953504_IZGACHEV.Blazor.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using WEB_953504_IZGACHEV.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using WEB_953504_IZGACHEV.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\_Imports.razor"
using WEB_953504_IZGACHEV.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
    public partial class SoftwareDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Components\SoftwareDetails.razor"
       
	[Parameter]
	public DetailsViewModel Software { get; set; }
	[Parameter]
	public EventCallback<DetailsViewModel> SoftwareChanged { get; set; }
	string imageSrc
	{
		get
		{
			return $"images/{Software.Image}";
		}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
