using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hike.Models;

namespace Hike.Controllers
{

    public class TrailController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;

        private ITrailRepository _repository;
        public TrailController(ICosmosDbService cosmosDbService,ITrailRepository repository)
        {
            _cosmosDbService = cosmosDbService;
            _repository = repository;
        }

       [HttpGet("/trails")]
        public async Task<IActionResult> Index()
        {

            using (HttpClient client = new HttpClient())
            {
                string lon = "-105.6403";
                string lat = "40.3105";
                client.BaseAddress = new Uri("https://www.hikingproject.com");
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var response =
                    await client.GetAsync($"/data/get-trails?lat={lat}&lon={lon}&maxDistance=200&sort=distance&MaxResults=100&key=200238177-24a146be40fa02014108db565b54b2ed");

                response.EnsureSuccessStatusCode();
                var stringresult = await response.Content.ReadAsStringAsync();
                JObject result = JObject.Parse(stringresult);
                //only need if you want to get a subsection of data
                IList<JToken> rawTrailsList = result["trails"].Children().ToList();
                List<Trail> trails = new List<Trail>();
                foreach (JToken item in rawTrailsList)
                {
                    Trail singleTrail = item.ToObject<Trail>();
                    trails.Add(singleTrail);
                }
                //save to memory repository
                _repository.AddTrails(trails);
                return View(trails);
            }
        }

        public IActionResult ShowTrail(int id)
        {
            var trail = _repository.GetTrail(id);
            return View(trail);
        }

        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("Id,Name,Summary,Location,Length")] Trail trail)
        {
            if (ModelState.IsValid)
            {
                trail.Id = Guid.NewGuid().ToString();
                await _cosmosDbService.AddHikeAsync(trail);
            }
            return View(trail);
        }  
    }
}