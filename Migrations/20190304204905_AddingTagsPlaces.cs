
using Microsoft.EntityFrameworkCore.Migrations;

namespace CulinaryGuide.API.Migrations
{
    public partial class AddingTagsPlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagPlace_Places_PlaceId",
                table: "TagPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPlace_Tags_TagId",
                table: "TagPlace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagPlace",
                table: "TagPlace");

            migrationBuilder.RenameTable(
                name: "TagPlace",
                newName: "TagPlaces");

            migrationBuilder.RenameIndex(
                name: "IX_TagPlace_PlaceId",
                table: "TagPlaces",
                newName: "IX_TagPlaces_PlaceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagPlaces",
                table: "TagPlaces",
                columns: new[] { "TagId", "PlaceId" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "Description", "Name", "PhotoLocation" },
                values: new object[,]
                {
                    { 1, "Simple but elegant food. Great cocktail choice", "Menza", null },
                    { 3, "Best friday morning bouffet in town!", "Rimon", null },
                    { 2, "Vide choice of ice cream & frozen yoghurt", "Katzefet", null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "color", "text" },
                values: new object[,]
                {
                    { 1, "#45ab78", "NonKosher" },
                    { 2, "#78ab78", "Breakfast" },
                    { 3, "#23cb78", "Bar" },
                    { 6, "#aa3418", "Italian" },
                    { 8, "#565be3", "Dairy" },
                    { 4, "#23ada8", "Family" },
                    { 5, "#12aa56", "Sandwich&Coffee" },
                    { 7, "#67ebe3", "Ice Cream" },
                    { 9, "#34aeae", "Meat" },
                    { 10, "#34aeae", "Business Lunch" }
                });

            migrationBuilder.InsertData(
                table: "TagPlaces",
                columns: new[] { "TagId", "PlaceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 8, 3 },
                    { 8, 2 },
                    { 4, 3 },
                    { 4, 2 },
                    { 7, 2 },
                    { 9, 3 },
                    { 10, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TagPlaces_Places_PlaceId",
                table: "TagPlaces",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPlaces_Tags_TagId",
                table: "TagPlaces",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagPlaces_Places_PlaceId",
                table: "TagPlaces");

            migrationBuilder.DropForeignKey(
                name: "FK_TagPlaces_Tags_TagId",
                table: "TagPlaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagPlaces",
                table: "TagPlaces");

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "TagPlaces",
                keyColumns: new[] { "TagId", "PlaceId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "TagPlaces",
                newName: "TagPlace");

            migrationBuilder.RenameIndex(
                name: "IX_TagPlaces_PlaceId",
                table: "TagPlace",
                newName: "IX_TagPlace_PlaceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagPlace",
                table: "TagPlace",
                columns: new[] { "TagId", "PlaceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TagPlace_Places_PlaceId",
                table: "TagPlace",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagPlace_Tags_TagId",
                table: "TagPlace",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
