using Microsoft.EntityFrameworkCore.Query.Internal;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services.Interfaces
{
    public interface ICustomerService
    {
        public List<CustomerViewModel> GetCustomersByRepCode();
        public string GetCustomersImage(string customerCode);
        public void CreateCustomer(CustomerRequest customer);
        public void UpdateCustomer(CustomerRequest customer);
    }
}
