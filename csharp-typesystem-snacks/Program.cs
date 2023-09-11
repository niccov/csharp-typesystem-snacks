// See https://aka.ms/new-console-template for more information

//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Inserisci 2 numeri interi e ti dirò quale è il maggiore!");

int firstNumber = int.Parse(Console.ReadLine());

int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Il numero maggiore è {firstNumber}");
} else if (firstNumber < secondNumber)
{
    Console.WriteLine($"Il numero maggiore è {secondNumber}");
} else
{
    Console.WriteLine($"I numeri sono uguali");
}

Console.WriteLine();

//Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Inserisci 2 parole e ti dirò quale è la più lunga!");

string firstWord = (Console.ReadLine());

string secondWord = (Console.ReadLine());

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola più lunga è {firstWord}");
} else if(firstWord.Length < secondWord.Length)
{
    Console.WriteLine($"La parola più lunga è {secondWord}");
} else
{
    Console.WriteLine($"Le parole hanno la stessa lunghezza");
}

Console.WriteLine();

//Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

Console.WriteLine("Inserisci 10 numeri interi e ti dirò quale è la somma!");


int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inserisci il valore numero: {i + 1}");
    sum += int.Parse(Console.ReadLine());
}
Console.WriteLine($"la somma dei valori inseriti è {sum}");

Console.WriteLine();
//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

//*   
Console.WriteLine("Somma e media dei numeri da 2 a 10!");

int sum1 = 0;

int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numbers.Length; i++)
{
    sum1 += numbers[i];
}
int average = sum1 / numbers.Length;
Console.WriteLine($"la somma dei valori è {sum1}");
Console.WriteLine($"la media dei valori è {average}");

Console.WriteLine();

//Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.WriteLine("Inserisci 1 numero intero, in caso sia pari te lo stamperò se è dispari ti stamperò il numero successivo!");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Il numero {number} è pari");
} else
{
    Console.WriteLine(number + 1);
}

Console.WriteLine();

//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
Console.WriteLine("Inserisci il tuo nome e ti dirò se sei invitato alla festa!");

string[] partyInvited = { "Luca", "Mario", "Benedetta", "Silvia", "Giorgio", "Piera"};

string name = Console.ReadLine();
bool utenteTrovato = false;

for (int i = 0; i < partyInvited.Length; i++)
{
    if (name == partyInvited[i])
    {
        utenteTrovato = true;
        Console.WriteLine("Sei stato invitato");
        break;
    }
}

if (!utenteTrovato)
{
    Console.WriteLine($"{name} non è stato invitato");
}

Console.WriteLine();

//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

//*
Console.WriteLine("Inserisci 6 numeri, se è dispari lo inserirò nell'array!");

int[] oddNumbersArray = new int[6];
for (int i = 0; i < oddNumbersArray.Length; i++)
{
    Console.WriteLine($"Tentativi: {oddNumbersArray.Length - i}");

    Console.Write($"Digita un numero: ");
    int inputNumber = int.Parse(Console.ReadLine());
    if (inputNumber % 2 != 0)
    {
        oddNumbersArray[i] = inputNumber;
    }

}
Console.WriteLine("Fine! La lista è piena, eccola di seguito: ");
foreach (int rightnumber in oddNumbersArray)
{
    Console.WriteLine($"{rightnumber} ");
}

Console.WriteLine();
//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

//*

Console.WriteLine("Creo un array di interi e faccio la somma degli elementi in posizione dispari");

int[] intNumbers = { 5, 17, 32, 1, 55, 46, 15, 18, 78, 91, 4 };
int sumElements = 0;
int sumElements2 = 0;
foreach (int number8 in intNumbers)
{
    Console.Write($"{number8} ");

    if (number8 % 2 != 0)
    {
        sumElements += number8;
    }
}
for (int i = 1; i < intNumbers.Length; i += 2)
{
    sumElements2 += intNumbers[i];
}
Console.WriteLine();

Console.WriteLine($"é: {sumElements2}");

Console.WriteLine();

//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

Console.WriteLine("Inserisci dei numeri e io creerò un array");

int[] arrayNumbers = new int[12];
int sum9 = 0;
int index = 0;

do
{
    Console.WriteLine($"La somma degli elementi è {sum9}");
    Console.WriteLine("Inserisci un numero intero da aggiungere alla somma");
    int numberToAdd = int.Parse(Console.ReadLine());
    arrayNumbers[index] = numberToAdd;

    sum9 += numberToAdd;

    if (index < arrayNumbers.Length - 1)
    {
        index++;
    }
    else
    {
        index = 0;
    }
} while (sum9 <= 50);
Console.WriteLine($"Fine! La somma dei valori è {sum9}");

Console.WriteLine();

//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine("Inserisci un numero N e genererò N array formati da 10 numeri casuali tra 1 e 100");

uint N = uint.Parse(Console.ReadLine());
Random rnd = new Random();
for (int i = 0; i < N; i++)
{
    int[] numbers10 = new int[10];
    for (int c = 0; c < numbers10.Length; c++)
    {
        numbers10[c] = rnd.Next(1, 100);
    }
    Console.Write($"Lista n.{i + 1}: ");
    foreach (int numberC in numbers10)
    {
        Console.Write($"{numberC} ");
    }
    Console.WriteLine();
}