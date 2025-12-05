namespace Ripassi
{
    public class ISBN
    {
        public static void main(string[] args)
        {
            Console.WriteLine("result:\t" + IsValid("9788849293371") + "\ttest: 9788849293371");
            Console.WriteLine("result:\t" + IsValid("1") + "\ttest: 1");
            Console.WriteLine("result:\t" + IsValid("12") + "\ttest: 12");
            Console.WriteLine("result:\t" + IsValid("123") + "\ttest: 123");
            Console.WriteLine("result:\t" + IsValid("1234") + "\ttest: 1234");
            Console.WriteLine("result:\t" + IsValid("12345") + "\ttest: 12345");
            Console.WriteLine("result:\t" + IsValid("123456") + "\ttest: 123456");
            Console.WriteLine("result:\t" + IsValid("1234567") + "\ttest: 1234567");
            Console.WriteLine("result:\t" + IsValid("12345678") + "\ttest: 12345678");
            Console.WriteLine("result:\t" + IsValid("123456789") + "\ttest: 123456789");
            Console.WriteLine("result:\t" + IsValid("1234567891") + "\ttest: 1234567891");
            Console.WriteLine("result:\t" + IsValid("12345678912") + "\ttest: 12345678912");
            Console.WriteLine("result:\t" + IsValid("123456789125") + "\ttest: 123456789125");
            Console.WriteLine("result:\t" + IsValid("1234567891256") + "\ttest: 1234567891256");
            Console.WriteLine("result:\t" + IsValid("abcdefghijklm") + "\ttest: abcdefghijklm");
        }

        static bool IsValid(string isbn)
        {
            if (isbn.Length != 13) return false;

            int sommaP = 0;
            int sommaD = 0;

            for (int i = 0; i < isbn.Length; i++)
            {
                int c = int.Parse(isbn[i].ToString());
                if ((i + 1) % 2 == 0) // Posizione PARI
                {
                    sommaP += c; // sommaP += int.Parse(isbn[i].ToString());
                }
                else // Posizione DISPARI
                {
                    sommaD += c;
                }
            }

            int result = sommaD + (sommaP * 3);


            if (result % 10 != 0) return false;
            
            return true;
        }
    }
        // foreach (char c in isbn)
        // {
        //     Console.WriteLine(c);
        // }
}