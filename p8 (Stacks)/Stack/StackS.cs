namespace Garbage
{
    public class Stack
    {
        private List<object> _stack = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null is not allowed");
            }
            _stack.Add(obj);
        }
        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            var obj = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return obj;
        }
        public void Clear()
        {
            _stack.Clear();
        }
    }
}