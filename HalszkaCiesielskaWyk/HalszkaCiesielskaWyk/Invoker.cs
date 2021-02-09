namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Invoker class
    /// </summary>
    public class Invoker
    {
        /// <summary>
        /// Method to invoke execution of appropriate command
        /// </summary>
        /// <param name="command"></param>
        public void Invoke(ICommand command)
        {
            // calling execute method
            command.Execute(); 
        }
    }
}
