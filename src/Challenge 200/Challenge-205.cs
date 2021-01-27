using System;
using System.Linq;

namespace Challenge_200
{
    public class Challenge_205
    {
        /// <summary>
        /// Encodes the <paramref name="messageToEncode"/>.
        /// </summary>
        /// <param name="messageToEncode">The message to encode</param>
        /// <returns>The encoded message</returns>
        public int[] Encode(string messageToEncode)
        {
            int[] encoded = new int[messageToEncode.Length];

            for (int i = 0; i < messageToEncode.Length; i++) // encoding is done char by char
            {
                if (i == 0) // first char just gets it's numeric value
                {
                    encoded[i] = (int)messageToEncode[i];
                    continue;
                }

                // all subsequent chars gets a value based on the difference in numeric value to the former char
                encoded[i] = messageToEncode[i] - messageToEncode[i - 1];
            }

            return encoded;
        }

        /// <summary>
        /// Decodes the <paramref name="encodedMessage"/>.
        /// </summary>
        /// <param name="encodedMessage">The message to encode</param>
        /// <returns>The message as a string</returns>
        public string Decode(int[] encodedMessage)
        {
            int[] decoded = new int[encodedMessage.Length];

            for (int i = 0; i < encodedMessage.Length; i++)
            {
                if (i == 0) // first char i numeric value
                {
                    decoded[i] = encodedMessage[i];
                    continue;
                }

                // all subsequent chars value can be found by adding the value of the char before it
                decoded[i] = decoded[i - 1] + encodedMessage[i];
            }

            var chars = decoded.Select(v => (char)v).ToArray();

            return new string(chars);
        }
    }
}
