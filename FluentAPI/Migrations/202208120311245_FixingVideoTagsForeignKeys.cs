namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingVideoTagsForeignKeys : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CourseTags", name: "TagId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.CourseTags", name: "CourseId", newName: "TagId");
            RenameColumn(table: "dbo.CourseTags", name: "__mig_tmp__0", newName: "CourseId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_TagId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.CourseTags", name: "IX_CourseId", newName: "IX_TagId");
            RenameIndex(table: "dbo.CourseTags", name: "__mig_tmp__0", newName: "IX_CourseId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CourseTags", name: "IX_CourseId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.CourseTags", name: "IX_TagId", newName: "IX_CourseId");
            RenameIndex(table: "dbo.CourseTags", name: "__mig_tmp__0", newName: "IX_TagId");
            RenameColumn(table: "dbo.CourseTags", name: "CourseId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.CourseTags", name: "TagId", newName: "CourseId");
            RenameColumn(table: "dbo.CourseTags", name: "__mig_tmp__0", newName: "TagId");
        }
    }
}
