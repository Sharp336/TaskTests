using NUnit.Framework;
using System.Globalization;
using System.Text.RegularExpressions;

[TestFixture]
public class Tests
{
    [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120, ExpectedResult="qualified")]
    [TestCase(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 120, ExpectedResult="qualified")]
    [TestCase(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64, ExpectedResult="qualified")]
    [TestCase(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120, ExpectedResult="disqualified")]
    [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120, ExpectedResult="disqualified")]
    [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130, ExpectedResult="disqualified")]
    [TestCase(new int[] { 5, 5, 10, 10, 15, 20, 50 }, 160, ExpectedResult="disqualified")]
    [TestCase(new int[] { 5, 5, 10, 10, 15, 15, 40 }, 120, ExpectedResult="disqualified")]
    [TestCase(new int[] { 10, 10, 15, 15, 20, 20 }, 150, ExpectedResult="disqualified")]
    [TestCase(new int[] { 5, 5, 10, 20, 15, 15, 20, 20 }, 140, ExpectedResult="disqualified")]
    
    public static string Test1(int[] arr, int tot)
    {
        return Program.Interview(arr, tot);
    }
    
    
    [TestCase(new string[] { "at", "be", "th", "au" }, new string[] { "beautiful, the, hat" }, ExpectedResult=true)]
    [TestCase(new string[] { "bo", "ta", "el", "st", "ca" }, new string[] { "books, table, cap, hostel" }, ExpectedResult=true)]
    [TestCase(new string[] { "la", "te" }, new string[] { "latte" }, ExpectedResult=true)]
    [TestCase(new string[] { "th", "fo", "ma", "or" }, new string[] { "the, many, for, forest" }, ExpectedResult=true)]
    [TestCase(new string[] { "ay", "be", "ta", "cu" }, new string[] { "maybe, beta, abet, course" }, ExpectedResult=false)]
    [TestCase(new string[] { "oo", "mi", "ki", "la" }, new string[] { "milk, chocolate, cooks" }, ExpectedResult=false)]
    [TestCase(new string[] { "la" }, new string[] { }, ExpectedResult=false)]
    [TestCase(new string[] { "la", "at", "te", "ea" }, new string[] { "latte" }, ExpectedResult=false)] 
    public static bool Test2(string[] bigrams, string[] words)
    {
        return Program.CanFind(bigrams, words);
    }
    
    
    [TestCase("12/03/2020", ExpectedResult="19/03/2020")]
	[TestCase("21/12/1989", ExpectedResult="28/12/1989")]
	[TestCase("01/01/2000", ExpectedResult="08/01/2000")]
	[TestCase("24/09/1924", ExpectedResult="01/10/1924")]
	[TestCase("21/07/1964", ExpectedResult="28/07/1964")]
	[TestCase("14/07/2085", ExpectedResult="21/07/2085")]
	[TestCase("25/04/1953", ExpectedResult="02/05/1953")]
	[TestCase("02/01/2200", ExpectedResult="09/01/2200")]
	[TestCase("06/01/2007", ExpectedResult="13/01/2007")]
	[TestCase("07/04/2195", ExpectedResult="14/04/2195")]
	[TestCase("04/09/2094", ExpectedResult="11/09/2094")]
	[TestCase("20/08/1910", ExpectedResult="27/08/1910")]
	[TestCase("12/12/1894", ExpectedResult="19/12/1894")]
	[TestCase("02/11/2094", ExpectedResult="09/11/2094")]
	[TestCase("22/12/1955", ExpectedResult="29/12/1955")]
	[TestCase("18/04/1859", ExpectedResult="25/04/1859")]
	[TestCase("17/03/1847", ExpectedResult="24/03/1847")]
	[TestCase("17/03/2142", ExpectedResult="24/03/2142")]
	[TestCase("26/01/2145", ExpectedResult="02/02/2145")]
	[TestCase("03/12/1959", ExpectedResult="10/12/1959")]
	[TestCase("01/06/1947", ExpectedResult="08/06/1947")]
	[TestCase("26/12/1853", ExpectedResult="02/01/1854")]
	[TestCase("27/10/2068", ExpectedResult="03/11/2068")]
	[TestCase("05/05/2080", ExpectedResult="12/05/2080")]
	[TestCase("22/12/2144", ExpectedResult="29/12/2144")]
	[TestCase("12/05/1870", ExpectedResult="19/05/1870")]
	[TestCase("07/01/1882", ExpectedResult="14/01/1882")]
	[TestCase("16/06/2032", ExpectedResult="23/06/2032")]
	[TestCase("02/10/2007", ExpectedResult="09/10/2007")]
	[TestCase("24/03/1871", ExpectedResult="31/03/1871")]
	[TestCase("19/08/1847", ExpectedResult="26/08/1847")]
	[TestCase("24/07/2157", ExpectedResult="31/07/2157")]
	[TestCase("28/12/1848", ExpectedResult="04/01/1849")]
	[TestCase("20/07/1951", ExpectedResult="27/07/1951")]
	[TestCase("14/11/2071", ExpectedResult="21/11/2071")]
	[TestCase("07/12/2170", ExpectedResult="14/12/2170")]
	[TestCase("01/03/2080", ExpectedResult="08/03/2080")]
	[TestCase("28/04/1906", ExpectedResult="05/05/1906")]
	[TestCase("15/06/2023", ExpectedResult="22/06/2023")]
	[TestCase("11/08/1950", ExpectedResult="18/08/1950")]
	[TestCase("15/11/2103", ExpectedResult="22/11/2103")]
	[TestCase("23/11/1852", ExpectedResult="30/11/1852")]
	[TestCase("08/01/1928", ExpectedResult="15/01/1928")]
	[TestCase("14/11/2118", ExpectedResult="21/11/2118")]
	[TestCase("11/10/2096", ExpectedResult="18/10/2096")]
	[TestCase("02/12/1816", ExpectedResult="09/12/1816")]
	[TestCase("10/10/1937", ExpectedResult="17/10/1937")]
	[TestCase("28/11/1959", ExpectedResult="05/12/1959")]
	[TestCase("27/05/2133", ExpectedResult="03/06/2133")]
	[TestCase("28/04/1932", ExpectedResult="05/05/1932")]
	[TestCase("23/02/2050", ExpectedResult="02/03/2050")]
	[TestCase("23/05/2146", ExpectedResult="30/05/2146")]
	[TestCase("24/07/2167", ExpectedResult="31/07/2167")]
  	public static string Test3(string date)
    {
        return Program.WeekAfter(date);
    }
    
    
    [TestCase(-1, 0, 25, ExpectedResult = new double[] {0, 25d})]
    [TestCase(1, 10, 25, ExpectedResult = new double[] {-5d, 0d})]
    [TestCase(8, 4, 0, ExpectedResult = new double[] {-0.25d, -0.5d})]
    [TestCase(4, -200, 1000, ExpectedResult = new double[] {25d, -1500d})]
    [TestCase(1, -50, -1000, ExpectedResult = new double[] {25d, -1625d})]
    [TestCase(-1, 20, 600, ExpectedResult = new double[] {10d, 700d})]
    [TestCase(5, 1, 20, ExpectedResult = new double[] {-0.1d, 19.95d})]
    public static double[] Test4(int a, int b, int c) => Program.FindVertex(a, b, c);
    
    
    [TestCase("Wh*r* d*d my v*w*ls g*?", "eeioeo", ExpectedResult = "Where did my vowels go?")]
    [TestCase("abcd", "", ExpectedResult = "abcd")]
    [TestCase("*PP*RC*S*", "UEAE", ExpectedResult = "UPPERCASE")]
    [TestCase("Ch**s*, Gr*mm*t -- ch**s*", "eeeoieee", ExpectedResult = "Cheese, Grommit -- cheese")]
    [TestCase("*l*ph*nt", "Eea", ExpectedResult = "Elephant")]
    public static string Test5(string txt, string vowels)
    {
	    Console.WriteLine($"Input: {txt}, {vowels}");
	    return Program.Uncensor(txt, vowels);
    }  

    [Test]
    [TestCase(123, ExpectedResult="321123")]
    [TestCase(123456789, ExpectedResult="987654321123456789")]
    public static string Test6(int num)
    {
	    Console.WriteLine($"Input: {num}");
	    return Program.ReverseAndNot(num);
    }
    
    [Test]
    [TestCase("Marta appreciated deep perpendicular right trapezoids", ExpectedResult=true)]
    [TestCase("Someone is outside the doorway", ExpectedResult=false)]
    [TestCase("She eats super righteously", ExpectedResult=true)]
    [TestCase("Ben naps so often", ExpectedResult=true)]
    [TestCase("Cute triangles are cute", ExpectedResult=false)]
    [TestCase("Mad dislikes sharp pointy yoyos", ExpectedResult=true)]
    [TestCase("Rita asks Sam mean numbered dilemmas", ExpectedResult=true)]
    [TestCase("Marigold daffodils streaming happily.", ExpectedResult=false)]
    [TestCase("Simply wonderful laughing.", ExpectedResult=false)]
    public static bool Test7(string sentence) 
    {
	    Console.WriteLine($"Input: {sentence}");
	    return Program.IsSmooth(sentence);
    }
    
    [TestCase(1, ExpectedResult="invalid")]
	[TestCase(3, ExpectedResult="b, a, ab")]
	[TestCase(7, ExpectedResult="b, a, ab, aba, abaab, abaababa, abaababaabaab")]
	[TestCase(10, ExpectedResult="b, a, ab, aba, abaab, abaababa, abaababaabaab, abaababaabaababaababa, abaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababa")]
	[TestCase(15, ExpectedResult="b, a, ab, aba, abaab, abaababa, abaababaabaab, abaababaabaababaababa, abaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababa, abaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaababaababaabaababaababaabaababaabaababaababaabaababaabaab")]
  	public static string Test8(int n)
    {
        return Program.FiboWord(n);
    }
    
    [TestCase("..<.<.", ExpectedResult=new int[] { 1, 1 })]
    [TestCase("....................................................................................................", ExpectedResult=new int[] {100,0})]
    [TestCase("<>>>><><<<><>>>><><<<><>>><>", ExpectedResult=new int[] { 0, 0 })]
    [TestCase(".<..<...<....<.....<......", ExpectedResult=new int[] { 3, 4 })]
    [TestCase(">>..", ExpectedResult=new int[] { -2, 0 })]
    [TestCase("..<<..>>..<<..>>..", ExpectedResult=new int[] { 2, 0 })]
    public static int[] Test9(string steps)
    {
	    return Program.TrackRobot(steps);
    }
    
    
    
    [TestCase(new [] { 9, 17, 30, 1.5 }, ExpectedResult="$240,00")]
    [TestCase(new double[] { 9, 18, 40, 2 }, ExpectedResult="$400,00")]
    [TestCase(new [] { 13, 20, 32.5, 2 }, ExpectedResult="$325,00")]
    [TestCase(new [] { 9, 13, 25, 1.5 }, ExpectedResult="$100,00")]
    [TestCase(new [] { 11.5, 19, 40, 1.8 }, ExpectedResult="$364,00")]
    public static string Test10(double[] arr)
    {
	    return Program.OverTime(arr);
    }
	
    [Test]
    [TestCase(1, 2, ExpectedResult = "1/2")]
    [TestCase(15, 27, ExpectedResult = "5/9")]
    [TestCase(-3, 4, ExpectedResult = "-3/4")]
    [TestCase(-5, -3, ExpectedResult = "5/3")]
    [TestCase(10, 5, ExpectedResult = "2")]
    public static string Test11_Create(int num, int denom)
    {
	    Console.WriteLine($"Create: new Rational({num}, {denom})");
	    return new Program.Rational(num, denom).ToString();
    }

    [TestCase(1, 2, ExpectedResult = 1)]
    [TestCase(15, 27, ExpectedResult = 5)]
    [TestCase(-3, 4, ExpectedResult = -3)]
    [TestCase(-5, -3, ExpectedResult = 5)]
    [TestCase(10, 5, ExpectedResult = 2)]
    public static int Test11_Numerator(int num, int denom)
    {
	    Console.WriteLine($"Numerator test: new Rational({num}, {denom})");
	    return new Program.Rational(num, denom).Numerator;
    }

    [TestCase(1, 2, ExpectedResult = 2)]
    [TestCase(15, 27, ExpectedResult = 9)]
    [TestCase(-3, 4, ExpectedResult = 4)]
    [TestCase(-5, -3, ExpectedResult = 3)]
    [TestCase(10, 5, ExpectedResult = 1)]
    [TestCase(0, 5, ExpectedResult = 1)]
    public static int Test11_Denominator(int num, int denom)
    {
	    Console.WriteLine($"Numerator test: new Rational({num}, {denom})");
	    return new Program.Rational(num, denom).Denominator;
    }
    
    [Test]
    [TestCase("5/7", ExpectedResult="5/7")]
    [TestCase("4/6", ExpectedResult="2/3")]
    [TestCase("11/10", ExpectedResult="11/10")]
    [TestCase("8/4", ExpectedResult="2")]
    [TestCase("7/4", Description="should work for improper fractions", ExpectedResult="7/4")]
    [TestCase("6/4", ExpectedResult="3/2")]
    [TestCase("300/200", ExpectedResult="3/2")]
    [TestCase("50/25", ExpectedResult="2")]
    [TestCase("5/45", ExpectedResult="1/9")]
    public static string Test12(string str) 
    {
	    Console.WriteLine($"Input: {str}");
	    return Program.Simplify(str);
    }
    
    
    [Test]
    [TestCase(11211230, ExpectedResult=false)]
    [TestCase(13001120, ExpectedResult=true)]
    [TestCase(23336014, ExpectedResult=true)]
    [TestCase(11, ExpectedResult=true)]
    [TestCase(1122, ExpectedResult=false)]
    [TestCase(332233, ExpectedResult=true)]
    [TestCase(10210112, ExpectedResult=true)]
    [TestCase(9735, ExpectedResult=false)]
    [TestCase(97358817, ExpectedResult=false)]
    public static bool Test13(int num) 
    {
	    Console.WriteLine($"Input: {num}");
	    return Program.PalindromeDescendant(num);
    }

    [Test]
  public static void Test14_Word()
  {
    Console.WriteLine("have ➞ avehay");
  	Assert.AreEqual("avehay", Program.TranslateWord("have"));
    Console.WriteLine("cram ➞ amcray");
  	Assert.AreEqual("amcray", Program.TranslateWord("cram"));
    Console.WriteLine("take ➞ aketay");
  	Assert.AreEqual("aketay", Program.TranslateWord("take"));
    Console.WriteLine("Cat ➞ Atcay");
  	Assert.AreEqual("Atcay", Program.TranslateWord("Cat"));
    Console.WriteLine("Shrimp ➞ Impshray");
  	Assert.AreEqual("Impshray", Program.TranslateWord("Shrimp"));
    Console.WriteLine("trebuchet ➞ ebuchettray");
  	Assert.AreEqual("ebuchettray", Program.TranslateWord("trebuchet"));
    Console.WriteLine("ate ➞ ateyay");
  	Assert.AreEqual("ateyay", Program.TranslateWord("ate"));
    Console.WriteLine("Apple ➞ Appleyay");
  	Assert.AreEqual("Appleyay", Program.TranslateWord("Apple"));
    Console.WriteLine("oaken ➞ oakenyay");
  	Assert.AreEqual("oakenyay", Program.TranslateWord("oaken"));
    Console.WriteLine("eagle ➞ eagleyay");
  	Assert.AreEqual("eagleyay", Program.TranslateWord("eagle"));
    Console.WriteLine("ink ➞ inkyay");
  	Assert.AreEqual("inkyay", Program.TranslateWord("ink"));
    Console.WriteLine("unicorn ➞ unicornyay");
  	Assert.AreEqual("unicornyay", Program.TranslateWord("unicorn"));
    Console.WriteLine("\"\" ➞ \"\"");
  	Assert.AreEqual("", Program.TranslateWord(""));
  }
  [Test]
  public static void Test14_Sentence()
  {
    Console.WriteLine("I like to eat honey waffles ➞ Iyay ikelay otay eatyay oneyhay afflesway");
  	Assert.AreEqual("Iyay ikelay otay eatyay oneyhay afflesway", Program.TranslateSentence("I like to eat honey waffles"));
    Console.WriteLine("Do you think it is going to rain today? ➞ Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?");
  	Assert.AreEqual("Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?", Program.TranslateSentence("Do you think it is going to rain today?"));
    Console.WriteLine("He said, \"When will this all end?\" ➞ Ehay aidsay, \"Enwhay illway isthay allyay endyay?\"");
  	Assert.AreEqual("Ehay aidsay, \"Enwhay illway isthay allyay endyay?\"", Program.TranslateSentence("He said, \"When will this all end?\""));
		Console.WriteLine("\"\" ➞ \"\"");
  	Assert.AreEqual("", Program.TranslateSentence(""));
  }
  
  [Test]
  [TestCase(5, ExpectedResult="Balanced")]
  [TestCase(211, ExpectedResult="Balanced")]
  [TestCase(593, ExpectedResult="Balanced")]
  [TestCase(1693, ExpectedResult="Strong")]
  [TestCase(599, ExpectedResult="Strong")]
  [TestCase(2203, ExpectedResult="Strong")]
  [TestCase(19, ExpectedResult="Weak")]
  [TestCase(2971, ExpectedResult="Weak")]
  [TestCase(1493, ExpectedResult="Weak")]
	
  public static string Test15(int n)
  {
	  Console.WriteLine($"Input: {n}");
	  return Program.PrimalStrength(n);
  }
}


