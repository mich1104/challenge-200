using System;

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
        public string Decode(int[] encodedMessage)
        {
            throw new NotImplementedException();
        }
    }
}
