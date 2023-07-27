using OrderFlow.Api.Models;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly SeefaErpceytramContext erpceytramContext;

        public CustomerService(SeefaErpceytramContext context)
        {
            erpceytramContext = context;
        }

        public void CreateCustomer(CustomerRequest customer)
        {

            erpceytramContext.CustomerMasters.Add(new CustomerMaster
            {
                Active = "Y",
                Address = customer.Address,
                AreaCode = customer.AreaCode,
                ContactName = customer.ContactName,
                CreditLimit = 0,
                CustomerCode = customer.CustomerCode,
                CustomerName = customer.CustomerName,
                Email = customer.Email,
                Fax = customer.Fax,
                Image = customer.Image,
                EntryDate = customer.EntryDate,
                NicNo = customer.NicNo,
                Others = customer.Others,
                PriceCode = customer.PriceCode,
                RepCode = customer.RepCode,
                SvatNo = customer.SvatNo,
                Tel = customer.Tel,
                UserId = customer.UserId,
                VatNo = customer.VatNo
            });

            erpceytramContext.SaveChangesAsync();

        }

        public List<CustomerViewModel> GetCustomersByRepCode()
        {

            return erpceytramContext.CustomerMasters.Where(x => !string.IsNullOrEmpty(x.CustomerName) && x.RepCode != null)
                 .OrderBy(x => x.CustomerName).Select(o => new CustomerViewModel
                 {
                     Address = o.Address,
                     Active = o.Active,
                     AreaCode = o.AreaCode,
                     ContactName = o.ContactName,
                     CustomerCode = o.CustomerCode,
                     CustomerName = o.CustomerName,
                     Email = o.Email,
                     EntryDate = o.EntryDate,
                     Fax = o.Fax,
                     NicNo = o.NicNo,
                     Others = o.Others,
                     RepCode = o.RepCode,
                     Tel = o.Tel,
                     UserId = o.UserId
                 }).ToList();

        }

        public string GetCustomersImage(string customerCode)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerRequest customer)
        {
            throw new NotImplementedException();
        }
    }
}
