using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DONGSHIN
{
    public class encodeDecode
    {

        // 1. 암호화
        //-------------------------------------------------------------------------------------------------------------
        public static string EncryptString(string InputText)
        {
            String Password = "pdmtech07";
            try
            {
                if ( InputText.Length > 0 )
                {
                    // Rihndael class를 선언하고, 초기화 합니다
                    RijndaelManaged RijndaelCipher = new RijndaelManaged();

                    // 입력받은 문자열을 바이트 배열로 변환
                    byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);

                    // 딕셔너리 공격을 대비해서 키를 더 풀기 어렵게 만들기 위해서 
                    // Salt를 사용합니다.
                    byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

                    // PasswordDeriveBytes 클래스를 사용해서 SecretKey를 얻습니다.
                    PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

                    // Create a encryptor from the existing SecretKey bytes.
                    // encryptor 객체를 SecretKey로부터 만듭니다.
                    // Secret Key에는 32바이트
                    // (Rijndael의 디폴트인 256bit가 바로 32바이트입니다)를 사용하고, 
                    // Initialization Vector로 16바이트
                    // (역시 디폴트인 128비트가 바로 16바이트입니다)를 사용합니다
                    ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

                    // 메모리스트림 객체를 선언,초기화 
                    MemoryStream memoryStream = new MemoryStream();

                    // CryptoStream객체를 암호화된 데이터를 쓰기 위한 용도로 선언
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

                    // 암호화 프로세스가 진행됩니다.
                    cryptoStream.Write(PlainText, 0, PlainText.Length);

                    // 암호화 종료
                    cryptoStream.FlushFinalBlock();

                    // 암호화된 데이터를 바이트 배열로 담습니다.
                    byte[] CipherBytes = memoryStream.ToArray();

                    // 스트림 해제
                    memoryStream.Close();
                    cryptoStream.Close();

                    // 암호화된 데이터를 Base64 인코딩된 문자열로 변환합니다.
                    string EncryptedData = Convert.ToBase64String(CipherBytes);

                    // 최종 결과를 리턴
                    return EncryptedData;
                }
                else
                {
                    return "";
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show("암호화 → " + ex.Message);
                return "";
            }
        }

        // 2. 복호화
        //-------------------------------------------------------------------------------------------------------------
        public static string DecryptString(string InputText)
        {
            String Password = "pdmtech07";
            try
            {
                RijndaelManaged RijndaelCipher = new RijndaelManaged();

                byte[] EncryptedData = Convert.FromBase64String(InputText);
                byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

                PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

                // Decryptor 객체를 만듭니다.
                ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

                MemoryStream memoryStream = new MemoryStream(EncryptedData);

                // 데이터 읽기(복호화이므로) 용도로 cryptoStream객체를 선언, 초기화
                CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

                // 복호화된 데이터를 담을 바이트 배열을 선언합니다.
                // 길이는 알 수 없지만, 일단 복호화되기 전의 데이터의 길이보다는
                // 길지 않을 것이기 때문에 그 길이로 선언합니다
                byte[] PlainText = new byte[EncryptedData.Length];

                // 복호화 시작
                int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

                memoryStream.Close();
                cryptoStream.Close();

                // 복호화된 데이터를 문자열로 바꿉니다.
                string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

                // 최종 결과 리턴
                return DecryptedData;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show("복호화 → " + ex.Message);
                return "";
            }
        }

        /// <summary>
        /// 암호설정
        /// </summary>
        /// <param name="texti"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string En_PASSWORD(String texti, int salt)
        {
            int tm = 0;
            int sana;
            int xn = 0;
            String Crypted = "";

            for ( int i = 0 ; i < texti.Length ; i++ )
            {
                sana = (int)(texti.Substring((i), 1))[0];
                xn = 0;

                if ( tm == 0 )
                    xn = (sana + (salt + 3));
                else if ( tm == 1 )
                    xn = (sana + (salt - 6));
                else if ( tm == 2 )
                    xn = (sana + (salt + 9));
                else if ( tm == 3 )
                    xn = (sana + (salt - 3));
                else if ( tm == 4 )
                    xn = (sana + (salt + 6));
                else
                    xn = (sana + (salt - 9));

                Crypted = Crypted + ((char)(xn));

                tm++;
                if ( tm > 5 )
                {
                    tm = 0;
                }
            }
            return Crypted;
        }

        /// <summary>
        /// 암호복호화
        /// </summary>
        /// <param name="texti"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string De_PASSWORD(String texti, int salt)
        {
            int tm = 0;
            int sana;
            int xn = 0;
            String Crypted = "";

            for ( int i = 0 ; i < texti.Length ; i++ )
            {
                sana = (int)(texti.Substring((i), 1))[0];
                xn = 0;

                if ( tm == 0 )
                    xn = (sana - (salt + 3));
                else if ( tm == 1 )
                    xn = (sana - (salt - 6));
                else if ( tm == 2 )
                    xn = (sana - (salt + 9));
                else if ( tm == 3 )
                    xn = (sana - (salt - 3));
                else if ( tm == 4 )
                    xn = (sana - (salt + 6));
                else
                    xn = (sana - (salt - 9));

                Crypted = Crypted + ((char)(xn));

                tm++;
                if ( tm > 5 )
                {
                    tm = 0;
                }
            }
            return Crypted;
        }

    }//클래스
}//네임스페이스
