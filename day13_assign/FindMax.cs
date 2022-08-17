namespace Generics
{
    internal class FindMax
    {
        public int FindMxInteger(int num1st, int num2nd, int num3rd)
        {
            if (num1st.CompareTo(num2nd) > 0 && num1st.CompareTo(num3rd) > 0)
                return num1st;
            if (num2nd.CompareTo(num1st) > 0 && num2nd.CompareTo(num3rd) > 0)
                return num2nd;
            if (num3rd.CompareTo(num1st) > 0 && num3rd.CompareTo(num2nd) > 0)
            {
                return num3rd;
            }
            return 0;
        }
    }
}