using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound() => NotFound();

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest() => BadRequest(new ProblemDetails { Title = "This is a bad request" });

        [HttpGet("unauthorised")]
        public ActionResult GetUnauthorised() => Unauthorized();

        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "This is first error");
            ModelState.AddModelError("Problem2", "This is second error");
            return ValidationProblem(); //returns errors in an array 
        }

        [HttpGet("server-error")]
        public ActionResult GetServerError() => throw new Exception("This is a server error");

    }
}