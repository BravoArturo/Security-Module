namespace DATOS
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class PROYECTO : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'PROYECTO' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DATOS.PROYECTO' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'PROYECTO'  en el archivo de configuración de la aplicación.
        public PROYECTO()
            : base("name=PROYECTO")
        {
        }
        public virtual DbSet<MODELO.usuario> USUARIOS { get; set; }
        public virtual DbSet<MODELO.grupo> GRUPOS { get; set; }
        public virtual DbSet<MODELO.informe> INFORMES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.usuario>()
                .HasKey(c => c.id);
            modelBuilder.Entity<MODELO.grupo>()
                .HasKey(c => c.id);
            modelBuilder.Entity<MODELO.informe>()
                .HasKey(c => c.id);
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}