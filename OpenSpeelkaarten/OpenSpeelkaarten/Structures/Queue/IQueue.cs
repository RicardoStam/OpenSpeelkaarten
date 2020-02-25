namespace OpenSpeelkaarten.Structures.Queue
{
    interface IQueue<T, L>
    {
        /// <summary>
        /// Adds an item to the back of the queue.
        /// </summary>
        /// <param name="value">Value to add to the queue.</param>
        void Enqueue(T value);

        /// <summary>
        /// Removes, and returns, the item in the front of the queue.
        /// </summary>
        T Dequeue();
        /// <summary>
        /// Returns the value in front of the queue
        /// </summary>
        /// <returns></returns>
        T Peek();
        /// <summary>
        /// Returns true if the queue is empty or not.
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// Prints the queue.
        /// </summary>
        void Display();
    }
}
