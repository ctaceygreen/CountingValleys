using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int seaLevel = 0;
        int numberOfValleys = 0;
        bool currentlyInValley = false;
        for(int charIndex = 0; charIndex < n; charIndex++)
        {
            char upDown = s[charIndex];
            if(upDown == 'U')
            {
                //Up
                seaLevel++;
                if(currentlyInValley && seaLevel == 0)
                {
                    currentlyInValley = false;
                    numberOfValleys++;
                }
            }
            else if(upDown == 'D')
            {
                if(seaLevel == 0)
                {
                    currentlyInValley = true;
                }
                seaLevel--;
            }
            else
            {
                return numberOfValleys;
            }
        }
        return numberOfValleys;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
