using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.WhoWeAreDtos;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _WhoWeAreViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _WhoWeAreViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:5164/api/WhoWeAreDetail");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsonData=await responsemessage.Content.ReadAsStringAsync();
                var value=JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData);
                ViewBag.title = value.Select(x=>x.Title).FirstOrDefault();
                ViewBag.subtitle = value.Select(x=>x.Subtitle).FirstOrDefault();
                ViewBag.description1 = value.Select(x => x.Description1).FirstOrDefault();
                ViewBag.description2 = value.Select(x=>x.Description2).FirstOrDefault();
                return View();
            }
            return View();
        }
    }
}
