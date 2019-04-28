using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter an equation: ");
            //string equation = Console.ReadLine();

            Console.WriteLine("Welcome in the Solver Equation Project!");
            Console.WriteLine("\nYou can enter the Equation:\n");
            Console.Write("Equation_Project ");

            string equation = Console.ReadLine();

            //string equation = "-A * 9 - 12 * 5 + + + 20 / 10 + p = 40 - p + ";
            //string equation = "5 * 3 = 5 * X";
            //string equation = "-X * 1 + + 3 * 4 - 5 = -5X * 3 - 2X + + 10X / 2";
            //string equation = "-X + X = 3 + X";
            //string equation = "X * 6 = 50";
            //string equation = "2X * 7 = 3 +2";
            //string equation = "2X *7+2 = 5 +5 + ";
            //string equation = "2X + 3 * 6X = 6 - 4X";
            //string equation = "5*5*5 = 3X";

            Console.WriteLine("1. Valid or Invalid Input");
            bool ni1 = Invalid_Input(equation);
            if (ni1 == true)
            {
                Console.WriteLine("Invalid Input" + '\n');
            }
            else
            {
                Console.WriteLine("Correct Input" + '\n');
            }

            Console.WriteLine("2. Replacing letters by X");
            string eq = Other_Letter_Than_X(equation);
            Console.WriteLine(eq + '\n');

            Console.WriteLine("2b. Space Before and After Signs");
            string eq2 = Spaces_Before_and_After_Signs(eq);
            Console.WriteLine(eq2 + '\n');

            Console.WriteLine("3. Space after Plus (at the end of the equation)");
            string eq3 = Space_After_Plus(eq2);
            Console.WriteLine(eq3 + '\n');

            /*Console.WriteLine("4. Suppression of useless Brackets");
            string eq3b = Remove_Useless_Brackets(eq3);
            Console.WriteLine(eq3b + '\n');*/

            Console.WriteLine("4. Operation Elimination");
            string eq4 = Operation_Elimination(eq3);
            Console.WriteLine(eq4 + '\n');

            Console.WriteLine("5. Case of Zero");
            string eq5 = Zero_Case(eq4);
            Console.WriteLine(eq5 + '\n');

            Console.WriteLine("6. Space Before and After Signs");
            string eq6 = Spaces_Before_and_After_Signs(eq5);
            Console.WriteLine(eq6 + '\n');

            char[] char_equa = new char[equation.Length];
            for (int i = 0; i < char_equa.Length; i++)
            {
                char_equa[i] = equation[i];
            }
            bool test = false;
            for (int i = 0; i < char_equa.Length; i++)
            {
                if(char_equa[i] == '*')
                {
                    test = true;
                }
                if (char_equa[i] == '/')
                {
                    test = true;
                }
            }
            
            Console.WriteLine("7. Reduction (Multiplication and Division)");
            string eq7 = "";
            if (test == true)
            {
                eq7 = Reduction_Multiply_Divised(eq6);
            }
            else
            {
                eq7 = eq6;
            }
            
            Console.WriteLine(eq7 + '\n');

            Console.WriteLine("8. Reduction (Addition and Soustraction)");
            string eq8 = Reduction(eq7);
            Console.WriteLine(eq8 + '\n');

            Console.WriteLine("9. Space Between Minus and First Number");
            string eq9 = Space_Between_Minus_And_First_Number(eq8);
            Console.WriteLine(eq9 + '\n');

            Console.WriteLine("10. Result");
            int res = Resolution_bis(eq9);
            Console.WriteLine("Result: X = " + res);


            //Tests Reduction Case
            /*string n = Reduction("5X + 2 = 3X - 5 + 3");
            string n2 = Reduction("3X - 5 = 4X + 1");
            string n3 = Reduction("5 - 4X = 6 + 3X");
            string n4 = Reduction("3X - 4 = 4X - 6X + 2");
            string n5 = Reduction("150 - 48X = 55X + 17 + 38X");
            string n6 = Reduction("1X + 5 - 12 = 48 - 17");
            string n7 = Reduction("X + 5 = 2X + 4");
            string n8 = Reduction("2X = 3 + 8");*/
            //string n9 = Reduction("- 4X + 1 = 2");
            //string n10 = Reduction("- 4X + 1 = - 3X + 2");
            //string n11 = Reduction("- 5 + 4X = 1");
            //string n12 = Reduction("- 5 + 4X = - 1 + 3X");


            //Tests Zero Case
            //string n01 = Zero_Case("X + 5 = 2X + 4");
            //string n02 = Zero_Case("2X + 4 = X + 5");
            //string n03 = Zero_Case("4 + X = 5 + X");
            //Reduction(n02);


            //Tests Space After Plus Case
            //string np1 = Space_After_Plus("3X + 2 = 5 + ");
            //Reduction(np1);


            //Tests Operation Elimination Case
            //string no1 = Operation_Elimination("3X = 5 + + + 4 - 6");
            //string no2 = Operation_Elimination("3X + + + + + 6 = 5 + + 4 - 6");
            //string no3 = Operation_Elimination("3X + + + 9 = 4X + + 9");
            //string no4 = Operation_Elimination("3X - - - 9 = 4X + + + + + 1");
            //string no5 = Operation_Elimination("3X - - 900X = 50X + + + 6");
            //string no6 = Operation_Elimination("5X + + + 2 = 3X - - - - - 5 + + 3");
            //string aaa = Reduction(no6);

            //string test = Reduction("5X = 5 - 105");
            //Resolution_bis(test);


            //Tests Invalid Input Case
            /*bool ni1 = Invalid_Input("3X + 2 + 5 + 6X");
            if(ni1 == true)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("Correct Input");
            }*/


            //Tests Space Between Minus & First Number Case
            /*string ns1 = Space_Between_Minus_And_First_Number("-5X = -3");
            string ns2 = Space_Between_Minus_And_First_Number("5X + 3 = -5 + 4");
            string ns3 = Space_Between_Minus_And_First_Number("-555X + 3 = -1000 + 2");
            */

            //Tests Resolution Case
            //int nr1 = Resolution_bis("- 5X = 20");

            //Tests other letter than X case
            //string nx1 = Other_Letter_Than_X("-2a + 5b = 6M");


            //Tests MULTIPLY DIVISED
            //string nmd1 = Reduction_Multiply_Divised("5 * 5 + 15X * 10 + 8 * 3 + 13 + 5X * 12 - 10 / 2 + 9 = 12 / 3 + 5");


            //Tests Spaces Case
            //string ns1 = Spaces_Before_and_After_Signs("5*3 + 5*X = 5/2");


            //Tests Brackets #1
            //string nb1 = Remove_Useless_Brackets("( 5 * 3 ) = ( 5 * X )");

            //Console.Write("Equation : ");
            //string END = "-A * 9 - 12 * 5 + + + 20 / 10 + p = 40 - p + ";
            //string END = "5 * 3 = 5 * X";
            //string END = "-X * 1 + + 3 * 4 - 5 = -5X * 3 - 2X + + 10X / 2";
            //string END = "-X + X = 3 + X";

            /*Console.WriteLine(END + '\n');

            Console.WriteLine("1. Valid or Invalid Input");
            bool ni1 = Invalid_Input(END);
            if (ni1 == true)
            {
                Console.WriteLine("Invalid Input" + '\n');
            }
            else
            {
                Console.WriteLine("Correct Input" + '\n');
            }

            Console.WriteLine("2. Replacing letters by X");
            string eq = Other_Letter_Than_X(END);
            Console.WriteLine(eq + '\n');

            Console.WriteLine("3. Space after Plus (at the end of the equation)");
            string eq2 = Space_After_Plus(eq);
            Console.WriteLine(eq2 + '\n');


            Console.WriteLine("4. Operation Elimination");
            string eq3 = Operation_Elimination(eq2);
            Console.WriteLine(eq3 + '\n');

            Console.WriteLine("5. Case of Zero");
            string eq4 = Zero_Case(eq3);
            Console.WriteLine(eq4 + '\n');

            Console.WriteLine("6. Space Before and After Signs");
            string eq5 = Spaces_Before_and_After_Signs(eq4);
            Console.WriteLine(eq5 + '\n');

            Console.WriteLine("7. Reduction (Multiplication and Division)");
            string eq6 = Reduction_Multiply_Divised(eq5);
            Console.WriteLine(eq6 + '\n');

            Console.WriteLine("8. Reduction (Addition and Soustraction)");
            string eq7 = Reduction(eq6);
            Console.WriteLine(eq7 + '\n');

            Console.WriteLine("9. Space Between Minus and First Number #2");
            string eq8 = Spaces_Before_and_After_Signs(eq7);
            Console.WriteLine(eq8 + '\n');

            Console.WriteLine("10. Result");
            int res = Resolution_bis(eq8);
            Console.WriteLine("Result: X = " + res);*/




            //string equation = "-2X + + + 3X - 200 = 10X - - 5 + ";
            //string equation = "-2X + 3X = 5";
            /*string equation = nmd1;
            string equation1 = Space_After_Plus(equation);
            string equation2 = Operation_Elimination(equation1);
            string equation3 = Space_Between_Minus_And_First_Number(equation2);
            string equation4 = Reduction(equation3);
            string equation5 = Space_Between_Minus_And_First_Number(equation4);
            int resultat = Resolution_bis(equation5);*/


            Console.ReadKey();
        }



        static string Zero_Case(string equation)
        {
            string final_equa = "";

            char[] char_equa = new char[equation.Length];
            for (int i = 0; i < equation.Length; i++)
            {
                char_equa[i] = equation[i];
            }

            int count = 0;
            for (int i = 1; i < equation.Length; i++)
            {
                if (equation[i] == 'X' && (equation[i - 1] == ' ' || equation[i - 1] == '-'))
                {
                    count++;
                }
            }
            if(equation[0] == 'X')
            {
                count++;
            }

            string[] equa_final = new string[equation.Length + count];
            int j = 0;
            if (equation[0] == 'X')
            {
                equa_final[0] = "1";
                equa_final[1] = "X";
                j = j + 2;

                for (int i = 1; i < equation.Length; i++)
                {
                    if ((equation[i] == 'X' && (equation[i - 1] == ' ' || equation[i - 1] == '-')))
                    {
                        equa_final[j] = "1";
                        equa_final[j + 1] = Convert.ToString(char_equa[i]);
                        j = j + 2;
                    }
                    else
                    {
                        equa_final[j] = Convert.ToString(char_equa[i]);
                        j++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < equation.Length; i++)
                {
                    if ((equation[i] == 'X' && (equation[i - 1] == ' ' || equation[i - 1] == '-')))
                    {
                        equa_final[j] = "1";
                        equa_final[j + 1] = Convert.ToString(char_equa[i]);
                        j = j + 2;
                    }
                    else
                    {
                        equa_final[j] = Convert.ToString(char_equa[i]);
                        j++;
                    }
                }
            }

            for (int i = 0; i < equa_final.Length; i++)
            {
                final_equa += equa_final[i];
            }



            //Left Side
            /*for (int i = 0; i < left_side.Length; i++)
            {
                if(left_side[0] == 'X')
                {
                    left_side = "1" + left_side;
                }
                if(left_side[1] == 'X' && left_side[0] == '-')
                {

                }
            }


            //Right Side
            for(int i = 0; i < right_side.Length; i++)
            {
                if(right_side[1] == 'X')
                {
                    right_side = "1" + right_side;
                }
            }


            //Mix places
            char[] char_right_side = new char[right_side.Length];

            for (int i = 0; i < char_right_side.Length; i++)
            {
                char_right_side[i] = right_side[i];
            }

            char blank = char_right_side[0];
            char_right_side[0] = char_right_side[1];
            char_right_side[1] = blank;

            string final_right_side = "";

            for (int i = 0; i < char_right_side.Length; i++)
            {
                final_right_side += char_right_side[i];
            }


            //Final Equation
            final_equa = left_side + "=" + final_right_side;*/

            return final_equa;
        }

        static string Space_After_Plus(string equation)
        {
            string final_equa = "";

            char[] equa_char = new char[equation.Length];

            for (int i = 0; i < equa_char.Length; i++)
            {
                equa_char[i] = equation[i];
            }

            //Intermediate Equation
            string intermadiate_equa = equation;
            if(intermadiate_equa[intermadiate_equa.Length - 2] == '+')
            {
                intermadiate_equa = intermadiate_equa + "0";
            }
            Console.WriteLine(intermadiate_equa);

            //Final Equation
            if(equation[equation.Length - 2] == '+')
            {
                for (int i = 0; i < equa_char.Length - 3; i++)
                {
                    final_equa += equa_char[i];
                }
            }
            else
            {
                final_equa = equation;
            }


            return final_equa;
        }

        static string Operation_Elimination(string equation)
        {
            string final_equa = "";

            char[] equa_char = new char[equation.Length];

            for (int i = 0; i < equation.Length; i++)
            {
                equa_char[i] = equation[i];
            }


            //Count the number of X
            int number_of_X = 0;
            for (int i = 0; i < equa_char.Length; i++)
            {
                if(equa_char[i] == 'X')
                {
                    number_of_X++;
                }
            }


            //Count the number of number that are more than 9 (e.g. 10 - 100000)
            int number_of_big_number = 0;
            for(int i = 0; i < equa_char.Length - 1; i++)
            {
                if (Char.IsNumber(equa_char[i]) == true && Char.IsNumber(equa_char[i + 1]) == true)
                {
                    number_of_big_number++;
                }
            }


            //Replace the not necessary + and - by a space
            if(equa_char.Length >= 10)
            {
                for (int i = 0; i < equa_char.Length - 2; i++)
                {
                    while ((equa_char[i] == '+' && equa_char[i + 2] == '+') || (equa_char[i] == '-' && equa_char[i + 2] == '-') || (equa_char[i] == '*' && equa_char[i + 2] == '*') || (equa_char[i] == '/' && equa_char[i + 2] == '/'))
                    {
                        equa_char[i] = ' ';
                    }
                }
            }



            //Create a string of the equation with the right number of operation but not the right form
            string equa_with_good_number_of_operation = "";

            for(int i = 0; i < equa_char.Length; i++)
            {
                equa_with_good_number_of_operation += equa_char[i];
            }


            //Create a string (then char) of the final equation without spaces
            string[] array_final_equa = equa_with_good_number_of_operation.Split(' ');

            string final_equa_without_spaces = "";

            for(int i = 0; i < array_final_equa.Length; i++)
            {
                final_equa_without_spaces += array_final_equa[i];
            }

            char[] final_equa_without_spaces_char = new char[final_equa_without_spaces.Length];

            for (int i = 0; i < final_equa_without_spaces.Length; i++)
            {
                final_equa_without_spaces_char[i] = Convert.ToChar(final_equa_without_spaces[i]); 
            }

            char[] final_equa_char = new char[(final_equa_without_spaces.Length * 2) - number_of_X - number_of_big_number + 2];


            //Determine where to put spaces on the equation
            int j = 0;
            for (int i = 0; i < final_equa_without_spaces.Length - 1; i++)
            {
                if (final_equa_without_spaces[i + 1] == 'X' && (final_equa_without_spaces[i] == '-'))
                {
                    final_equa_char[j] = final_equa_without_spaces[i];
                    final_equa_char[j + 1] = ' ';
                    j = j + 2;
                }
                else if (final_equa_without_spaces[i + 1] == 'X' && (final_equa_without_spaces[i] == '+'))
                {
                    final_equa_char[j] = final_equa_without_spaces[i];
                    final_equa_char[j + 1] = ' ';
                    j = j + 2;
                }
                else if (final_equa_without_spaces[i + 1] == 'X' && (final_equa_without_spaces[i] == '*'))
                {
                    final_equa_char[j] = final_equa_without_spaces[i];
                    final_equa_char[j + 1] = ' ';
                    j = j + 2;
                }
                else if (final_equa_without_spaces[i + 1] == 'X' && (final_equa_without_spaces[i] == '/'))
                {
                    final_equa_char[j] = final_equa_without_spaces[i];
                    final_equa_char[j + 1] = ' ';
                    j = j + 2;
                }
                else if (final_equa_without_spaces[i + 1] == 'X' || (Char.IsNumber(final_equa_without_spaces[i + 1]) == true && Char.IsNumber(final_equa_without_spaces[i]) == true))
                {
                    final_equa_char[j] = final_equa_without_spaces[i];
                    j++;
                }
                else
                {
                    final_equa_char[j] = final_equa_without_spaces[i];
                    final_equa_char[j + 1] = ' ';
                    j = j + 2;
                }
            }
            
            final_equa_char[j] = final_equa_without_spaces[final_equa_without_spaces.Length - 1];


            //Final equation
            for(int i = 0; i < final_equa_char.Length; i++)
            {
                final_equa += final_equa_char[i];
            }

            return final_equa;
        }

        static bool Invalid_Input(string equation)
        {
            bool result = true;

            for (int i = 0; i < equation.Length; i++)
            {
                if(equation[i] == '=')
                {
                    result = false;
                }
            }

            return result;
        }

        static string Space_Between_Minus_And_First_Number(string equation)
        {
            string final_equa = "";

            string[] sep_equa = equation.Split('=');

            string equa_left = sep_equa[0];
            string equa_right = sep_equa[1];

            char[] char_equa_left = new char[equa_left.Length];
            char[] char_equa_right = new char[equa_right.Length];

            for (int i = 0; i < char_equa_left.Length; i++)
            {
                char_equa_left[i] = equa_left[i];
            }
            for (int i = 0; i < char_equa_right.Length; i++)
            {
                char_equa_right[i] = equa_right[i];
            }


            //For the left side
            if(char_equa_left[0] == '-' && char_equa_left[1] != ' ')
            {
                int j = 0;
                char[] char_final_equa_left = new char[char_equa_left.Length + 1];

                for (int i = 0; i < char_equa_left.Length; i++)
                {
                    if(i != 1)
                    {
                        char_final_equa_left[j] = char_equa_left[i];
                        j++;
                    }
                    else
                    {
                        char_final_equa_left[1] = ' ';
                        char_final_equa_left[2] = char_equa_left[1];
                        j = j + 2;
                    }
                }

                for (int i = 0; i < char_final_equa_left.Length; i++)
                {
                    final_equa += char_final_equa_left[i];
                }

                final_equa = final_equa + "=";
            }
            else
            {
                for(int i = 0; i < char_equa_left.Length; i++)
                {
                    final_equa += char_equa_left[i];
                }

                final_equa = final_equa + "=";
            }


            if (char_equa_right[1] == '-' && char_equa_right[2] != ' ')
            {
                int j = 1;
                char[] char_final_equa_right = new char[char_equa_right.Length + 1];

                for (int i = 1; i < char_equa_right.Length; i++)
                {
                    if (i != 2)
                    {
                        char_final_equa_right[j] = char_equa_right[i];
                        j++;
                    }
                    else
                    {
                        char_final_equa_right[2] = ' ';
                        char_final_equa_right[3] = char_equa_right[2];
                        j = j + 2;
                    }
                    char_final_equa_right[0] = ' ';
                }

                for (int i = 0; i < char_final_equa_right.Length; i++)
                {
                    final_equa += char_final_equa_right[i];
                }
            }
            else
            {
                for (int i = 0; i < char_equa_right.Length; i++)
                {
                    final_equa += char_equa_right[i];
                }
            }

            return final_equa;
        }

        static string Other_Letter_Than_X(string equation)
        {
            string final_equa = "";

            char[] char_equa = new char[equation.Length];

            for(int i = 0; i < equation.Length; i++)
            {
                char_equa[i] = equation[i];
            }

            for(int i = 0; i < char_equa.Length; i++)
            {
                if(Char.IsLetter(char_equa[i]))
                {
                    if(char_equa[i] != 'X')
                    {
                        char_equa[i] = 'X';
                    }
                }
            }

            for (int i = 0; i < char_equa.Length; i++)
            {
                final_equa += char_equa[i];
            }

                return final_equa;
        }

        static string Spaces_Before_and_After_Signs(string equation)
        {
            string final_equa = "";

            char[] equa_char = new char[equation.Length];

            for (int i = 0; i < equa_char.Length; i++)
            {
                equa_char[i] = equation[i];
            }

            int count = 0;
            for (int i = 1; i < equa_char.Length; i++)
            {
                if ((equa_char[i] == '*' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')) || (equa_char[i] == '/' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')) || (equa_char[i] == '+' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')) || (equa_char[i] == '-' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')))  
                {
                    count++;
                }
            }

            char[] final_equa_char = new char[equa_char.Length + count * 2];
            int j = 1;
            final_equa_char[0] = equa_char[0];
            for (int i = 1; i < equa_char.Length; i++)
            {
                if ((equa_char[i] == '*' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')) || (equa_char[i] == '/' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')) || (equa_char[i] == '+' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')) || (equa_char[i] == '-' && (equa_char[i - 1] != ' ' || equa_char[i + 1] != ' ')))
                {
                    final_equa_char[j] = ' ';
                    final_equa_char[j + 1] = equa_char[i];
                    final_equa_char[j + 2] = ' ';
                    j = j + 3;
                }
                else
                {
                    final_equa_char[j] = equa_char[i];
                    j++;
                }
            }

            for (int i = 0; i < final_equa_char.Length; i++)
            {
                final_equa += final_equa_char[i];
            }



            return final_equa;
        }

        static string Remove_Useless_Brackets(string equation)
        {
            string final_equa = "";

            string[] sep_equa = equation.Split('=');
            string left_equa = sep_equa[0];
            string right_equa = sep_equa[1];

            char[] char_left_side = new char[left_equa.Length];
            char[] char_right_side = new char[right_equa.Length];

            for (int i = 0; i < char_left_side.Length; i++)
            {
                char_left_side[i] = left_equa[i];
            }
            for (int i = 0; i < char_right_side.Length; i++)
            {
                char_right_side[i] = right_equa[i];
            }

            char[] final_char_left = new char[char_left_side.Length];
            if (char_left_side.Length >= 4)
            {
                final_char_left = new char[char_left_side.Length - 4];
                int j = 2;
                if (char_left_side[0] == '(' && char_left_side[char_left_side.Length - 2] == ')')
                {

                    for (int i = 0; i < final_char_left.Length; i++)
                    {
                        final_char_left[i] = char_left_side[j];
                        j++;
                    }
                }
            }
            else
            {
                final_char_left = new char[char_left_side.Length];
                for (int i = 0; i < final_char_left.Length; i++)
                {
                    final_char_left[i] = char_left_side[i];
                }
            }

            char[] final_char_right = new char[char_right_side.Length];
            if (char_right_side.Length >= 4)
            {
                final_char_right = new char[char_right_side.Length - 4];
                int k = 2;
                if (char_right_side[1] == '(' && char_right_side[char_right_side.Length - 1] == ')')
                {

                    for (int i = 0; i < final_char_right.Length; i++)
                    {
                        final_char_right[i] = char_right_side[k];
                        k++;
                    }
                }
            }
            else
            {
                final_char_right = new char[char_right_side.Length];
                for (int i = 0; i < final_char_right.Length; i++)
                {
                    final_char_right[i] = char_right_side[i];
                }
            }


            string final_left = "";
            string final_right = "";

            for (int i = 0; i < final_char_left.Length; i++)
            {
                final_left += final_char_left[i];
            }
            for (int i = 0; i < final_char_right.Length; i++)
            {
                final_right += final_char_right[i];
            }

            final_equa = final_left + "=" + final_right;


            return final_equa;
        }



        static string Reduction(string equation)
        {
            string final_equa = "";

            string[] separated_equation = equation.Split('=');

            string equa_left = separated_equation[0];
            string equa_right = separated_equation[1];

            string[] sep_equa_left = equa_left.Split(' ');
            string[] sep_equa_right = equa_right.Split(' ');

            string[] array_X = new string[(sep_equa_left.Length + sep_equa_right.Length)/2];
            string[] array_C = new string[(sep_equa_left.Length + sep_equa_right.Length)/2];

            int j = 0;
            int k = 0;


            //Left side of the equation
            for (int i = 0; i < sep_equa_left.Length; i++)
            {
                if(sep_equa_left[i].Contains("X"))
                {
                    if (i == 0)
                    {
                        if(sep_equa_left[0] == "-")
                        {
                            array_X[j] = "- " + sep_equa_left[i + 1] + " ";
                            j = j + 2;
                        }
                        else
                        {
                            array_X[j] = "+ " + sep_equa_left[i] + " ";
                            j++;
                        }
                    }
                    else
                    {
                        if (sep_equa_left[i - 1] == "+")
                        {
                            array_X[j] = "+ " + sep_equa_left[i] + " ";
                            j++;
                        }
                        else
                        {
                            array_X[j] = "- " + sep_equa_left[i] + " ";
                            j++;
                        }

                    }

                }
                if(IsNumeric(sep_equa_left[i]))
                {
                    if (i == 0)
                    {
                        if(sep_equa_left[0] == "-")
                        {
                            array_C[k] = "+ " + sep_equa_left[i + 1] + " ";
                            k = k + 2;
                        }
                        else
                        {
                            array_C[k] = "- " + sep_equa_left[i] + " ";
                            k++;
                        }
                    }
                    else
                    {
                        if (sep_equa_left[i - 1] == "+")
                        {
                            array_C[k] = "- " + sep_equa_left[i] + " ";
                            k++;
                        }
                        else
                        {
                            array_C[k] = "+ " + sep_equa_left[i] + " ";
                            k++;
                        }

                    }


                }
            }


            //Right side of the equation
            for (int i = 0; i < sep_equa_right.Length; i++)
            {
                if (sep_equa_right[i].Contains("X"))
                {
                    if (i == 1)
                    {
                        if (sep_equa_right[1] == "-")
                        {
                            array_X[j] = "+ " + sep_equa_right[i + 1] + " ";
                            j = j + 2;
                        }
                        else
                        {
                            array_X[j] = "- " + sep_equa_right[i] + " ";
                            j++;
                        }
                    }
                    else
                    {
                        if (sep_equa_right[i - 1] == "+")
                        {
                            array_X[j] = "- " + sep_equa_right[i] + " ";
                            j++;
                        }
                        else
                        {
                            array_X[j] = "+ " + sep_equa_right[i] + " ";
                            j++;
                        }
                    }
                }
                if (IsNumeric(sep_equa_right[i]))
                {
                    if (i == 1)
                    {
                        if(sep_equa_right[1] == "-")
                        {
                            array_C[k] = "- " + sep_equa_right[i] + " ";
                            k = k + 2;
                        }
                        else
                        {
                            array_C[k] = "+ " + sep_equa_right[i] + " ";
                            k++;
                        }
                    }
                    else
                    {
                        if (sep_equa_right[i - 1] == "+")
                        {
                            array_C[k] = "+ " + sep_equa_right[i] + " ";
                            k++;
                        }
                        else
                        {
                            array_C[k] = "- " + sep_equa_right[i] + " ";
                            k++;
                        }

                    }
                }
            }


            string equa_X = "";
            string equa_C = "";

            for(int i = 0; i <array_X.Length; i++)
            {
                equa_X += array_X[i];
            }
            for(int i = 0; i < array_C.Length; i++)
            {
                equa_C += array_C[i];
            }


            //Calcul of equa C
            string[] sep_equa_C = equa_C.Split(' ');
            int temp = 0;
            int C = 0;

            for(int i = 0; i < sep_equa_C.Length; i++)
            {
                if(IsNumeric(sep_equa_C[i]))
                {
                    temp = Convert.ToInt32(sep_equa_C[i]);
                    if(sep_equa_C[i - 1] == "+")
                    {
                        C += temp;
                    }
                    else
                    {
                        C -= temp;
                    }
                }
            }


            //Calcul of equa X
            char[] array_remove_X = new char[equa_X.Length];
            for(int i = 0; i < equa_X.Length; i++)
            {
                array_remove_X[i] = equa_X[i];
            }
            for(int i = 0; i < array_remove_X.Length; i++)
            {
                if(array_remove_X[i] == 'X')
                {
                    array_remove_X[i] = ' ';
                }
            }

            string equa_X_without_X = "";
            for (int i = 0; i < array_remove_X.Length; i++)
            {
                equa_X_without_X += array_remove_X[i];
            }

            string[] sep_equa_X_without_X = equa_X_without_X.Split(' ');

            int temp2 = 0;
            int X = 0;

            for (int i = 0; i < sep_equa_X_without_X.Length; i++)
            {
                if (IsNumeric(sep_equa_X_without_X[i]))
                {
                    temp2 = Convert.ToInt32(sep_equa_X_without_X[i]);
                    if (sep_equa_X_without_X[i - 1] == "+")
                    {
                        X += temp2;
                    }
                    else
                    {
                        X -= temp2;
                    }
                }
            }


            //Final Equation
            final_equa = X + "X = " + C; 


            return final_equa;
        }

        public static bool IsNumeric(string s)
        {
            double Result;
            return double.TryParse(s, out Result);  // TryParse routines were added in Framework version 2.0.
        }

        public static int Resolution_bis(string equation)
        {
            int X = 0;

            string[] separated_equation = equation.Split(' ');

            string[] separated_equation_bis = equation.Split('=');
            string equa_left = separated_equation_bis[0];
            string equa_right = separated_equation_bis[1];
            string[] sep_equa_right = equa_right.Split(' ');

            //Search of A
            int A = 0;
            string A_bis = "";
            string A_double_bis = "";
            for (int i = 0; i < separated_equation.Length; i++)
            {
                if (separated_equation[i].Contains("X"))
                {
                    A_bis = separated_equation[i];
                }
            }
            for (int i = 0; i < A_bis.Length - 1; i++)
            {
                A_double_bis += Convert.ToString(A_bis[i]);
            }
            A = Convert.ToInt32(A_double_bis);


            //Search of B
            int B = 0;
            B = Convert.ToInt32(sep_equa_right[sep_equa_right.Length - 1]);


            //Search for the sign
            if(A != 0)
            {
                if ((equa_left[0] == '-' && equa_right[1] != '-') || (equa_right[1] == '-' && equa_left[0] != '-'))
                {
                    X = -(B / A);
                }
                else
                {
                    X = B / A;
                }
            }
            else
            {
                Console.WriteLine("X can not be calculated: We can not devised by zero");
                Console.WriteLine("(X = 0 is the default value when X can not be calculated)");
            }

            return X;
        }

        static string Reduction_Multiply_Divised(string equation)
        {
            string final_equa = "";

            string[] sep_equa = equation.Split('=');

            string equa_left = sep_equa[0];
            string equa_right = sep_equa[1];

            string[] sep_equa_left = equa_left.Split(' ');
            string[] sep_equa_right = equa_right.Split(' ');

            int A = 0;
            int B = 0;
            int AxB = 0; //Multiplication
            int AdB = 0; //Division


            //Left side
            string final_left_side = "";
            bool test_first_number_left = IsNumeric(sep_equa_left[0]);
            if (test_first_number_left == true && (sep_equa_left[1] != "*" && sep_equa_left[1] != "/"))
            {
                final_left_side = sep_equa_left[0] + " ";
            }
            if(sep_equa_left[0].Contains('X'))
            {
                final_left_side = sep_equa_left[0] + " ";
            }
            for (int i = 1; i < sep_equa_left.Length; i++)
            {
                if (sep_equa_left[i] == "*")
                {
                    if (sep_equa_left[i - 1].Contains('X'))
                    {
                        string[] sep_equa_X = sep_equa_left[i - 1].Split('X');
                        A = Convert.ToInt32(sep_equa_X[0]);
                        B = Convert.ToInt32(sep_equa_left[i + 1]);
                        AxB = A * B;
                        if (i > 1 && sep_equa_left[i - 2] == "+")
                        {
                            final_left_side += "+ " + Convert.ToString(AxB) + "X ";
                        }
                        else if(i > 1 && sep_equa_left[i - 2] == "-")
                        {
                            final_left_side += "- " + Convert.ToString(AxB) + "X ";
                        }            
                        else
                        {
                            final_left_side += Convert.ToString(AxB) + "X ";
                        }          
                    }
                    else if (sep_equa_left[i + 1].Contains('X'))
                    {
                        string[] sep_equa_X = sep_equa_left[i + 1].Split('X');
                        A = Convert.ToInt32(sep_equa_X[0]);
                        B = Convert.ToInt32(sep_equa_left[i - 1]);
                        AxB = A * B;
                        if (i > 1 && sep_equa_left[i - 2] == "+")
                        {
                            final_left_side += "+ " + Convert.ToString(AxB) + "X ";
                        }
                        else if (i > 1 && sep_equa_left[i - 2] == "-")
                        {
                            final_left_side += "- " + Convert.ToString(AxB) + "X ";
                        }
                        else
                        {
                            final_left_side += Convert.ToString(AxB) + "X ";
                        }
                    }
                    else
                    {
                        A = Convert.ToInt32(sep_equa_left[i - 1]);
                        B = Convert.ToInt32(sep_equa_left[i + 1]);
                        AxB = A * B;
                        if (i > 1 && sep_equa_left[i - 2] == "+")
                        {
                            final_left_side += "+ " + Convert.ToString(AxB) + " ";
                        }
                        else if (i > 1 && sep_equa_left[i - 2] == "-")
                        {
                            final_left_side += "- " + Convert.ToString(AxB) + " ";
                        }
                        else
                        {
                            final_left_side += Convert.ToString(AxB) + " ";
                        }
                    }
                }

                if (sep_equa_left[i] == "/")
                {
                    if (sep_equa_left[i - 1].Contains('X'))
                    {
                        string[] sep_equa_X = sep_equa_left[i - 1].Split('X');
                        A = Convert.ToInt32(sep_equa_X[0]);
                        B = Convert.ToInt32(sep_equa_left[i + 1]);
                        AdB = A / B;
                        if (i > 1 && sep_equa_left[i - 2] == "+")
                        {
                            final_left_side += "+ " + Convert.ToString(AdB) + "X ";
                        }
                        else if (i > 1 && sep_equa_left[i - 2] == "-")
                        {
                            final_left_side += "- " + Convert.ToString(AdB) + "X ";
                        }
                        else
                        {
                            final_left_side += Convert.ToString(AdB) + "X ";
                        }
                    }
                    else if (sep_equa_left[i + 1].Contains('X'))
                    {
                        string[] sep_equa_X = sep_equa_left[i + 1].Split('X');
                        A = Convert.ToInt32(sep_equa_X[0]);
                        B = Convert.ToInt32(sep_equa_left[i - 1]);
                        AdB = A / B;
                        if (i > 1 && sep_equa_left[i - 2] == "+")
                        {
                            final_left_side += "+ " + Convert.ToString(AdB) + "X ";
                        }
                        else if (i > 1 && sep_equa_left[i - 2] == "-")
                        {
                            final_left_side += "- " + Convert.ToString(AdB) + "X ";
                        }
                        else
                        {
                            final_left_side += Convert.ToString(AdB) + "X ";
                        }
                    }
                    else
                    {
                        A = Convert.ToInt32(sep_equa_left[i - 1]);
                        B = Convert.ToInt32(sep_equa_left[i + 1]);
                        AdB = A / B;
                        if (i > 1 && sep_equa_left[i - 2] == "+")
                        {
                            final_left_side += "+ " + Convert.ToString(AdB) + " ";
                        }
                        else if (i > 1 && sep_equa_left[i - 2] == "-")
                        {
                            final_left_side += "- " + Convert.ToString(AdB) + " ";
                        }
                        else
                        {
                            final_left_side += Convert.ToString(AdB) + " ";
                        }
                    }
                }

                if (i < sep_equa_left.Length - 1 && sep_equa_left[i - 1] == "+" && (sep_equa_left[i + 1] != "*" && sep_equa_left[i + 1] != "/")) 
                {
                    final_left_side += "+ " + sep_equa_left[i] + " ";
                }
                else if (i < sep_equa_left.Length - 1 && sep_equa_left[i - 1] == "-" && (sep_equa_left[i + 1] != "*" && sep_equa_left[i + 1] != "/"))
                {
                    final_left_side += "- " + sep_equa_left[i] + " ";
                }
                else if (i >= sep_equa_left.Length - 1 && sep_equa_left[i - 1] == "+")
                {
                    final_left_side += "+ " + sep_equa_left[i];
                }
                else if (i >= sep_equa_left.Length - 1 && sep_equa_left[i - 1] == "-")
                {
                    final_left_side += "- " + sep_equa_left[i];
                }
            }


            //Right Side
            string final_right_side = "";
            bool test_first_number_right = IsNumeric(sep_equa_right[1]);
            if (sep_equa_right.Length >= 3)
            {
                if (test_first_number_right == true && (sep_equa_right[2] != "*" && sep_equa_right[2] != "/"))
                {
                    final_right_side = sep_equa_right[1] + " ";
                }
                for (int i = 1; i < sep_equa_right.Length; i++)
                {
                    if (sep_equa_right[i] == "*")
                    {
                        if (sep_equa_right[i - 1].Contains('X'))
                        {
                            string[] sep_equa_X = sep_equa_right[i - 1].Split('X');
                            A = Convert.ToInt32(sep_equa_X[0]);
                            B = Convert.ToInt32(sep_equa_right[i + 1]);
                            AxB = A * B;
                            if (i > 1 && sep_equa_right[i - 2] == "+")
                            {
                                final_right_side += "+ " + Convert.ToString(AxB) + "X ";
                            }
                            else if (i > 1 && sep_equa_right[i - 2] == "-")
                            {
                                final_right_side += "- " + Convert.ToString(AxB) + "X ";
                            }
                            else
                            {
                                final_right_side += Convert.ToString(AxB) + "X ";
                            }
                        }
                        else if (sep_equa_right[i + 1].Contains('X'))
                        {
                            string[] sep_equa_X = sep_equa_right[i + 1].Split('X');
                            A = Convert.ToInt32(sep_equa_X[0]);
                            B = Convert.ToInt32(sep_equa_right[i - 1]);
                            AxB = A * B;
                            if (i > 1 && sep_equa_right[i - 2] == "+")
                            {
                                final_right_side += "+ " + Convert.ToString(AxB) + "X ";
                            }
                            else if (i > 1 && sep_equa_right[i - 2] == "-")
                            {
                                final_right_side += "- " + Convert.ToString(AxB) + "X ";
                            }
                            else
                            {
                                final_right_side += Convert.ToString(AxB) + "X ";
                            }
                        }
                        else
                        {
                            A = Convert.ToInt32(sep_equa_right[i - 1]);
                            B = Convert.ToInt32(sep_equa_right[i + 1]);
                            AxB = A * B;
                            if (sep_equa_right[i - 2] == "+")
                            {
                                final_right_side += "+ " + Convert.ToString(AxB) + " ";
                            }
                            else if (sep_equa_right[i - 2] == "-")
                            {
                                final_right_side += "- " + Convert.ToString(AxB) + " ";
                            }
                            else
                            {
                                final_right_side += Convert.ToString(AxB) + " ";
                            }
                        }
                    }

                    if (sep_equa_right[i] == "/")
                    {
                        if (sep_equa_right[i - 1].Contains('X'))
                        {
                            string[] sep_equa_X = sep_equa_right[i - 1].Split('X');
                            A = Convert.ToInt32(sep_equa_X[0]);
                            B = Convert.ToInt32(sep_equa_right[i + 1]);
                            AdB = A / B;
                            if (i > 1 && sep_equa_right[i - 2] == "+")
                            {
                                final_right_side += "+ " + Convert.ToString(AdB) + "X ";
                            }
                            else if (i > 1 && sep_equa_right[i - 2] == "-")
                            {
                                final_right_side += "- " + Convert.ToString(AdB) + "X ";
                            }
                            else
                            {
                                final_right_side += Convert.ToString(AdB) + "X ";
                            }
                        }
                        else if (sep_equa_right[i + 1].Contains('X'))
                        {
                            string[] sep_equa_X = sep_equa_right[i + 1].Split('X');
                            A = Convert.ToInt32(sep_equa_X[0]);
                            B = Convert.ToInt32(sep_equa_right[i - 1]);
                            AdB = A / B;
                            if (i > 1 && sep_equa_right[i - 2] == "+")
                            {
                                final_right_side += "+ " + Convert.ToString(AdB) + "X ";
                            }
                            else if (i > 1 && sep_equa_right[i - 2] == "-")
                            {
                                final_right_side += "- " + Convert.ToString(AdB) + "X ";
                            }
                            else
                            {
                                final_right_side += Convert.ToString(AdB) + "X ";
                            }
                        }
                        else
                        {
                            A = Convert.ToInt32(sep_equa_right[i - 1]);
                            B = Convert.ToInt32(sep_equa_right[i + 1]);
                            AdB = A / B;
                            if (i > 1 && sep_equa_right[i - 2] == "+")
                            {
                                final_right_side += "+ " + Convert.ToString(AdB) + " ";
                            }
                            else if (i > 1 && sep_equa_right[i - 2] == "-")
                            {
                                final_right_side += "- " + Convert.ToString(AdB) + " ";
                            }
                            else
                            {
                                final_right_side += Convert.ToString(AdB) + " ";
                            }
                        }
                    }

                    if (i < sep_equa_right.Length - 1 && sep_equa_right[i - 1] == "+" && (sep_equa_right[i + 1] != "*" && sep_equa_right[i + 1] != "/"))
                    {
                        final_right_side += "+ " + sep_equa_right[i] + " ";
                    }
                    else if (i < sep_equa_right.Length - 1 && sep_equa_right[i - 1] == "-" && (sep_equa_right[i + 1] != "*" && sep_equa_right[i + 1] != "/"))
                    {
                        final_right_side += "- " + sep_equa_right[i] + " ";
                    }
                    else if (i >= sep_equa_right.Length - 1 && sep_equa_right[i - 1] == "+")
                    {
                        final_right_side += "+ " + sep_equa_right[i];
                    }
                    else if (i >= sep_equa_right.Length - 1 && sep_equa_right[i - 1] == "-")
                    {
                        final_right_side += "- " + sep_equa_right[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < sep_equa_right.Length; i++)
                {
                    final_right_side += sep_equa_right[i];
                }
            }
            


            final_equa = final_left_side + "= " + final_right_side;  

            return final_equa;
        }

    }
}
