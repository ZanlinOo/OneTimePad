﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTimePadProgram
{
    public partial class MainFrom : Form
    {
        private OneTimePad pad;
        private string key;
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            pad = new OneTimePad();
            key = "";
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string textToEncrypt = enterText.Text;
            key = pad.GetKey(textToEncrypt);
            keyTextBox.Text = key;
            ResultingText.Text = pad.Encrypt(textToEncrypt, key);
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            string textToDecrypt = enterText.Text;
            key = keyTextBox.Text;
            ResultingText.Text = pad.Decrypt(textToDecrypt, key);
        }
    }
}
