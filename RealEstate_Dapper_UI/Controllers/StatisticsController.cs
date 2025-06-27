using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            #region ActiveCategory
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:7240/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategory = jsonData;
            #endregion

            #region ActiveEmployee
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client.GetAsync("http://localhost:7240/api/Statistics/ActiveEmployeeCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.activeEmployee = jsonData1;
            #endregion

            #region ApartmentCount
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("http://localhost:7240/api/Statistics/ApartmentCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = jsonData2;
            #endregion

            #region AverageProductPriceByRange
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client.GetAsync("http://localhost:7240/api/Statistics/AverageProductPriceByRange");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRange = jsonData3;
            #endregion

            #region AverageProductPriceBySale
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client.GetAsync("http://localhost:7240/api/Statistics/AverageProductPriceBySale");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsonData4;
            #endregion

            #region AverageRoomCount
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client.GetAsync("http://localhost:7240/api/Statistics/AverageRoomCount");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData5;
            #endregion

            #region CategoryCount
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client.GetAsync("http://localhost:7240/api/Statistics/CategoryCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData6;
            #endregion

            #region CategoryNameByMaxProductCount
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client.GetAsync("http://localhost:7240/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData7;
            #endregion

            #region CityNameByMaxProductCount
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client.GetAsync("http://localhost:7240/api/Statistics/CityNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsonData8;
            #endregion

            #region DifferentCityCount
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client.GetAsync("http://localhost:7240/api/Statistics/DifferentCityCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsonData9;
            #endregion

            #region EmployeeNameByMaxProductCount
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client.GetAsync("http://localhost:7240/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsonData10;
            #endregion

            #region LastProductPrice
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client.GetAsync("http://localhost:7240/api/Statistics/LastProductPrice");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsonData11;
            #endregion

            #region NewestBuildingYear
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client.GetAsync("http://localhost:7240/api/Statistics/NewestBuildingYear");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData12;
            #endregion

            #region OldestBuildingYear
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client.GetAsync("http://localhost:7240/api/Statistics/OldestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData13;
            #endregion

            #region PassiveCategoryCount
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client.GetAsync("http://localhost:7240/api/Statistics/PassiveCategoryCount");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData14;
            #endregion

            #region ProductCount
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client.GetAsync("http://localhost:7240/api/Statistics/ProductCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData15;
            #endregion


            return View();
        }
    }
}
