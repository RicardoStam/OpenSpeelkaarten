namespace OpenSpeelkaarten.Structures.Stack
{
    abstract class AbsStack<T, L> : IStack<T, L>
    {
        protected L elements;

        abstract public void Push(T value);

        abstract public T Pop();

        abstract public T Peek();
        abstract public bool IsEmpty();
    }
}
