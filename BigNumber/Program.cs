using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber
{

    public class BigNumber
    {
        private readonly List<int> _container = new List<int>();

        public BigNumber(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                _container.Add(c - '0');
            }
        }

        private BigNumber(List<int> container)
        {
            _container = container;
        }

        public BigNumber Add(BigNumber other)
        {
            int n1 = _container.Count;
            int n2 = other._container.Count;

            int n = n1 > n2 ? n1 : n2;  

            List<int> resultContainer = new List<int>(n + 1);

            int x = 0;
            for (int i = 0; i < n; i++)
            {
                int a = i < _container.Count ? _container[i] : 0;
                int b = i < other._container.Count ? other._container[i] : 0;

                int result = a + b + x;

                resultContainer.Add(result % 10);
                x = result / 10;
            }

            if (x != 0)
            {
                resultContainer.Add(x);
            }

            return new BigNumber(resultContainer);
        }

        public override string ToString()
        {
            return string.Join("", ((IEnumerable<int>) _container).Reverse());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {                               

        }
    }
}
