using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace test_3
{
    public class Download
    {
        public static Stream DownloadFile(String URL)
        {
            //String URL = "https://t7.baidu.com/it/u=1595072465,3644073269&fm=193&f=GIF.jpg";
            HttpWebRequest Myrq = (HttpWebRequest)WebRequest.Create(URL);
            Myrq.KeepAlive = false;
            Myrq.Timeout = 30 * 1000;
            Myrq.Method = "GET";
            Myrq.Accept = " text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
            //Myrq.Host = "";
           // Myrq.Referer = "";
            Myrq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36";

            HttpWebResponse Myrp = (HttpWebResponse)Myrq.GetResponse();

            if (Myrp.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            return Myrp.GetResponseStream();
        }

        public static Boolean DownloadFile(String URL, String Filename,String Referer)
        {
            //String URL = "https://t7.baidu.com/it/u=1595072465,3644073269&fm=193&f=GIF.jpg";
            HttpWebRequest Myrq = (HttpWebRequest)WebRequest.Create(URL);
            Myrq.KeepAlive = false;
            Myrq.Timeout = 30 * 1000;
            Myrq.Method = "GET";
            Myrq.Accept = " text/html,application/xhtml+xml,application/xml;q=0.9,image/apng,*/*;q=0.8";
            Myrq.Host =URL.Split('/')[2];
            Myrq.Referer = Referer;
            Myrq.UserAgent = GetUA();

            HttpWebResponse Myrp = (HttpWebResponse)Myrq.GetResponse();

            if (Myrp.StatusCode != HttpStatusCode.OK)
            {
                return false;
            }
            
            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                Myrp.GetResponseStream().CopyTo(fs);
            }
            return true;
        }
        private static String GetUA()
        {
            string[] userAgents = {
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 90.0.4430.212 Safari / 537.36"
            };
            return userAgents[new Random().Next(0, userAgents.Length)];
        }
    }
}
