using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Email_Auth.PLL
{
    public partial class MainForm : Form
    {
        private static int minPrimeValue = 1000;
        private static int maxPrimeValue = 9999;

        byte[] Sk;
        string FilePath;
        public MainForm()
        {
            InitializeComponent();
            Sk = new byte[64];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            var input = File.ReadAllText(openFileDialog.FileName);
            this.textBox1.Text = input;
            FilePath = openFileDialog.FileName;
        }

 

        private void GetSecretKeyBtn_Click(object sender, EventArgs e)
        {
            Sk= BLL.hash.HashFunction.GetSecretKey();
            for (int i =0;i< Sk.Length; i++)
            {
                SecritKayTxt.Text += Sk[i].ToString();
            }
             
        }

        private void HashBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                Byte[] keyBytes = encoder.GetBytes(SecritKayTxt.Text);

                TxtHash.Text = BLL.hash.HashFunction.Hash(FilePath, keyBytes);
                MessageBox.Show("The hash value has been calculated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void generatePrimes()
        {
            Random random = new Random();
            int p, q;
            p = BLL.RSA.RandomPrimeGenerator.generate(minPrimeValue, maxPrimeValue, random);
            do
            {
                q = BLL.RSA.RandomPrimeGenerator.generate(minPrimeValue, maxPrimeValue, random);
            } while (p == q);


            pTextBox.Text = p.ToString();
            qTextBox.Text = q.ToString();
        }

        private void BtnKeuGen_Click(object sender, EventArgs e)
        {
            generatePrimes();

        }

        private void Btnkeys_Click(object sender, EventArgs e)
        {
            if (validatePQ())
            {
                generateKeys();
            }
        }
        private bool validatePQ()
        {
            if (validateParameter(pTextBox.Text, "p"))
                return validateParameter(qTextBox.Text, "q");
            return false;
        }

        private bool validateParameter(String data, String parameterName)
        {
            if (data.Length == 0)
            {
                MessageBox.Show("Field '" + parameterName + "'cannot be empty.");
                return false;
            }
            else
            {
                int parameter;
                bool result = Int32.TryParse(data, out parameter);
                if (!result)
                {
                    MessageBox.Show("Field '" + parameterName + "' can only contain numbers.");
                    return false;
                }
            }
            return true;
        }

        private void generateKeys()
        {
            int p = Int32.Parse(pTextBox.Text);
            int q = Int32.Parse(qTextBox.Text);
            BLL.RSA.PrivatePublicKey keys = BLL.RSA.KeyGenerator.generate(p, q);

            nTextBox.Text = keys.PrivateKey.n.ToString();
            eTextBox.Text = keys.PublicKey.key.ToString();
            dTextBox.Text = keys.PrivateKey.key.ToString();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            enableButtons(false);

            try
            {
                if (validateRawData() && validatePublicKey())
                {
                    //String encryptedString = encryptMethod(rawTextBox.Text);
                    //encryptedString = Convert.ToBase64String(BitConverter.GetBytes(Convert.ToInt64(encryptedString)));
                    //var EncBytes = System.Text.Encoding.UTF8.GetBytes(encryptedString);
                    //encryptedTextBox.Text = System.Convert.ToBase64String(EncBytes);
                    //encryptedTextBox.Text = encryptMethod(rawTextBox.Text);

                    String encryptedString = encryptMethod(rawTextBox.Text);
                    encryptedTextBox.Text = encryptedString;

                }
            }
            catch (Exception ex)
            {
                String message = "Error occured:" + Environment.NewLine + ex.Message;
                MessageBox.Show(message);
            }

            enableButtons(true);
        }
        private void enableButtons(bool state)
        {
            encryptButton.Enabled = state;
            decryptButton.Enabled = state;
        }

        private bool validateRawData()
        {
            String rawData = rawTextBox.Text;
            if (rawData.Length == 0)
            {
                MessageBox.Show("The input data field cannot be empty.");
                return false;
            }
            return true;
        }
        private bool validatePublicKey()
        {
            if (validateParameter(nTextBox.Text, "n"))
                return validateParameter(eTextBox.Text, "q");
            return false;
        }

        private String encryptMethod(String data)
        {
            BLL.RSA.Key publicKey = generatePublicKey();
            List<CarlJohansen.BigInt> arr = BLL.RSA.Encryptor.encrypt(publicKey, data);

            String s = "";

            if (arr.Count > 0)
            {
                s += arr[0].ToString();
                for (int i = 1; i < arr.Count; i++)
                {
                    s += Environment.NewLine;
                    s += arr[i].ToString();
                }
            }
            return s;
        }

        private String signingMethod(String data)
        {
            BLL.RSA.Key publicKey = generatePrivateKey();
            List<CarlJohansen.BigInt> arr = BLL.RSA.Encryptor.encrypt(publicKey, data);

            String s = "";

            if (arr.Count > 0)
            {
                s += arr[0].ToString();
                for (int i = 1; i < arr.Count; i++)
                {
                    s += Environment.NewLine;
                    s += arr[i].ToString();
                }
            }
            return s;
        }


        private BLL.RSA.Key generatePublicKey()
        {
            BLL.RSA.Key k = new BLL.RSA.Key();
            k.key = Int32.Parse(eTextBox.Text);
            k.n = Int32.Parse(nTextBox.Text);
            return k;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            enableButtons(false);

            try
            {
                if (validateEncryptedData() && validatePrivateKey())
                {
                    BLL.RSA.Key privateKey = generatePrivateKey();
                    List<CarlJohansen.BigInt> ints = parseBigIntegers();
                    String decrypted = BLL.RSA.Decryptor.decrypt(ints, privateKey);
                    decryptedTextBox.Text = decrypted;
                }
            }
            catch (Exception ex)
            {
                String message = "Error occured:" + Environment.NewLine + ex.Message;
                //MessageBox.Show(System.Environment.StackTrace);
                MessageBox.Show(message);
            }

            enableButtons(true);
        }

        private List<CarlJohansen.BigInt> parseBigIntegers()
        {
            List<CarlJohansen.BigInt> ints = new List<CarlJohansen.BigInt>();
            string[] separators = { Environment.NewLine };
            string[] strings = encryptedTextBox.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strings)
            {
                try
                {
                    CarlJohansen.BigInt result = s;
                    ints.Add(result);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error parsing data: " + ex.Message);
                }
            }
            return ints;
        }

        private List<CarlJohansen.BigInt> parseBigSignedIntegers()
        {
            List<CarlJohansen.BigInt> ints = new List<CarlJohansen.BigInt>();
            string[] separators = { Environment.NewLine };
            string[] strings = TxtSigned.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strings)
            {
                try
                {
                    CarlJohansen.BigInt result = s;
                    ints.Add(result);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error parsing data: " + ex.Message);
                }
            }
            return ints;
        }
        private BLL.RSA.Key generatePrivateKey()
        {
            BLL.RSA.Key k = new BLL.RSA.Key();
            k.key = Int32.Parse(dTextBox.Text);
            k.n = Int32.Parse(nTextBox.Text);
            return k;
        }

        private bool validateEncryptedData()
        {
            String rawData = encryptedTextBox.Text;
            if (rawData.Length == 0)
            {
                MessageBox.Show("The encrypted data field cannot be empty.");
                return false;
            }
            return true;
        }

        private bool validatePrivateKey()
        {
            if (validateParameter(nTextBox.Text, "n"))
                return validateParameter(dTextBox.Text, "d");
            return false;
        }

        private void BtnSigning_Click(object sender, EventArgs e)
        {
            enableButtons(false);

            try
            {
                if (validateRawData() && validatePrivateKey())
                {
                    String encryptedString = signingMethod(rawTextBox.Text);
                    //encryptedString = Convert.ToBase64String(BitConverter.GetBytes(Convert.ToInt64(encryptedString)));
                    //var EncBytes = System.Text.Encoding.UTF8.GetBytes(encryptedString);
                    TxtSigned.Text = encryptedString;
                }
            }
            catch (Exception ex)
            {
                String message = "Error occured:" + Environment.NewLine + ex.Message;
                MessageBox.Show(message);
            }

            enableButtons(true);
        }

        private void BtnVerifySigning_Click(object sender, EventArgs e)
        {
            enableButtons(false);

            try
            {
                if ( validatePublicKey())
                {
                    BLL.RSA.Key privateKey = generatePublicKey();
                    List<CarlJohansen.BigInt> ints = parseBigSignedIntegers();
                    String decrypted = BLL.RSA.Decryptor.decrypt(ints, privateKey);
                    SignedTxtDecipher.Text = decrypted;
                }
            }
            catch (Exception ex)
            {
                String message = "Error occured:" + Environment.NewLine + ex.Message;
                MessageBox.Show(message);
            }

            enableButtons(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( TxtHash.Text == decryptedTextBox.Text)
            {
                MessageBox.Show( "Message accepted","Hash value", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show( "Message rejected","Hash value", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void decryptedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
