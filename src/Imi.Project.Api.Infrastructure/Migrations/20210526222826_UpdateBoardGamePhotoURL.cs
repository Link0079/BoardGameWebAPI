using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateBoardGamePhotoURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "b491009f-6ed5-4f67-8718-2bbad4ce3d2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "71af43e1-0ca4-4acc-b151-e62965fae7d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "941b3ae9-00c2-416a-bc44-356a73e30292");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "935041b8-7af7-4a75-992d-b44daa836f98");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebbb3aac-9673-43d3-b021-796115ca6967", "AQAAAAEAACcQAAAAEIOvsk54ZPpKesxVZkHPt0c7p8kJJGKLPwXaY45ZlzQzwGrkNnZ+tJI5Z6HIilTFSw==", "ec28f7f8e47d4df9a37cb65dafaa5158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "530f2c02-1d05-4ec6-b93e-a9896533616e", "AQAAAAEAACcQAAAAEBO0y2s0IPKStdhblZ+8V2D2MChx7FG0UK2q3UTNua640pXQ3ZWPglIfeNaw+AxSIQ==", "2c56122f7b964903970f2826d70175a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75b2dd26-2735-457c-bba7-d22e04f94983", "AQAAAAEAACcQAAAAELcchuUJmBuFbZdi2/xbrESQ91wMBOaxTBwClO3wvoV7km8K3zbyLeMMU0b1Ge8Vqw==", "1042295b06af4e44be83d6d69f54fdc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a4a8eea-3a5e-421e-9d16-26c9bfc1c27f", "AQAAAAEAACcQAAAAEARaDzSt7PeP3wmYtj7JZqfOXazxoOpHongAsRuDPYErfJRbelLaoO2EUYK8TCovUQ==", "9c9b50e17c6e4c58851a0e0ffca08181" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c1ec7cc-3d47-4c6b-9b58-af66a6d7c1ba", "AQAAAAEAACcQAAAAEEtYayOK2hzJo06h/q7BcGHHgzXQ9nmy0GsJpwbaBp2B1cwodM+PpsHAHuknzOL27g==", "f488a435112c4d40a09abf2479ee040b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63a566d0-876d-469b-94ef-c4f18b10cab2", "AQAAAAEAACcQAAAAELNwI5q1hMhPue5Oh2n4zpdcOwsvkgU2HfjGLDrTmRwhLQ/xn8DczRY5kG3rrmjE6w==", "04ba36f8272c4c7ba016587cb0ee8c97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41ad12c5-bcc3-45c9-99b6-b5d82485e680", "AQAAAAEAACcQAAAAEMg3VHj9j+8PCYALHy/QJg9F+AGlIJ0ZRLJlGdvImcZemwnnDQRhans4yiFvLk5lJw==", "1c774edab09b4e08bb2ce88d8e51fc13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8e421a6-7b06-4c01-aa45-fb2dcb823263", "AQAAAAEAACcQAAAAEBpnFqunQ+drp4HN5C0IqVgBZWNwMunGQYndRpaZk7mrvqFlWWdtfDCCfXI5V1CvbA==", "0c0e5900d2de447c86ab91b96b4f7f0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47075f0f-632c-48cf-8202-a48ef9b187f3", "AQAAAAEAACcQAAAAEMRXtjM2GW+MBXmFOgH394QPDvngmskp3iYqLgXycRdQ1dZf5mI5YX7QIu5TVxY/Pw==", "9321aabd38f34bf987e09646b45c4950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41fd11f2-7b00-48f7-bed6-5b4e2aa4ed4d", "AQAAAAEAACcQAAAAEI5ANxf5PEmsU3nnZtyC9sAm7qWQ7YPvp8/uEUaDsWdt396MX1K9Ko315o8lOCdI8g==", "eb5a349b2a21408d9a5ca3ca200f285d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f34a02e0-fd6a-4377-b324-bf0582a66bf4", "AQAAAAEAACcQAAAAEN3dtzICfReAWH4gHIEwWgIItXPkW306nTcd2kMRZiZF9/WEiNTqsv4pStliLmTQSQ==", "99f2872a89bb42f1b43d2bddb1db323b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476e5b28-d2b4-4fc0-9338-3e2f473be699", "AQAAAAEAACcQAAAAEC1KN1j/PkbgYP3AHhGIdMW5q5gQ22Kv1DPK2jqQ7S8Vpazmzet6LW1rP6XxPuAgJQ==", "5df72485321a45deb91308584bca4e1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61f050fb-da08-4750-bed2-2be785e11955", "AQAAAAEAACcQAAAAEP2Vn/4S+cB6Vn6pFFl4m+R2embKCp2yVl+i+mkCJe14FoqPblgWSGue1Nxj/kGd6w==", "d185152771ef4cf5bdab59db652008eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea497935-89c9-4a43-9cde-e1c777ef5ccb", "AQAAAAEAACcQAAAAEEcAcc+dmUycctdcg3xa+aqM3UQVAOQXAQGOlZlYaWFx1Hx9bTZ8DADfcgMtdnudaw==", "d4fd0318f1274cf08e2335e7087db334" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09977519-055a-4fd6-807f-e9778962745f", "AQAAAAEAACcQAAAAECg7/Hk6IvuMjU/GuCWlSuGxOGxOscZMQkq7o/zwBZo/mTb1kMrEuASPiwhC5VxYfg==", "60059f5a128d4a61a5995d75c17f69d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32397d7c-27c8-45d3-8aef-7eb051a4bc0b", "AQAAAAEAACcQAAAAEJd9yD99SZcvFQkWvSr2KTaZSyxupGOFCuGoLXiigJO0POmFGclSrF22q41on70stA==", "b3c72957079247408b9aaecbcdb3d7bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70d8ace6-7501-47dc-8611-4a78e6a8258b", "AQAAAAEAACcQAAAAENeoEIyWLZ6I4IWy/UUQqz/Do8108NwTyiKfxELoQNPYBxIUnA/GraC5A9YwZL+jXA==", "7c65397fa2154e60b032e3ebe2420b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f6f44ee-48a9-4286-ad61-0f65f1e134d2", "AQAAAAEAACcQAAAAEGyEB74U3QJvhgftS3yWGr4NixWcCfGXw8z0H2YjoOd8YnSwYe/nCT34+qfddZmFMA==", "d4c33396417d403287af4b2c1d6250a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-280000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26487413-6550-4aea-a992-5ea5a4037aff", "AQAAAAEAACcQAAAAEF21q2ky/DEtMBfl5YbSMpA/WCsLJvujR8tVcjr3deh3lgtIhp/CI+XU+piE/jGEDQ==", "9b8560bc02604226a4ef78a0cf33ebe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-290000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73f9ee19-f056-4383-9a4d-9e002900995c", "AQAAAAEAACcQAAAAENq8xCSyVwE5CPAF37CcBJEMyRb9EjwZ3gz+1U4objf0kCydlCI3r5ucnWmGl5qRAQ==", "12d15487fec34e758d0b9735bbe1e544" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6a5087f-0d57-436e-899d-e2cb12d45b54", "AQAAAAEAACcQAAAAEIWB5Cfc1If3hqVbm8CupZqaMIO2O1gmcHeAdJPiqpAqWhDFLec9CkKn9s3jglLPHQ==", "3e869961a1f14ccead82c0e486b27240" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-310000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65ff3a61-c059-4d19-bcdc-84fd63952096", "AQAAAAEAACcQAAAAEATxSVIL/n3/yGKtZ56YKeU+VaeheN5CXW1BLFuwq2qOadujk8TMOBAw8YgMHxgmnA==", "190ddde70ff44e8789e5e12a0ed6ea97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-320000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec78557-b1ab-4d4d-949a-715eec2a295c", "AQAAAAEAACcQAAAAEMqCQvGJF2jyprlB/xH5KiQrKuYAsS7FyrhtCGk/SEiHbwDPHJrJ4LObxsy3xNkgsA==", "4940e4bbed7744cbb8cd9842eb322598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-330000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa08a26-1deb-4c6a-bc07-b942178b246f", "AQAAAAEAACcQAAAAEL1vxoq3S9Ax5DtFAnQrqQrm5vu/g8oa0yHTE16YeLIOnpBTEozWZfRWoJIKNostBg==", "158d5fdeb0dc4130ac53ab27757ad53a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-340000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d81f09e0-11c1-4679-8a09-453a9c6b89eb", "AQAAAAEAACcQAAAAENlqT6Tq68ReeDei26PAPEAsKr0ewihxRQM4b7MWYoWCihZ6Mrh93e+85x4kqNOxEg==", "3ae7be0c715249dd84887b6cb34d3009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b11dcd-5943-4742-a969-702288e7df6c", "AQAAAAEAACcQAAAAEKys7wGs8OmSnT2ZCXDl1THwRaViRSnobl/2VLNB3EFG/jQtOXNBVhT/Y2DqpiEkPg==", "5c682971e6db42a7befdfa81a9923d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "806d68c2-2c86-407e-bdcc-ee2ba6561a9b", "AQAAAAEAACcQAAAAEJCPTJ3bkZPZ9ttYtvLoKPucujNOmSdG3IHbwFAU+XiJxMN0Tw0Cb0iploiNJgpVjw==", "15c19e0400934e48876b3049ddd0c87f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04bcb7ab-8722-45f5-b4f2-5e42f30ff927", "AQAAAAEAACcQAAAAELqGI2WitGPn4a4JEtLPYkOz3gY9uXgf5Etn+cv34E7kciEoNVmNteeNeZGBmpAgCg==", "943a0e93e83e419996dc77fdfb24d2db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a6e567-14ba-49f2-aab2-4e226f0cad00", "AQAAAAEAACcQAAAAEHRx4EJPEqgJK7izBeCN2AP4I0c8ZATLoqECi1itFifV4gXPVa6hgJBzMicUIzVxeQ==", "054681c4a2f14da5a0412c6b3260edec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a726b6a1-16e3-4c8f-8a50-bc7957637369", "AQAAAAEAACcQAAAAELUXExIuk/FKnZ67ufOucRUzeqpomDy6JFx9aJDcHv8CQFec4iGVAO5PXrdI01wEVw==", "2e1a649fe936469780fb804dce2b916b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91ee62e0-3e88-4fee-b0c6-14ba2c342f06", "AQAAAAEAACcQAAAAEDxZ+hxDQ/8iefrR7inh4GqWGlZQtrusmNQJ4BGxmOhNPHsmWr7b+E1VQ0fx7AaDWA==", "bc132ce799f646219aebaefeb9ae82b3" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/xas0x0fMly5bxEVOSDmdNQ__imagepage/img/FDpAA_ow4dQqM3u6aXrSleZv14I=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2648302.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/B5F5ulz0UivNgrI9Ky0euA__imagepagezoom/img/DRtkNm13lxOk207XPSzA-WDS25g=/fit-in/1200x900/filters:no_upscale():strip_icc()/pic3122349.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/RvFVTEpnbb4NM7k0IF8V7A__imagepage/img/zruHYxY2_jx-796WgsDj7hitidQ=/fit-in/900x600/filters:no_upscale():strip_icc()/pic860217.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/U1C1mLc1wLXixz2e77AJpQ__imagepage/img/1us3YOPMkCZPFlFhg26fRQ1PDWQ=/fit-in/900x600/filters:no_upscale():strip_icc()/pic5885666.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/yLZJCVLlIx4c7eJEWUNJ7w__imagepage/img/uIjeoKgHMcRtzRSR4MoUYl3nXxs=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4458123.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/JtjGOgkaIxnLUeoV56cWFQ__imagepage/img/mdwAZkhgv48okMZg7kDtIJtdtNA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic814011.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/rAQ3hIXoH6xDcj41v9iqCg__imagepage/img/QTDaAfkaWhobmpHVlfVtBz30OH0=/fit-in/900x600/filters:no_upscale():strip_icc()/pic5164305.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/Ehx72XRdSeQHISVXcZVnHg__imagepage/img/7wwISG7kfg1a-dIi07n6n9fAK2Y=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2453926.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/tw_4LppTBY7uvp96klEV_g__imagepage/img/Al_xBBmzRYcrRZeTiKyV46lONlk=/fit-in/900x600/filters:no_upscale():strip_icc()/pic5937448.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/YfUxodD7JSqYitxvjXB69Q__imagepage/img/DX6-XYd-2-RNTaWIEhcIjoJsNXQ=/fit-in/900x600/filters:no_upscale():strip_icc()/pic5147022.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/mmZDNnsH1ZiHSnSRv82yzQ__imagepage/img/5GMXi6rYuJCDAqk-6UGVAEORbJQ=/fit-in/900x600/filters:no_upscale():strip_icc()/pic252235.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/eVy9IyAVtzzKv2VvPHFPbA__imagepage/img/ejOIi-lOsES1MJ2VLTLeftm3kQc=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3013621.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/nhoyoLpYPC2b3UiJ5kJ0yg__imagepage/img/BzS2PYOAIB4Ei-FHDyPm7Q0PoyU=/fit-in/900x600/filters:no_upscale():strip_icc()/pic1473629.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/V6m5SH45BlP6t7-HuGWA-w__imagepage/img/tGsJPobtgrpUDxVEJvtnXDtrJ9k=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3562670.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/Rq78Zg67kx0Ay24kgNnx0Q__imagepage/img/lBLqeOrFdt1bcotqmKBN07IG9yw=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4145901.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/eJqxaN9zO6PeZSzzsfR61A__imagepage/img/CXHLk31KSobbQPsMofLvWeN4CLE=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4189314.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/-EB8c-OIEZfHi1p-8qwiUw__imagepage/img/WVOIPQI-l7Cki7MfQOmdgTCTUEA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3684814.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/g4XmxyKhNVdhC3QPd1purQ__imagepage/img/KvLHuOPPN-sARwc-vBXWoLRJ0B0=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3761012.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/XpunFAlu_OzFHuhf2fBJxA__imagepage/img/KWvqCx6zMVzhKOTX_lVeykdvfj0=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4764176.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/eNgD_0WGHeO9fPCpgTOBrQ__imagepage/img/zz5IGiCDcPft5e342NdFBdWovuU=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4118864.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/GifbnAmsA4lfEcDkeaC9VA__imagepage/img/TvxriorE7sP7kHcUQAgLGoJP7ZQ=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4397932.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/xpu231bU50Ho1oIWNg4-LQ__imagepage/img/ghK-ff0BlXyXFyXugsWLpTHPaZU=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4543702.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/_Ppn5lssO5OaildSE-FgFA__imagepage/img/0AK9hQgpcOOOLJh8IEZS3Nw57vE=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3727516.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/RmKYojYHmV8X-ebtNgaz-g__imagepage/img/DhsNqblAoesFszW_9lJjV8ACzx4=/fit-in/900x600/filters:no_upscale():strip_icc()/pic738119.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/ImPgGag98W6gpV1KV812aA__imagepage/img/ZHAFxwwPAmpSqOjPb98GZV_x3rA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic1215633.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/MAIDRapFcDC08pmZIBM7EQ__imagepage/img/DznDkaq6jDgwzHR6nvKbQc9JbwU=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3315057.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/6uEBiPxMH8gfGJ6f3HLNGg__imagepage/img/NMxxGcFNEH9FQsJwaZex92T2q00=/fit-in/900x600/filters:no_upscale():strip_icc()/pic1807124.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/wg9oOLcsKvDesSUdZQ4rxw__imagepage/img/FS1RE8Ue6nk1pNbPI3l-OSapQGc=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3536616.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/EhXCpSR6ambdYuKbrej3UQ__imagepage/img/WYdcor5Fi0cZYgk4XinAKJ7AWi4=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4134810.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/JUAUWaVUzeBgzirhZNmHHw__imagepage/img/ZF-dta5ffawuKAkAt2LB-QTIv5M=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4254509.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/dDDo2Hexl80ucK1IlqTk-g__imagepage/img/TLgJgsf7CyGgl8RM2duUYOrE41E=/fit-in/900x600/filters:no_upscale():strip_icc()/pic831744.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/fjE7V5LNq31yVEW_yuqI-Q__imagepage/img/ijYTk6KGtxLRdIvLsGar13ZHs4c=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3918905.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/hLJv1A1TwrMrLLIJhVpKVA__imagepage/img/fMzQSQeqMkeqHHK_hmj3FBjAx2I=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3429338.png");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/sZYp_3BTDGjh2unaZfZmuA__imagepage/img/pBaOL7vV402nn1I5dHsdSKsFHqA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2437871.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/HkZSJfQnZ3EpS214xtuplg__imagepage/img/nLp0poXg-Y6szkicHe7U2thnwhk=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2439223.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/tAqLpWxQ0Oo3GaPP3MER1g__imagepage/img/XyHxeMepMS292xwGjwdK6SvPL4I=/fit-in/900x600/filters:no_upscale():strip_icc()/pic5073276.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/7SrPNGBKg9IIsP4UQpOi8g__imagepage/img/89ViRUkHkCJhvZA5fay7A9-46mY=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4325841.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/M_7UvwZvuxBVjxdadsa5AA__imagepage/img/AuKDe6Q4lyGdm6rTS2JUEXvhTbQ=/fit-in/900x600/filters:no_upscale():strip_icc()/pic1077906.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/iwevA6XmiNLHn1QnGUucqw__imagepage/img/W6vxWVStCBL7qs6yW_G0VbC9Jxw=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3880340.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/x3zxjr-Vw5iU4yDPg70Jgw__imagepage/img/-17KkOmxbTu2slJTabGrkO8ZW8s=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3490053.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://cf.geekdo-images.com/wW5xjgBJcFyLaEWZwrYuKA__imagepage/img/DUNPUEzMu1Elu0SNuqnTNDrUTLY=/fit-in/900x600/filters:no_upscale():strip_icc()/pic4583626.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "f59a8880-f88d-4119-95d5-5336a7d26210");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "0a11e8ef-e50b-4faa-8a30-d65110fed2ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "e78234c9-0964-4556-9d3e-a637b111880b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "daad365a-9a2e-431d-8f3b-3b4f7f34ce94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e86f920-b36e-447b-9ca1-727a134dcbbc", "AQAAAAEAACcQAAAAEJ+yhfAZtUK6F/y819/pOz5GK4sDtNwyucl87RAuwIsD7P9Mq45eK0FI/LAGqLnMmQ==", "ad8cc8df46c6432bad78433ce7625cbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98b91a94-2f5a-49d6-8cf5-610cb3084f24", "AQAAAAEAACcQAAAAEKaekgEb4wKOTI0BMNRf7focSwUltiVgaSjjX3rUu45X06rIbcC63fod87IKvRuPJw==", "ee8725f3a69442da9981e82ca251c2d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1515eaa-08c4-4a2f-a69d-4ecd460b434b", "AQAAAAEAACcQAAAAEAu+tmmQQ4CKeR+SfiSi3Ei1RmfcTxMHBLsRd3WwUgIc8SgVQGvLjYMnFgzapcyQaw==", "eb51b6101813432abbf985981f66aee2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e759888-fefc-4c41-bc9f-e662da90b0aa", "AQAAAAEAACcQAAAAEGzpLeb2kOeDVU7RP9n8n/QSHng3E9iX5Sfz4q8mNA/SQyLqw9nd8YYxJF1C1C437A==", "5032e1ef75ed4d65b325e353237281de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b661bcf-cb00-4a9c-beb4-82619783dd4a", "AQAAAAEAACcQAAAAEIwGSOWd+CjHKr5imV06g0iMdUAeAH0JoYsHAiAssuQdEO9ZUOK9l9uC79qwE616UA==", "55a4473cdb4d432480e0c9a4c147461d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfee9e94-b22e-4e1b-9049-0c4c93dc2de6", "AQAAAAEAACcQAAAAEAstCxfwWpuEDAkXxlaSZxq++1XF4t2HayXRrOcSqUiMD6QudQmaWd0ADzazAJ/pRA==", "9eb62f42ef9e4f3e820c32ecbdcc12a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31da3431-27ca-4ea8-92ba-1bc6f19a43c6", "AQAAAAEAACcQAAAAEMpgYci4md9QX8hGxQv6Xr06lj8GEql9/78wo/hWCmlo1sQ7d+5j6G3gUD8pohic3g==", "7a9bcc75fb9e46ee84c20b969e92a508" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02c4eae0-86a9-469d-a3f6-d5418ccfd143", "AQAAAAEAACcQAAAAEFJZy1UEtct7gI3CXUb2QkTIt98MJGsUFa6bJ+V8hjIbuDRNFhZs4DX0AmP+y2+q6w==", "8e4d40813938431cb34b055c9d376582" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c7040ea-26f2-40a0-8913-42101baff615", "AQAAAAEAACcQAAAAELjOIB9Jq4NYziz+sgbROcyGGvKCg8JNZ96Bo0mAA4jIsi61mwqgYUhBijriaNtqEQ==", "a16c5566767445f3bcf802009556b42a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f757c00-c553-4f0a-8e38-421a5f4cc06a", "AQAAAAEAACcQAAAAEGk9DnDPAAq5rZQrxA3K/zzjuitoKepu8YLmYSbigGE2KOMWV5jUohkWyaRWS1KMyg==", "e8917789303949c89e96b43d47bac06f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39761dc5-71ed-41fd-ad73-48b227851583", "AQAAAAEAACcQAAAAEBJwnddBrYzBKkIjnOUDIdXrTEihWov78qm9XeSHezeSXpMR9/grkcsOtg8TflkmbQ==", "b06e9b24600648d8965734af298143cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01f886e-15ad-4d3b-a3c4-b61a305868fe", "AQAAAAEAACcQAAAAED8vG1O6ykuqExoFmFpbauAMc3m5w+Q6wmApzqDEzUrpSSYEJEZ2mGP4kYsn1kY9zw==", "9dc55cdb3ce749c383a1a818b8a521c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aab24c3-1189-47a1-9da8-32228b407d86", "AQAAAAEAACcQAAAAEJuRp5g9KEZxGIxLFoHkVNnnlOvVRm6ijIoZmSiJkVSOBP1aFTGy78NoyeKH1TCPaw==", "2c08f34ed39a4b84b64cde9f9e467728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9677bcce-3a83-4771-8a63-2106e8e88dd8", "AQAAAAEAACcQAAAAEIJKKATbYatl10XDH2ZLpSrDqvcvW9qs/AB4KOOeD6LnfxhKNUkVB7yExouW5pU91w==", "04adc38c227d44c8abd41db84d54fe2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c99d75e-04da-4146-9b2e-2b4842425974", "AQAAAAEAACcQAAAAEPhSbpJGLvpAgTx7Yc8EOQRRJc/zrzKxE0B33mdf+R7pDg3RgMeFqbwljPmfI0Ve4Q==", "a443e1f915d94c5abaedc333947c00b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f7b928c-faf7-43e8-94e7-0a8b1147e39d", "AQAAAAEAACcQAAAAEKRcxJQf4tEzMCf/C+ofB9ci+AyVCGpMT3BW0QGly22e3nbPipR5ZmhVFrDiUD5kCQ==", "c5499abc04e54d51a5ae8ab30c026908" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaed80a7-e35d-4e55-9ab0-f743f3728994", "AQAAAAEAACcQAAAAEAqc+JkDmzrYaMdQKRcMsHX/BXY4Y2XYYIaAq3vGUYEN6Nov2iCUmPwVEyP1fsHKuA==", "3d3454acc14f43cdb4ce7f8f06e0a735" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31bac60c-fea7-4451-b0f6-dde230ab5cad", "AQAAAAEAACcQAAAAEClZyJWG3CL2iz9ZgYkDIAAagMVltiaIrGLz+WoOnj2HnFDXCn+fc4fGQGM+MzAs1A==", "c42ea9a7449940d3bf9218d4c222d101" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-280000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce862f75-3728-42a0-971a-e46a75c02e77", "AQAAAAEAACcQAAAAEMvc/HCYdHDJp3rgVgkmslrO7xvYNxEwcnMUnEyVH6BapTjto2Xssh4INZqPHNo60Q==", "ed067328b04b459486cebf15f639ecb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-290000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8917a4f-1a0e-4497-bb96-df3728bb108c", "AQAAAAEAACcQAAAAENQEy2z9VpXcEVYRg8JMhsF+e9m+oznKAuFOcPwpEfDtEpI2WFZaylk+AgqWZFbomg==", "5a88f9a29b2443baab12441291c656ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c1e23af-e136-4608-b020-493b66db42dc", "AQAAAAEAACcQAAAAEKQvlQTYqad3REqtKnOoXKuhfxQ/77G4N2OynUzgBaEbvQ4dHCULQ5BWskXvgVjOPg==", "dc188556796b4a89aee4312e3071fc3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-310000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5e7dd56-135e-4da9-b2f9-e18868d8c53d", "AQAAAAEAACcQAAAAEHFNAH4JDJnzUrpowdcz9NwAubp0xTFUyWvybCufe+RdcOaSnkHfdydDZ1E5snoa1Q==", "c3b342547ec84c8baa5818e0ae88b25b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-320000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddc46b07-2493-4f96-9262-696550d55dbf", "AQAAAAEAACcQAAAAEE2aYgRXfnkYHe6rOGN3+/+0oSzIuWgMQFeQQYAg3A4vITcat215NeazuyDcXGnkWg==", "491c491811544329aa01a50b948be3da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-330000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69318029-b02b-4080-9744-f62c4a0aa1b2", "AQAAAAEAACcQAAAAEHzidNVqiHYvsFXiiS0jdJNrjXn2MCO8eAobZQlgrE4xul8zz1p7b/YpGKyZBlNGtw==", "890604be69b64eab994ef275baceb3c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-340000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd66c3a-6166-41e3-9fe6-62b1c2faaafd", "AQAAAAEAACcQAAAAEBEwSQb+f6jrSdAYY7Ka4uAoq0N4EsFQxZ+kCUl8n9rcdiDsheJwpti41Lkoiuw5Tw==", "ec045774fb2944969bc048a8d9e7405d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a47d4952-cae3-4689-9101-29302c7d2fb7", "AQAAAAEAACcQAAAAEKcXY2veYc3t6wblofxKOFDD/0A3D3tMrrF4I2b6mKAbhx+V9XjNUwSAU+cKhjJCWA==", "79ae3caa698a413d9ff6ad121da05ac1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4c8c47-a21f-43cd-a2e3-d11dc2bcc648", "AQAAAAEAACcQAAAAEMItDxwrEa0kg2+mW+8PTcxHFkGOvi9JYQFiNpOIm4ZNU6EVRnPq7brPzMEd+RveXQ==", "110b85d4611c435b8bdb5e56c247cbc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "496bcd4b-e712-479a-af7e-defac99a1b69", "AQAAAAEAACcQAAAAEHtXvtft3mAJtwJ4pTYZ8Afz4MEALVbMdwdE17aWZ0O9Osv3LNazsVdGlg24nMS1WQ==", "8719586dd6aa4e48ae0b0863e94396c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2d140a-529a-4162-9174-148be3e91292", "AQAAAAEAACcQAAAAEFyb6JBFioM9GZKcEdV/L1/NXVAOL4rBT2aMe42s6RRFzsJIc8pHtLErXM3BzUW6Og==", "833f66c92946440f9f783e32e7610c45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdabb32b-e77c-40a5-a12f-91539d9b1ff0", "AQAAAAEAACcQAAAAENGq1CjxsxzeMJRIEDLEDmwPDhZRqDQnT0T/ERSvstDdhGD52HZ5W3z1C7O58H6MFw==", "46f65be4acd049708eb38e3319dc528f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "327386e4-4753-42d3-a187-fbe4dc535121", "AQAAAAEAACcQAAAAEMR7VlwXHi4KI40wUfvGKQRwEPdZ7ZRugUhM8FqRVyIrxU51tqPChZeI2YPe1HqJIA==", "44e04f951c5f48dda19b1c7e48f4234a" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=The+7th+Continent");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Arkham+Horror:+The+Card+Game");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=7+Wonders");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Joking+Hazard");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Wingspan");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Mansions+of+Madness");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Secret+Hitler");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=SpyFall");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Pick+Your+Poison");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Pictionary");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=What+The+Fuck");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Captain+Sonar");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Roll+for+the+Galaxy");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Dice+Hospital");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Dice+Settlers");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Impact:+Battle+of+Elements");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Too+Many+Bones");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Welcome+To...");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Rome+and+Roll");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Railroad+Ink");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Cartographers");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Imperial+Settlers:+Roll+and+Write");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Twilight+Imperium+(4th+edition)");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Merchants+and+Marauders");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=War+of+the+Rings");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Heroes+of+Land,+Air+and+Sea");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Xia:+Legends+of+a+Drift+System");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Terraforming+Mars");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=My+Little+Scythe");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Root");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Agricola");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Everdell");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Dinosaur+Island");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Gloomhaven");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Blood+Rage");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Nemesis");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Star+Wars:+Rebellion");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=A+Game+of+Thrones:+The+Board+Game");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Rising+Sun");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Brass:+Birmingham");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://dummyimage.com/600x600/000/fff.jpg&text=Teotihuacan:+City+of+Gods");
        }
    }
}
