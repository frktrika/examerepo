using System;

namespace Eksamensprojekt
{
    /// <summary>
    /// Class hvor jeg opretter classen QuizQuestion, med strings jeg trækker gennemgående i programmet.
    /// </summary>
    class QuizQuestion
    {
        public string questionText;
        public string correctAnswer;
        public string questionOption1;
        public string questionOption2;

        public Boolean DoQuestion()
        {
            bool cont = true;

            while (cont) 
            {
                Console.WriteLine(questionText);
                Console.WriteLine(questionOption1);
                Console.WriteLine(questionOption2);
                Console.WriteLine("Skriv nu 'a' eller 'b', alt efter hvad du vil svare.");

                
                string inputFromUser = Console.ReadLine();

                if (inputFromUser == "a")
                {
                    cont = true;
                    if (inputFromUser == correctAnswer) //Her tjekker vi om input fra bruger svarer til det rigtige svar.

                    {
                        Console.WriteLine("\nDu har svaret a, og det er korrekt!");
                        return (true);     //Her laver vi return med en true eller false alt efter om user input svarer til korrekt svar, så der kommer en returnering til det boolske udtryk DoQuestion
                    }
                    else
                    {
                        Console.WriteLine("\nDu har svaret a, og det er ikke korrekt.");
                        return false;
                    }
                }
                else if (inputFromUser == "b") //Der er lavet ifelse på om både a eller b er det rigtige svar, derfor if/else, 4 svar muligheder i alt
                {
                    cont = false;
                    if (inputFromUser == correctAnswer)
                    {
                        Console.WriteLine("\nDu har svaret b, og det er korrekt");
                        return (true);
                    }
                    else
                    {
                        Console.WriteLine("\nDu har svaret b, og det er ikke korrekt.");
                        return (false);
                    }
                }
                Console.WriteLine("Du skal skrive enten 'a' eller 'b'."); //Her looper den videre hvis man skriver noget andet end a eller b - 

            }
            return false;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            VelkommenIntro(); 
            
            Console.ReadLine();
            Console.Clear();

            QuizQuestion[] question = new QuizQuestion[2]; //- Array oprettet med spørgsmålene hvor de har fået deklareret hver deres nummer

            question[0] = new QuizQuestion();
            question[0].questionText = "Hvor stor mon en Asteroide er?";
            question[0].correctAnswer = "a";
            question[0].questionOption1 = "a: Den er virkelig virkelig stor";
            question[0].questionOption2 = "b: Den er ikke så stor.";

            question[1] = new QuizQuestion();
            question[1].questionText = "Hvor hurtigt flyver en Asteroide afsted med km/t?";
            question[1].correctAnswer = "b";
            question[1].questionOption1 = "a: Ofte omkring 200.000 km/t.";
            question[1].questionOption2 = "b: Mindst 300.000 km/t!";

           

            int numberOfCorrectAnswers = 0; //DoQuestion trækkes via den boolske class, som lægger sammen om der er true/false på et spørgsmål for at oplyse brugeren når man er færdig, hvor mange rigtige man har.
            
            for (int i = 0; i < question.Length; i++)
            {
                if (question[i].DoQuestion())
                {
                    numberOfCorrectAnswers++;
                }
            }

            Console.WriteLine();
            Console.Clear();
            NaasteSporgsmaal();

            AfslutningsTale();



           ///<summary>
           ///Funktion til afslutning og hvor mange antal numre man har rigtige ned til 0.
           /// </summary>
            void AfslutningsTale()
             
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("Du har nu svaret på alle spørgsmålene, du fik " + numberOfCorrectAnswers + " rigtige.");
                Console.ReadLine();
            }
            
            ///<summary>
            ///Funktion hvor jeg angiver næste spg
            /// </summary>
            void NaasteSporgsmaal()
            {
                Console.WriteLine("\nDu vil nu se næste spørgsmål på skærmen... Tryk på en tast for at fortsætte.");
                Console.ReadKey();
                Console.Clear();
            }
                
            ///<summary>
            ///Funktion som består af velkomst når programmet start
            /// </summary>
            void VelkommenIntro()

            {
                Console.WriteLine("==================================================================================");
                Console.WriteLine("                             VELKOMMEN TIL SPILLET...                             ");
                Console.WriteLine();
                Console.WriteLine("Du skal nu svare på nogle virkelig mærkelige spørgsmål... Good luck!              ");
                Console.WriteLine("                                                                                  ");
                Console.WriteLine("                        Tryk på en tast for at fortsætte                          ");
                Console.WriteLine("==================================================================================");
            }
            
        }
    }
}
