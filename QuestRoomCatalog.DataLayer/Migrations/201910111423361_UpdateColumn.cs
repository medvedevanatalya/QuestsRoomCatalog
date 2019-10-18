namespace QuestRoomCatalog.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.QuestsRooms", "Name", c => c.String(nullable: false, maxLength: 250));
            //AddColumn("dbo.QuestsRooms", "Decription", c => c.String(nullable: false));
            //AddColumn("dbo.QuestsRooms", "FearLevel", c => c.Int(nullable: false));
            //AddColumn("dbo.QuestsRooms", "ComplexityLevel", c => c.Int(nullable: false));
            //DropColumn("dbo.QuestsRooms", "NameQuestsRooms");
            //DropColumn("dbo.QuestsRooms", "DecriptionQuestsRooms");
            //DropColumn("dbo.QuestsRooms", "FearsLevel");
            //DropColumn("dbo.QuestsRooms", "ComplexitysLevel");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.QuestsRooms", "ComplexitysLevel", c => c.Int(nullable: false));
            //AddColumn("dbo.QuestsRooms", "FearsLevel", c => c.Int(nullable: false));
            //AddColumn("dbo.QuestsRooms", "DecriptionQuestsRooms", c => c.String(nullable: false));
            //AddColumn("dbo.QuestsRooms", "NameQuestsRooms", c => c.String(nullable: false, maxLength: 250));
            //DropColumn("dbo.QuestsRooms", "ComplexityLevel");
            //DropColumn("dbo.QuestsRooms", "FearLevel");
            //DropColumn("dbo.QuestsRooms", "Decription");
            //DropColumn("dbo.QuestsRooms", "Name");
        }
    }
}
