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
        static void Main(string[] args)
        {
            // Esercizio 1
            Console.WriteLine(Prettifier("Esercizio 1 : classi astratte"));
            Cane cane = new();
            Passerotto passerotto = new();
            Aquila aquila = new();
            Delfino delfino = new();
            cane.Mangia();
            cane.Verso();
            cane.Dormi();
            passerotto.Mangia();
            passerotto.Verso();
            passerotto.Dormi();
            aquila.Mangia();
            aquila.Verso();
            aquila.Dormi();
            delfino.Mangia();
            delfino.Verso();
            delfino.Dormi();
        }

        static string Prettifier(string input)
            => $"{String.Concat(Enumerable.Repeat("-", input.Length + 2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length + 2))}";
    }
}
