using Backend.Models.Scaffold;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Internal;


namespace Backend.Models
{
    public class MySQLDbContext : FescFuentesodaContext
    {
        //private readonly MySQLSettings _mySQLsettings;
        //public MySQLDbContext(IAppSettingsService appSettings)
        //{
        //    _mySQLSettings = appSettingsService.GetMySQLSettings();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("server=localhost;database=fesc_fuentesoda;user=root;password=root;");


    }
}
