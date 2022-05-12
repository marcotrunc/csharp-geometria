/*
 * Consegna: Nel progetto csharp-geometria creare le seguenti classi
Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. 
Aggiungere un opportuno costruttore con parametri. Aggiungere due metodi: calcolaArea e calcolaPerimetro 
che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di 
base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, stampate a video il perimetro e l’area.
Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e 
provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad 
esempio cosi:
—— Rettangolo1 —— base: 20 cm altezza: 10 cm Perimetro: 60 cm Area: 200 cm2
BONUS Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
 */
using csharp_geometria;
namespace SecondoGiorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dBase, dAltezza;
            LeggiNumeri.ReadNum("Inserisci base di un rettangolo : ", out dBase);
            LeggiNumeri.ReadNum("Inserisci altezza del rettangolo: ", out dAltezza);

   

            Rettangolo Rett1 = new Rettangolo(dBase, dAltezza);
            Console.WriteLine("L'Area del seguente rettangolo misura: {0}", Rett1.Area());
            Console.WriteLine("Il perimetro del seguente rettangolo misura: {0}", Rett1.Perimetro());

            Rett1.StampaRettangolo();


            Rettangolo Rett2 = new Rettangolo(10, 20);
            Rettangolo Rett3 = new Rettangolo(30, 40);
            Rettangolo Rett4 = new Rettangolo(50, 60);

            Rett2.StampaRettangolo();
            Rett3.StampaRettangolo();
            Rett4.StampaRettangolo();

            //Rett1.Disegna();
        }
    }
}
