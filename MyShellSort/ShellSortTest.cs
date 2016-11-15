using Xunit;  
 
public class ShellSortTest  
{  
    static bool ShortComparer(short a, short b) => a > b; 
 
    [Fact]  
    public void TestFirstAndLastSort()  
    {  
        short[] data = {10,7,3,1,9,7,4,3};  
            ShellSorter.Sort<short>(data, ShortComparer);  
        Assert.Equal((short) 1, data[0]);  
        Assert.Equal((short) 10, data[7]);  
    }  
}