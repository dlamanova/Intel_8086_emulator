using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086_emulator
{
    public class RegisterManager
    {
        private readonly Dictionary<string, string> registers;

        public RegisterManager()
        {
            registers = new Dictionary<string, string>
            {
                {"AH", "00"},
                {"BH", "00"},
                {"CH", "00"},
                {"DH", "00"},
                {"AL", "00"},
                {"BL", "00"},
                {"CL", "00"},
                {"DL", "00"}
            };
        }

        public string GetRegisterValue(string registerName)
        {
            if (registers.ContainsKey(registerName))
            {
                return registers[registerName];
            }
            else
            {
                throw new ArgumentException("Nieprawidłowa nazwa rejestru");
            }
        }

        public void ExecuteCommand(string command, string register1, string register2)
        {
            switch (command)
            {
                case "MOV":
                    MoveRegisters(register1, register2);
                    break;
                case "XCHG":
                    ExchangeRegisters(register1, register2);
                    break;
                case "ADD":
                    AddRegisters(register1, register2);
                    break;
                case "SUB":
                    SubtractRegisters(register1, register2);
                    break;
                case "AND":
                    AndRegisters(register1, register2);
                    break;
                case "OR":
                    OrRegisters(register1, register2);
                    break;
                default:
                    throw new ArgumentException("Nieznana operacja!");
            }
        }

        private void MoveRegisters(string sourceRegister, string destinationRegister)
        {
            try
            {
                string valueToMove = GetRegisterValue(sourceRegister);
                SetRegisterValue(destinationRegister, valueToMove);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }

        }

        private void ExchangeRegisters(string register1, string register2)
        {
            try
            {
                string temp = GetRegisterValue(register1);
                SetRegisterValue(register1, GetRegisterValue(register2));
                SetRegisterValue(register2, temp);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }

        }

        public void AddRegisters(string register1, string register2)
        {
            try
            {
                int value1 = Convert.ToInt32(GetRegisterValue(register1), 16);
                int value2 = Convert.ToInt32(GetRegisterValue(register2), 16);
                int result = value1 + value2;
                SetRegisterValue(register1, result.ToString("X2"));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy format danych w rejestrze");
            }
        }


        private void SubtractRegisters(string register1, string register2)
        {
            try
            {
                int value1 = Convert.ToInt32(GetRegisterValue(register1), 16);
                int value2 = Convert.ToInt32(GetRegisterValue(register2), 16);
                int result = value1 - value2;
                SetRegisterValue(register1, result.ToString("X2"));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy format danych w rejestrze");
            }
        }

        private void AndRegisters(string register1, string register2)
        {
            try
            {
                int value1 = Convert.ToInt32(GetRegisterValue(register1), 16);
                int value2 = Convert.ToInt32(GetRegisterValue(register2), 16);
                int result = value1 & value2;
                SetRegisterValue(register1, result.ToString("X2"));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy format danych w rejestrze");
            }
        }

        private void OrRegisters(string register1, string register2)
        {
            try
            {
                int value1 = Convert.ToInt32(GetRegisterValue(register1), 16);
                int value2 = Convert.ToInt32(GetRegisterValue(register2), 16);
                int result = value1 | value2;
                SetRegisterValue(register1, result.ToString("X2"));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy format danych w rejestrze");
            }
        }

        public void SetRegisterValue(string registerName, string value)
        {
            if (registers.ContainsKey(registerName))
            {
                registers[registerName] = value;
            }
            else
            {
                throw new ArgumentException("Nieprawidłowa nazwa rejestru");
            }
        }

    }
}
