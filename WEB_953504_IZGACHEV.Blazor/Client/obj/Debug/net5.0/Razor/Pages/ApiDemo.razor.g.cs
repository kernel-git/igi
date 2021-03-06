#pragma checksum "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Pages\ApiDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541e7c93dcbf1442f88c956303be38b3e6cae5fa"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_953504_IZGACHEV.Blazor.Client.Pages
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
#nullable restore
#line 1 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Pages\ApiDemo.razor"
using WEB_953504_IZGACHEV.Blazor.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apidemo")]
    public partial class ApiDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<WEB_953504_IZGACHEV.Blazor.Client.Components.SoftwareList>(2);
            __builder.AddAttribute(3, "SelectedObjectChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 6 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Pages\ApiDemo.razor"
                                                                   ShowDetails

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Products", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WEB_953504_IZGACHEV.Blazor.Client.Models.ListViewModel>>(
#nullable restore
#line 6 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Pages\ApiDemo.razor"
                                  Products

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ProductsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<WEB_953504_IZGACHEV.Blazor.Client.Models.ListViewModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<WEB_953504_IZGACHEV.Blazor.Client.Models.ListViewModel>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Products = __value, Products))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\t");
            __builder.OpenComponent<WEB_953504_IZGACHEV.Blazor.Client.Components.SoftwareDetails>(7);
            __builder.AddAttribute(8, "Software", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WEB_953504_IZGACHEV.Blazor.Client.Models.DetailsViewModel>(
#nullable restore
#line 7 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Pages\ApiDemo.razor"
                                     SelectedSoftware

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "SoftwareChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<WEB_953504_IZGACHEV.Blazor.Client.Models.DetailsViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<WEB_953504_IZGACHEV.Blazor.Client.Models.DetailsViewModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedSoftware = __value, SelectedSoftware))));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Study\IGI\WEB_953504_IZGACHEV.Blazor\Client\Pages\ApiDemo.razor"
       
	[Parameter]
	public IEnumerable<ListViewModel> Products { get; set; }
	protected override async Task OnInitializedAsync()
	{
		Products = await
			client.GetFromJsonAsync<IEnumerable<ListViewModel>>("api/products");
	}

	[Parameter]
	public DetailsViewModel SelectedSoftware { get; set; }
	private async Task ShowDetails(int id)
	{
		SelectedSoftware = await
			client.GetFromJsonAsync<DetailsViewModel>($"api/products/{id}");
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
