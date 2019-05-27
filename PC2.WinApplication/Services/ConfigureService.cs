using Microsoft.Extensions.DependencyInjection;
using PC2.Domain.Concessionaire.Commands.Handlers;
using PC2.Domain.Concessionaire.Entities;
using PC2.Domain.Concessionaire.Repositories;
using PC2.Domain.Customers.Commands.Handlers;
using PC2.Domain.Customers.Entities;
using PC2.Domain.Customers.Repositories;
using PC2.Domain.Shared.Commands.Handlers;
using PC2.Domain.Shared.Entities;
using PC2.Domain.Shared.Repositories;
using PC2.Infra.Contexts;
using PC2.Infra.Infra;
using PC2.Infra.Repositories.Concessionaire;
using PC2.Infra.Repositories.Customer;
using PC2.Infra.Repositories.Shared;
using PC2.WinApplication.Configurations;
using PC2.WinApplication.Forms;
using PC2.WinApplication.Forms.AddsEdits;
using PC2.WinApplication.Forms.Lists;

namespace PC2.WinApplication.Services
{
    public static class ConfigureService
    {
        public static ServiceCollection Collection(ServiceCollection service)
        {
            service.AddTransient<IModelRepository, ModelRepository>();
            service.AddTransient<IVehicleRepository, VehicleRepository>();
            service.AddTransient<IVehicleSalesRepository, VehicleSalesRepository>();
            service.AddTransient<IBuyerRepository, BuyerRepository>();
            service.AddTransient<IAddressRepository, AddressRepository>();

            service.AddTransient<Model>();
            service.AddTransient<Vehicle>();
            service.AddTransient<VehicleSales>();
            service.AddTransient<Address>();
            service.AddTransient<Buyer>();

            service.AddTransient<ModelHandler>();
            service.AddTransient<VehicleHandler>();
            service.AddTransient<VehicleSalesHandler>();
            service.AddTransient<BuyerHandler>();
            service.AddTransient<AddressHandler>();

            service.AddTransient<frmListModel>();
            service.AddTransient<frmListBuyer>();
            service.AddTransient<frmListVehicle>();
            service.AddTransient<frmListSale>();

            service.AddTransient<frmPrincipal>();
            service.AddTransient<frmAddModel>();
            service.AddTransient<frmAddBuyer>();
            service.AddTransient<frmAddVehicle>();
            service.AddTransient<frmSale>();

            service.AddTransient<IDBConfiguration, MSSQLConfiguration>();
            service.AddSingleton<IDB, MSSQLContext>();

            //service.AddSingleton<IDB, SQLLITEContext>();

            return service;
        }
    }
}
