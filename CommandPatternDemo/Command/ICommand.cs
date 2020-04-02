namespace CommandPatternDemo.Command
{
    /// <summary>
    /// Command Interface
    /// </summary>
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
