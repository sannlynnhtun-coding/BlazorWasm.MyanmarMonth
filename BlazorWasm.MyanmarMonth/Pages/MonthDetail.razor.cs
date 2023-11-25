using BlazorWasm.MyanmarMonth.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWasm.MyanmarMonth.Pages
{
    public partial class MonthDetail
    {
        private List<MyanmarMonthModel>? _months;
        private EnumMonthDetail _enumMonthDetail = EnumMonthDetail.Disable;
        private MyanmarMonthModel? _monthDetail;

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if (Id == 0)
            {
                Back();
            }
            Console.WriteLine("OnParametersSetAsync");
            _monthDetail = MonthService.GetMonth(Id);
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Delay(500);
                Console.WriteLine("OnAfterRenderAsync");
                //await JsRuntime.InvokeVoidAsync("loadForm");
                //await JsRuntime.InvokeVoidAsync("loadJs", "themes/js/plugins/three.min.js");
                await JsRuntime.InvokeVoidAsync("loadJs", "themes/js/plugins/app.js");
            }
        }

        private void Back()
        {
            Nav.NavigateTo("/");
        }
    }
}
