using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController:ControllerBase
{
  IHelloWorldService helloWorldService;

  public HelloWorldController(IHelloWorldService helloWorldService)
  {
    this.helloWorldService = helloWorldService;
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok(helloWorldService.GetHelloWorld());
  }
}