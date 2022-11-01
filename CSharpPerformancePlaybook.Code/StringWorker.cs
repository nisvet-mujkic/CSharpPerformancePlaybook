using System.Text;

namespace CSharpPerformancePlaybook.Code
{
    public class StringWorker
    {
        public string BuildStringBadly(string value)
        {
            for (int i = 0; i < 50; i++)
                value += " " + "test";

            return value;
        }

        public string BuildStringBetter(string value)
        {
            var stringBuilder = new StringBuilder(value);

            for (int i = 0; i < 50; i++)
            {
                stringBuilder.Append(' ');
                stringBuilder.Append("test");
            }

            return stringBuilder.ToString();
        }

        public (string lastName, string firstName) NaiveSplitName(string name)
        {
            var commaPosition = name.IndexOf(',');
            var lastName = name.Substring(0, commaPosition);
            var firstName = name.Substring(commaPosition + 2);

            return (lastName, firstName);
        }

        public (string lastName, string firstName) SplitSplitName(string name)
        {
            var nameArray = name.Split(',');

            return (nameArray[0].Trim(), nameArray[1].Trim());
        }

        public (string lastName, string firstName) SpanSplitName(string name)
        {
            var nameSpan = name.AsSpan();

            var lastName = nameSpan.Slice(0, name.IndexOf(',')).ToString();
            var firstName = nameSpan.Slice(name.IndexOf(',') + 2).ToString();

            return (lastName, firstName);
        }
    }
}