﻿namespace BmesRestApi.Messages.DataTransferObjects.Cart
{
    public class CartDto
    {
        public CartDto()
        {
            CartItems=new List<CartItemDto>();
        }
        public long Id { get; set; }
        public string UniqueCartId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public IEnumerable<CartItemDto> CartItems { get; set; }
    }
}
