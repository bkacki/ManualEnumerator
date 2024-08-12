namespace YieldReturnEnumerator
{
    internal class Program
    {
        static IEnumerable<string> SimpleEnumerable()
        {
            yield return "jabłka";
            yield return "pomarańcze";
            yield return "banany";
            yield return "jednorożce";
        }

        static void Main(string[] args)
        {
            foreach(var item in SimpleEnumerable())
                Console.WriteLine(item);

            var simpleEnumerableTest = SimpleEnumerable();
            Console.WriteLine(String.Join(", ", simpleEnumerableTest));
        }
    }
}
