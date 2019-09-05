using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; //for the httpclient class
using static System.Console; // for using the static methods of the Console without having to reference the class name.
namespace Repo
{
    
    class Program
    {
        const string API_BASE = "https://www.gitignore.io/api/";
        const string API_LIST_LINES = API_BASE + "list? format=lines";
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var response = client.GetAsync(API_LIST_LINES).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                WriteLine(content);
                ReadLine();
            }
        }
    }
}
