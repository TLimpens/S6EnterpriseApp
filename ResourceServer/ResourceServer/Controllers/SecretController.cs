﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResourceServer.Controllers
{
    public class SecretController : Controller
    {

        [Route("/secret")]
        [Authorize]
        public string Index()
        {
            return "Secret message from Resource server";
        }
    }
}