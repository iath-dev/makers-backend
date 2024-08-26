using TestSolution.Methods;

namespace AppTests
{
    public class XYZTest
    {
        [Fact]
        public void ActualValue()
        {
            List<List<int>> data = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 7, 8, 9 }
            };

            int res = XYZ.xyz(data);

            Assert.Equal(0, res);
        }

        [Fact]

        public void NoSquareMatrix()
        {
            List<List<int>> data = new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 4, 5 },
                new List<int> { 7, 8 }
            };

            var XYZ = new XYZ();

            Assert.Throws<ArgumentOutOfRangeException>(() => XYZ.xyz(data));
        }
    }
}