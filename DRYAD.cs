using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerInsideOneTimePadGenerator {
    public class DRYAD {
        public static string generateKTC1400C(int blocchi) {
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < blocchi; i++) {

                ris += "PAD: " + padID + "-" + i.ToString() + " \n";

                ris += "   ";

                ris += 0 + "    "; //ok
                ris += 1 + "   ";
                ris += 2 + "  ";
                ris += 3 + "  ";
                ris += 4 + "   ";
                ris += 5 + "  ";
                ris += 6 + "  ";
                ris += 7 + "  ";
                ris += 8 + "  ";
                ris += 9 + "";

                ris += "\n";

                for (int k = 0; k < 25; k++) {

                    ris += alpha[k] + " ";

                    ris += RandomDRYADString();



                    ris += "\n";
                }

                ris += "\n";


            }
            return ris;
        }

        static string RandomDRYADString() {
            int length = 0;
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXY";
            StringBuilder res = new StringBuilder();
            
                byte[] uintBuffer = new byte[sizeof(uint)];
                char lettera;
                res.Append(RandomUtils.getRandomUniqueString(4, res));  // Prima colonna 4 lettere
                res.Append(RandomUtils.getRandomUniqueString(3, res));  // Seconda colonna 3 lettere
                res.Append(RandomUtils.getRandomUniqueString(3, res)); // Terza colonna 3 lettere
                res.Append(RandomUtils.getRandomUniqueString(2, res)); // Quarta colonna 2 lettere
                res.Append(RandomUtils.getRandomUniqueString(2, res)); // Quinta colonna 2 lettere
                res.Append(RandomUtils.getRandomUniqueString(3, res)); // sesta colonna 3 lettere
                res.Append(RandomUtils.getRandomUniqueString(2, res)); // Settima colonna 3 lettere
                res.Append(RandomUtils.getRandomUniqueString(2, res)); // Ottava colonna 2 lettere
                res.Append(RandomUtils.getRandomUniqueString(2, res)); // Nona colonna 2 lettere
                res.Append(RandomUtils.getRandomUniqueString(2, res)); // Decima colonna 2 lettere

            return res.ToString();
        }

        public static string generateKTC1400D(int blocchi) {
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < blocchi; i++) {

                ris += "PAD: " + padID + "-" + i.ToString() + " \n";

                ris = formatDRYAD(ris);

                for (int k = 0; k < 25; k++) {

                    ris += alpha[k] + " ";

                    ris += RandomDRYADString();

                    ris += "\n";

                    if (k == 5 || k == 11 || k == 17) {
                        ris += "\n";
                        ris = formatDRYAD(ris);
                    }

                }

                ris += "\n";


            }
            return ris;
        }

        public static string formatDRYAD(string ris) {
            ris += "   ";

            ris += "ABC DEF GHJ KL MN PQR ST UV WX YZ\n";

            ris += "   ";

            ris += 0 + "    "; //ok
            ris += 1 + "   ";
            ris += 2 + "  ";
            ris += 3 + "  ";
            ris += 4 + "   ";
            ris += 5 + "  ";
            ris += 6 + "  ";
            ris += 7 + "  ";
            ris += 8 + "  ";
            ris += 9 + "";

            ris += "\n";
            return ris;
        }
    }

}
