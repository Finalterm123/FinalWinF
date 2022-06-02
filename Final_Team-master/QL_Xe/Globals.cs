using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe
{
    internal class Globals
    {
        public static int GlobalsUserId { get; private set; }
        public static void SetGlobalsUserId(int userId)
        {
            GlobalsUserId = userId;
        }
        public static string GlobalsUserRole { get; private set; }
        public static void SetGlobalsUserRole(string userRole)
        {
            GlobalsUserRole = userRole;
        }
        public static string GlobalsUserName { get; private set; }
        public static void SetGlobalsUsername(string userName)
        {
            GlobalsUserName = userName;
        }

        public static MemoryStream GlobalsUserImages { get; private set; }
        public static void SetGlobalsUserImages(MemoryStream userImages)
        {
            GlobalsUserImages = userImages;
        }

        public static int GlobalsXeId { get; private set; }
        public static void SetGlobalsXeId(int ID_Xe)
        {
            GlobalsXeId = ID_Xe;
        }

    }
}
