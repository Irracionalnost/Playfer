using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RZ_PlaipherShifr
{
    internal class plaipher_crypt
    {
        public char[,] matrixPlaipher;
        private int rows;
        private int cols;
        private string alphabet = "";

        public plaipher_crypt(string language)
        {
            if (language == "rus")
            {
                rows = 7;
                cols = 5;
                alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ$*";
            }
            else if (language == "en")
            {
                rows = 7;
                cols = 4;
                alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ$*";
            }
            matrixPlaipher = new char[rows, cols];
        }
        private void initMatrixPlaipher(string key)
        {
            string preparationKey = new string((key.ToUpper().Replace(" ", "") + alphabet).Distinct().ToArray());
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrixPlaipher[i, j] = preparationKey[i * cols + j];
        }

        public string plaipher_Encode(string data, string key)
        {
            initMatrixPlaipher(key);

            string encode_result = "";
            data = preparationData(data);
            int n_row1;
            int n_col1;
            char sym1;
            int n_row2;
            int n_col2;
            char sym2;

            for (int i = 0; i < data.Length - 1; i += 2)
            {
                sym1 = data[i];
                sym2 = data[i + 1];

                if (getRowCol(sym1, out n_row1, out n_col1) && getRowCol(sym2, out n_row2, out n_col2))
                {
                    if (n_row1 != n_row2 && n_col1 != n_col2)
                    {
                        encode_result += matrixPlaipher[n_row1, n_col2];
                        encode_result += matrixPlaipher[n_row2, n_col1];
                    }
                    if (n_row1 == n_row2)
                    {
                        encode_result += (n_col1 == cols - 1) ? matrixPlaipher[n_row1, 0] : matrixPlaipher[n_row1, n_col1 + 1];
                        encode_result += (n_col2 == cols - 1) ? matrixPlaipher[n_row2, 0] : matrixPlaipher[n_row2, n_col2 + 1];
                    }

                    if (n_col1 == n_col2)
                    {
                        encode_result += (n_row1 == rows - 1) ? matrixPlaipher[0, n_col1] : matrixPlaipher[n_row1 + 1, n_col1];
                        encode_result += (n_row2 == rows - 1) ? matrixPlaipher[0, n_col2] : matrixPlaipher[n_row2 + 1, n_col2];
                    }
                }
            }
            return encode_result;
        }

        public string preparationData(string data)
        {
            string step1Data = data.ToUpper().Replace(' ', '$');
            string step2Data = "";
            for (int i = 0; i < step1Data.Length - 1; i++)
            {
                step2Data += step1Data[i];
                if (step1Data[i] == step1Data[i + 1])
                    step2Data += "*";
            }
            step2Data += step1Data[step1Data.Length-1];
            if (step2Data.Length % 2 != 0)
                step2Data += "*";
            return step2Data;
        }
        private bool getRowCol(char sym, out int n_row, out int n_col)
        {
            n_col = -1; n_row = -1;
            bool flag = false;
            for (int i = 0; i < rows && !flag; i++)
                for (int j = 0; j < cols && !flag; j++)
                    if (matrixPlaipher[i, j] == sym)
                    {
                        n_row = i;
                        n_col = j;
                        flag = true;
                    }
            return flag;
        }
        public string plaipher_Decode(string data, string key, string sign = "")
        {
            initMatrixPlaipher(key);

            string decode_result = "";
            int n_row1;
            int n_col1;
            char sym1;
            int n_row2;
            int n_col2;
            char sym2;

            for (int i = 0; i < data.Length - 1; i += 2)
            {
                sym1 = data[i];
                sym2 = data[i + 1];

                if (getRowCol(sym1, out n_row1, out n_col1) && getRowCol(sym2, out n_row2, out n_col2))
                {
                    if (n_row1 != n_row2 && n_col1 != n_col2)
                    {
                        decode_result += matrixPlaipher[n_row1, n_col2];
                        decode_result += matrixPlaipher[n_row2, n_col1];
                    }
                    if (n_row1 == n_row2)
                    {
                        decode_result += (n_col1 == 0) ? matrixPlaipher[n_row1, cols - 1] : matrixPlaipher[n_row1, n_col1 - 1];
                        decode_result += (n_col2 == 0) ? matrixPlaipher[n_row2, cols - 1] : matrixPlaipher[n_row2, n_col2 - 1];
                    }

                    if (n_col1 == n_col2)
                    {
                        decode_result += (n_row1 == 0) ? matrixPlaipher[rows - 1, n_col1] : matrixPlaipher[n_row1 - 1, n_col1];
                        decode_result += (n_row2 == 0) ? matrixPlaipher[rows - 1, n_col2] : matrixPlaipher[n_row2 - 1, n_col2];
                    }
                }
            }
            decode_result = decode_result.Replace("*", "").Replace('$', ' ');
            if (string.IsNullOrEmpty(sign))
                return decode_result;

            for (int i = 0; i < sign.Length; i++)
            {
                if (decode_result[decode_result.Length - 1 - i] != sign[sign.Length - 1 - i])
                    return "-1";
            }
            return decode_result.Replace(sign, "");
        }

    }
}
