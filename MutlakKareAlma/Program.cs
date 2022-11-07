//Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

//Örnek: Input: 56 45 68 77

//Output: 33 101
string str = Console.ReadLine();
int small = 0;
int big = 0;
string[] numbers = str.Split(' ');
for(int i=0; i<numbers.Length; i++)
{
    int value = Convert.ToInt32(numbers[i]);
    
    if (value>67)
    {
        big += (value-67)*(value-67);
    }
    else
    {
        small += (67 - value);
    }
}
Console.WriteLine(small + " " + big);
