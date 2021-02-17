namespace Corpus.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class ExercisesController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }
    }
}
