using BlazorWasm.MyanmarMonth.Models;
using Microsoft.JSInterop;

namespace BlazorWasm.MyanmarMonth.Pages
{
    public partial class MonthDetail
    {
        private List<MyanmarMonthModel>? _months;
        private EnumMonthDetail _enumMonthDetail = EnumMonthDetail.Disable;
        private MyanmarMonthModel? _monthDetail;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Delay(500);
                //await JsRuntime.InvokeVoidAsync("loadForm");
                await JsRuntime.InvokeVoidAsync("loadJs", "themes/js/32tfwgs.js");
            }
        }

        private async Task Detail(MyanmarMonthModel item)
        {
            _monthDetail = item;
            _enumMonthDetail = EnumMonthDetail.Enable;
            StateHasChanged();
        }

        private void Back()
        {
            _enumMonthDetail = EnumMonthDetail.Disable;
            _monthDetail = null;
        }

    }
}
