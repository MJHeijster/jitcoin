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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result2 = MessageBox.Show("Invalid address.", "Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
