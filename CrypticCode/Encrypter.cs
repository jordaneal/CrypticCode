using System.Text;

namespace CrypticCode
{
    public class Encrypter
    {
        private int _asciiSum;
        public string Encrypt(string unencrypted)
        {
            _asciiSum = 0;

            foreach (char c in unencrypted)
            {
                _asciiSum += c;
            }

            char[] charArr = unencrypted.ToCharArray();
            int[] intArr = new int[charArr.Length];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < charArr.Length; i++)
            {
                intArr[i] = (int)(charArr[i] * _asciiSum) - _asciiSum;

                if (i == charArr.Length - 1)
                {
                    sb.Append(intArr[i]);
                    break;
                }
                sb.Append($"{intArr[i]},");
            }
            return sb.ToString();
        }

        public string Decrypt(string encrypted)
        {
            string[] stringArr = encrypted.Split(',');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stringArr.Length; i++)
            {
                sb.Append((char)((int.Parse(stringArr[i]) + _asciiSum) / _asciiSum));
            }

            return sb.ToString();
        }
    }
}
