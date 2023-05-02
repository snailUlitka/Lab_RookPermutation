namespace Lab1
{
    public partial class Lab1 : Form
    {
        private int fieldSize;

        public Lab1()
        {
            fieldSize = 1;

            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Info.Visible = !Info.Visible;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool flag = !SetSize_Lbl.Visible;

            SetSize_Btn.Visible = flag;
            SetSize_Lbl.Visible = flag;
            SetSize_TB.Visible = flag;
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lab1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClosingInfo() == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private static DialogResult ClosingInfo()
        {
            DialogResult res =
                MessageBox.Show("Вы хотите выйти?", "Выход", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void SetSize_TB_TextChanged(object sender, EventArgs e)
        {
            if (SetSize_TB.Text.Length > 0)
            {
                if (!int.TryParse(SetSize_TB.Text, out fieldSize) || fieldSize > 65 || fieldSize <= 0)
                {
                    SetSize_TB.Text = SetSize_TB.Text[..^1];
                    MessageBox.Show("Ошибка ввода!\nВведите число меньше 66 и больше 0", "ERROR", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fieldSize = 1;
            }
        }

        private void SetSize_Btn_Click(object sender, EventArgs e)
        {
            if (fieldSize > 0)
            {
                Answer.Text = $"Кол-во перестановок: {Fields.FactLong(fieldSize)}";
                Answer.Visible = true;

                if (fieldSize <= 10)
                {
                    ShowPerm_Btn.Visible = true;
                }
                else
                {
                    ShowPerm_Btn.Visible = false;
                }
            }
        }

        private void ShowPerm_Btn_Click(object sender, EventArgs e)
        {
            PermField field = new(fieldSize);
            field.Show();
        }
    }
}