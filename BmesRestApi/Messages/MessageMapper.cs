﻿using BmesRestApi.Messages.DataTransferObjects.Cart;
using BmesRestApi.Messages.DataTransferObjects.Product;
using BmesRestApi.Models.Cart;
using BmesRestApi.Models.Product;

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
                Description = brandDto.Description,
                MetaDescription = brandDto.MetaDescription,
                MetaKeywords = brandDto.MetaKeywords,
                BrandStatus = (BrandStatus)brandDto.BrandStatus,
                ModifiedDate = brandDto.ModifiedDate,
                IsDeleted = brandDto.IsDeleted
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
                brandDto.Description = brand.Description;
                brandDto.MetaDescription = brand.MetaDescription;
                brandDto.MetaKeywords = brand.MetaKeywords;
                brandDto.BrandStatus = (int)brand.BrandStatus;
                brandDto.ModifiedDate = brand.ModifiedDate;
                brandDto.IsDeleted = brand.IsDeleted;
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
                Description = categoryDto.Description,
                MetaDescription = categoryDto.MetaDescription,
                MetaKeywords = categoryDto.MetaKeywords,
                CategoryStatus=(CategoryStatus)categoryDto.CategoryStatus,
                ModifiedDate=categoryDto.ModifiedDate,
                IsDeleted=categoryDto.IsDeleted
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
                Description = category.Description,
                MetaDescription = category.MetaDescription,
                MetaKeywords = category.MetaKeywords,
                CategoryStatus = (int)category.CategoryStatus,
                ModifiedDate = category.ModifiedDate,
                IsDeleted = category.IsDeleted
            };
        }
        public Product MapToProduct(ProductDto productDto)
        {
            var product = new Product
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Slug = productDto.Slug,
                Description = productDto.Description,
                MetaDescription = productDto.MetaDescription,
                MetaKeywords = productDto.MetaKeywords,
                SKU=productDto.SKU,
                Model=productDto.Model,
                Price = productDto.Price,
                SalePrice=productDto.SalePrice,
                OldPrice=productDto.OldPrice,
                ImageUrl=productDto.ImageUrl,
                QuantityInStock=productDto.QuantityInStock,
                IsBestseller=productDto.IsBestseller,
                CategoryId=productDto.CategoryId,
                BrandId=productDto.BrandId,
                ProductStatus=(ProductStatus)productDto.ProductStatus,
                CreateDate=productDto.CreateDate,
                ModifiedDate=productDto.ModifiedDate,
                IsDeleted=productDto.IsDeleted
            };
            return product;
        }
        public ProductDto MapToProductDto(Product product)
        {
            var productDto = new ProductDto();
            if (product!=null)
            {
                productDto.Id = product.Id;
                productDto.Name = product.Name;
                productDto.Slug = product.Slug;
                productDto.Description = product.Description;
                productDto.MetaDescription = product.MetaDescription;
                productDto.MetaKeywords = product.MetaKeywords;
                productDto.SKU=product.SKU;
                productDto.Model=product.Model;
                productDto.Price=product.Price;
                productDto.SalePrice=product.SalePrice;
                productDto.OldPrice=product.OldPrice;
                productDto.ImageUrl=product.ImageUrl;
                productDto.QuantityInStock=product.QuantityInStock;
                productDto.CategoryId=product.CategoryId;
                productDto.BrandId=product.BrandId;
                productDto.IsBestseller= product.IsBestseller;
                productDto.ProductStatus = (int)product.ProductStatus;
                productDto.CreateDate = product.CreateDate;
                productDto.ModifiedDate = product.ModifiedDate;
                productDto.IsDeleted = product.IsDeleted;
            }
            return productDto;
        }

        public CartDto MapToCartDto(Cart cart)
        {
            var cartDto = new CartDto();
            if (cart!=null)
            {
                cartDto.Id = cart.Id;
                cartDto.CreateDate= cart.CreateDate;
                cartDto.ModifiedDate= cart.ModifiedDate;
                cartDto.IsDeleted= cart.IsDeleted;
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
                cart.IsDeleted= cartDto.IsDeleted;
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
