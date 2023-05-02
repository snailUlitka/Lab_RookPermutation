namespace Lab1
{
    internal class Permutation
    {
        private readonly int[,] field;
        private readonly Fields fields;

        public Fields Fields
        {
            get { return fields; }
        }

        public Permutation(int size)
        {
            field = new int[size, size];
            fields = new(size);

            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(0); x++)
                {
                    field[y, x] = 0;
                }
            }
        }

        private void SetRook(int y, int x)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                field[y, i] += 1;
                field[i, x] += 1;
            }

            field[y, x] = -1;
        }

        private void RemoveRook(int y, int x)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                field[y, i] -= 1;
                field[i, x] -= 1;
            }

            field[y, x] = 0;
        }


        private void Rec(int row)
        {
            for (int column = 0; column < field.GetLength(0); column++)
            {
                if (field[row, column] == 0)
                {
                    SetRook(row, column);

                    if (row == field.GetLength(0) - 1)
                    {
                        fields.SaveField(field);
                    }
                    else
                    {
                        Rec(row + 1);
                    }

                    RemoveRook(row, column);
                }
            }
        }

        public void Start()
        {
            Rec(0);
        }
    }
}
