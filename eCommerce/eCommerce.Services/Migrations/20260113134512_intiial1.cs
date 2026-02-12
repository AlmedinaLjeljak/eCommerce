using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class intiial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartEvent_CartItems_CartItemId",
                table: "CartEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CartEvent_Carts_CartId",
                table: "CartEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CartEvent_Users_UserId",
                table: "CartEvent");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 13, 13, 45, 12, 90, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvent_CartItems_CartItemId",
                table: "CartEvent",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvent_Carts_CartId",
                table: "CartEvent",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvent_Users_UserId",
                table: "CartEvent",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartEvent_CartItems_CartItemId",
                table: "CartEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CartEvent_Carts_CartId",
                table: "CartEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CartEvent_Users_UserId",
                table: "CartEvent");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 12, 11, 11, 50, 745, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvent_CartItems_CartItemId",
                table: "CartEvent",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvent_Carts_CartId",
                table: "CartEvent",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvent_Users_UserId",
                table: "CartEvent",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
