using System;
using System.Runtime.CompilerServices;

namespace AlgorithmiqueEnCsharp
{
    internal class Program
    {
        static void Main()
        {
            bool re = true;

            while (re == true)
            {
                Console.WriteLine("Selectionnez une option:");
                Console.WriteLine("Algo01 - catégoriser l'age de l'utilisateur: tappez '1'");
                Console.WriteLine("Algo02 - calculer somme et moyenne d'une suite de nombres saisis : tappez '2'");
                Console.WriteLine("Algo03 - catégoriser l'age de l'utilisateur, loopable: tappez '3'");
                Console.WriteLine("Algo04 - affiche les 10 premières tables de multiplication : tappez '4'");
                Console.WriteLine("Algo05 - obtenir la factorielle d'un nombre: tappez '5'");
                Console.WriteLine("Algo06 - afficher les n premier nombres impairs: tappez '6'");
                Console.WriteLine("Algo07 - calculer l'hypothenuse d'un triangle: tappez '7'");
                Console.WriteLine("\n" + " Quitter: tappez '0'");

                sbyte option;
                string optionS;
                bool verifSbyte;

                optionS = Console.ReadLine();


                verifSbyte = sbyte.TryParse(optionS, out option);

                while (verifSbyte == false || option < 0 || option > 7)
                {
                    Console.WriteLine("Cette valeur n'est pas valide. re-saisissez un nombre");
                    optionS = Console.ReadLine();
                    verifSbyte = sbyte.TryParse(optionS, out option);
                }

                switch (option)
                {
                    case 0: re = false; break;
                    case 1: Algo01_AgeUtilisateur(); break;
                    case 2: Algo02_SomMoyInt(); break;
                    case 3: Algo03_AgeUtilisateurRe(); break;
                    case 4: Algo04_10TablesMultiplication(); break;
                    case 5: Algo05_factorielles(); break;
                    case 6: Algo06_NbrsImpairs(); break;
                    case 7: Algo07_CalculHypothénuse(); break;
                }
                if (re == false) break;


                string saisie = "s";

                Console.WriteLine("Voulez-vous quitter ('0') ou retourner au menu ('m') ?");

                while (saisie != "0" && saisie != "m")
                {
                    saisie = Console.ReadLine();
                    if (saisie == "0") { re = false; }
                    else if (saisie == "m") { re = true; }
                    else Console.WriteLine("Saisie incorrecte. Voulez-vous quitter ('q') ou retourner au menu ('m') ?");
                }
                Console.Clear();
            }
        }


        /// <summary>
        /// Algo01 Age Utilisateur
        /// </summary>
        static void Algo01_AgeUtilisateur()
        {
            sbyte age;
            string ageS;
            bool verifInt = false;

            Console.WriteLine("Entrez votre age");
            ageS = Console.ReadLine();

            verifInt = sbyte.TryParse(ageS, out age);

            while (verifInt == false || age < 1)
            {
                Console.WriteLine("Cette valeur n'est pas valide. re-entrez votre age");
                ageS = Console.ReadLine();
                verifInt = sbyte.TryParse(ageS, out age);
            }
            // age = Convert.ToSByte(ageS);

            if (age < 18) { Console.WriteLine("Ce programme est réservé aux personnes majeures"); }
            else if (age < 27) { Console.WriteLine("Vous avez le statut 'Jeune'"); }
            else if (age < 65) { Console.WriteLine("Vous avez le statut 'Adulte'"); }
            else { Console.WriteLine("Erreur! ce programme est réservé aux personnes non-retraitées."); }
        }


