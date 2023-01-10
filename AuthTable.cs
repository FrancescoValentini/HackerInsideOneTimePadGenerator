using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerInsideOneTimePadGenerator {
    public class AuthTable {
        public static string getAuthTable(int blocchi) { // Implementare contatore
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int cnt = 0;
            string cntStr = "";
            int min = 0, max = 10;


            for (int i = 0; i < blocchi; i++) {
                min = 0;
                max = 10;
                ris += "PAD: " + padID + "-" + i.ToString() + " \n";

                for (int j = 0; j < 20; j++) {


                    for (int k = 0; k < 10; k++) {
                        if (k == 0 && cnt == 0) {
                            ris += createCounterString(min, max) + "\n";
                            min = max;
                            max += 10;
                        }
                        ris += RandomUtils.getRandomUniqueString(2, "") + " ";
                    }
                    ris += "\n";
                    cnt++;
                    if (cnt == 5) { // Spezza ogni 5 righe
                        ris += "\n\n";
                        cnt = 0;
                    }
                }
            }
            return ris;
        }

        public static string createCounterString(int min, int max) {
            string str = "";
            int cnt = min;
            while (cnt < max) {
                if (cnt < 10)
                    str += "0" + cnt + "  ";
                else
                    str += cnt + "  ";
                cnt++;
            }
            return str;
        }

    }
}
