
Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;

System.Console.WriteLine("Class Alan Hesabı   :{0}",dikdortgen.AlanHesapla());

Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
dikdortgen_Struct.KisaKenar = 4;
dikdortgen_Struct.UzunKenar = 5;
System.Console.WriteLine("Struct Alan Hesabı   :{0}",dikdortgen_Struct.AlanHesapla());


class  Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;
    public long AlanHesapla(){
        return KisaKenar*UzunKenar;
    }
}
struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;
    public long AlanHesapla(){
        return KisaKenar*UzunKenar;
    }
}