using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreTemplate.BL.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
