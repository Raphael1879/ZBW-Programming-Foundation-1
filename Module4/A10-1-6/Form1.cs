
namespace A10_1_6
{
    public partial class A1016 : Form
    {
        private readonly Random random = new Random();
        int[] data = [];

        public A1016()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            data = GenerateRandomNumberArray(1000, -1000, 1000);
            textBox.Text = string.Join(' ', data);
            maxLabel.Text = Max(data).ToString();
            smallLabel.Text = Min(data).ToString();
            averageLabel.Text = Average(data).ToString();
            deltaMaxLabel.Text = DeltaMax(data).ToString();
            deltaMinLabel.Text = DeltaMin(data).ToString();
        }

        private int[] GenerateRandomNumberArray(int size, int min, int max)
        {
            var array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }

        private int Max(int[] data) => data.Max();
        private int Min(int[] data) => data.Min();
        private double Average(int[] data) => data.Average();


        /*
         * Computes the absolute difference ("delta") between each pair of 
         * consecutive elements in the input array.
         *
         * Example:
         *   Input:  [5, 8, 3, 10]
         *   Deltas: [3, 5, 7]
         *     because |8 - 5| = 3,
         *              |3 - 8| = 5,
         *              |10 - 3| = 7
         *
         * Returns:
         *   An array where each element represents the delta between data[i] 
         *   and data[i + 1].
         */
        private int[] GetDeltaArray(int[] delta)
        {
            int[] deltas = new int[data.Length-1];
            for (int i = 0; i < data.Length; i++)
            {
                if (i + 1 < data.Length)
                {
                    deltas[i] = Math.Abs(data[i + 1] - data[i]);
                }
            }
            return deltas;
        }
        private int DeltaMax(int[] data) => Max(GetDeltaArray(data));
        private int DeltaMin(int[] data) => Min(GetDeltaArray(data));

    }
}
