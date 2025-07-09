using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region ProductCount
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("http://localhost:7240/api/Statistics/ProductCount");
            var jsonData1= await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData1;
            #endregion

            #region CategoryCount
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:7240/api/Statistics/CategoryCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData2;
            #endregion

            #region ActiveEmployee
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("http://localhost:7240/api/Statistics/ActiveEmployeeCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.activeEmployee = jsonData3;
            #endregion

            #region ApartmentCount
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("http://localhost:7240/api/Statistics/ApartmentCount");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData4;
            #endregion

            return View();
        }
    }
}
