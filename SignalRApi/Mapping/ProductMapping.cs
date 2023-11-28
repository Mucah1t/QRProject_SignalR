﻿using AutoMapper;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SignalRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto> ().ReverseMap();
            CreateMap<Product, CreateProductDto> ().ReverseMap();
            CreateMap<Product, GetProductDto> ().ReverseMap();
            CreateMap<Product, UpdateProductDto> ().ReverseMap();
        }
    }
}