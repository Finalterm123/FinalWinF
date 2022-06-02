using QL_Xe.TrongCoiXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Xe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        ///Nồng ngu lắm!
        /////TÚ ĐÂU RỒI????
        /// Tú đây
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());

        }
    }
}
