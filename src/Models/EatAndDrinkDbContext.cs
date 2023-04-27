using Microsoft.EntityFrameworkCore;

namespace EatAndDrink.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class EatAndDrinkDbContext : DbContext
    {
        // TODO: Нужно обновить строку подключения
        // Вместо <сервер> указываем имя сервера SQL Server Expres
        // Вместо <пароль> указываем пароль созданный при установке SQL Server Expres
        private readonly String _connectionString = "Data Source=<сервер>;Initial Catalog=EatAndDrinkDB;Persist Security Info=True;User ID = sa;Password=<пароль>;";
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(_connectionString);
    }
}