        /// <summary>
        /// Algo02_Somme et Moyenne d'Int
        /// </summary>
        static void Algo02_SomMoyInt()
        {
            string inputS;
            bool verifInt, finSaisie = false;
            int compteur = 0, input, min = 0, max = 0, somme = 0;
            float moy;


            while (finSaisie == false)
            {
                Console.WriteLine("Saisissez un nombre entier, 0 pour sortir.");
                inputS = Console.ReadLine();
                if (inputS == "0") { finSaisie = true;}
                else
                {
                    verifInt = int.TryParse(inputS, out input);

                    while (verifInt == false)
                    {
                        Console.WriteLine("Cette valeur n'est pas valide. re-saisissez votre nombre");
                        inputS = Console.ReadLine();
                        verifInt = int.TryParse(inputS, out input);
                    }

                    // input = Convert.ToInt32(inputS);

                    if (compteur == 0) {
                        min = input;
                        max = input;
                    }
                    else if (min > input && input != 0) { min = input; }
                    else if (max < input && input != 0) { max = input; }
                    somme = somme + input;
                    if (input != 0) { compteur = compteur + 1; }
                }
            }
            if (compteur > 0) { moy = (float)somme / compteur; }
            else { moy = 0; }

            Console.WriteLine
                ("statistique sur les nombres saisis: " + "\n" +
                compteur + " nombres saisis." + "\n" +
                "compris entre: " + min + " et " + max + "\n" +
                "pour une somme de: " + somme + "\n" +
                "et une moyenne de: " + moy + "\n" +
                "Au revoir!");
        }


        /// <summary>
        /// Algo03 Age UtilisateurRe
        /// </summary>
        static void Algo03_AgeUtilisateurRe()
        {
            sbyte age;
            string ageS;
            bool verifInt = false;
            bool re = true;

            while (re == true)
            {
                Console.WriteLine("Entrez votre age");
                ageS = Console.ReadLine();

                verifInt = sbyte.TryParse(ageS, out age);

                while (verifInt == false || age < 1)
                {
                    Console.WriteLine("Cette valeur n'est pas valide. re-entrez votre age");
                    ageS = Console.ReadLine();
                    verifInt = sbyte.TryParse(ageS, out age);
                }
                // age = Convert.ToSByte(ageS);

                switch (age)
                {
                    case < 18:
                        Console.WriteLine("Ce programme est réservé aux personnes majeures. " + "\n" + "Voulez-vous recommancer (o/n)?");
                        break;
                    case < 27:
                        Console.WriteLine("Vous avez le statut 'Jeune'." + "\n" + "Voulez-vous recommancer (o/n)?");
                        break;
                    case < 65:
                        Console.WriteLine("Vous avez le statut 'Adulte'." + "\n" + "Voulez-vous recommancer (o/n)?");
                        break;
                    default:
                        Console.WriteLine("Erreur! ce programme est réservé aux personnes non-retraitées." + "\n" + "Voulez-vous recommancer (o/n)?");
                        break;
                }
                while (ageS != "n" && ageS != "o")
                {
                    ageS = Console.ReadLine();
                    if (ageS == "n") { re = false; }
                    else if (ageS == "o") { re = true; }
                    else Console.WriteLine("Saisie incorrecte. Voulez-vous recommancer (o/n)?");
                }
            }
        }


        /// <summary>
        /// Algo04_10TablesMultiplication
        /// </summary>
        static void Algo04_10TablesMultiplication()
        {
            int i = 1, table = 1;
            string continuer;

            while (table < 11)
            {
                for (i = 1; i < 11; i++)
                {
                    Console.WriteLine(i + " * " + table + " = " + (i * table));
                }
                Console.WriteLine("...on respire... Frappez espace et validez...");
                continuer = Console.ReadLine();

                while (continuer != " ")
                {
                    Console.WriteLine("'Espace' puis 'entrer' pour continuer");
                    continuer = Console.ReadLine();
                }
                table++;
            }
        }


        /// <summary>
        /// Algo05_factorielles
        /// </summary>
        static void Algo05_factorielles()
        {
            int n, n2, f;
            string saisie;
            bool recommencer = true, verifInt;

            while (recommencer == true)
            {
                f = 1;
                Console.WriteLine("entrez un nombre entier positif pour obtenir sa factorielle.");
                saisie = Console.ReadLine();

                verifInt = int.TryParse(saisie, out n);

                while (verifInt == false || n < 0)
                {
                    Console.WriteLine("Cette valeur n'est pas valide. Entrez un nombre entier positif");
                    saisie = Console.ReadLine();
                    verifInt = int.TryParse(saisie, out n);
                }
                // n2 = n;
                for (n2 = n; n2 > 0; n2--) { f = (n2 * f); }

                Console.WriteLine("la factorielle de " + n + " est: " + f);
                Console.WriteLine("Voulez-vous recommencer (o/n) ?");

                while (saisie != "n" && saisie != "o")
                {
                    saisie = Console.ReadLine();
                    if (saisie == "n") { recommencer = false; }
                    else if (saisie == "o") { recommencer = true; }
                    else Console.WriteLine("Saisie incorrecte. Voulez-vous recommancer (o/n)?");
                }
            }
        }


