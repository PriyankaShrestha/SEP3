#pragma checksum "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff233570b1f503251ffbc9116088f2ae966d0db7"
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
#line 2 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
using BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
using BlazorClient.Data.CustomerService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
using BlazorClient.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
using BlazorClient.Data.SendMoney;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PayBill")]
    public partial class PayBill : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "xmlns", "http://www.w3.org/1999/html");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Pay Bill</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group row");
            __builder.AddMarkupContent(8, "<label class=\"col-form-label\">Account number:</label>\r\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "placeholder", "account number");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                                                           AccountNumber

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AccountNumber = __value, AccountNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group row");
            __builder.AddMarkupContent(17, "<label class=\"col-form-label\">Account Holder\'s Name:</label>\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "placeholder", "name");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                                               AccountName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AccountName = __value, AccountName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group row");
            __builder.AddMarkupContent(26, "<label class=\"col-form-label\">Invoice Number:</label>\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "number");
            __builder.AddAttribute(29, "placeholder", "invoice number");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                                                           InvoiceNumber

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InvoiceNumber = __value, InvoiceNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group row");
            __builder.AddMarkupContent(35, "<label class=\"col-form-label\">Amount:</label>\r\n            ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "number");
            __builder.AddAttribute(38, "placeholder", "amount");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                                                   Amount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Amount = __value, Amount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group row");
            __builder.AddMarkupContent(44, "<label class=\"col-form-label\">Message:</label>\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "placeholder", "message");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                                                  Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        \r\n        ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "checkbox");
            __builder.AddAttribute(53, "checked", 
#nullable restore
#line 34 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                        Save

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "Save Transaction>\r\n\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "color:red");
            __builder.AddContent(57, 
#nullable restore
#line 36 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "disabled", 
#nullable restore
#line 37 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                           _loading

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(61, "class", "btn btn-light");
#nullable restore
#line 38 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
             if (_loading) 
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<span class=\"spinner-border spinner-border-sm mr-1\"></span>");
#nullable restore
#line 41 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "href", "");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
                                 PayBillAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\const\Group6_fifthVersion\Group6System-main\Group6System-main\BlazorClient\BlazorClient\Pages\PayBill.razor"
       
    private long AccountNumber;
    private double Amount;
    private String AccountName;
    private long InvoiceNumber;
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
            String successMessage = await TransactionService.PayBillAsync(transaction);
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
