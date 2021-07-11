using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShopApi.Migrations
{
    public partial class InitMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMenus_SubMenus_SubMenuId",
                table: "SubMenus");

            migrationBuilder.RenameColumn(
                name: "SubMenuId",
                table: "SubMenus",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_SubMenus_SubMenuId",
                table: "SubMenus",
                newName: "IX_SubMenus_MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenus_Menus_MenuId",
                table: "SubMenus",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubMenus_Menus_MenuId",
                table: "SubMenus");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "SubMenus",
                newName: "SubMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_SubMenus_MenuId",
                table: "SubMenus",
                newName: "IX_SubMenus_SubMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenus_SubMenus_SubMenuId",
                table: "SubMenus",
                column: "SubMenuId",
                principalTable: "SubMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
