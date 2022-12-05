﻿using BmesRestApi.Models.Shared;

namespace BmesRestApi.Models.Cart
{
    public class Cart:BaseObject
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        public string UniqueCartId { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
