using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace EncriptarDesencriptar
{
    public partial class FormEncriptador : Form
    {
        //////////////////////////////////////////// ATENÇÃO ! ! ! ////////////////////////////////////////////
        /*Possíveis vulnerabilidades:
            1. A chave de encriptação é fixa e incorporada diretamente no código-fonte; 
            2. O IV (Initialization Vector) também é fixo, o que pode comprometer a segurança;*/
        //////////////////////////////////////////// ATENÇÃO ! ! ! ////////////////////////////////////////////

        public FormEncriptador()
        {
            InitializeComponent();

            btnDesencriptar.Enabled = false;
        }

        private void FormEncriptador_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////
        }

        // Chave AES (Advanced Encryption Standard) gerada aleatoriamente.
        private static readonly byte[] EncryptionKey = new byte[] {
            0x7D, 0x43, 0xF5, 0x0A, 0x31, 0x81, 0x6E, 0x94,
            0xA9, 0x22, 0x6F, 0xCD, 0x57, 0xE8, 0x9B, 0x0C,
            0x42, 0x39, 0x72, 0x2F, 0x5E, 0x0D, 0x4B, 0x1A,
            0x63, 0xB8, 0xD4, 0xE2, 0xF9, 0x8E, 0x1D, 0x75
        };

        // Método para Encriptação da senha.
        public static string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = EncryptionKey;
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                        csEncrypt.FlushFinalBlock();
                    }

                    byte[] encryptedBytes = msEncrypt.ToArray();
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        // Método para Desencriptação da senha.
        public static string Decrypt(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = EncryptionKey;
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        // Botão Encriptar.
        private void btnEncriptacao_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != "" && txbSenha.Text != null)
            {
                string senha = txbSenha.Text;
                string senhaCriptografada = Encrypt(senha);

                txbEncriptacao.Text = senhaCriptografada;

                btnDesencriptar.Enabled = true;
            }
        }

        // Botão Desencriptar.
        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (txbEncriptacao.Text != "" && txbEncriptacao.Text != null)
            {
                string senhaCriptografada = txbEncriptacao.Text;
                string senhaDescriptografada = Decrypt(senhaCriptografada);

                txbDesencriptacao.Text = senhaDescriptografada;

                btnEncriptacao.Enabled = false;
            }
        }

        // Botão Limpar.
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbSenha.Clear();
            txbEncriptacao.Clear();
            txbDesencriptacao.Clear();

            btnEncriptacao.Enabled = true;
            btnDesencriptar.Enabled = false;
        }
    }
}
