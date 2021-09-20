using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncriptadorMultiple
{
    public class HelperRSA
    {
        private readonly RSACryptoServiceProvider RSA;

        public  HelperRSA(RSACryptoServiceProvider _RSA =null)
        {
            RSA = _RSA;
        }

        public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }

        public string DecryptionBase64WithXMLPublicKey(string base64Encrypted, string xmlKey, bool DoOAEPPadding)
        {
            try
            {


                // server decrypting data with private key                    
                RSA.FromXmlString(xmlKey);

                var resultBytes = Convert.FromBase64String(base64Encrypted);
                var decryptedBytes = RSA.Decrypt(resultBytes, false);


                var decryptedData = Encoding.Unicode.GetString(decryptedBytes);
                //var decryptedData = BytesToStringConverted(decryptedBytes);
                
                return decryptedData.ToString();


                
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }


        public string GetRSAStr(string source)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                byte[] plaintext = ByteConverter.GetBytes(source);
                byte[] encryptedtext = Encryption(plaintext, RSA.ExportParameters(true), false);
                //return ByteConverter.GetString(encryptedtext);

                return Convert.ToBase64String(encryptedtext);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public string GetRSAPublicKeyXMLStr()
        {
            try
            {

                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, RSA.ExportParameters(false));
                //get the string from the stream
                return sw.ToString();

                //return Convert.ToBase64String(RSA.ExportParameters(true).Modulus);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public string GetRSAPublicKeyStrBase64()
        {
            try
            {

                return Convert.ToBase64String(RSA.ExportParameters(false).Modulus);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string GetRSAPrivateKeyXMLStr()
        {
            try
            {

                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, RSA.ExportParameters(true));
                //get the string from the stream
                return sw.ToString();

                //return Convert.ToBase64String(RSA.ExportParameters(true).Modulus);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }





        public string GetRSAPrivateKeyStrBase64()
        {
            TextWriter outputStream = new StringWriter();

            if (RSA.PublicOnly) throw new ArgumentException("CSP does not contain a private key", "csp");
            var parameters = RSA.ExportParameters(true);
            using (var stream = new MemoryStream())
            {
                var writer = new BinaryWriter(stream);
                writer.Write((byte)0x30); // SEQUENCE
                using (var innerStream = new MemoryStream())
                {
                    var innerWriter = new BinaryWriter(innerStream);
                    EncodeIntegerBigEndian(innerWriter, new byte[] { 0x00 }); // Version
                    EncodeIntegerBigEndian(innerWriter, parameters.Modulus);
                    EncodeIntegerBigEndian(innerWriter, parameters.Exponent);
                    EncodeIntegerBigEndian(innerWriter, parameters.D);
                    EncodeIntegerBigEndian(innerWriter, parameters.P);
                    EncodeIntegerBigEndian(innerWriter, parameters.Q);
                    EncodeIntegerBigEndian(innerWriter, parameters.DP);
                    EncodeIntegerBigEndian(innerWriter, parameters.DQ);
                    EncodeIntegerBigEndian(innerWriter, parameters.InverseQ);
                    var length = (int)innerStream.Length;
                    EncodeLength(writer, length);
                    writer.Write(innerStream.GetBuffer(), 0, length);
                }

                var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();
                outputStream.WriteLine("-----BEGIN RSA PRIVATE KEY-----");
                // Output as Base64 with lines chopped at 64 characters
                for (var i = 0; i < base64.Length; i += 64)
                {
                    outputStream.WriteLine(base64, i, Math.Min(64, base64.Length - i));
                }
                outputStream.WriteLine("-----END RSA PRIVATE KEY-----");




                return outputStream.ToString();
            }

            return null;
        }


        private static void EncodeLength(BinaryWriter stream, int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length", "Length must be non-negative");
            if (length < 0x80)
            {
                // Short form
                stream.Write((byte)length);
            }
            else
            {
                // Long form
                var temp = length;
                var bytesRequired = 0;
                while (temp > 0)
                {
                    temp >>= 8;
                    bytesRequired++;
                }
                stream.Write((byte)(bytesRequired | 0x80));
                for (var i = bytesRequired - 1; i >= 0; i--)
                {
                    stream.Write((byte)(length >> (8 * i) & 0xff));
                }
            }
        }

        private static void EncodeIntegerBigEndian(BinaryWriter stream, byte[] value, bool forceUnsigned = true)
        {
            stream.Write((byte)0x02); // INTEGER
            var prefixZeros = 0;
            for (var i = 0; i < value.Length; i++)
            {
                if (value[i] != 0) break;
                prefixZeros++;
            }
            if (value.Length - prefixZeros == 0)
            {
                EncodeLength(stream, 1);
                stream.Write((byte)0);
            }
            else
            {
                if (forceUnsigned && value[prefixZeros] > 0x7f)
                {
                    // Add a prefix zero to force unsigned if the MSB is 1
                    EncodeLength(stream, value.Length - prefixZeros + 1);
                    stream.Write((byte)0);
                }
                else
                {
                    EncodeLength(stream, value.Length - prefixZeros);
                }
                for (var i = prefixZeros; i < value.Length; i++)
                {
                    stream.Write(value[i]);
                }
            }
        }
    }
}
