using BmesRestApi.Messages.DataTransferObjects.Cart;
using BmesRestApi.Messages.DataTransferObjects.Customer;
using BmesRestApi.Messages.DataTransferObjects.Order;
using BmesRestApi.Messages.DataTransferObjects.Product;
using BmesRestApi.Messages.DataTransferObjects.Shared;
using BmesRestApi.Models.Cart;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Order;
using BmesRestApi.Models.Product;
using BmesRestApi.Models.Shared;

namespace BmesRestApi.Messages
{
    public class MessageMapper
    {
        public Brand MapToBrand(BrandDto brandDto)
        {
            var brand = new Brand
            {
                Id = brandDto.Id,
                Name = brandDto.Name,
                Slug = brandDto.Slug,
                BrandStatus = (BrandStatus)brandDto.BrandStatus,
                ModifiedDate = brandDto.ModifiedDate
            };
            return brand;
        }
        public BrandDto MapToBrandDto(Brand brand)
        {
            var brandDto = new BrandDto();
            if (brand!=null)
            {
                brandDto.Id = brand.Id;
                brandDto.Name = brand.Name;
                brandDto.Slug = brand.Slug;
                brandDto.BrandStatus = (int)brand.BrandStatus;
                brandDto.ModifiedDate = brand.ModifiedDate;
            }
            return brandDto;
        }
        public Category MapToCategory(CategoryDto categoryDto)
        {
            var category = new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Slug = categoryDto.Slug,
                CategoryStatus=(CategoryStatus)categoryDto.CategoryStatus,
                ModifiedDate=categoryDto.ModifiedDate
            };
            return category;
        }
        public CategoryDto MapToCategoryDto(Category category)
        {
            return new CategoryDto
            {

                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug,
                CategoryStatus = (int)category.CategoryStatus,
                ModifiedDate = category.ModifiedDate
            };
        }
        public Product MapToProduct(ProductDto productDto)
        {
            var product = new Product
            {
                Id = productDto.Id,
                Title = productDto.Title,
                Price = productDto.Price,
                QuantityInStock=productDto.QuantityInStock,
                CategoryId=productDto.CategoryId,
                BrandId=productDto.BrandId,
                ProductStatus=(ProductStatus)productDto.ProductStatus,
                CreateDate=productDto.CreateDate,
                ModifiedDate=productDto.ModifiedDate
            };
            return product;
        }
        public ProductDto MapToProductDto(Product product)
        {
            var productDto = new ProductDto();
            if (product!=null)
            {
                productDto.Id = product.Id;
                productDto.Title = product.Title;
                productDto.Price=product.Price;
                productDto.QuantityInStock=product.QuantityInStock;
                productDto.CategoryId=product.CategoryId;
                productDto.BrandId=product.BrandId;
                productDto.ProductStatus = (int)product.ProductStatus;
                productDto.CreateDate = product.CreateDate;
                productDto.ModifiedDate = product.ModifiedDate;
            }
            return productDto;
        }

        
        public CustomerDto MapToCustomerDto(Customer customer)
        {
            var customerDto = new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Person.Name,
                EmailAddress = customer.Person.EmailAddress,
                PhoneNumber = customer.Person.PhoneNumber,
                Gender = (int)customer.Person.Gender,
                DateOfBirth = customer.Person.DateOfBirth,
                CreateDate = customer.CreateDate,
                ModifiedDate = customer.ModifiedDate
            };

