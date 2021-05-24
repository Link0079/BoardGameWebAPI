using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddNewPhotoUrlToBoardGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "ce60208d-218e-4d43-93f1-61b86da5fe96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "1777de1f-65f3-40a0-a40f-96cb8eba127d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "a95b7e38-a9ba-4a01-9b0a-f7442d25decd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "ConcurrencyStamp",
                value: "590ff7cc-8e69-49df-bf54-ab63cf878978");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-100000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea976eb-27cd-4fee-a815-6c2371a8f4f6", "AQAAAAEAACcQAAAAEDTaZ4sJIsEoNlWahezCQojPe6FlizQK2h4tN3BuNzqY1BWMt5JCY64oAotE2nQzLA==", "4a123418449a4c1cb067ff5a732c90ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-110000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2f2b7a1-77ed-49e3-b413-c3e4eb676c6d", "AQAAAAEAACcQAAAAENFOdWVkkBA2g6gQ4MzFHHJF1BaybXwikaf5Mtolef2qJi+sywoNfxzY0XVQygH6rg==", "ff17825e23924ae0b22f178aed981f67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-120000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4ce9e04-811e-49a8-b95a-8e5b73d306c2", "AQAAAAEAACcQAAAAEEMopFJkk83Zwg4IIbIHVE0nghQYcjH4RslDF1mWhm+7rEKdl+k5aFVCWJaWkfL8OA==", "d6e54c677ca24a6998f99ad41fcd6c74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-130000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e5a1d84-db06-4217-919f-50c9bcd1a906", "AQAAAAEAACcQAAAAEH/LS4fq1S5ytsVRk/c+ugQN2q8/dtZqdJerZIpR38WRHk3NQQdOKG/LgYcbTHYpzQ==", "7c2bb277fc464f4ba1308c300231827c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-140000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d68d931-6ba2-42dc-a05a-ee60afb47759", "AQAAAAEAACcQAAAAEArbC9SRT1LJJhLOL4OcYT1zbMUSe95TW/P/Zmoa63zOwlOauUZZspXLur+WXriRRA==", "8e8f0d39be424df88b261b2ce6f0d21b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-150000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0494adb-7d38-4612-93a6-27ff3ebf4862", "AQAAAAEAACcQAAAAEDWpubP7oP0tfxqyFIjVPIz518coT+hZQHggQSQu1foLrQUomraoG5uIA4bkZp/qUA==", "a97688517129443d843730230c92b91b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-160000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a516e3e1-6a72-4d29-8a06-606807c32b97", "AQAAAAEAACcQAAAAEEokksrexHcIWDxcuNKgFiShn0OqMZuLjNbmbWxwktK02oqzfL8NsCcRocsDnzr3Gg==", "8e523be53d004a48896ed5d4bc7a50f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-170000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29cb9d51-a094-480d-aa95-bcdf33aa2e2e", "AQAAAAEAACcQAAAAEAovE5igm3WYovnS20B5euXe+9B6RoSkP5gNoiIIme3bsl2tMUr590SB6dIBDxoWgg==", "93604a1298b04b42bdfcb48049e6fa3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-180000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7c8eeac-c0c1-4d1f-ba03-0647c50472ae", "AQAAAAEAACcQAAAAEDVxUIfFN27m7yuMzUel+cof4iYyBe5ZEOTsQHnfI7xyjwzB4RWtCmtdM6G86RMakA==", "a21f2e7333944b41a18cadb02dc2218b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-190000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdac971-9b38-4078-bec7-d2ebd7fdf828", "AQAAAAEAACcQAAAAEHlc4kPC06nYTH8scsJUNvLzUX8edjVH7YpUypfIc+nGJLqI3KYOUQ4732+sVUnmlw==", "5af52b8bc72f45f3847a89e0885ab903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-200000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fb622d1-0244-41c0-bfc4-0c8514fbff93", "AQAAAAEAACcQAAAAEGgLdPAeZOImjmI2nnEgV/a4V8pZRF4UCZoA+NaWgj33O34tNf5pKV0ygw/romSnlQ==", "1a92d47172274aa7b415e88fd5671fd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-210000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a363d7e-3b4e-4507-a2b3-cf2a632a2048", "AQAAAAEAACcQAAAAEDuLAhWI9kYXeB/8+T3DKHfnUcZWKkO1rdMm8jtElO/M4VqxoKllnWfla2+raCJ70w==", "419cb53744e54c408e8e7e03d18236e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-220000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c5e83f2-5a70-4be8-be48-98930f44dfbb", "AQAAAAEAACcQAAAAENnIzt0b5RfB8Nq8691+3YFaeYrrGhWMK9//uKwKKNjk15SIOzhlju4+taixSAvIww==", "7795b53a637a456e802d264ad11d4b49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-230000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4b65479-fe00-406b-8216-9263649c6074", "AQAAAAEAACcQAAAAECWg8la87UvycYuMT62qE1JiTM0SEd59a8dEzhcAsU0A7mXgq9D06OqHBU9zyJRnFg==", "8115b4033bab46939d1025977ed093b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-240000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c2c0f88-49a4-45b4-9f61-4b65dc6d6f21", "AQAAAAEAACcQAAAAEODFbIOWRNPLhi6CmRpYfKfBbMH1fllAjHZ6F8Bf+Mkjyd1qm9biut6qnxhW12eLFQ==", "8f6f39c5403644d7998777b4746de90e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-250000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "046d1b7a-1ef6-4350-8899-17a25ddd62e7", "AQAAAAEAACcQAAAAEIx+9gMPWz646wreAqceuRbRwKPunJKtpcIJC6md1kFw1IskomYxkjB1VTVN9eMDNQ==", "6010d85cb1ae43a2861f6f01a8ee7c80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-260000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01bd55d-1eca-45b6-8406-767795bbbb63", "AQAAAAEAACcQAAAAEHaOzlSnHPxY8cynKurvXssjdxO9KlSFJ5wemwOpBRAS6i8fp0xrhNlElHLeTD7qaA==", "53f1910db053412194a7756e3ccd33f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-270000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "010f2624-1507-4b71-b4f3-a68fb09b4e31", "AQAAAAEAACcQAAAAEAuBfKr/RCPkcE8tLTPLjU9TZOo/Cj6Lc15zRl4MDTV7JE9uoZ8OzbE/1A5x0FElqg==", "95d89fdd4616415e85766f2900208424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-280000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b40697-d4f9-4419-bcb8-02b91104f108", "AQAAAAEAACcQAAAAEGa3qhZ/Sv4pD0Wy/4KBZbfCrcJPoXWyzl0OJs6uATO//wCca9MIfBS6FoiVIe3QFg==", "b3160ada8a9d421eaea3c71aee219a5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-290000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80fa8e80-6650-4512-99c5-06e0726d6a82", "AQAAAAEAACcQAAAAEJlPmTuprOyUBp2mFitqFsOV/K+ocyTrh4MYuoD0EJ7BbmzBJDkd/ZVggGgZXzxhqQ==", "845be8ff87b9428fa491728ac7fd47df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-300000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5594082f-2720-420e-88e6-acf663707c24", "AQAAAAEAACcQAAAAEJkEz+BFcw3J7fdCL7IzMVwoMYE9nzSxG5JadgnI5lWCEA2KzNF8vl62YJxdo9QLzg==", "393425542a2d49b0b5a4c9a95b4b23bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-310000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff7b1d9e-5529-41c1-b397-ed5ec034da0c", "AQAAAAEAACcQAAAAECKvsl8uFpEUer4v6mrv6tZAeKX6DkLwIbnDCpd3OVyc93Hj019vlvWPv3SfQgsANg==", "49253d09a9fc4eaba8ca43438c6b3a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-320000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ab09dab-b96d-4f1c-8f33-d7a7646bbb42", "AQAAAAEAACcQAAAAEAd4OCXbWDNp4WB2EfiC3NsNC5vUFYiN/lXaVSzeyQYlsQ4qVA59JmeBz1FcN9H7uA==", "9b51b0d7cdbf42da9b074f712c0a48e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-330000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5373f380-b1cf-4c35-b94d-43f69b3a4e32", "AQAAAAEAACcQAAAAEE9wcpCTpQqGjNI6NmIGvKudmKI6zHd18F8axi8PTMumkNgd35BtsOsrSj+/mP4IEQ==", "4e92da4c59b246f49d59a4586c1a378d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-340000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51261015-625e-434f-9a5b-75f8e629c2a7", "AQAAAAEAACcQAAAAEG0ROYkC+PBGi9OynMMInXx/YISyE42GAl+D2QX/NU468PsYK8OyfONjPIQWD0oeFg==", "c6ded2bc572c458e9ba78b8f67220d9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-400000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59916b3a-9e83-4056-9031-8a8e134035d3", "AQAAAAEAACcQAAAAEIu7Oy4XrWZczBB/k+SVyBxmjW1nZ78VXiRZb4rKEpb9cKoSjS/mwwsz9zR4GU1pBg==", "db545936a4f7498682e7b565c9a2a187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-500000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad61789b-5506-4927-8b40-1e133c3a55ea", "AQAAAAEAACcQAAAAEJpJQpC/sd8XkdcWx4IjehDcyek3aXZBnhNRW+1bw5OrUlPHaTiXfeBy22wyz6uUKg==", "6546ffae995048e69744c82c14dfc754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-600000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fa204fd-5db0-4f1a-8b9d-761406b6572b", "AQAAAAEAACcQAAAAEOK+6Dqi6Y4WrsKxQ3bUg6nPS5HFi9XjzpprGXP1ghF+f7NKnA6yo9O1kePBv3SCEg==", "d1263ac66c7440b1acc242eac43ae37d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-700000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00003103-fbeb-4216-8122-d05bfc7a4e5d", "AQAAAAEAACcQAAAAEFBi+10Uccibii11IcMCG6dwxacwYk0rF4Q0aYifNfyp2BM8t8skW5GjTh39dsIc6g==", "b868899da5b741d29008be1d547b5a4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-800000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4eac4d-2a8f-4225-9581-c7e3f1cf5bdf", "AQAAAAEAACcQAAAAEPE17kLU7JrNQzeyxrLTRnnNXV2z8YHjSc4d8XYbrMlKgEaNb6DuCh2ZCX3jo7edoA==", "b7bd11405a6e484e9a4e3dc62f503211" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-900000000000"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddbdf3b7-e8c5-4d6d-a8f5-e75378023634", "AQAAAAEAACcQAAAAEGS+aQ6LXqNCU7yZfLXZOuibVNO94cfZ89JI5pJPsmBXu8v+00erc7RE2/QBHRzk1Q==", "53d032cbbf92451d84b353fd5d6bdb59" });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000005-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000006-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000007-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000008-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000009-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000010-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000011-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000012-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000013-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000014-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000015-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000016-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000017-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000018-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000019-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000020-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000021-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000022-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000023-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000024-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000025-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000026-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000027-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000028-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000029-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000030-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000031-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000032-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000033-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000034-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000035-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000036-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000037-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000038-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000039-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000040-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: new Guid("00000041-0000-0000-0000-000000000000"),
                column: "PhotoUrl",
                value: "https://i.scdn.co/image/ab67616d0000b2731cc6d15e607e0a514b7f4b95");
        }
    }
}
