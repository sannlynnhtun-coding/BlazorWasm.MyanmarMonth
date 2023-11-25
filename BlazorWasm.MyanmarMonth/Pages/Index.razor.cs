using BlazorWasm.MyanmarMonth.Models;
using BlazorWasm.MyanmarMonth.Services;
using Microsoft.JSInterop;

namespace BlazorWasm.MyanmarMonth.Pages;

public partial class Index
{
    private List<MyanmarMonthModel>? _months;
    private EnumMonthDetail _enumMonthDetail = EnumMonthDetail.Disable;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Task.Delay(500);
            //await JsRuntime.InvokeVoidAsync("loadForm");
            await JsRuntime.InvokeVoidAsync("loadJs", "themes/js/32tfwgs.js");
            _months = MonthService.GetMonths();
            StateHasChanged();
        }
    }

    private async Task OnClick(MyanmarMonthModel item)
    {
        _enumMonthDetail = EnumMonthDetail.Enable;
    }
}
