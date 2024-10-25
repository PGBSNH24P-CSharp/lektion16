namespace lektion16;

using System.Reflection;

public class Reflection
{
    public static void Run()
    {
        // Reflection (System.Reflection)
        FieldInfo[] fields = typeof(Person).GetFields();
        foreach (FieldInfo field in fields) {
            Console.WriteLine(field);
        }

        Person person = new Person();
        // person.name = "";
        FieldInfo nameField = typeof(Person).GetField("name")!;
        // Type type = typeof(Person);
        nameField.SetValue(person, "Ironman");
        
        // Type, typeof
        // Assembly
        // Exempel: auto register commands (todo-app)
    }
}

public class Person {
    private string name;
    public int age;
}