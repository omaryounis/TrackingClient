using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingClient.ViewModels;

namespace TrackingClient.Models
{
    

    public class ClientTrackingMap : ClassMap<ClientTracking>
    {
        public ClientTrackingMap()
        {
            Map(m => m.T_NIF).Index(0).Name("T_NIF");
            Map(m => m.T_DIRECCION).Index(1).Name("T_DIRECCION");
            Map(m => m.T_BALANCE).Index(2).Name("T_DIRECCION");
            Map(m => m.T_NOMBRE).Index(3).Name("T_DIRECCION");
            Map(m => m.T_MeterNumber).Index(4).Name("T_DIRECCION");
            Map(m => m.T_TELEFONO).Index(5).Name("T_DIRECCION");
        }
    }
}
