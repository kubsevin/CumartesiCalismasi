namespace Cumarteside.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                        UserName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