class Program
{
	// "Сложные" задания - 7 шт.
	
	
	
	// Create a function to check if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.
    //
    //     The criteria for a candidate to be qualified in the coding interview is:
    //
    // The candidate should have complete all the questions.
    //     The maximum time given to complete the interview is 120 minutes.
    //     The maximum time given for very easy questions is 5 minutes each.
    //     The maximum time given for easy questions is 10 minutes each.
    //     The maximum time given for medium questions is 15 minutes each.
    //     The maximum time given for hard questions is 20 minutes each.
    //     If all the above conditions are satisfied, return "qualified", else return "disqualified".
    //
    // You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.
    //
    //     Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].
    //
    // The maximum time to complete the interview includes a buffer time of 20 minutes.
    public static string Interview(int[] arr, int tot) {
        var q = new Queue<int>(new int[] {5, 5, 10, 10, 15, 15, 20, 20});
        return arr.Length == 8 && tot <= 120 && arr.All(x => x <= q.Dequeue()) ? "qualified" : "disqualified";
    }
    
    
    // You are given an input array of bigrams, and an array of words.
    //
    //     Write a function that returns true if every single bigram from this array can be found at least once in an the list of words.
    //     A bigram is string of two consecutive characters in the same word.
    //     If the array of words is empty, return false.
    
