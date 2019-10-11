/*
Что выведет программа?
*/

public class Program
{
    public static void Main(string[] args)
    {
        var a =  new A(5);
        var b = new B(4);
        var c = new C(2);

        Console.WriteLine(
            string.Format("{2}{0}{1}", 
            a.Foo(2),
            b.Foo(7),
            c.Foo(8)) );
    }
}

public class A 
{
    public A(int bar)
    {
        this.Bar = bar;
    }

    public int Bar { get; set; }

    public virtual int Foo(int n)
    {
        return n < Bar ? n : Bar;
    }
}

public class B : A
{
    public B(int bar): base(bar)
    {}

    public override sealed int Foo(int n)
    {
        return n > Bar ? Bar : n;
    }
}

public class C : A
{
    public C(int bar) : base(bar)
    {}

    public override sealed int Foo(int n)
    {
        return base.Foo(n) * Bar;
    }
}