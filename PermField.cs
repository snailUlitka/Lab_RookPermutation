namespace Lab1
{
    public partial class PermField : Form
    {
        private readonly Permutation perm;
        private int index;
        private readonly int maxIndex;

        public PermField(int size)
        {
            perm = new(size);

            index = 1;
            maxIndex = Fields.Fact(size);

            perm.Start();

            InitializeComponent();

            Field_DGW.RowCount = size;
            Field_DGW.ColumnCount = size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        Field_DGW.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                }
            }
        }

        private void SetSize_TB_TextChanged(object sender, EventArgs e)
        {
            if (SetIndex_TB.Text.Length > 0)
            {
                if (!int.TryParse(SetIndex_TB.Text, out index) || index > maxIndex || index == 0)
                {
                    SetIndex_TB.Text = SetIndex_TB.Text[..^1];
                    MessageBox.Show($"Ошибка ввода!\nВведите число больше 0 и меньше {maxIndex + 1}", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetIndex_Btn_Click(object sender, EventArgs e)
        {
            int[,] field = perm.Fields.GetField(index - 1);

            for (int i = 0; i < Field_DGW.RowCount; i++)
            {
                for (int j = 0; j < Field_DGW.ColumnCount; j++)
                {
                    Field_DGW.Rows[i].Cells[j].Value = field[i, j] == -1 ? '*' : ' ';

                    Field_DGW.Rows[i].Cells[j].Style.Font =
                        new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
                    Field_DGW.Rows[i].Cells[j].Style.ForeColor = Color.Red;

                    Field_DGW.Columns[i].Width = 50;
                    Field_DGW.Rows[i].Height = 50;
                }
            }

            Field_DGW.Visible = true;

            if (index < maxIndex)
            {
                index++;
                SetIndex_TB.Text = index.ToString();
            }
        }

        private void Field_DGW_SelectionChanged(object sender, EventArgs e)
        {
            Field_DGW.ClearSelection();
        }
    }
}
