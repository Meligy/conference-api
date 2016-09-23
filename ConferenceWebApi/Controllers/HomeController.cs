﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Results;
using ConferenceWebApi.Tools;


namespace ConferenceWebApi.Controllers
{

    [Route("")]
    public class HomeController : ApiController
    {
        
        public IHttpActionResult Get()
        {
            return new OkResult(Request)
                .WithContent(new StreamContent(this.GetType().Assembly.GetManifestResourceStream("ConferenceWebApi.swagger.json")));
        }
    }


  }
