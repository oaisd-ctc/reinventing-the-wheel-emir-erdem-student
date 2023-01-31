using Xunit;
using StringUtilities;
using MathUtilities;
using ArrayUtilities;
public class Tests
{
    [Fact]

    public void Some_Very_Specific_Test_Use_Case_Here()
    {
        string testString = "Gavin";

        //LengthTest
        // int lengthStringOutcome = 5;
        // Assert.Equal(lengthStringOutcome, StringUtils.Length(testString));

        //ReverseTest
        // string reverseOutcome = "nivaG";
        // Assert.Equal(reverseOutcome, StringUtils.Reverse(testString));

        //CountVowels
        // int VowelAmount = 2;
        // Assert.Equal(VowelAmount, StringUtils.CountVowels(testString));

        //CountConsonants
        // int ConsonantAmount = 3;
        // Assert.Equal(ConsonantAmount, StringUtils.CountConsonants(testString));

        //HasLetter
        // bool HasLette = true;
        // char LetterHas = 'a';
        // Assert.Equal(HasLette, StringUtils.HasLetter(testString, LetterHas));

        //spaceOut
        // string spaceOutNice = "G a v i n ";
        // Assert.Equal(spaceOutNice, StringUtils.spaceOut(testString));

        //printDown
        // char letterEnding = 'i';
        // bool theEnder = true;
        // Assert.Equal(theEnder, StringUtils.EndsWith(testString, letterEnding));

        //Compare
        // string comparison = "Gavin";
        // bool comp = true;
        // Assert.Equal(comp, StringUtils.Compare(testString, comparison));

        //RemoveTest
        // string removeOutcome = "Gvin";
        // char removeThing = 'a';
        // Assert.Equal(removeOutcome, StringUtils.Remove(testString, removeThing));



        int x = 4;
        int y = 2;
        double x1 = 4.0;
        double x2 = 2.0;
        //min
        // int mincome = 2;
        // Assert.Equal(mincome, MathUtils.Min(x,y));

        //max
        // int maxcome = 4;
        // Assert.Equal(maxcome, MathUtils.Max(x,y));

        //add
        // int outcomeadd = 6;
        // Assert.Equal(outcomeadd, MathUtils.Add(x,y));

        //subtract
        // int outcomesub = 2;
        // Assert.Equal(outcomesub, MathUtils.Subtract(x,y));

        //Multiply
        // int outcomemul = 8;
        // Assert.Equal(outcomemul, MathUtils.Multiply(x,y));

        //Divide
        // int outcomediv = 2;
        // Assert.Equal(outcomediv, MathUtils.Divide(x,y));

        //AbsValue
        // int outcomeabs = 4;
        // Assert.Equal(outcomeabs, MathUtils.AbsValue(x));

        //Power
        // int outcomep = 16;
        // Assert.Equal(outcomep, MathUtils.Power(x,y));

        //Round
        // int outcomernd = 5;
        // Assert.Equal(outcomernd, MathUtils.Round(x1));

        //sqrt
        // double outcomesq = 2.0;
        // Assert.Equal(outcomesq, MathUtils.Sqrt(x1));

        //Floor
        // double outcomef = 2.0;
        // Assert.Equal(outcomef, MathUtils.Floor(x1));

        //ceiling
        // double outcomec = 2.0;
        // Assert.Equal(outcomec, MathUtils.Ceiling(x1));

        //square
        // int sqoutcome = 4;
        // Assert.Equal(sqoutcome, MathUtils.Square(x));

        //cube
        // int cboutcome = 8;
        // Assert.Equal(cboutcome, MathUtils.Cube(x));

        int[] testArray = {2, 4, 6, 8, 10};
        int[] blankArray = new int[testArray.Length];

        // Average
        double av = 6.0;
        Assert.Equal(av, ArrayUtils.Average(testArray));

        // Max
        int maxo = 10;
        Assert.Equal(maxo, ArrayUtils.Max(testArray));

        // Min
        int mino = 2;
        Assert.Equal(mino, ArrayUtils.Min(testArray));

        // sum
        int sumo = 30;
        Assert.Equal(sumo, ArrayUtils.Sum(testArray));

        // product
        int producto = 3840;
        Assert.Equal(producto, ArrayUtils.Product(testArray));

        // SortAscend
        int[] ascendo = {2, 4, 6, 8, 10};
        Assert.Equal(ascendo, ArrayUtils.SortAscend(testArray));

        // SortDescend
        int[] descendo = {10, 8, 6, 4, 2};
        Assert.Equal(descendo, ArrayUtils.SortDescend(testArray));

        // GetArrayLength
        int length = 5;
        Assert.Equal(length, ArrayUtils.GetArrayLength(testArray));

        // Copy
        int[] copyo = {2, 4, 6, 8, 10};
        Assert.Equal(copyo, ArrayUtils.Copy(testArray, copyo));

        // Reverse
        int[] reverseo = {10, 8, 6, 4, 2};
        Assert.Equal(reverseo, ArrayUtils.Reverse(testArray));

    }
}