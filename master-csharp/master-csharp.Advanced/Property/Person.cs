
namespace master_csharp.App.Property
{
    class Person
    {
        private string name;   // field

        public string Name     // property
        {
            get { return name; }
            set { name = value; }
        }
    }
}
