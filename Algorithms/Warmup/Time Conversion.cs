using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
        string[] timeArr = s.Split(':');
        string AMPM = timeArr[2].Substring(2);
        string hh = "";
        if(AMPM.Contains("PM"))
        {
            if (timeArr[0] == "12")
                hh = "12";
            else if (Convert.ToInt16(timeArr[0]) +12 == 24)
                hh = "00";
            else
                hh = (Convert.ToInt16(timeArr[0])+12).ToString();
        }
        else if(AMPM.Contains("AM"))
        {
            if(timeArr[0] == "12")
                hh = "00";
            else
                hh = timeArr[0];
        }
        return string.Concat(hh,":", timeArr[1], ":", timeArr[2].Substring(0,2));
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}