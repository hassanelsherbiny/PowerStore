﻿using AutoMapper;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;
using PowerStore.Services.Seo;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using System.Collections.Generic;
using System.Linq;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ManufacturerProfile : Profile, IAutoMapperProfile
    {
        public ManufacturerProfile()
        {
            CreateMap<Manufacturer, ManufacturerModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableManufacturerTemplates, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableDiscounts, mo => mo.Ignore())
                .ForMember(dest => dest.SelectedDiscountIds, mo => mo.Ignore())
                .ForMember(dest => dest.SeName, mo => mo.MapFrom(src => src.GetSeName("", true)))
                .ForMember(dest => dest.AvailableCustomerRoles, mo => mo.Ignore())
                .ForMember(dest => dest.SelectedCustomerRoleIds, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableStores, mo => mo.Ignore())
                .ForMember(dest => dest.SelectedStoreIds, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableSortOptions, mo => mo.Ignore());

            CreateMap<ManufacturerModel, Manufacturer>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Stores, mo => mo.MapFrom(x => x.SelectedStoreIds != null ? x.SelectedStoreIds.ToList() : new List<string>()))
                .ForMember(dest => dest.CustomerRoles, mo => mo.MapFrom(x => x.SelectedCustomerRoleIds != null ? x.SelectedCustomerRoleIds.ToList() : new List<string>()))
                .ForMember(dest => dest.Locales, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.AppliedDiscounts, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}