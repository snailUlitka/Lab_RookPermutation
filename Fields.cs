namespace Lab1
{
    internal class Fields
    {
        private readonly int[][,] fields;
        private int index = 0;

        public Fields(int size)
        {
            fields = new int[Fact(size)][,];

            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = new int[size, size];
            }
        }

        public void SaveField(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    fields[index][i, j] = field[i, j];
                }
            }

            index++;
        }

        public int[,] GetField(int index)
        {
            return fields[index];
        }

        public static int Fact(int num)
        {
            int res;

            if (num == 1)
            {
                res = 1;
            }
            else
            {
                res = num * Fact(num - 1);
            }

            return res;
        }

        public static ulong FactLong(int num)
        {
            ulong res;

            if (num == 1)
            {
                res = 1;
            }
            else
            {
                res = (ulong)num * FactLong(num - 1);
            }

            return res;
        }
    }
}
