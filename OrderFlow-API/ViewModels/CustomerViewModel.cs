using System.Text.Json.Serialization;

namespace OrderFlow.Api.ViewModels
{
    public class CustomerListResponse : BaseResponse
    {
        public List<CustomerViewModel> body { get; set; }
        
    }

    public class CustomerCreateResponse : BaseResponse
    {
        public CustomerViewModel body { get; set; }
    }


    public class CustomerViewModel
    {
        [JsonPropertyName("CustomerCode")]
        public string CustomerCode { get; set; }

        [JsonPropertyName("CustomerName")]
        public string CustomerName { get; set; }

        [JsonPropertyName("ContactName")]
        public string ContactName { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("Tel")]
        public string Tel { get; set; }

        [JsonPropertyName("RepCode")]
        public int? RepCode { get; set; }

        [JsonPropertyName("Others")]
        public string Others { get; set; }

        [JsonPropertyName("Active")]
        public string Active { get; set; }

        [JsonPropertyName("AreaCode")]
        public string AreaCode { get; set; }

        [JsonPropertyName("UserId")]
        public string UserId { get; set; }

        [JsonPropertyName("EntryDate")]
        public DateTime? EntryDate { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("NicNo")]
        public string NicNo { get; set; }

        [JsonPropertyName("Fax")]
        public string Fax { get; set; }
    }

    public class CustomerRequest
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int? RepCode { get; set; }
        public string Others { get; set; }
        public string Active { get; set; }
        public string AreaCode { get; set; }
        public string UserId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Email { get; set; }
        public string NicNo { get; set; }
        public string Fax { get; set; }
        public string Image { get; set; }
        public int PriceCode { get; set; } = -1;
        public string SvatNo { get; set; }
        public string VatNo { get; set; }
    }
}
