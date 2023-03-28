using System.Runtime.CompilerServices;

namespace CSharpFom
{
    public class ValueSet
    {
        private int count;
        private int[] values = new int[100];

        public bool AddValue(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (values[i] == value) return false;
            }
            values[count++] = value;
            return true;

        }

        public void PrintValues()
        {
            for (int i = 0; i < count; i++) {
                Console.WriteLine(values[i]);
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            ValueSet vs = new ValueSet();
            vs.AddValue(1);
            vs.AddValue(2);
            vs.AddValue(3);
            vs.AddValue(2);
            vs.PrintValues();
        }
    }
}