using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc_2019_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stored way too much data, but I guess it works

            // orbit around checksum
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\William.000\Downloads\input-2019-6a.txt");
            //System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\Users\William.000\Downloads\foo.txt");
            Dictionary<String, List<String>> children = new Dictionary<string, List<String>>(); // map star to planets
            Dictionary<String, List<String>> centers = new Dictionary<string, List<String>>(); // map planet to star
            HashSet<string> all = new HashSet<string>();

            Dictionary<String, int> numThingsThisOrbits = new Dictionary<string, int>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var parts = line.Split(')');
                var first = parts[0];
                var second = parts[1];
                if (!children.Keys.Contains(first))
                {
                    children.Add(first, new List<string>());
                }
                if (!centers.Keys.Contains(second))
                {
                    centers.Add(second, new List<string>());
                }
                children[first].Add(second);
                centers[second].Add(first);

                if (!all.Contains(first))
                {
                    all.Add(first);
                }
                if (!all.Contains(second))
                {
                    all.Add(second);
                }
            }

            int num = 0;
            List<string> toexpand = new List<string>();
            foreach (string n in all)
            {
                if (!centers.Keys.Contains(n)) // n doesn't orbit anything, its a leaf.
                {
                    numThingsThisOrbits.Add(n, 0);
                    // Expand to children
                    toexpand.Add(n);
                }
            }

            while (toexpand.Count != 0)
            {
                var exp = toexpand[0];
                toexpand.RemoveAt(0);

                if (children.ContainsKey(exp))
                {
                    foreach (var child in children[exp])
                    {
                        numThingsThisOrbits.Add(child, 1+numThingsThisOrbits[exp]);
                        toexpand.Add(child);
                    }
                }
            }

            int answer = 0;
            foreach (var kv in numThingsThisOrbits)
            {
                answer += kv.Value;
            }
            Console.WriteLine(answer);

            // How many orbital transfers for YOU
            string you = "YOU";
            string san = "SAN";

            List<String> YouToCom = new List<string>();
            string cur = you;
            while (cur != "COM")
            {
                cur = centers[cur].First();
                YouToCom.Add(cur);
            }
            YouToCom.Reverse();
            List<String> SanToCom = new List<string>();
            cur = san;
            while (cur != "COM")
            {
                cur = centers[cur].First();
                SanToCom.Add(cur);
            }
            SanToCom.Reverse();

            int numSame = 0;
            for (int i = 0; i < YouToCom.Count && i < SanToCom.Count; ++i)
            {
                if (SanToCom[i] == YouToCom[i])
                {
                    numSame++;
                    Console.WriteLine("{0} {1}", SanToCom[i], YouToCom[i]);
                }
                else break;
            }

            int answer2 = YouToCom.Count + SanToCom.Count - numSame*2;
            Console.WriteLine(answer2);
        }
    }
}
