using Microsoft.AspNetCore.Mvc;

namespace ValorantServer.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public abstract class BaseAPIController : ControllerBase
{
}