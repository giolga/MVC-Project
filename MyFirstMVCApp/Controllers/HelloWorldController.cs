using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        private static List<string> images = new List<string>() {
            "https://images.pexels.com/photos/1108099/pexels-photo-1108099.jpeg",
            "https://cdn.britannica.com/79/232779-050-6B0411D7/German-Shepherd-dog-Alsatian.jpg",
            "https://www.princeton.edu/sites/default/files/styles/scale_1440/public/images/2022/02/KOA_Nassau_2697x1517.jpg?itok=lA8UuoHt",
            "https://img.freepik.com/free-photo/shallow-focus-vertical-shot-cute-golden-retriever-puppy-sitting-grass-ground_181624-27259.jpg",
            "https://www.humanesociety.org/sites/default/files/2019/02/dog-451643.jpg",
            "https://media-cldnry.s-nbcnews.com/image/upload/t_focal-760x428,f_auto,q_auto:best/mpx/2704722219/2023_11/1700486907837_tdy_news_8a_kreutz_mystery_dog_illness_231120_1920x1080-ggrpnf.jpg",
            "https://hips.hearstapps.com/hmg-prod/images/small-fluffy-dog-breeds-maltipoo-663009b6293cc.jpg?crop=0.668xw:1.00xh;0.143xw,0&resize=980:*",
        };

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            DogViewModel dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Image()
        {
            
            return View(model: images);
        }

       
    }
}
