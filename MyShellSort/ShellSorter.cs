public class ShellSorter 
{ 
    public delegate bool IsGreater<T>(T a, T b); 
 
    public static void Sort<T>(T[] array, IsGreater<T> isArg1Greater) 
    { 
        int h = array.Length/3; 
        while(h > 0) 
        { 
            for(int i = h; i < array.Length; i++) 
            { 
                int j; 
                T dataObject = array[i]; 
                for(j = i; j >= h && isArg1Greater(array[j-h], dataObject); j-=h) 
                { 
                    array[j] = array[j-h]; 
                } 
                array[j] = dataObject; 
            } 
            h/=2; 
        } 
    } 
}  