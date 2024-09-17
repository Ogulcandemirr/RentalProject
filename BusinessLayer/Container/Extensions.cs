using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUow;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services) //startupta newlemeden getirmek için yaptık
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<ICarDal, EfCarDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();   
            
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

			services.AddScoped<IGuideService, GuideManager>();
			services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IExcelService,ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

			services.AddScoped<IContactUsService, ContactUsManager>();
			services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IRentConditionService, RentConditionManager>();
            services.AddScoped<IRentConditionDal, EfRentConditionDal>();

            services.AddScoped<INewsLetterService, NewstLetterManager>();
            services.AddScoped<INewsLetterDal, EfNewsLetterDal>();



            services.AddScoped<IUowDal,UowDal>();

        }
        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        }
    }
}
