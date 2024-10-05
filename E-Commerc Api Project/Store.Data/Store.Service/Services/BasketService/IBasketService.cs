using Store.Repository.Basket.Models;
using Store.Service.Services.BasketService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.BasketService
{
    public interface IBasketService
    {
        Task<CustomerBasketDto> GetCustomerAsync(string basketId);
        Task<CustomerBasketDto> UpdateCustomerAsync(CustomerBasketDto basket);
        Task<bool> DeleteCustomerAsync(string basketId);
    }
}
