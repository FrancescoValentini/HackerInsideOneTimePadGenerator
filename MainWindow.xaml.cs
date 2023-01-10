using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HackerInsideOneTimePadGenerator {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnGeneraOTP_Click(object sender, RoutedEventArgs e) {
            txtbCPerRiga.Content = "0";
            txtbCPerBlocco.Content = "0";
            txtbCTotali.Content = "0";


            int lunghezzaRiga = Int32.Parse(txtbLunghezzaRiga.Text);
            int lunghezzaOTP = Int32.Parse(txtbLunghezzaOTP.Text);
            String separatore = txtbSeparatore.Text;
            int otpPerBlocco = Int32.Parse(txtbOTPPerBlocco.Text);
            int blocchi = Int32.Parse(txtbOTPDaGenerare.Text);




            if (cmbTipologia.SelectedIndex == 0) { //lettere
                setOTPText(
                    generateStringOTP(blocchi, lunghezzaOTP, otpPerBlocco, lunghezzaRiga, separatore)
                );
                int cPerRiga = lunghezzaRiga * lunghezzaOTP;
                int cPerBlocco = cPerRiga * otpPerBlocco;
                int cTotali = cPerBlocco * blocchi;
                txtbCPerRiga.Content = cPerRiga.ToString();
                txtbCPerBlocco.Content = cPerBlocco.ToString();
                txtbCTotali.Content = cTotali.ToString();


            } else if (cmbTipologia.SelectedIndex == 1) { //Numeri
                setOTPText(generateNumbersOTP(blocchi, lunghezzaOTP, otpPerBlocco, lunghezzaRiga, separatore));

            } else if (cmbTipologia.SelectedIndex == 2) { //Hex
                setOTPText(generateHexOTP(blocchi, lunghezzaOTP, otpPerBlocco, lunghezzaRiga, separatore));

            } else if (cmbTipologia.SelectedIndex == 3) { //KTC1400C

                setOTPText(DRYAD.generateKTC1400C(blocchi));


            } else if (cmbTipologia.SelectedIndex == 4) { //KTC1400D

                setOTPText(DRYAD.generateKTC1400D(blocchi));
    

            } else if (cmbTipologia.SelectedIndex == 5) { // Auth table

                setOTPText(AuthTable.getAuthTable(blocchi));
            } else if (cmbTipologia.SelectedIndex == 6) { // VLOTP

                setOTPText(VLOTP.getVLOTP(blocchi));
            }

        }

        public void setOTPText(string text) {
            txtbOTP.Document.Blocks.Clear();
            txtbOTP.Document.Blocks.Add(new Paragraph(new Run(text)));
        }



        public static string generateStringOTP(int blocchi, int lunghezzaOTP, int otpPerBlocco, int lunghezzaRiga, string separatore) {
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            for (int i = 0; i < blocchi; i++) {

                ris += "PAD: " + padID + "-" + i.ToString() + " \n";

                for (int k = 0; k < otpPerBlocco; k++) {
                    for (int j = 0; j < lunghezzaRiga; j++) {
                        ris += RandomUtils.RandomString(lunghezzaOTP);

                        if (j != lunghezzaRiga - 1)
                            ris += separatore;
                    }
                    ris += "\n";
                }

                ris += "\n";


            }
            return ris;
        }
        public static string generateNumbersOTP(int blocchi, int lunghezzaOTP, int otpPerBlocco, int lunghezzaRiga, string separatore) {
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            for (int i = 0; i < blocchi; i++) {

                ris += "PAD: " + padID + "-" + i.ToString() + " \n";

                for (int k = 0; k < otpPerBlocco; k++) {
                    for (int j = 0; j < lunghezzaRiga; j++) {
                        ris += RandomUtils.RandomNumSequence(lunghezzaOTP);

                        if (j != lunghezzaRiga - 1)
                            ris += separatore;
                    }
                    ris += "\n";
                }

                ris += "\n";


            }
            return ris;
        }
        public static string generateHexOTP(int blocchi, int lunghezzaOTP, int otpPerBlocco, int lunghezzaRiga, string separatore) {
            string ris = "";
            string padID = RandomUtils.RandomString(5);
            for (int i = 0; i < blocchi; i++) {

                ris += "PAD: " + padID + "-" + i.ToString() + " \n";

                for (int k = 0; k < otpPerBlocco; k++) {
                    for (int j = 0; j < lunghezzaRiga; j++) {
                        ris += RandomUtils.RandomHexSequence(lunghezzaOTP);

                        if (j != lunghezzaRiga - 1)
                            ris += separatore;
                    }
                    ris += "\n";
                }

                ris += "\n";


            }
            return ris;
        }

        private void cmbTipologia_DropDownClosed(object sender, EventArgs e) {
            if (cmbTipologia.SelectedIndex == 3 || cmbTipologia.SelectedIndex == 4 || cmbTipologia.SelectedIndex == 5 || cmbTipologia.SelectedIndex == 6) {
                txtbLunghezzaRiga.IsEnabled = false;
                txtbLunghezzaOTP.IsEnabled = false;
                txtbSeparatore.IsEnabled = false;
                txtbOTPPerBlocco.IsEnabled = false;
            
            }
            else {
                txtbLunghezzaRiga.IsEnabled = true;
                txtbLunghezzaOTP.IsEnabled = true;
                txtbSeparatore.IsEnabled = true;
                txtbOTPPerBlocco.IsEnabled = true;
                txtbOTPDaGenerare.IsEnabled = true;
            }
            
        }
    }
}
