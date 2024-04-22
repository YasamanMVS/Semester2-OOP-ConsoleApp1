using System;
using System.Collections.Generic;
using System.Linq;

/* -- Yasaman Mirvahabi Sabet
 * -- 101217770
 */

namespace SemesterCalculation
{
    class gradeCalculator
    {
        static void Main(string[] args)
        {
            int ID, a, b, c, d, passed, failed;
            float[] final = new float[4];
            string grade = "";
            passed = 0;
            failed = 0;

            Console.WriteLine("------------------------------------- Student Semester Calculation -------------------------------------");
            Console.WriteLine("");

            /* -- In this part first we get the students ID then
             * their grade for each course, and 
             * calculate their final grade -- */

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a student ID (0 to Quit) : ");
                ID = Convert.ToInt32(Console.ReadLine());
                if(ID == 0)
                {
                    break;
                }
                
                Console.WriteLine("Enter the mark for course 1 (out of 100): ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the mark for course 2 (out of 100): ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the mark for course 3 (out of 100): ");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the mark for course 4 (out of 100): ");
                d = Convert.ToInt32(Console.ReadLine());

                final[i] = (a + b + c + d) / 4;

                if(final[i] >= 70)
                {
                    grade = "A";
                }
                else if(final[i] >= 60)
                {
                    grade = "B";
                }
                else if(final[i] >= 40)
                {
                    grade = "D";
                }
                else { grade = "F"; }

                /* -- Now we display all inputs together --*/

                Console.WriteLine("Student            Course 1     Course 2     Course 3     Course 4         Final   Grade");
                Console.WriteLine(ID + "          " + a + "           " + b + "           " + c + "           " + d + "               " + final[i] + "      " + grade);

                if (final[i] >= 60)
                {
                    passed++;
                    Console.WriteLine("Student " + ID + " moves on to the next semester.");
                }
                else
                {
                    failed++;
                    Console.WriteLine("Student " + ID + " doesn't move on to the next semester.");
                }
            }

            /* --- Here we show how many student will or will not move on to next semester and
             * who has the highest grade -- */

            float m = final.Max();
            int p = Array.IndexOf(final, m);

            Console.WriteLine("");
            Console.WriteLine("****************  Summary Report ****************");
            Console.WriteLine("");
            Console.WriteLine("Student with highest average was " + "ID" + " with an average of " + final[p]);
            Console.WriteLine("Number of students who are moving on: " + passed);
            Console.WriteLine("Number of students who are not moving on: " + failed);

        }
    }
}
