﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya_bakinykh
{
    class chifr
    {
        //генератор повторений пароля
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        //метод шифрования/дешифровки сообщения
        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length);
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }
            byte[] bytes = Encoding.ASCII.GetBytes(res);
            return Convert.ToBase64String(bytes);
        }
        //шифрование текста сообщения
        public string Encrypt(string plainText, string password)
        {
            return Cipher(plainText, password);
        }

    }
}
