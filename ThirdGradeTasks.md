## 1. Модификаторы доступа методов

Опишите различия видимости методов, представленных в нижепредствленном C#-классе.

```csharp
public class Expample
{
    public void MethodA();

    private void MethodB();

    protected void MethodC();

    internal void MethodD();

    internal protected void MethodE();

    protected private void MethodF();
}
```

## 2. Магические методы

Что выведет в консоль следующий C#-код?

```csharp

namespace BRC 
{

    public partial class Magician : IDisposable
    {
        private readonly string first;
        private readonly string second;
        private readonly string third;
        private readonly WeightResouce resouce = new WieghtResouce();

        public Magician(string first, string second, string third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public partial Tuple<string, string, string> GetFieldTuple();

        public void Deconstruct(out string a, out string b, out string c)
        {
            a = this.second;
            b = this.third;
            c = this.first;
        }

        public void Dispose()
        {
            this.resouce.Dispose();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(var cheater = new Magician("a", "b", "c"))
                {
                    var (a, b, c) = cheater;

                    Console.WriteLine(c + b + a);
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
```

## 3. Нейминг.

Выберите варианты, содержащий стилистическую ошибку наименования.

a)
```csharp
public abstract class Container
{
    public IEnumerable<Person> Persons { get; set; }
}
```

b) 
```csharp
var isCanceled = !this.context.TaskPool.GetNewest().IsActive;
```

c)
```csharp
public class Worker
{
    public IEnumerable<IStatusReturnable> Holders { get; }  
    
    public string GetHolderStatuses 
    {
        get => string.Join(", ", this.Holders.Select(h => h.Status.ToString()).ToArray());
    }

    public Worker(IEnumerable<IStatusReturnable> holders)
    {
        this.Holders = holders;
    }
}
```

d)
```csharp
var getStringMethodInfo = this.GetType().GetMethods().FirstOrDefault(m => m.Name == "Get" && m.IsGenericType).MakeGenericMethod(new[] Type{ typeof(string) });
```