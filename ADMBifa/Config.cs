using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMBifa
{
    public class Config
    {
        public static string ConnectionString { get; } = @"Server=localhost,1433;Database=ADMBifa;User ID=sa;Password=adrvsc;TrustServerCertificate=True";
    }
}