            return customerDto;
        }
        public Customer MapToCustomer(CustomerDto customerDto)
        {
            var person = new Person
            {
                Id = customerDto.Id,
                Name = customerDto.Name,
                EmailAddress = customerDto.EmailAddress,
                PhoneNumber = customerDto.PhoneNumber,
                Gender = (Gender)customerDto.Gender,
                DateOfBirth = customerDto.DateOfBirth,
                CreateDate = customerDto.CreateDate,
                ModifiedDate = customerDto.ModifiedDate
            };

            return new Customer
            {
                Id = customerDto.Id,
                Person = person
            };
        }

        public PersonDto MapToPersonDto(Person person)
        {
            var personDto = new PersonDto
            {
                Id = person.Id,
                Name = person.Name,
                EmailAddress = person.EmailAddress,
                PhoneNumber = person.PhoneNumber,
                Gender = (int)person.Gender,
                DateOfBirth = person.DateOfBirth,
                CreateDate = person.CreateDate,
                ModifiedDate = person.ModifiedDate
            };

            return personDto;
        }

        public Person MapToPerson(PersonDto personDto)
        {
            return new Person
            {
                Id = personDto.Id,
                Name = personDto.Name,
                EmailAddress = personDto.EmailAddress,
                PhoneNumber = personDto.PhoneNumber,
                Gender = (Gender)personDto.Gender,
                DateOfBirth = personDto.DateOfBirth,
                CreateDate = personDto.CreateDate,
                ModifiedDate = personDto.ModifiedDate
            };
        }

        public CartDto MapToCartDto(Cart cart)
        {
            var cartDto = new CartDto();
            if (cart!=null)
            {
                cartDto.Id = cart.Id;
                cartDto.CreateDate= cart.CreateDate;
                cartDto.ModifiedDate= cart.ModifiedDate;
                cartDto.CartStatus=(int)cart.CartStatus;
                cartDto.UniqueCartId=cart.UniqueCartId;
            }
            return cartDto;
        }

        public Cart MapToCart(CartDto cartDto)
        {
            var cart = new Cart();
            if(cartDto!=null)
            {
                cart.Id = cartDto.Id;
                cart.UniqueCartId=cartDto.UniqueCartId;
                cart.CartStatus = (CartStatus)cartDto.CartStatus;
                cart.CreateDate= cartDto.CreateDate;
                cart.ModifiedDate= cartDto.ModifiedDate;
            }
            return cart;
        }

        public CartItemDto MapToCartItemDto(CartItem cartItem)
        {
            CartItemDto cartItemDto = new CartItemDto();

            if (cartItem.Product!=null)
            {
                var productDto = MapToProductDto(cartItem.Product);

                cartItemDto = new CartItemDto
                {
                    Id=cartItem.Id,
                    CartId=cartItem.Id,
                    Product=productDto,
                    Quantity=cartItem.Quantity
                };
            }
            return cartItemDto;
        }

        public CartItem MapToCartItem(CartItemDto cartItemDto)
        {
            return new CartItem
            {
                CartId =cartItemDto.CartId,
                ProductId = cartItemDto.Product.Id,
                Quantity = cartItemDto.Quantity
            };
        }

        public OrderDto MapToOrderDto(Order order)
        {
            var orderDto = new OrderDto
            {
                Id = order.Id,
                OrderTotal = order.OrderTotal,
                OrderItemTotal = order.OrderTotal,
                ShippingCharge = order.ShippingCharge,
                CustomerId = order.CustomerId,
                OrderStatus = (int)order.OrderStatus,
                CreateDate = order.CreateDate,
                ModifiedDate = order.ModifiedDate
            };

            return orderDto;
        }

        public Order MapToOrder(OrderDto orderDto)
        {
            return new Order
            {
                Id = orderDto.Id,
                OrderTotal = orderDto.OrderTotal,
                OrderItemTotal = orderDto.OrderTotal,
                ShippingCharge = orderDto.ShippingCharge,
                CustomerId = orderDto.CustomerId,
                OrderStatus = (OrderStatus)orderDto.OrderStatus,
                CreateDate = orderDto.CreateDate,
                ModifiedDate = orderDto.ModifiedDate
            };
        }

        public OrderItemDto MapToOrderItemDto(OrderItem orderItem)
        {
            OrderItemDto orderItemDto = null;

            if (orderItem?.Product != null)
            {
                var productDto = MapToProductDto(orderItem.Product);

                orderItemDto = new OrderItemDto
                {
                    Id = orderItem.Id,
                    OrderId = orderItem.OrderId,
                    Product = productDto,
                    Quantity = orderItem.Quantity
                };
            }

            return orderItemDto;
        }

        public OrderItem MapToOrderItem(OrderItemDto orderItemDto)
        {
            return new OrderItem
            {
                OrderId = orderItemDto.OrderId,
                ProductId = orderItemDto.Product.Id,
                Quantity = orderItemDto.Quantity
            };
        }

        public List<BrandDto> MapToBrandDtos(IEnumerable<Brand> brands)
        {
            var brandDtos = new List<BrandDto>();
            foreach(var brand in brands)
            {
                var brandDto = MapToBrandDto(brand);
                brandDtos.Add(brandDto);
            }
            return brandDtos;
        }
        public List<CategoryDto> MapToCategoryDtos(IEnumerable<Category> categories)
        {
            var categoryDtos = new List<CategoryDto>();
            foreach(var category in categories)
            {
                var categoryDto = MapToCategoryDto(category);
                categoryDtos.Add(categoryDto);
            }
            return categoryDtos;
        }
        public List<ProductDto> MapToProductDtos(IEnumerable<Product> products)
        {
            var productsDto = new List<ProductDto>();
            foreach(var product in products)
            {
                var productDto = MapToProductDto(product);
                productsDto.Add(productDto);
            }
            return productsDto;
        }
        public List<CartItemDto> MapToCartItemDtos(IEnumerable<CartItem> cartItems)
        {
            var cartItemDtos = new List<CartItemDto>();
            foreach(var cartItem in cartItems)
            {
                var cartItemDto = MapToCartItemDto(cartItem);
                cartItemDtos.Add(cartItemDto);
            }
            return cartItemDtos;
        }

    }
}
