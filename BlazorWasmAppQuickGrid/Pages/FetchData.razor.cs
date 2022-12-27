using System.Net.Http.Json;
using CSharpSharedData;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmAppQuickGrid.Pages;


public partial class FetchData : ComponentBase
{

    private IQueryable<WeatherForecast>? forecasts;

    protected override void OnInitialized()
    {
        forecasts = WeatherForecast.Data.AsQueryable();
    }


}