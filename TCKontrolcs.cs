using System;

public class Araclar
{
   
    public static bool TCKontrol(string tcNo)
    {
        if (tcNo.Length != 11) return false;

        int toplam = 0;
        for (int i = 0; i < 10; i++)
        {
            toplam += Convert.ToInt32(tcNo[i].ToString());
        }

        int sonHane = Convert.ToInt32(tcNo[10].ToString());

        return (toplam % 10 == sonHane);
    }
}