namespace Laba_1_Tsezar
{
    class TsezarSwift
    {
        private char[] InputMassage;
        public string OutOutMessage { get; set; }
        private int Key;

        public TsezarSwift(string inputMessage, int key)
        {
            InputMassage = inputMessage.ToCharArray();
            Key = key;
        }

        public string Encryp()
        {
            string Encryptedtext="";
            foreach (var item in InputMassage)
            {
                Encryptedtext += (char)(item + Key);
            }

            return Encryptedtext;
        }

        public string Decrypt(string enctyptedText, int key)
        {
            string DecryptedText = "";

            foreach (var item in enctyptedText)
            {
                DecryptedText += (char)(item - key);
            }
            return DecryptedText;
        }
    }
}
