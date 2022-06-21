using System;
class ReferenceType
    {
    public int valueVal;
}

class TestReference
{
    static void Main(String[] args)
    {
        ReferenceType refer = new ReferenceType();
        refer.valueVal = 5;
        Test(refer);
        Console.WriteLine("the value of the varible is {0}", refer.valueVal);
        Console.ReadLine();
    }
    static void Test(ReferenceType refer)
    {
        int temp = 5;
        refer.valueVal = temp *2;
    }
}