    public static bool CanFind(string[] bigrams, string[] words) {
        var bigramsl = bigrams.ToList();
        if (words.Length <= 0) return false;
        foreach (var bigram in bigrams)
        {
            foreach (var word in words)
            {
                if (!word.Contains(bigram)) continue;
                bigramsl.Remove(bigram);
                break;
            }
        }
        return bigramsl.Count == 0;
    }
    
    // Create a function which takes in a date as a string, and returns the date a week after.
    //     Note that dates will be given in day/month/year format.
    //     Single digit numbers should be zero padded.
    
    public static string WeekAfter(string date) => DateOnly.ParseExact(date, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture).AddDays(7).ToString("dd'/'MM'/'yyyy");

    
    // Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.
    //
	   //  Given the values a, b and c, you need to return the coordinates of the vertex. Return your answers rounded to 2 decimal places.
	   //  See Resources if you're not sure how to find the x or y coordinates of the vertex.
	   //  a will always be non-zero.    
	   
	public static double[] FindVertex(int a, int b, int c) {
		var x = (double)(-b)/(2*a);
		return new [] {x, a*x*x + b*x + c};
	}
	
	
	// Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. Luckily, I've been able to find the vowels that were removed.
	//
	// 	Given a censored string and a string of the censored vowels, return the original uncensored string.
	// The vowels are given in the correct order.
	// 	The number of vowels will match the number of * characters in the censored string.
	
