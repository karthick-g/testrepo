﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
namespace OwinPOC.Controllers
{
    [RoutePrefix("api/data")]
    [Authorize]
    public class DataController : ApiController
    {
         [Route("")]
    public IHttpActionResult Get()
    {
        ClaimsPrincipal principal = Request.GetRequestContext().Principal as ClaimsPrincipal;
        var userName = principal.Claims.Where(c => c.Type == "sub").Single().Value;
        return Ok("You are allowed to request data");
    }

    }
}
