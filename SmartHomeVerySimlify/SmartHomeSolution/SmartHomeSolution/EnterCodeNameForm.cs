using System;
using System.Windows.Forms;
using SmartHome.Core.Interfaces.UIInterfaces;

namespace SmartHomeSolution
{
    public partial class EnterCodeNameForm : Form, IEnterNameForm
    {
        public EnterCodeNameForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowModalForm()
        {
            return  this.ShowDialog();
        }

        public string ResultValue { get; set; }

        private void _btOk_Click(object sender, EventArgs e)
        {
            ResultValue = _txtValue.Text;
        }
    }
}
