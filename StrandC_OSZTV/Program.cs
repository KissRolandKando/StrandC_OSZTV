


namespace StrandC_OSZTV
{
    internal class Program
    {
        static List<Furdo> furdok=new List<Furdo>();
        static void Main(string[] args)
        {
            Feladat_5();
            Feladat_7();
            Feladat_8();
            Feladat_9();
            Feladat_10();
        }

        private static void Feladat_10()
        {
            Console.WriteLine("Kérem adja a fürdő nevét:");
            string furdoNev=Console.ReadLine();

            Furdo keresett=furdok.FirstOrDefault(f=>f.Nev==furdoNev);
            if (keresett==null)
            {
                Console.WriteLine("Nincs ilyen nevű fürdő!");
            }
            else
            {
                Console.WriteLine($"A fürdő {keresett.Telepules()} településen van, irányítószáma: {keresett.IRSZ()}");
            }

        }

        private static void Feladat_9()
        {
            string leghidegebb = furdok.FirstOrDefault(f => f.VizHofok == furdok.Min(x => x.VizHofok)).Nev;
            var leg = furdok.MinBy(x => x.VizHofok);
            
            Console.WriteLine($"9. feladat:\nA leghidegebb víz a(a) {leghidegebb} nevü fürdőben van.");
            Console.WriteLine(leg.Nev);
        }

        private static void Feladat_8()
        {
            double atlag = Math.Round(furdok.Average(f => f.Ar),1);
            Console.WriteLine($"8. feladat\nA fürdőbelépők átlagos ára: {atlag}");
        }

        private static void Feladat_7()
        {
            Console.WriteLine($"7. feladat:\nFürdők száma: {furdok.Count}");
        }

        private static void Feladat_5()
        {
            string[] allomany=File.ReadAllLines("strandadatok.txt");
            foreach (var item in allomany.Skip(1))
            {
                furdok.Add(new Furdo(item));
            }
        }
    }
}
