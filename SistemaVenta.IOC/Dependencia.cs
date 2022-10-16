using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SistemaVentas.BLL.Implementacion;
//using SistemaVentas.BLL.Interfaces;
//using SistemaVenta.DAL.Implementacion;
//using SistemaVenta.DAL.Interfaces;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(
                    "Server=DDC-CO-LGUERRE; DataBase=DBVENTA; Integrated Security=true; Trusted_Connection=True"));
            });
        }
    }
}
