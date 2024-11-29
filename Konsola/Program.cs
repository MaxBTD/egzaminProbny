namespace ConsoleApp1
{
    internal class Program
    {
        const int maxLiczba = 999;
        class LiczbyParzystocyfrowe
        {
            
            static bool[] wypelnijBoolTab() {
                
                bool[] czyParzystocyfrowa = new bool[maxLiczba + 1];
                for (int i = 0; i < maxLiczba+1; i++)
                {
                    int wynik = 0;
                    char[] cyfryLiczby = i.ToString().ToCharArray();
                    foreach(char c in cyfryLiczby)
                    {
                        wynik += int.Parse(c.ToString());
                    }
                    if (wynik % 2 == 0)
                        czyParzystocyfrowa[i] = true;
                    else
                        czyParzystocyfrowa[i] = false;
                }

                return czyParzystocyfrowa;
            }

            /**********************************************************************
             * nazwa funkcji:       sprawdzLiczbe()
             * parametry wejściowe: int index - podana sprawdzana liczba
             * wartość zwracana     pole tablicy wartości logicznych "czyParzystocyfrowa"
             *                      o indexie rownego podanej liczbie
             * Konrad Piniaź:       19412539123
            **********************************************************************/
            public bool sprawdzLiczbe(int index)
            {
                return czyParzystocyfrowa[index];
            }

            public bool[] czyParzystocyfrowa = wypelnijBoolTab();


        }
        static void Main(string[] args)
        {
            LiczbyParzystocyfrowe Liczby = new LiczbyParzystocyfrowe();

            Console.WriteLine(Liczby.sprawdzLiczbe(218));
            Console.WriteLine(Liczby.sprawdzLiczbe(653));
            Console.WriteLine(Liczby.sprawdzLiczbe(917));
            Console.WriteLine(Liczby.sprawdzLiczbe(395));
        }
    }
}
