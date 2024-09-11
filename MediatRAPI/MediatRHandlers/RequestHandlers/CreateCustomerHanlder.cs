using MediatR;
using MediatRHandlers.Repositories;
using MediatRHandlers.Requests;

namespace MediatRHandlers.RequestHandlers
{
    public class CreateCustomerHanlder : IRequestHandler<CreateCustomerRequest,int>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerHanlder(ICustomerRepository customRepository)
        {
            _customerRepository = customRepository;
        }  

        public async Task<int> Handle(CreateCustomerRequest request,
           CancellationToken cancellationToken)
        {
            return await _customerRepository.CreateCustomer(request.Customer);
        }
    }
}
