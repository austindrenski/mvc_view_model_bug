using Microsoft.AspNetCore.Mvc;

namespace mvc_view_model_bug
{
    [Route("[controller]")]
    public class ExampleController : Controller
    {
        // Note: no model is passed to the view.
        [HttpGet("[action]")]
        public IActionResult Index() => View("Index.cshtml");

        [HttpPost("[action]")]
        public IActionResult Index(ExampleModel model) => View("Index.cshtml", model);
    }
}