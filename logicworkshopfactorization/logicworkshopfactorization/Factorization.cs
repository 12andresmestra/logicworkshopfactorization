using System.Text;

namespace LogicWorkshop;

public class Factorization
{
    private int _number;

    public Factorization(int number)
    {
        _number = number;
    }

    public string GetResult()
    {
        int n = _number;
        int divisor = 2;
        StringBuilder result = new StringBuilder();
        result.Append($"{_number} ");

        bool first = true;

        while (n > 1)
        {
            if (n % divisor == 0)
            {
                if (!first)
                {
                    result.Append(" x ");
                }
                result.Append(divisor);
                n /= divisor;
                first = false;
            }
            else
            {
                divisor++;
            }
        }

        return result.ToString();
    }
}