using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreTemplate.Web.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ViewModel<T> : ControllerBase { }
}
