using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HackerInsideOneTimePadGenerator {
    public class RandomUtils {
        public static string getRandomUniqueString(int length, string spacer) {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] uintBuffer = new byte[sizeof(uint)];
                char lettera;

                while (length > 0) {
                    do {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        lettera = valid[(int)(num % (uint)valid.Length)];
                        if (!res.ToString().Contains(lettera)) {
                            res.Append(lettera);
                            res.Append(spacer);
                            length--;
                        }
                        if (length == 0)
                            break;
                        //MessageBox.Show(length.ToString() + " " + res.ToString());
                    } while (res.ToString().Contains(lettera));
                }

                res.Append(" ");

                return res.ToString();
            }
        }

        public static string getRandomUniqueString(int length, StringBuilder res) {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXY";
            StringBuilder res1 = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {

                byte[] uintBuffer = new byte[sizeof(uint)];
                char lettera;

                while (length > 0) {
                    do {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        lettera = valid[(int)(num % (uint)valid.Length)];
                        if (!res.ToString().Contains(lettera) && !res1.ToString().Contains(lettera)) {
                            res1.Append(lettera);
                            length--;
                        }
                        if (length == 0)
                            break;
                        //MessageBox.Show(length.ToString() + " " + res.ToString());
                    } while (res.ToString().Contains(lettera) && res1.ToString().Contains(lettera));
                }

                res1.Append(" ");

                return res1.ToString();
            }
        }

        public static string RandomNumSequence(int length) {
            const string valid = "1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0) {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        public static string RandomHexSequence(int length) {
            const string valid = "123456789ABCDEF";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0) {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }

        public static string RandomString(int length) {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0) {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
    }
}
