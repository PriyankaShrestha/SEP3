#pragma checksum "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843a558736151dd8df5fa80620e4c431bcc885db"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Data.CustomerService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Data.SendMoney;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Send_Money")]
    public partial class Send_Money : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<h4 class=\"card-header\">Send Money</h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group row");
            __builder.AddMarkupContent(7, "<label class=\"col-form-label\">Account number:</label>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "number");
            __builder.AddAttribute(10, "placeholder", "account number");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                                                           AccountNumber

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AccountNumber = __value, AccountNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group row");
            __builder.AddMarkupContent(16, "<label class=\"col-form-label\">Account Holder\'s Name:</label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "placeholder", "name");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                                               AccountName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AccountName = __value, AccountName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group row");
            __builder.AddMarkupContent(25, "<label class=\"col-form-label\">Amount:</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "number");
            __builder.AddAttribute(28, "placeholder", "amount");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                                                   Amount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Amount = __value, Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group row");
            __builder.AddMarkupContent(34, "<label class=\"col-form-label\">Message:</label>\r\n            ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "placeholder", "message");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                                                  Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        \r\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "checkbox");
            __builder.AddAttribute(43, "checked", 
#nullable restore
#line 30 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                        Save

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "style", "color:red");
            __builder.AddContent(47, 
#nullable restore
#line 32 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "disabled", 
#nullable restore
#line 33 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                           _loading

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "class", "btn btn-light");
#nullable restore
#line 34 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
             if (_loading) 
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<span class=\"spinner-border spinner-border-sm mr-1\"></span>");
#nullable restore
#line 37 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
                                 PayBillAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\Send Money.razor"
       
    private long AccountNumber;
    private double Amount;
    private String AccountName;
    private String Message;
    private bool _loading;
    private bool Save;
    private string ErrorMessage { get; set; }

    private async Task PayBillAsync()
    {
        _loading = true;
        User user = AuthStat._cachedUser;
        Models.Account Sender = await Service.GetAccount(user.Username, user.Password);
        Models.Account Receiver = new Models.Account(AccountNumber, AccountName);

        Transaction transaction = new Transaction(Sender, Receiver, Amount, Message, DateTime.Now, Save);
        
        //Send money
        try
        {
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomAuthenticationStateProvider AuthStat { get; set; }
    }
}
#pragma warning restore 1591