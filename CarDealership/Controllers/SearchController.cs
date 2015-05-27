using CarDealership.Models;
using CarDealership.Models.Dealership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarDealership.Controllers
{
    public class SearchController : ApiController
    {

        private ApplicationDbContext _db = new ApplicationDbContext();
        public SearchController()
        {
            if (_db.Cars.Count() == 0) // Initialize Database
            {
                InitializeDB();
            }
        }


        // GET api/<controller>
        public IEnumerable<Car> Get()
        {
            return _db.Cars.ToList();
        }

        // GET api/<controller>/5
        public Car GetById(int id)
        {
            return _db.Cars.Find(id);
        }

        [Route("Api/Search/{make}")]
        public IEnumerable<Car> GetByMake(string make)
        {
            return _db.Cars.Where(c => c.Make == make).ToList();
        }

        [Route("Api/Search/Model/{searchterm}")]
        public IEnumerable<Car> GetByModel(string searchterm)
        {
            return _db.Cars.Where(c => c.Model.StartsWith(searchterm)).ToList();
        }

        [Route("Api/Search/Description/{searchterm}")]
        public IEnumerable<Car> GetByFullDescription(string searchterm)
        {
            return _db.Cars.Where(c => c.BreifDescription.Contains(searchterm)).ToList();
        }

        // POST api/<controller>
        public void Post(Car car)
        {
            if (ModelState.IsValid)
            {
                var originalCar = _db.Cars.Find(car);
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }


        public void InitializeDB()
        {
            var cars = new List<Car> {
                    new Tesla {
                        Model = "Roadster",
                        BreifDescription = "Stephen's favorite car",
                        FullDescription = "Wowwee look at how fast it goes. I saw one of these on the freeway once. I almsot swerved intot he other lane because of how nice the car looks. They should market that. \"The car with looks so good, they kill.\"",
                        ImgSrc = "http://o.aolcdn.com/dims-shared/dims3/GLOB/legacy_thumbnail/750x422/quality/95/http://www.blogcdn.com/green.autoblog.com/media/2010/07/tesla-roadster-2-5100315271l.jpg",
                        Price = 100000m,
                        Range = 240,
                        ChargeTime = 12
                    },
                    new Tesla {
                        Model = "Model S",
                        BreifDescription = "Stephen's favorite car",
                        FullDescription = "Wowwee look at how fast it goes. I saw one of these on the freeway once. I almsot swerved intot he other lane because of how nice the car looks. They should market that. \"The car with looks so good, they kill.\"",
                        ImgSrc = "https://a.tcimg.net/v//colorid_images/v1/1309462/360x185/f3q",
                        Price = 100001m,
                        Range = 241,
                        ChargeTime = 13
                    },
                    new Tesla {
                        Model = "Model X",
                        BreifDescription = "Stephen's favorite car",
                        FullDescription = "Wowwee look at how fast it goes. I saw one of these on the freeway once. I almsot swerved intot he other lane because of how nice the car looks. They should market that. \"The car with looks so good, they kill.\"",
                        ImgSrc = "http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2",
                        Price = 100002m,
                        Range = 242,
                        ChargeTime = 15
                    },
                    new RollsRoyce {
                        Model = "Phantom",
                        BreifDescription = "Stephen's second favorite car",
                        FullDescription = "Wowwee this car is expensive.",
                        ImgSrc = "http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2",
                        Price = 502000m,
                        GasMilage = 11
                    },
                   new RollsRoyce {
                        Model = "Spirit",
                        BreifDescription = "Spirited Away",
                        FullDescription = "Closures",
                        ImgSrc = "http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2",
                        Price = 100002m,
                        GasMilage = 14
                    },
                    new RollsRoyce {
                        Model = "Closure",
                        BreifDescription = "Closure",
                        FullDescription = "Closure Closure Closure Closure Closure Closure Closure",
                        ImgSrc = "http://www.harvestministryteams.com/blog/wp-content/uploads/2014/01/Closure.jpg",
                        Price = 34m,
                        GasMilage = 1
                    },
                    // aaand repeat
                    new Tesla {
                        Model = "Roadster",
                        BreifDescription = "2Stephen's favorite car",
                        FullDescription = "2Wowwee look at how fast it goes. I saw one of these on the freeway once. I almsot swerved intot he other lane because of how nice the car looks. They should market that. \"The car with looks so good, they kill.\"",
                        ImgSrc = "http://o.aolcdn.com/dims-shared/dims3/GLOB/legacy_thumbnail/750x422/quality/95/http://www.blogcdn.com/green.autoblog.com/media/2010/07/tesla-roadster-2-5100315271l.jpg",
                        Price = 100000m,
                        Range = 240,
                        ChargeTime = 12
                    },
                    new Tesla {
                        Model = "Model S",
                        BreifDescription = "2Stephen's favorite car",
                        FullDescription = "2Wowwee look at how fast it goes. I saw one of these on the freeway once. I almsot swerved intot he other lane because of how nice the car looks. They should market that. \"The car with looks so good, they kill.\"",
                        ImgSrc = "https://a.tcimg.net/v//colorid_images/v1/1309462/360x185/f3q",
                        Price = 100001m,
                        Range = 241,
                        ChargeTime = 13
                    },
                    new Tesla {
                        Model = "Model X",
                        BreifDescription = "2Stephen's favorite car",
                        FullDescription = "2Wowwee look at how fast it goes. I saw one of these on the freeway once. I almsot swerved intot he other lane because of how nice the car looks. They should market that. \"The car with looks so good, they kill.\"",
                        ImgSrc = "http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2",
                        Price = 100002m,
                        Range = 242,
                        ChargeTime = 15
                    },
                    new RollsRoyce {
                        Model = "Phantom",
                        BreifDescription = "2Stephen's second favorite car",
                        FullDescription = "2Wowwee this car is expensive.",
                        ImgSrc = "http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2",
                        Price = 502000m,
                        GasMilage = 11
                    },
                   new RollsRoyce {
                        Model = "Spirit",
                        BreifDescription = "2Spirited Away",
                        FullDescription = "2Closures",
                        ImgSrc = "http://www.teslamotors.com/sites/default/files/images/model-x/teaser@2x.jpg?2",
                        Price = 100002m,
                        GasMilage = 14
                    },
                    new RollsRoyce {
                        Model = "Closure",
                        BreifDescription = "Closure2",
                        FullDescription = "Closure2 Closure Closure Closure Closure Closure Closure",
                        ImgSrc = "http://www.harvestministryteams.com/blog/wp-content/uploads/2014/01/Closure.jpg",
                        Price = 34m,
                        GasMilage = 1
                    }

                }; // list

            cars.ForEach(p => _db.Cars.Add(p));
            _db.SaveChanges();
        }
    }
}