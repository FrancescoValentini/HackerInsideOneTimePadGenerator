using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerInsideOneTimePadGenerator {
    public class VLOTP {
        public static string getVLOTP(int blocchi) {
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < blocchi; i++) {
                ris += "PAD: " + padID + "-" + i.ToString() + " \n";
                ris += "  ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "\n";
                for (int j = 0; j < 26; j++) {
                    ris += alpha[j] + " " + RandomUtils.getRandomUniqueString(26, "") + "\n";
                }
                ris += "\n";
            }
            return ris;
        }
    }
}
