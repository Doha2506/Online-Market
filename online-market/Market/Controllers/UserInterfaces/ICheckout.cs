using Microsoft.AspNetCore.Mvc;

namespace Market.Controllers.UserInterfaces
{
    public interface ICheckout
    {
        public void CheckZeroQuantity(int Quantity, int productId);
        public IActionResult Checkout(int userId);
        public IActionResult CheckoutDetails(int userId);
        public IActionResult Confirm();

    }
}
