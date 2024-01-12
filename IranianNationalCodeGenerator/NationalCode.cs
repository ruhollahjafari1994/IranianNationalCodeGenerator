using System;

namespace IranianNationalCodeGenerator
{
    public static class NationalCode
    {
        public static string Generator()
        {
            int[] list = new int[10];
            int sum = 0;

            for (int i = 10; i > 1; i--)
            {
                int j = new Random().Next(10);
                list[10 - i] = j;
                sum += j * i;
            }

            int s = sum % 11;
            if (s < 2)
            {
                list[9] = s;
            }
            else if (s >= 2)
            {
                list[9] = 11 - s;
            }

            return string.Join("", list);
        }

        public static string RoundGenerator()
        {
            int[] list = new int[10];
            int sum = 0;
            int j = 10;

            for (int i = 10; i > 1; i--)
            {
                j = new Random().Next(j < 2 ? 2 : j);
                list[10 - i] = j;
                sum += j * i;
            }

            int s = sum % 11;
            if (s < 2)
            {
                list[9] = s;
            }
            else if (s >= 2)
            {
                list[9] = 11 - s;
            }

            if (Array.TrueForAll(list, item => item == list[0]))
            {
                return RoundGenerator();
            }

            return string.Join("", list);
        }

        public static bool Validator(string val)
        {
            string[] allDigitEqual =
            {
                "0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666",
                "7777777777", "8888888888", "9999999999"
            };
            string codeMelliPattern = "^([0-9]{10})+$";

            if (Array.Exists(allDigitEqual, item => item == val) ||
                !System.Text.RegularExpressions.Regex.IsMatch(val, codeMelliPattern))
            {
                return false;
            }

            char[] chArray = val.ToCharArray();
            int num0 = int.Parse(chArray[0].ToString()) * 10;
            int num2 = int.Parse(chArray[1].ToString()) * 9;
            int num3 = int.Parse(chArray[2].ToString()) * 8;
            int num4 = int.Parse(chArray[3].ToString()) * 7;
            int num5 = int.Parse(chArray[4].ToString()) * 6;
            int num6 = int.Parse(chArray[5].ToString()) * 5;
            int num7 = int.Parse(chArray[6].ToString()) * 4;
            int num8 = int.Parse(chArray[7].ToString()) * 3;
            int num9 = int.Parse(chArray[8].ToString()) * 2;
            int a = int.Parse(chArray[9].ToString());
            int b = num0 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9;
            int c = b % 11;

            return ((c < 2 && a == c) || (c >= 2 && (11 - c) == a));
        }
    }
}