using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace zoo_backend_vs.Controllers
{
    public class LatestNewsController : Controller
    {
        private readonly HttpClient _httpClient;
        public LatestNewsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
        }

        [HttpGet("zoo-news")]
        public async Task<IActionResult> ZooNews()
        {
            var url = "https://www.zoo.gov.taipei/OpenData.aspx?SN=022A4E6F1C7F323A";
            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }
            var jsonData = await response.Content.ReadAsStringAsync();
            return Json(jsonData);
        }

        [HttpGet("zoo-events")]
        public async Task<IActionResult> ZooEvents()
        {
            var url = "https://www.zoo.gov.taipei/OpenData.aspx?SN=D2A75D913CDBB2CE";
            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }
            var jsonData = await response.Content.ReadAsStringAsync();
            return Json(jsonData);
        }

        [HttpGet("zoo-announcements")]
        public async Task<IActionResult> ZooAnnouncement()
        {
            var url = "https://www.zoo.gov.taipei/OpenData.aspx?SN=77C6F77920C917B2";
            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }
            var jsonData = await response.Content.ReadAsStringAsync();

            return Json(jsonData);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
