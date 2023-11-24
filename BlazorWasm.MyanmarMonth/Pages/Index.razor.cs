using Microsoft.JSInterop;

namespace BlazorWasm.MyanmarMonth.Pages;

public partial class Index
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            //await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./assets/js/main.js");
            //var targetUrl = "./assets/js/main.js";
            //await JsRuntime.InvokeVoidAsync("loadJs", targetUrl);

            await Task.Delay(500);
            //await JsRuntime.InvokeVoidAsync("loadForm");
            await JsRuntime.InvokeVoidAsync("loadJs", "themes/js/32tfwgs.js");
        }
    }
}
