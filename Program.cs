Console.WriteLine("Zadejte delší slovo");
string slovoDlouhe = Console.ReadLine();
Console.WriteLine("Zadejte kratší slovo");
string slovoKratke = Console.ReadLine();

int dlouhe = slovoDlouhe.Length;
int kratke = slovoKratke.Length;
int rozdil = dlouhe - kratke;
Console.WriteLine("Slova se liší délkou o " + rozdil + " znaků.");
Console.ReadLine();