using System;
using System.Net;

namespace Parser_FlenovInfo
{
    class Program
    {
        private static string _urlBlogAddress = "https://www.flenov.info/blog/index";

        static void Main()
        {
            WebClient webClient = new WebClient();
            string content = webClient.DownloadString(_urlBlogAddress);
            Console.WriteLine($"{content}");

            Console.ReadLine();
        }
    }
}
