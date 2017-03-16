using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ModbusTcp
{
    public static class AndroidFcmSender
    {
        private static readonly string serverKey = "AAAATmmTEsQ:APA91bGErVh9QZGLN-3nMjSm_0tJasSkaDE1ciE0kOBKBk0A_Pd2rWizL7GzlohEp9Q0HOgNuhfBu_0jkZmjXfvqVGCMbzDyFGVlmpXoT6zG65CeYR0LWWUKbmrAbShaKUilocn5rN2O";


        /// <summary>
        /// fcmTokens을 가진 유저에게 푸시 전송
        /// </summary>
        /// <param name="fcmTokens"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public static void SendNotiToRegisteredUser(string[] fcmTokens, string title, string body)
        {
            try
            {
                for (int i = 0; i < fcmTokens.Length; i++)
                {
                    string receiver = fcmTokens[i];
                    SendNotificationToTokenId(receiver, title, body);
                }
            }
            catch { }

        }

        private static string SendNotificationToTokenId(string receiver, string title, string body)
        {
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization:key=" + serverKey);
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = getJsonStringForTokenId(receiver, title, body);

                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }

        public static string SendNotificationToTopic(string topic, string title, string body)
        {
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization:key=" + serverKey);
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = getJsonStringForTopic(topic, title, body);

                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }


        private static string getJsonString_Data(string title, string body)
        {
            return "\"data\": { \"title\": \"" + title + "\", \"body\": \"" + body + "\" }";
        }

        private static string getJsonStringForTokenId(string receiver, string title, string body)
        {
            return "{ " + getJsonString_Data(title, body) + ", \"to\" : \"" + receiver + "\" }";
        }

        private static string getJsonStringForTopic(string topic, string title, string body)
        {
            return "{ " + getJsonString_Data(title, body) + ", \"to\" : \"/topics/" + topic + "\" }";
        }


        public static DataTable getFcmTokens()
        {
            string query = @"SELECT * FROM MobileFcmTokens WHERE   AllowPush = 'Y' ";

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlConnectionString = "connection string from somewhere";
            using (SqlConnection sqlCon = new SqlConnection(sqlConnectionString))
            {
                try
                {
                    cmd.Connection = sqlCon;
                    cmd.CommandText = query;

                    cmd.Parameters.Clear();

                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    cmd.Dispose();
                    adapter.Dispose();

                    return dataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }
        

    }
}
