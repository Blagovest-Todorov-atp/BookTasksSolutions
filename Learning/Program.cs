namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            var ticks = DateTime.Now.Ticks;
            var guid = Guid.NewGuid().ToString();
            var uniqueSessionId = ticks.ToString() + '-' + guid; //guid created by combining ticks and guid

            var datetime = new DateTime(ticks);//for checking purpose
            var datetimenow = DateTime.Now;    //both these date times are different.

            Console.WriteLine(ticks);
            Console.WriteLine(datetime);

            //Page 150 pdf -> Chapter 7 .//

        }
    }
}