using System.Data;

namespace ExtrmDataPreview.Extentions
{
    public class ServiceExtentions
    {
        public static void ConfigureDapperMsSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("connection");

            //services.AddSingleton<IDbConnection>(provider => new SqlConnection(connectionString));

            //services.AddTransient<DapperDBContext>();

            /*Repository */
           /* services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IImItemRepository, ImItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();*/


            /*services */
      /*      services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IImItemServices, ImItemServices>();
            services.AddScoped<IOrderServices, OrderServices>();*/
        }



        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
           /* MapperConfiguration mapperConfig = new MapperConfiguration(mapConfig => {
                mapConfig.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);*/
        }


    }
}
