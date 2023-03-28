using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenndreLaMonaie_Ricquier_Dimitri
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    Random rnd = new Random();
                    decimal montantàregler = Convert.ToDecimal(rnd.NextDouble() * (201 - 1) + 1);
                    montantàregler = decimal.Round(montantàregler, 2, MidpointRounding.ToEven);
                    Console.WriteLine($"Montant à régler : {montantàregler} euros");
                Recommencer:
                    Console.WriteLine("Saisir le montant que vous voulez réglé : ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal mrd))
                    {
                        if (mrd == 0)
                        {
                            return;
                        }
                        if (mrd > montantàregler)
                        {
                            {
                                decimal montantrendre = mrd - montantàregler;
                                Console.WriteLine($"Le montant à rendre est {montantrendre}");



                                int compteur20 = 0;
                                int compteur10 = 0;
                                int compteur5 = 0;
                                int compteur2 = 0;
                                int compteur1 = 0;
                                int compteur050 = 0;
                                int compteur020 = 0;
                                int compteur010 = 0;
                                int compteur005 = 0;
                                int compteur002 = 0;
                                int compteur001 = 0;
                                Console.WriteLine("Détails de votre monnaie");

                                while (montantrendre >= 20)
                                {
                                    montantrendre -= 20;
                                    compteur20 += 1;
                                }
                                if (montantrendre >= 10)
                                {
                                    montantrendre -= 10;
                                    compteur10 += 1;
                                }
                                if (montantrendre >= 5)
                                {
                                    montantrendre -= 5;
                                    compteur5 += 1;
                                }
                                while (montantrendre >= 2)
                                {
                                    montantrendre -= 2;
                                    compteur2 += 1;
                                }
                                if (montantrendre >= 1)
                                {
                                    montantrendre -= 1;
                                    compteur1 += 1;
                                }
                                if (montantrendre >= (decimal)0.5)
                                {
                                    montantrendre -= (decimal)0.5;
                                    compteur050 += 1;
                                }
                                while (montantrendre >= (decimal)0.2)
                                {
                                    montantrendre -= (decimal)0.2;
                                    compteur020 += 1;
                                }
                                if (montantrendre >= (decimal)0.1)
                                {
                                    montantrendre -= (decimal)0.1;
                                    compteur010 += 1;
                                }
                                if (montantrendre >= (decimal)0.05)
                                {
                                    montantrendre -= (decimal)0.05;
                                    compteur005 += 1;
                                }
                                while (montantrendre >= (decimal)0.02)
                                {
                                    montantrendre -= (decimal)0.02;
                                    compteur002 += 1;
                                }
                                if (montantrendre >= (decimal)0.01)
                                {
                                    montantrendre -= (decimal)0.01;
                                    compteur001 += 1;
                                }
                                if (compteur20 > 0)
                                {
                                    if (compteur20 == 1)
                                    {
                                        Console.WriteLine($"{compteur20} billet de 20 euros");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur20} billets de 20 euros");
                                    }
                                }
                                if (compteur10 > 0)
                                {
                                    if (compteur10 == 1)
                                    {
                                        Console.WriteLine($"{compteur10} billet de 10 euros");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur10} billets de 10 euros");
                                    }
                                }

                                if (compteur5 > 0)
                                {
                                    if (compteur5 == 1)
                                    {
                                        Console.WriteLine($"{compteur5} billet de 5 euros");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur5} billets de 5 euros");
                                    }
                                }
                                if (compteur2 > 0)
                                {
                                    if (compteur2 == 1)
                                    {
                                        Console.WriteLine($"{compteur2} pièce de 2 euros");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur2} pièces de 2 euros");
                                    }
                                }

                                if (compteur1 > 0)
                                {
                                    if (compteur1 == 1)
                                    {
                                        Console.WriteLine($"{compteur1} pièce de 1 euro");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur1} pièces de 1 euro");
                                    }
                                }
                                if (compteur050 > 0)
                                {
                                    if (compteur050 == 1)
                                    {
                                        Console.WriteLine($"{compteur050} pièce de 50 centimes");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur050} pièces de 50 centimes");
                                    }

                                }
                                if (compteur020 > 0)
                                {
                                    if (compteur020 == 1)
                                    {
                                        Console.WriteLine($"{compteur020} pièce de 20 centimes");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur020} pièces de 20 centimes");
                                    }
                                }
                                if (compteur010 > 0)
                                {
                                    if (compteur010 == 1)
                                    {
                                        Console.WriteLine($"{compteur010} pièce de 10 centimes");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur010} pièces de 10 centimes");
                                    }
                                }
                                if (compteur005 > 0)
                                {
                                    if (compteur005 == 1)
                                    {
                                        Console.WriteLine($"{compteur005} pièce de 5 centimes");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur005} pièces de 5 centimes");
                                    }
                                }
                                if (compteur002 > 0)
                                {
                                    if (compteur002 == 1)
                                    {
                                        Console.WriteLine($"{compteur002} pièce de 2 centimes");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur002} pièces de 20 centimes");
                                    }
                                }
                                if (compteur001 > 0)
                                {
                                    if (compteur001 == 1)
                                    {
                                        Console.WriteLine($"{compteur001} pièce de 1 centime");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{compteur001} pièces de 1 centime");
                                    }
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Le montant réglé ne peut pas être inférieur à {montantàregler} euros.");
                            goto Recommencer;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Valeur saisie incorrecte,veuillez recommencer !");
                        goto Recommencer;

                    }
                }



                Console.ReadKey();
            }
        }
    }
}




