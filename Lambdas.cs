namespace lektion16;

// När man skapar en egen delegate så görs det i två steg:
// 1. Skapa delegate
// 2. Skapa lambda (se rad 37)
public delegate string DelegateName(string text, int num);

public class Lambdas
{
    public static void Run()
    {
        Action testFun = Test();
        testFun();

        // Lambdas
        string text = "Ironman!";

        Action<int> myLambda = num => {
            Console.WriteLine("Hej!");
            Console.WriteLine(text);
            Console.WriteLine(num);
        };

        text = "Superman";

        myLambda(5);

        Func<int, int, int> sum = (a, b) => { return a + b; };

        // Förkortning av ovanför (fungerar på grund av att det är endast en rad + en return)
        Func<int, int, int> sum2 = (a, b) => a + b;

        var doSomething = () => {}; 

        int sumTest = sum(4, 5);

        DelegateName myOwnLambda = (s, n) => {
            return "";
        };

        // Anonymous, values, capturing
        // Action<T1, T2, T3...>
        // Func<T1, T2, T3...>
        // var
        // Delegates

        // int är till nummer vad delegates är till lambdas
        // 5 (int)
        // () => {} (delegate)

        // Select, Sort, Where, Find
        // Egen 'Find' metod med lambdas och generics

        List<int> nums = [1, 2, 3, 4];

        nums.Sort((a, b) => {
            if (a > b) {
                return -1;
            } else {
                return 1;
            }
        });

        nums.ForEach((num) => {
            Console.WriteLine(num);
        });

        // Förtkortad version av ovanför (fungerar eftersom 'WriteLine' också tar in ett argument)
        nums.ForEach(Console.WriteLine);

        foreach (int num in nums) {
            Console.WriteLine(num);
        }
    }

    public static Action Test() {
        string text = "Ironman!";
        Action action = () => {
            Console.WriteLine(text);
        };

        text = "Superman";

        return action;
    }
}
