Console.WriteLine("1->Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

int i =0;
while (i<10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
int j = 1;
while (j <= 20)
{
    Console.Write(j + " ");
    j++;

}
Console.WriteLine("\n");

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

int k = 1;
while (k<=20)
{
    //sayı çift ise ekrana yazdırıyorum
    if (k % 2 == 0)
    {
        Console.Write(k + " ");
    }
    k++;
}
Console.WriteLine("\n");

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

//toplam değerini tutmak için değişken tanımlayıp başlangıç değerini 0 yapıyorum
int sum = 0;
int m = 50;
while ( m <= 150)
{
    //her bir i değerini topluyorum
    sum += m;
    m++;
}
Console.WriteLine(sum);

Console.WriteLine("---------------------------------------------------------------------------");

Console.WriteLine("5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

//tek sayıların toplamı için başlangıç değeri 0 olan bir değişken tanımlıyorum
int sumOdd = 0;
//çift sayıların toplamı için başlangıç değeri 0 olan bir değişken tanımlıyorum
int sumEven = 0;
int n = 1;
while (n <= 120)
{
    //sayı çift değilse i değerini sumOdd üzerine ekliyorum
    if (n % 2 != 0)
    {
        sumOdd += n;
    }
    else
    {
        //diğer durumda zaten sayı çift olur her bir i değerini sumEven üzerine ekliyorum
        sumEven +=n;
    }
    n++;
}
//Ekrana yazdırıyorum
Console.WriteLine("Tek Sayıların Toplamı: " + sumOdd);
Console.WriteLine("Çift Sayıların Toplamı: " + sumEven);

