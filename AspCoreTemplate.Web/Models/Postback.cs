using Microsoft.AspNetCore.Mvc;

namespace AspCoreTemplate.Web.Models
{
    public class Postback : HttpPostAttribute
    {
        public Postback() : base("[action]") { }
    }
}
