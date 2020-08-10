using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AspCoreTemplate.BL.DTOs;
using AspCoreTemplate.BL.Models;
using AspCoreTemplate.BL.Services;
using AspCoreTemplate.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreTemplate.Web.Controllers
{ 
    public class State
    {
        public int Count { get; set; }
        public Dataset<CustomerDTO> Dataset { get; set; }
    }

    public class StateController : ViewModel<State>
    {
        protected CustomerService CustomerService { get; }

        public StateController(CustomerService customerService)
        {
            CustomerService = customerService;
        }

        [HttpGet]
        public ActionResult<State> Get()
        {
            return new State() { Count = 0 };
        }

        [Postback]
        public ActionResult<State> Increment([FromBody] State state)
        {
            state.Count++;
            return state;
        }

        [Postback]
        public ActionResult<State> Decrement([FromBody] State state)
        {
            state.Count--;
            return state;
        }

        [Postback]
        public ActionResult<State> Dataset([FromBody] State state)
        {
            state.Dataset = CustomerService.UpdateDataset(state.Dataset);
            return state;
        }

        [Postback]
        public ActionResult<State> ApplyDatasetEdits([FromBody] State state)
        {
            //try { 
            //    foreach (var add in state.Dataset?.Edits?.Add)
            //    {
            //        _context.Customers.Add(add.Value);
            //    }
            //    state.Dataset.Edits.Add.Clear();
            //    _context.SaveChanges();
            //}
            //catch { }

            //state.Dataset = UpdateDataset(state.Dataset);
            return state;
        }
    }
}
