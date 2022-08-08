namespace Garbage
{
  public class BigStacks
  {
    public static void SMain()
    {
      var stack = new Stack();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Pop());
    }
  }
}