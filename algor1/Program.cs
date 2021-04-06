using System;
using System.Collections.Generic;

namespace algor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введiть кiлькiсть рiвнiв ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("введiть рядок ");
            string decoded_message = Console.ReadLine();
            string encoded_message="";

            encoded_message = encode(decoded_message, size);
            Console.WriteLine($"закодоване повідомлення: {encoded_message}");


        }
        static string encode(string decoded_message, int size)
        {
            string[] encoded_array = new string[size];
            string encoded_message = "";
            bool x = true;
            int count = 0;
            char[] decoded_message_char = decoded_message.ToCharArray();
            List<char> Encode_rows = new List<char>();
            for(int i = 0; i < decoded_message_char.Length; i++)
            {

                encoded_array[count]+=(decoded_message_char[i]);
                
                if (x == true)
                {
                    count++;
                    
                    if (count == size)
                    {
                        count -= 2;
                        x = false;
                    }
                }
                else
                {
                    count--;
                    if (count == -1)
                    {
                        count += 2;
                        x = true;
                    }
                }
               
            }
            for(int i = 0; i < encoded_array.Length; i++)
            {
                encoded_message += encoded_array[i];
            }
            return encoded_message;
        }
       
    }
}
