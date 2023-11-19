int[] array = { 11, 12, 31, 14, 15, 61, 71, 18, 14 };

int n = array.Length;
int find = 14;
int index = 0;

while (index < n) 
{
    if(array[index] == find) {
        Console.WriteLine(index);
        break;
    } 

    
    index = index + 1;
}