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
#line 1 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Data.CustomerService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Data.SendMoney;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Send_Money")]
    public partial class Send_Money : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\HP\SEP3\Group6_Git\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
       
    private long AccountNumber;
    private double Amount;
    private String AccountName;
    private String Message;
    private bool _loading;
    private bool Save;
    private string ErrorMessage { get; set; }

    private async Task SendMoneyAsync()
    {
        try
        {
            _loading = true;
            User user = CustomAuthenticationStateProvider.storedUser;
            Account Sender = await Service.GetAccount(user.Username);
            //ToDo get the receiver from the customer's input
            Account Receiver = await Service.GetAccount(AccountName);

            Transaction transaction = new Transaction(Sender, Receiver, Amount, Message, DateTime.Now.ToString(), Save);
            String successMessage = await TransactionService.SendMoney(transaction);
            
            ErrorMessage = successMessage;
            _loading = false;
        }
        catch (Exception e)
        {
            _loading = false;
            ErrorMessage = e.Message;
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISendMoneyService TransactionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStat { get; set; }
    }
}
#pragma warning restore 1591
