using LeetCode.Arrays.Medium;
using LeetCode.String.Medium;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, List<string>> graph = new()
        {
            ["Bob"] = ["Anuj", "Peggy"],
            ["Alice"] = ["Peggy"],
            ["Claire"] = ["Thom", "Jonny"],
            ["Peggy"] = [],
            ["Thom"] = ["Marry"],
            ["Jonny"] = ["Jane", "Deft"],
            ["Anuj"] = [],
            ["Marry"] = [],
            ["Jane"] = [],
            ["Deft"] = []
        };

        // search who is mango saler
        Console.WriteLine("The mango saler is " + BreathFirstSearch(graph));
        Console.ReadKey();
    }

    private static string BreathFirstSearch(Dictionary<string, List<string>> graph)
    {
        Queue<string> queue = new Queue<string>();
        HashSet<string> visitedPerson = new HashSet<string>();

        // add all level 1 connection to queue
        foreach (string key in graph.Keys)
        {
            queue.Enqueue(key);
        }

        while (queue.Count > 0)
        {
            string person = queue.Dequeue();

            if (visitedPerson.Contains(person)) continue;

            if (IsMangoSaler(person))
            {
                return person;
            }
            else
            {
                visitedPerson.Add(person);

                // add connection of that person

                Console.WriteLine($"Add Connectio of {person} : {string.Join(", ", graph[person])}");

                foreach (string connection in graph[person])
                {
                    queue.Enqueue(connection);
                }
            }
        }

        return string.Empty;
    }

    private static bool IsMangoSaler(string person)
    {
        if (person.Substring(person.Length - 1) == "y")
            return true;
        return false;
    }
}