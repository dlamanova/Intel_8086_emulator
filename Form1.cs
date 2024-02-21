using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Intel_8086_emulator
{
    public partial class Form1 : Form
    {
        private RegisterManager registerManager;

        public Form1()
        {
            InitializeComponent();
            registerManager = new RegisterManager();

            SetDefaultRegisterValues();
        }

        private void SetDefaultRegisterValues()
        {
            ah.Text = "00";
            bh.Text = "00";
            ch.Text = "00";
            dh.Text = "00";
            al.Text = "00";
            bl.Text = "00";
            cl.Text = "00";
            dl.Text = "00";
        }

        private bool IsValidRegisterValue(string value)
        {
            int intValue;
            return int.TryParse(value, System.Globalization.NumberStyles.HexNumber, null, out intValue) && intValue >= 0 && intValue <= 255;
        }

        private bool AreValidRegisterValues()
        {
            return IsValidRegisterValue(ah.Text) && IsValidRegisterValue(bh.Text) &&
                   IsValidRegisterValue(ch.Text) && IsValidRegisterValue(dh.Text) &&
                   IsValidRegisterValue(al.Text) && IsValidRegisterValue(bl.Text) &&
                   IsValidRegisterValue(cl.Text) && IsValidRegisterValue(dl.Text);
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            string command = OperationComboBox.SelectedItem as string;
            string register1 = FirstValComboBox.SelectedItem as string;
            string register2 = SecondValComboBox.SelectedItem as string;

            if (command == null || register1 == null || register2 == null)
            {
                MessageBox.Show("Wybierz operację i rejestry!");
                return;
            }

            if (!AreValidRegisterValues())
            {
                MessageBox.Show("Wprowadź poprawne wartości do rejestrów!");
                return;
            }

            try
            {
                SetRegisterValues();
                registerManager.ExecuteCommand(command, register1, register2);
                UpdateRegisterValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            RandomizeRegisters();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SetDefaultRegisterValues();
        }
        private void SetRegisterValues()
        {
            registerManager.SetRegisterValue("AH", ah.Text);
            registerManager.SetRegisterValue("BH", bh.Text);
            registerManager.SetRegisterValue("CH", ch.Text);
            registerManager.SetRegisterValue("DH", dh.Text);
            registerManager.SetRegisterValue("AL", al.Text);
            registerManager.SetRegisterValue("BL", bl.Text);
            registerManager.SetRegisterValue("CL", cl.Text);
            registerManager.SetRegisterValue("DL", dl.Text);
        }

        private void UpdateRegisterValues()
        {
            ah.Text = registerManager.GetRegisterValue("AH");
            bh.Text = registerManager.GetRegisterValue("BH");
            ch.Text = registerManager.GetRegisterValue("CH");
            dh.Text = registerManager.GetRegisterValue("DH");
            al.Text = registerManager.GetRegisterValue("AL");
            bl.Text = registerManager.GetRegisterValue("BL");
            cl.Text = registerManager.GetRegisterValue("CL");
            dl.Text = registerManager.GetRegisterValue("DL");
        }

        private void RandomizeRegisters()
        {
            Random random = new Random();
            byte[] buffer = new byte[1];

            foreach (var textBox in Controls.OfType<TextBox>())
            {
                random.NextBytes(buffer);
                textBox.Text = buffer[0].ToString("X2");
            }
        }
    }
}
