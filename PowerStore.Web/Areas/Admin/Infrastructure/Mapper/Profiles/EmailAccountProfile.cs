﻿using AutoMapper;
using PowerStore.Domain.Messages;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class EmailAccountProfile : Profile, IAutoMapperProfile
    {
        public EmailAccountProfile()
        {
            CreateMap<EmailAccount, EmailAccountModel>()
                .ForMember(dest => dest.Password, mo => mo.Ignore())
                .ForMember(dest => dest.IsDefaultEmailAccount, mo => mo.Ignore())
                .ForMember(dest => dest.SendTestEmailTo, mo => mo.Ignore());

            CreateMap<EmailAccountModel, EmailAccount>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Password, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}