        /// <summary>
        /// Algo06_NbrsImpairs
        /// </summary>
        static void Algo06_NbrsImpairs()
        {
            int i, r, n;
            string saisie;
            bool re = true, verifInt;

            while (re == true)
            {
                i = 1;

                Console.WriteLine("entrez le nombre de nombre impairs que vous voulez afficher.");
                saisie = Console.ReadLine();

                verifInt = int.TryParse(saisie, out n);

                while (verifInt == false || n < 0)
                {
                    Console.WriteLine("Cette valeur n'est pas valide. Entrez un nombre entier positif");
                    saisie = Console.ReadLine();
                    verifInt = int.TryParse(saisie, out n);
                }

                for (r = 1; r <= n; r++)
                {
                    Console.WriteLine(i + " est le " + r + "ième nombre impair.");
                    i += 2;
                }

                Console.WriteLine("Voulez-vous recommencer (o/n) ?");

                while (saisie != "n" && saisie != "o")
                {
                    saisie = Console.ReadLine();
                    if (saisie == "n") { re = false; }
                    else if (saisie == "o") { re = true; }
                    else Console.WriteLine("Saisie incorrecte. Voulez-vous recommancer (o/n)?");
                }
            }
        }


        /// <summary>
        /// Algo07_CalculHypothénuse
        /// </summary>
        static void Algo07_CalculHypothénuse()
        {
            float c1, c2, hypothenuse;
            string saisie;
            bool re = true, verifFloat;

            while (re == true)
            {
                Console.WriteLine("entrez la longueur du 1er côté.");
                saisie = Console.ReadLine();

                verifFloat = float.TryParse(saisie, out c1);

                while (verifFloat == false)
                {
                    Console.WriteLine("Cette valeur n'est pas valide. Entrez un nombre réel");
                    saisie = Console.ReadLine();
                    verifFloat = float.TryParse(saisie, out c1);
                }
                Console.WriteLine("entrez la longueur du 2ème côté.");
                saisie = Console.ReadLine();

                verifFloat = float.TryParse(saisie, out c2);

                while (verifFloat == false)
                {
                    Console.WriteLine("Cette valeur n'est pas valide. Entrez un nombre réel");
                    saisie = Console.ReadLine();
                    verifFloat = float.TryParse(saisie, out c2);
                }
                
                hypothenuse = (float)Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));

                Console.WriteLine("côté 1 = " + c1 + ", côté 2 = " + c2 + "\n" +
                                    "La longueur de l'hypothénuse est donc: " + hypothenuse);

                Console.WriteLine("Voulez-vous recommencer (o/n) ?");

                while (saisie != "n" && saisie != "o")
                {
                    saisie = Console.ReadLine();
                    if (saisie == "n") { re = false; }
                    else if (saisie == "o") { re = true; }
                    else Console.WriteLine("Saisie incorrecte. Voulez-vous recommancer (o/n)?");
                }
            }
        }


        /// <summary>
        /// ReverseString
        /// </summary>
        static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }

        /// <summary>
        /// Algo08_Pendu
        /// </summary>
        /*static void Algo08_Pendu()
        {
            int longueur, erreurRest = 10;
            string saisie, mot, motCache, lettresIncorrectes;

            Console.WriteLine("entrez le mot à trouver: ");
            mot = Console.ReadLine();
            Console.Clear

            longueur = mot.Length;
            Console.WriteLine("Longueur mot: " + longueur + " lettres.");
        }*/
    }
}
