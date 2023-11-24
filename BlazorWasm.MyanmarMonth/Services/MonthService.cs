using BlazorWasm.MyanmarMonth.Models;
using Newtonsoft.Json;

namespace BlazorWasm.MyanmarMonth.Services;

public class MonthService
{
    public List<MyanmarMonthModel> GetMonths()
    {
        return JsonConvert.DeserializeObject<List<MyanmarMonthModel>>(MonthData.Months)!;
    }

    public MyanmarMonthModel GetMonth(int id)
    {
        return GetMonths().FirstOrDefault(x => x.Id == id)!;
    }
}
