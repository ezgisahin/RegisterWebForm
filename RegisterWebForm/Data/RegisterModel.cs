namespace RegisterWebForm.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using RegisterWebForm.Models;

    public partial class RegisterModel : DbContext
    {
        public RegisterModel()
            : base("name=RegisterModel1")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
