using System.Text;

namespace LeetCode.String.Medium;

public class EncodeAndDecodeTinyURL
{
    /***
    * Tag: Medium
    * Name: 535. Encode and Decode TinyURL
    * Start Time: 10/07/2024 10:50 AM
    * End Time: 10/07/2024 10:53 AM
    * Result: 
        * Runtime: solution 1: Beats 83.56% of users with C# ( 53ms )
        * Memory:  solution 1: Beats 97.26% of users with C# ( 40.14MB )
    ***/

    public static void Run()
    {
        string url = "http://www.leetcode.com/faq/?id=10";
        Codec codec = new Codec();
        string decode = codec.decode(codec.encode(url));
        System.Console.WriteLine(decode);
    }
}

public class Codec {
    private string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    private int number = 1000000;
    private Dictionary<int, string> map = new Dictionary<int, string>();
    
    private string tinyUrl = "http://tinyurl.com/";

    private string originalUrl = string.Empty;

    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        originalUrl = longUrl;

        number++;
        map.Add(number, originalUrl);
        int num = number;
        List<int> ints = new List<int>();
        
        while (num >= 62)
        {
            ints.Add(num % 62);
            num /= 62;
        }

        ints.Add(num);

        StringBuilder encodeUrl = new StringBuilder();

        foreach (int i in ints)
        {
            encodeUrl.Append(chars[i]);
        }

        return $"{tinyUrl}{encodeUrl}";
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {

        shortUrl = shortUrl.Replace(tinyUrl, string.Empty);
        int num = 0;
        int length = 0;
        foreach (char c in shortUrl)
        {
            int index = chars.IndexOf(c);

            num += index * (int)Math.Pow(62, length);
            length++;
        }

        return map[num];
    }
}