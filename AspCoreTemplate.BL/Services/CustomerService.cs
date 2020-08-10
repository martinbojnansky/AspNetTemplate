using AspCoreTemplate.BL.DTOs;
using AspCoreTemplate.DAL;
using AspCoreTemplate.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreTemplate.BL.Services
{
    public class CustomerService : EntityService<Customer, CustomerDTO>
    {
        protected override DbSet<Customer> DbSet => Context.Customers;

        public CustomerService(AppDbContext context) : base(context)
        {
        }

        protected override CustomerDTO MapEntityToDTO(Customer entity)
        {
            return new CustomerDTO()
            {
                Id = entity.Id,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
    }
}
