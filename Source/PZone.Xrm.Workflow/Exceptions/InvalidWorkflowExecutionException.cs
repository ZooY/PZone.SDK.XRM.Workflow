using System;
using PZone.Exceptions;


namespace PZone.Xrm.Workflow.Exceptions
{
    /// <summary>
    /// Ошибка выполнения действия процесса.
    /// </summary>
    /// <remarks>
    /// Код ошибки: 10200000.
    /// </remarks>
    public class InvalidWorkflowExecutionException : CommonException
    {
        private const int CODE = 10200000;

        /// <summary>
        /// Конструтор класса.
        /// </summary>
        /// <param name="message">Текст сообщения об ошибке.</param>
        public InvalidWorkflowExecutionException(string message) : this(message, null)
        {
        }


        /// <summary>
        /// Конструтор класса.
        /// </summary>
        /// <param name="message">Текст сообщения об ошибке.</param>
        /// <param name="exception">Исключение, приведшее к ошибке.</param>
        public InvalidWorkflowExecutionException(string message, Exception exception) : base(CODE, message, exception)
        {
        }
    }
}