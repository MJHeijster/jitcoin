#region Totally le JIT copyright/left?
//
// JJJJJ  IIIII  TTTTT
//     J    I      T
//     J    I      T
// J   J    I      T
//  JJJ   IIIII    T
//
// JEH, TJA 2017
//
#endregion
using System;
using System.Windows.Forms;

namespace jitcoin {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
