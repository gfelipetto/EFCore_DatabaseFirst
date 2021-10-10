using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Negocio
{
    [Keyless]
    class EFMigrationsHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
