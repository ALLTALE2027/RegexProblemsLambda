namespace UseRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex Problems");
            RegexCases lambdaRegexCases= new RegexCases();

            //UC1 
            lambdaRegexCases.CheckFirstName("Darshan");

            //UC2
            lambdaRegexCases.CheckLastName("Deshmukh");

            //UC3
            lambdaRegexCases.CheckEmail("abc.xyz@bl.co.in");

            //UC4
            lambdaRegexCases.CheckMobilNumber("91 9123456780");

            //UC5
            lambdaRegexCases.CheckPassmin8Char("Abc01234abre");

            //UC6
            lambdaRegexCases.CheckPass8CharWithUpperCase("54bAvads");

            //UC7
            lambdaRegexCases.CheckPass8CharWithNumber("abqmbAAAAA1");

            //UC8
            lambdaRegexCases.CheckPass8CharWithSpecialChar("adf@asfwefwedw");

        }
    }
}