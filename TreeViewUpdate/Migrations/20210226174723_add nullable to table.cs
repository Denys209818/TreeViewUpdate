using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeViewUpdate.Migrations
{
    public partial class addnullabletotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblTreeViewUpdateElements_tblTreeViewUpdateElements_ParentId",
                table: "tblTreeViewUpdateElements");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "tblTreeViewUpdateElements",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_tblTreeViewUpdateElements_tblTreeViewUpdateElements_ParentId",
                table: "tblTreeViewUpdateElements",
                column: "ParentId",
                principalTable: "tblTreeViewUpdateElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblTreeViewUpdateElements_tblTreeViewUpdateElements_ParentId",
                table: "tblTreeViewUpdateElements");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "tblTreeViewUpdateElements",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblTreeViewUpdateElements_tblTreeViewUpdateElements_ParentId",
                table: "tblTreeViewUpdateElements",
                column: "ParentId",
                principalTable: "tblTreeViewUpdateElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
