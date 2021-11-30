using FluentMigrator;

namespace Migrations.Migrations
{
    [Migration(202111300050)]
    public class _202111300050_CreateCoachesTable : Migration
    {
        public override void Up()
        {
            Create.Table("Coaches")
                  .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Identity()
                  .WithColumn("FirstName").AsString(50).NotNullable()
                  .WithColumn("LastName").AsString(50).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Coaches");
        }
    }
}
