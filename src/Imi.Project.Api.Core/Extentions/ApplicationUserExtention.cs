using Imi.Project.Api.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Extentions
{
    public static class ApplicationUserExtention
    {
        public static string MakeUserNameFromPlayerName(this Player applicationUser)
        {
            return SplitNameOfPlayer(applicationUser);
        }
        public static string MakeEmailFromPlayerName(this Player applicationUser)
        {
            string result = SplitNameOfPlayer(applicationUser);
            return $"{result}@BoardGameWebAPI.com";
        }
        private static string SplitNameOfPlayer(Player applicationUser)
        {
            var result = "";
            var splitName = applicationUser.Name.Split(" ");
            for (int i = 0; i < splitName.Length; i++)
            {
                if (i == 0)
                    result += $"{splitName[i]}";
                else
                    result += $".{splitName[i]}";
            }
            return result;
        }
    }
}