	public static string Uncensor(string txt, string vowels)
	{
		int counter = -1;
		return new Regex(@"\*").Replace(txt, delegate { counter++; return vowels[counter].ToString(); });
	}
	
	
	// Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
	//
	// 	To illustrate:
	//
	// "123"
	// We reverse "123" to get "321" and then add "123" to the end, resulting in "321123".
	//
	// Examples
	// 	ReverseAndNot(123) ➞ "321123"
	//
	// ReverseAndNot(152) ➞ "251152"
	//
	// ReverseAndNot(123456789) ➞ "987654321123456789"
	// Notes
	// 	i is a non-negative integer.
	// 	Bonus: By using System.Linq this should be completed in one line of code.
	
	public static string ReverseAndNot(int i) => new string(i.ToString().Reverse().ToArray()) + i;
	
	
	// Carlos is a huge fan of something he calls smooth sentences.
	//
	// 	A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive, so "A" would be the same as "a").
	//
	// The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
	//
	// Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.
	//
	// 	Examples
	// 	IsSmooth("Marta appreciated deep perpendicular right trapezoids") ➞ true
	//
	// IsSmooth("Someone is outside the doorway") ➞ false
	//
	// IsSmooth("She eats super righteously") ➞ true
	// Notes
	// 	The last and first letters are case insensitive.
	// 	There will be no punctuation in each sentence.
	
