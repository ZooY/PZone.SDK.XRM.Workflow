using System.Activities;


namespace PZone.Xrm.Workflow
{
    /// <summary>
    /// Расширение стандартного функционала класса <see cref="InArgument"/>.
    /// </summary>
    // ReSharper disable once CheckNamespace
    public static class InArgumentExtensions
    {
        /// <summary>
        /// Получение значения входного параметра.
        /// </summary>
        /// <typeparam name="T">Тип параметра.</typeparam>
        /// <param name="argument">Экземпляр класса <see cref="InArgument{T}"/>.</param>
        /// <param name="context">Контекст выполенения.</param>
        /// <returns>Метод возвращает значение указанного входного параметра.</returns>
        public static T Get<T>(this InArgument<T> argument, Context context)
        {
            return argument.Get<T>(context.SourceActivityContext);
        }
    }
}