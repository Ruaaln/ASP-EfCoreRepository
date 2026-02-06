
namespace EfCoreCodeFirst.Controllers;

using Microsoft.AspNetCore.Mvc;

public class ErrorController : Controller
{
    [Route("Error/404")]
    public IActionResult NotFoundPage() => View("NotFound");

    [Route("Error/500")]
    public IActionResult ServerError() => View("ServerError");
}