	public static bool IsSmooth(string sentence) => Regex.Matches(sentence, @"([a-z]) \1", RegexOptions.IgnoreCase).Count == sentence.Split(' ').Length - 1;
	
	
	
	
	
	
	// "Очень сложные" задания - 5шт.
	
	// A Fibonacci Word is a specific sequence of binary digits (or symbols from any two-letter alphabet). The Fibonacci Word is formed by repeated concatenation in the same way that the Fibonacci numbers are formed by repeated addition.
	//
	// 	Create a function that takes a number n as an argument and returns the first n elements of the Fibonacci Word sequence.
	//
	// 	If n < 2, the function must return "invalid".
	//
	// Examples
	// 	FiboWord(1) ➞ "invalid"
	//
	// FiboWord(3) ➞ "b, a, ab"
	//
	// FiboWord(7) ➞ "b, a, ab, aba, abaab, abaababa, abaababaabaab"
	// Notes
	// 	You can try solving this using a recursive approach. No bonus points just extra satisfaction!!
	
	public static string FiboWord(int n) {
		if (n < 2) return "invalid";
		var lst = new List<string> { "b", "a" };
		for (int i = n; i > 2; i--) {lst.Add(lst.Last() + lst[lst.Count-2]);}
		return string.Join(", ", lst);
	}
	
	
	// A robot moves around a 2D grid. At the start, it is at [0, 0], facing east. It is controlled by a sequence of instructions:
	//
	// . means take one step forwards in the current direction.
	// < means turn 90 degrees anticlockwise.
	// > means turn 90 degrees clockwise.
	// 	Your job is to process the instructions and return the final position of the robot.
	//
	// 	Example
	// For example, if the robot is given the sequence of instructions ..<.<., then:
	//
	// Step 1: . It still faces east, and is at [1, 0].
	// Step 2: . It still faces east, and is at [2, 0].
	// Step 3: < It now faces north, and is still at [2, 0].
	// Step 4: . It still faces north, and is at [2, 1].
	// Step 5: < It now faces west, and is still at [2, 1].
	// Step 6: . It still faces west, and is now at [1, 1].
	// So, TrackRobot("..<.<.") returns [1, 1].
	//
	// Notes
	// 	The instruction strings will only contain the three valid characters ., < or >.
	// You will always be passed a string (but the string might be empty).
	
