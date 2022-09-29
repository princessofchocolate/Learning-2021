using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOps {
    public class StrOps {

        public int IndexOf(string input, string target) {
            if (string.IsNullOrEmpty(input))
                return -1;
            if (string.IsNullOrEmpty(target))
                return -1;

            if (target.Length > input.Length) {
                return -1;
            }

            for (int i = 0; i < input.Length; i++) {
                bool isOk = true;
                for (int j = 0; j < target.Length; j++) {
                    if (i + j >= input.Length) {
                        isOk = false;
                        break;
                    }
                    if (target[j] != input[i + j]) {
                        isOk = false;
                        break;
                    }
                }
                if (isOk) {
                    return i;
                }
            }
            return -1;
        }
        public string SubString(string input, int startIndex, int length) {
            if (string.IsNullOrEmpty(input))
                return null;
            if (length == 0) {
                return "";
            }
            if (length > input.Length) {
                return null;
            }
            if (startIndex >= input.Length) {
                return null;
            }

            if (input.Length < startIndex + length) {
                return null;
            }
            char[] substring = new char[length];
            for (int i = startIndex; i < startIndex + length; i++) {

                substring[i - startIndex] = input[i];
            }

            return new string(substring);
        }
        public string Reverse(string input) {
            if (string.IsNullOrEmpty(input))
                return "";
            char[] temp = input.ToCharArray();
            int len = input.Length;
            for (int i = 0; i < input.Length; i++) {

                temp[len - 1 - i] = input[i];
            }

            return new string(temp);
        }
        public int WordCount(string input) {

            //examples:
            //abc, def : 2
            //12,3 4a!: 2
            //: 0
            //         :0
            //abc    def  weds: 3
            //   a b c d :4 
            if (input == null) {
                return 0;
            }

            char[] inchar = input.ToCharArray();
            int wordCount = 0;
            bool inword = false;
            int i = 0;

            if (inchar.Length == 0) {
                return 0;
            }
            while (i < inchar.Length) {
                if (inchar[i] != ' ') {
                    if (inword == false) {
                        wordCount++;
                        inword = true;
                    }
                } else {
                    inword = false;
                }
                i++;
            }
            return wordCount;
        }
        public bool IsPalindrom(string input) {
            if (string.IsNullOrEmpty(input)) {
                return false;
            }
            int j = ((input.Length) - 1);
            for (int i = 0; j > i; i++, j--) {
                if (input[i] != input[j]) {
                    return false;
                }
                //j--; --> double increment decrement in for statement
            }
            return true;
        }

        string skipChars = " .,'\":;-_<>!?*\\/&()+{}[]^=$€%#";
        public bool IsPalindromIgnorePuncs(string input) {
            if (string.IsNullOrEmpty(input)) {
                return false;
            }
            string lowerInput = input.ToLower();//quick and dirty
            int i = 0;
            int j = ((lowerInput.Length) - 1);
            while (j > i) {
                while (skipChars.Contains(input[i])) {
                    i++;
                }
                while (skipChars.Contains(input[j])) {
                    j--;
                }
                if (j <= i) {
                    return true;
                }
                if (lowerInput[i] != lowerInput[j]) {
                    return false;
                }
                i++;
                j--;
            }
            /*
            for (int i = 0; j > i; i++, j--) {
                while (skipChars.Contains(input[i])) {
                    i++;
                }
                while (skipChars.Contains(input[j])) {
                    j--;
                }
                if (j <= i) {
                    return true;
                }
                if (lowerInput[i] != lowerInput[j]) {
                    return false;
                }
            }
            */
            return true;
        }

    }
}
