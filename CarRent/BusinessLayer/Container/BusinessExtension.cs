﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class BusinessExtension
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAboutService,AboutManager>();
            services.AddScoped<IAboutDal,EFAboutDal>();

            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<ISliderDal, EFSliderDal>();

            services.AddScoped<ILogoService,LogoManager>();
            services.AddScoped<ILogoDal, EFLogoDal>();

            services.AddScoped<IBioService, BioManager>();
            services.AddScoped<IBioDal,EFBioDal>();

            services.AddScoped<ISocialMediaService,SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();

            services.AddScoped<IBanService, BanManager>();
            services.AddScoped<IBanDal, EFBanDal>();

            services.AddScoped<IMarkaService,MarkaManager>();
            services.AddScoped<IMarkaDal,EFMarkaDal>();

            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<ICarDal, EFCarDal>();

            services.AddScoped<IContactFormService, ContactFormManager>();
            services.AddScoped<IContactFormDal, EFContactFormDal>();

            services.AddScoped<IContactInfoService, ContactInfoManager>();
            services.AddScoped<IContactInfoDal,EFContactInfoDal>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EFServiceDal>();
        }
    }
}