	public static int[] TrackRobot(string steps) {
		int d = 0, x = 0, y = 0;
		foreach (char c in steps)
		{
			switch (c)
			{
				case '>':
					d++;
					break;
				case '<':
					d--;
					break;
				default:
					switch (Math.Abs(d) % 4)
					{
						case 0:
							x++;
							break;
						case 1:
							y++;
							break;
						case 2:
							x--;
							break;
						case 3:
							y--;
							break;
					}
					break;
			}
		}
		return new [] {x, y};
	}
	
	
	// Write a function that calculates overtime and pay associated with overtime.
	//
	// 	Working 9 to 5: regular hours
	// After 5pm is overtime
	// 	Your function gets an array with 4 values:
	//
	// Start of working day, in decimal format, (24-hour day notation)
	// End of working day. (Same format)
	// 	Hourly rate
	// 	Overtime multiplier
	// 	Your function should spit out:
	//
	// $ + earned that day (rounded to the nearest hundreth)
	// Examples
	// 	OverTime([9, 17, 30, 1.5]) ➞ "$240.00"
	//
	// OverTime([16, 18, 30, 1.8]) ➞ "$84.00"
	//
	// OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"
	// 	2nd example explained:
	//
	// From 16 to 17 is regular, so 1 * 30 = 30
	// From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
	// 30 + 54 = $84.00
	
	
	public static string OverTime(double[] arr) => 
		$"${(17 > arr[0] ? (Math.Min(arr[1], 17) - arr[0]) * arr[2] : 0) + (17 < arr[1] ? (arr[1] - Math.Max(arr[0], 17)) * arr[2] * arr[3] : 0):0.00}";
	
	
	// C# has several numeric types, including natural, real, and irrational numbers. One numeric type that's missing is a Rational number. A rational number, as the name suggests is a ratio between 2 natural numbers and is usually represented as a fraction in the form 1/2, 5/4, -79/13, etc.
	//
	// 	Create a C# struct with a constructor that takes two integer parameters, either or both of which may be positive or negative. Include two read-only properties, Numerator and Denominator, that return the numerator and denominator of the fraction respectively of type int. Also, override the ToString() method to give a string representation of the rational number as described in the preceding paragraph.
	//
	// 	Examples
	// 	var r1 = new Rational(1, 2);
	// r1.Numerator ➞ 1
	// r1.Denominator ➞ 2
	// r1.ToString() ➞ "1/2"
	//
	// var r2 = new Rational(10, 8);
	// r2.Numerator ➞ 5
	// r2.Denominator ➞ 4
	// r2.ToString() ➞ "5/4"
	//
	// var r3 = new Rational(2, -1);
	// r3.Numerator ➞ -2
	// r3.Denominator ➞ 1
	// r3.ToString() ➞ "-2"
	//
	// var r4 = new Rational(-16, -64);
	// r4.Numerator ➞ 1
	// r4.Denominator ➞ 4
	// r4.ToString() ➞ "1/4"
	// Notes
	// 	The numerator may be zero, but if the denominator is zero an ArgumentException should be raised by the constructor function.
	// 	The Numerator and Denominator values should be reduced to their lowest possible integer values to maintain the ratio (examples r2 and r4 above).
	// If the resulting fraction is a whole number, the Denominator should return 1 but the ToString() method should only show the integer value (example r3 above).
	// If one of the values of numerator and denominator is negative, the sign is shown on the Numerator and the Denominator is positive (example r3 above).
	// If both the numerator and denominator are negative, the fraction is positive and both Numerator and Denominator are positive (example r4 above).
	// If the numerator is zero, the denominator should be set to 1, regardless of the value passed to the constructor.
	
