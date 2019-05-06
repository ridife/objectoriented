using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacRestAPI
{
    public class ZodiacRest
    {
        private string url;
        private string constUrl = "http://sandipbgt.com/theastrologer/api/horoscope";
        /// <summary>
        /// constructor of the API 
        /// </summary>
        /// <param name="url">it should be sandipbgt.com/theastrologer/api/horoscope/ </param>
        public ZodiacRest(string url)
        {
            this.url = url;
        }

        public ZodiacRest()
        {
            url = constUrl;
        }

        public ZodiacResult ObtainResult(ZodiacSign sign, TimeSign time)
        {
            ZodiacResult zodiacResult = new ZodiacResult();
            string customURL = string.Format(url + "/" + sign.ToString().ToLower() + "/" + time.ToString() + "/");
            var client = new RestClient(customURL);
            var response = client.Execute<List<ZodiacResult>>(new RestRequest());
            zodiacResult = JsonConvert.DeserializeObject<ZodiacResult>(response.Content);

            return zodiacResult;
        }

    }



    public enum TimeSign
    {
        today, tomorrow, yesterday
    }

    public enum ZodiacSign
    {
        Capricorn, Aquarius, Pisces, Aries, Taurus, Gemini, Cancer, Leo, Virgo, Libra, Scorpio, Sagittarius
    }
}
