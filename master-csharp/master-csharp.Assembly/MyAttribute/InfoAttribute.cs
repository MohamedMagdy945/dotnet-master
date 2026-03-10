
namespace master_csharp.Assembly.MyAttribute
{
    [AttributeUsage(AttributeTargets.Field)]
    public class InfoAttribute : Attribute
    {
        public string Description { get; }
        public InfoAttribute(string description)
        {
            Description = description;
            Console.WriteLine("InfoAttribute constructor called!");
        }
    }

}
