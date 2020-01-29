namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblLogin",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TblPackage",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Offer = c.String(nullable: false, maxLength: 40),
                        Image = c.String(),
                        Description = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TblPayment",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        paymentMode = c.String(),
                        RegId = c.Int(nullable: false),
                        Reservation_sid = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tblReg", t => t.Reservation_sid)
                .Index(t => t.Reservation_sid);
            
            CreateTable(
                "dbo.tblReg",
                c => new
                    {
                        sid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Email = c.String(nullable: false, maxLength: 20),
                        Guide = c.String(nullable: false, maxLength: 40),
                        Offers = c.String(),
                        Service = c.String(nullable: false, maxLength: 40),
                        cellNo = c.String(nullable: false, maxLength: 15),
                        NIC = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.sid);
            
            CreateTable(
                "dbo.TblServices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Service = c.String(nullable: false, maxLength: 40),
                        Image = c.String(nullable: false, maxLength: 40),
                        Description = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblPayment", "Reservation_sid", "dbo.tblReg");
            DropIndex("dbo.TblPayment", new[] { "Reservation_sid" });
            DropTable("dbo.TblServices");
            DropTable("dbo.tblReg");
            DropTable("dbo.TblPayment");
            DropTable("dbo.TblPackage");
            DropTable("dbo.TblLogin");
        }
    }
}
