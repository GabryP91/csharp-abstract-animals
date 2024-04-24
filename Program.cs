/*
  
 
 **Esercizio 1 : classi astratte**
 Dobbiamo realizzare un programma che rappresenti il regno animale.
Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
Vogliamo che gli animali abbiano i seguenti metodi
- void Dormi() (mostra a video “Zzz”)
- void Verso() (mostra a video il verso fatto dall'animale specifico)
- void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.

**Esercizio 2 : interfacce**
Alcuni degli animali che abbiamo creato volano, altri nuotano.
Gli animali che volano hanno il seguente metodo :
- void Vola() (mostra a video “Sto volando!!!”)
Gli animali che nuotano hanno il seguente metodo :
- void Nuota() (mostra a video “Sto nuotando!!!”)
Scrivere un programma avente 2 metodi :
- void FaiVolare(IVolante animale)
- void FaiNuotare(INuotante animale)
Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.
 
*/

namespace csharp_abstract_animals
{
    internal class Program
    {
        //dichiaro funzione che preso in input interfaccia oggetto animale, richiama funzione corrispondente (vola)
        static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }

        static void Main(string[] args)
        {
            
            List<Animale> animali = new List<Animale>();

            animali.Add(new Cane());
            animali.Add(new Capra());
            animali.Add(new Orca());
            animali.Add(new Passerotto());

            foreach(Animale animale in animali)
            {
                /*
                 * //metodo per ritornare il nome classe
                 * Console.WriteLine(animale.GetType().Name);

                //altro metodo per ritornare il nome classe
                if (animale.GetType() == typeof(Cane))
                {
                    Console.WriteLine("Sono un cane e il mio verso è:");
                    animale.Verso();
                    
                }*/

                //acquisisco il nome di ogni classe animale
                string typeA = animale.GetType().Name;

                //stampo ogni 
                switch (typeA)
                {
                    case "Cane":

                        Console.WriteLine($"\nSono un {typeA} e il mio verso è:");
                        animale.Verso();
                        Console.WriteLine("mangio:");
                        animale.Mangia();

                        chekInterface(animale);

                        break;

                    case "Capra":

                        Console.WriteLine($"\nSono un {typeA} e il mio verso è:");
                        animale.Verso();
                        Console.WriteLine("e mangio:");
                        animale.Mangia();

                        chekInterface(animale);

                        break;

                    case "Orca":

                        Console.WriteLine($"\nSono un {typeA} e il mio verso è:");
                        animale.Verso();
                        Console.WriteLine("e mangio:");
                        animale.Mangia();

                        chekInterface(animale);

                        break;

                    case "Passerotto":

                        Console.WriteLine($"\nSono un {typeA} e il mio verso è:");
                        animale.Verso();
                        Console.WriteLine("e mangio:");
                        animale.Mangia();

                        chekInterface(animale);
                       
                        break;

                }

            }
            

        }


        static void chekInterface(Animale animale) 
        {

            // Se l'animale ha un'azione speciale, eseguila
            if (animale is IVolante volante)
            {
                FaiVolare(volante);
            }
            else if (animale is INuotante nuotante)
            {
                FaiNuotare(nuotante);
            }

        }

    }
}