	public struct Rational
	{
		public readonly int Numerator;
		public readonly int Denominator;

		public Rational(int numerator, int denominator)
		{
			if (denominator == 0)
			{
				throw new ArgumentException("Знаменатель не может равняться нулю");
			}
			if (numerator == 0)
			{
				Numerator = 0;
				Denominator = 1;
			}
			else
			{
				var gcd = Math.Abs(GCD(numerator, denominator));
				Numerator = Math.Sign(numerator * denominator) * Math.Abs(numerator) / gcd;
				Denominator = Math.Abs(denominator) / gcd;
			}
		}

		public override string ToString()
		{
			return Denominator > 1 ? $"{Numerator}/{Denominator}" : Numerator.ToString();
		}
	}
	
	
	// Create a function that returns the simplified version of a fraction.
	//
	// 	Examples
	// 	Simplify("4/6") ➞ "2/3"
	//
	// Simplify("10/11") ➞ "10/11"
	//
	// Simplify("100/400") ➞ "1/4"
	//
	// Simplify("8/4") ➞ "2"
	// Notes
	// 	A fraction is simplified if there are no common factors (except 1) between the numerator and the denominator. For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.
	// 	If improper fractions can be transformed into integers, do so in your code (see example #4).
		
		
	public static string Simplify(string str) 
	{
		string[] numbers = str.Split('/');
		int a = int.Parse(numbers[0]);
		int b = int.Parse(numbers[1]); 
		int min = a < b ? a : b;
		for (int i = min; i > 1; i--)
		{
			if (a % i == 0 && b % i == 0)
			{
				a /= i;
				b /= i;
				break;
			}
		}
		return b == 1 ? a.ToString() : $"{a}/{b}";
	}
	private static int GCD(int a, int b)
	{
		while (true)
		{
			if (b == 0) return a;
			var i = a;
			a = b;
			b = i % b;
		}
	}
	
	
// 	A number may not be a palindrome, but its descendant can be. A number's direct child is created by summing each pair of adjacent digits to create the digits of the next number.
//
// 		For instance, 123312 is not a palindrome, but its next child 363 is, where: 3 = 1 + 2; 6 = 3 + 3; 3 = 1 + 2.
//
// 	Create a function that returns true if the number itself is a palindrome or any of its descendants down to the first 2 digit number (a 1-digit number is trivially a palindrome).
//
// 	Examples
// 		PalindromeDescendant(11211230) ➞ false
// // 11211230 ➞ 2333 ➞ 56
//
// 	palindromeDescendant(13001120) ➞ true
// // 13001120 ➞ 4022 ➞ 44
//
// 	PalindromeDescendant(23336014) ➞ true
// // 23336014 ➞ 5665
//
// 	PalindromeDescendant(11) ➞ true
// // Number itself is a palindrome.
// 	Notes
// 		Numbers will always have an even number of digits.


