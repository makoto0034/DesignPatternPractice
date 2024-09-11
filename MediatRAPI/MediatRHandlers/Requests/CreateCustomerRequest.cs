using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MediatRHandlers.Entities;

namespace MediatRHandlers.Requests
{
    public class CreateCustomerRequest : IRequest<int>
    {
        public Customer Customer { get; set; }
    }
}
