using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace advent_of_code_2019_5
{
    class Program
    {
        static int Input()
        {
            return int.Parse(Console.ReadLine());
            //return 0;
        }

        static void Output(int num)
        {
            //if (num == 0) <- this was dumb... the answer was not 0.
            {
                Console.WriteLine(num);
            }
            int x = 5;
        }

        static void Main(string[] args)
        {
            int add = 1;
            int multiply = 2;
            int input = 3;
            int output = 4;
            int jump_if_true = 5;
            int jump_if_false = 6;
            int less_than = 7;
            int equals = 8;
            int done = 99;

            var line = "3,225,1,225,6,6,1100,1,238,225,104,0,1,192,154,224,101,-161,224,224,4,224,102,8,223,223,101,5,224,224,1,223,224,223,1001,157,48,224,1001,224,-61,224,4,224,102,8,223,223,101,2,224,224,1,223,224,223,1102,15,28,225,1002,162,75,224,1001,224,-600,224,4,224,1002,223,8,223,1001,224,1,224,1,224,223,223,102,32,57,224,1001,224,-480,224,4,224,102,8,223,223,101,1,224,224,1,224,223,223,1101,6,23,225,1102,15,70,224,1001,224,-1050,224,4,224,1002,223,8,223,101,5,224,224,1,224,223,223,101,53,196,224,1001,224,-63,224,4,224,102,8,223,223,1001,224,3,224,1,224,223,223,1101,64,94,225,1102,13,23,225,1101,41,8,225,2,105,187,224,1001,224,-60,224,4,224,1002,223,8,223,101,6,224,224,1,224,223,223,1101,10,23,225,1101,16,67,225,1101,58,10,225,1101,25,34,224,1001,224,-59,224,4,224,1002,223,8,223,1001,224,3,224,1,223,224,223,4,223,99,0,0,0,677,0,0,0,0,0,0,0,0,0,0,0,1105,0,99999,1105,227,247,1105,1,99999,1005,227,99999,1005,0,256,1105,1,99999,1106,227,99999,1106,0,265,1105,1,99999,1006,0,99999,1006,227,274,1105,1,99999,1105,1,280,1105,1,99999,1,225,225,225,1101,294,0,0,105,1,0,1105,1,99999,1106,0,300,1105,1,99999,1,225,225,225,1101,314,0,0,106,0,0,1105,1,99999,1108,226,226,224,102,2,223,223,1005,224,329,101,1,223,223,107,226,226,224,1002,223,2,223,1005,224,344,1001,223,1,223,107,677,226,224,102,2,223,223,1005,224,359,101,1,223,223,7,677,226,224,102,2,223,223,1005,224,374,101,1,223,223,108,226,226,224,102,2,223,223,1006,224,389,101,1,223,223,1007,677,677,224,102,2,223,223,1005,224,404,101,1,223,223,7,226,677,224,102,2,223,223,1006,224,419,101,1,223,223,1107,226,677,224,1002,223,2,223,1005,224,434,1001,223,1,223,1108,226,677,224,102,2,223,223,1005,224,449,101,1,223,223,108,226,677,224,102,2,223,223,1005,224,464,1001,223,1,223,8,226,677,224,1002,223,2,223,1005,224,479,1001,223,1,223,1007,226,226,224,102,2,223,223,1006,224,494,101,1,223,223,1008,226,677,224,102,2,223,223,1006,224,509,101,1,223,223,1107,677,226,224,1002,223,2,223,1006,224,524,1001,223,1,223,108,677,677,224,1002,223,2,223,1005,224,539,1001,223,1,223,1107,226,226,224,1002,223,2,223,1006,224,554,1001,223,1,223,7,226,226,224,1002,223,2,223,1006,224,569,1001,223,1,223,8,677,226,224,102,2,223,223,1006,224,584,101,1,223,223,1008,677,677,224,102,2,223,223,1005,224,599,101,1,223,223,1007,226,677,224,1002,223,2,223,1006,224,614,1001,223,1,223,8,677,677,224,1002,223,2,223,1005,224,629,101,1,223,223,107,677,677,224,102,2,223,223,1005,224,644,101,1,223,223,1108,677,226,224,102,2,223,223,1005,224,659,101,1,223,223,1008,226,226,224,102,2,223,223,1006,224,674,1001,223,1,223,4,223,99,226";
            //var line = "3,12,6,12,15,1,13,14,13,4,13,99,-1,0,1,9";
            //var line = "3,21,1008,21,8,20,1005,20,22,107,8,21,20,1006,20,31,1106,0,36,98,0,0,1002,21,125,20,4,20,1105,1,46,104,999,1105,1,46,1101,1000,1,20,4,20,1105,1,46,98,99";

            var nums_as_string = line.Split(',');
            int[] prog = new int[nums_as_string.Length];

            //for (int noun = 0; noun < 100; ++noun)
            {
                //for (int verb = 0; verb < 100; ++verb)
                {

                    for (int i = 0; i < nums_as_string.Length; ++i)
                    {
                        prog[i] = int.Parse(nums_as_string[i]);
                    }

                    //prog[1] = noun;
                    //prog[2] = verb;

                    for (int i = 0; i < nums_as_string.Length; )
                    {
                        int inst = prog[i];
                        int modes = inst / 100;

                        bool first_immediate = modes % 10 != 0;
                        bool second_immediate = (modes / 10) % 10 != 0;
                        bool third_immediate = (modes / 100) % 10 != 0;

                        inst = inst % 100;
                        if (inst == add)
                        {
                            Console.WriteLine("{0}: {1} {2} {3} {4}", i, prog[i], prog[i + 1], prog[i + 2], prog[i + 3]);
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            int arg2 = second_immediate ? prog[i + 2] : prog[prog[i + 2]];

                            Console.WriteLine("  Add: {0}: {1}-{2}, {3}-{4}", prog[i], arg1, first_immediate, arg2, second_immediate);

                            if (third_immediate)
                            {
                                int x = 5;
                            }

                            prog[prog[i + 3]] = arg1 + arg2;
                            i += 4;
                        }
                        else if (inst == multiply)
                        {
                            Console.WriteLine("{0}: {1} {2} {3} {4}", i, prog[i], prog[i + 1], prog[i + 2], prog[i + 3]);
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            int arg2 = second_immediate ? prog[i + 2] : prog[prog[i + 2]];

                            Console.WriteLine("  Multiply: {0}: {1}-{2}, {3}-{4}", prog[i], arg1, first_immediate, arg2, second_immediate);

                            if (third_immediate)
                            {
                                int x = 5;
                            }
                            prog[prog[i + 3]] = arg1 * arg2;
                            i += 4;
                        }
                        else if (inst == input)
                        {
                            Console.WriteLine("{0}: {1} {2}", i, prog[i], prog[i + 1]);
                            Console.WriteLine("  Input: {0}: {1}", prog[i], prog[i + 1]);
                            prog[prog[i + 1]] = Input();
                            if (first_immediate)
                            {
                                int x = 5;
                            }
                            i += 2;
                        }
                        else if (inst == output)
                        {
                            Console.WriteLine("{0}: {1} {2}", i, prog[i], prog[i + 1]);
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            Console.WriteLine("  Output: {0}: {1}-{2}", prog[i], arg1, first_immediate);
                            Output(arg1);
                            i += 2;
                        }
                        else if (inst == jump_if_true)
                        {
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            int arg2 = second_immediate ? prog[i + 2] : prog[prog[i + 2]];
                            if (arg1 != 0)
                            {
                                i = arg2;
                                continue;
                            }

                            i += 3;
                        }
                        else if (inst == jump_if_false)
                        {
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            int arg2 = second_immediate ? prog[i + 2] : prog[prog[i + 2]];
                            if (arg1 == 0)
                            {
                                i = arg2;
                                continue;
                            }
                            i += 3;
                        }
                        else if (inst == less_than)
                        {
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            int arg2 = second_immediate ? prog[i + 2] : prog[prog[i + 2]];
                            prog[prog[i + 3]] = (arg1 < arg2) ? 1 : 0;
                            i += 4;
                        }
                        else if (inst == equals)
                        {
                            int arg1 = first_immediate ? prog[i + 1] : prog[prog[i + 1]];
                            int arg2 = second_immediate ? prog[i + 2] : prog[prog[i + 2]];
                            prog[prog[i + 3]] = (arg1 == arg2) ? 1 : 0;
                            i += 4;
                        }
                        else if (inst == done)
                        {
                            Console.WriteLine("{0}: {1}", i, prog[i]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("what?");
                        }
                    }
                    //if (prog[0] == 19690720)
                    //{
                    //    int x = prog[0];
                    //    int y = 100 * noun + verb;
                    //    Console.WriteLine(x);
                    //}
                }
            }
        }
    }
}
