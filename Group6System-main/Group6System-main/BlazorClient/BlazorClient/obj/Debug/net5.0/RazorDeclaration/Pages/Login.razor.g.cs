// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Login.razor"
using BlazorClient.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Login.razor"
       
    private string _username;
    private string _password;
    private string ErrorMessage { get; set; }
    private bool _loading;

    public async Task PerformLoginAsync()
    {
        _loading = true;
        try
        {
            await ((CustomAuthenticationStateProvider) _authenticationStateProvider).ValidateLoginAsync(_username, _password);
            _username = "";
            _password = "";
            _navMgr.NavigateTo("/Customers");
        }
        catch (Exception e)
        {
            ErrorMessage = e.Message;
            _loading = false;
            Console.WriteLine(ErrorMessage);
        }
        
    }

    public async Task PerformLogoutAsync()
    {
        ErrorMessage = "";
        _username = "";
        _password = "";
        try
        {
            ((CustomAuthenticationStateProvider) _authenticationStateProvider).Logout();
            _navMgr.NavigateTo("/Login");
        }
        catch (Exception e)
        {
        }
    }

    private void Signup()
    {
        _navMgr.NavigateTo("/Customers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
