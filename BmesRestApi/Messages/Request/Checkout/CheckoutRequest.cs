namespace BmesRestApi.Messages.Request.Checkout
{
    using DataTransferObjects.Cart;
    using DataTransferObjects.Customer;
    public class CheckoutRequest
    {
        public CustomerDto Customer { get; set; }

        public CartDto Cart { get; set; }
    }
}