	public static bool PalindromeDescendant(int num) 
	{
		var str = num.ToString();
		while (true)
		{
			if (str.SequenceEqual(str.Reverse()) && str.Length > 1) return true;
			if (str.Length <= 2) return false;
			var subres = string.Empty;
			for (var i = 0; i < str.Length - 1; i += 2) subres += char.GetNumericValue(str[i]) + char.GetNumericValue(str[i + 1]);
			str = subres;
		}
	}


	// Pig latin has two very simple rules:
    //
    // If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
	   //  have ➞ avehay
	   //  cram ➞ amcray
	   //  take ➞ aketay
	   //  cat ➞ atcay
	   //  shrimp ➞ impshray
	   //  trebuchet ➞ ebuchettray
	   //  If a word starts with a vowel add "yay" to the end of the word.
	   //  ate ➞ ateyay
	   //  apple ➞ appleyay
	   //  oaken ➞ oakenyay
	   //  eagle ➞ eagleyay
	   //  Write two functions to make an English to pig latin translator. The first function TranslateWord(word) takes a single word and returns that word translated into pig latin. The second function TranslateSentence(sentence) takes an English sentence and returns that sentence translated into pig latin.
    //
	   //  Examples
    // TranslateWord("flag") ➞ "agflay"
    //
    // TranslateWord("Apple") ➞ "Appleyay"
    //
    // TranslateWord("button") ➞ "uttonbay"
    //
    // TranslateWord("") ➞ ""
    //
    // TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."
    //
    // TranslateSentence("Do you think it is going to rain today?") ➞ "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"
    // Notes
	   //  Regular expressions will help you not mess up the punctuation in the sentence.
	   //  If the original word or sentence starts with a capital letter, the translation should preserve its case (see examples #2, #5 and #6).
	   
	   public static string TranslateWord(string word) 
	   {
		   var fvi = word.IndexOfAny("aeiouAEIOU".ToCharArray());
		   if (fvi == 0) return word + "yay";
		   return fvi == -1 ?  word: (char.IsUpper(word[0]) ? char.ToUpper(word[fvi]) : char.ToLower(word[fvi])) + word.Substring(fvi + 1) + word.Substring(0, fvi).ToLower() + "ay";
	   }

	   public static string TranslateSentence(string sentence)
	   {
		   return Regex.Replace(sentence, "[a-z]+", m => TranslateWord(m.Value), RegexOptions.IgnoreCase);
	   }
	   
	   
	   // In number theory, a prime number is balanced if it is equidistant from the prime before it and the prime after it. It is therefore the arithmetic mean of those primes. For example, 5 is a balanced prime, two units away from 3, and two from 7. 211 is 12 units away from the previous prime, 199, and 12 away from the next, 223.
	   //
	   // A prime that is greater than the arithmetic mean of the primes before and after it is called a strong prime. It is closer to the prime after it than the one before it. For example, the strong prime 17 is closer to 19 than it is to 13 (see note at bottom).
	   //
	   // A prime that is lesser than the arithmetic mean of the primes before and after it is called weak prime. For example, 19.
	   //
	   // Create a function that takes a prime number as input and returns "Strong" if it is a strong prime, "Weak" if it is a weak prime, or "Balanced".
	   //
	   // Examples
	   // 	PrimalStrength(211) ➞ "Balanced"
	   //
	   // PrimalStrength(17) ➞ "Strong"
	   //
	   // PrimalStrength(19) ➞ "Weak"
	   // Notes
	   // 	This definition of strong primes is not to be confused with strong primes as defined in cryptography, which are much more complicated than this. You are all welcome to make a challenge based on cryptographically strong primes.
	
	   public static string PrimalStrength(int n)
	   {
		   int prev = n, next = n;
		   while(!IsPrime(--prev));
		   while(!IsPrime(++next));
		   return n - prev == next - n ? "Balanced" : n - prev > next - n ? "Strong" : "Weak";
	   }
	
	   static bool IsPrime(int n)
	   {
		   for(var i = 2; i * i <= n; i++) if(n % i == 0) return false;
		   return n > 1;
	   }
}


