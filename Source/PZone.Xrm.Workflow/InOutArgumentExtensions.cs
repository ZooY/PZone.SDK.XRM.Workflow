﻿using System.Activities;


namespace PZone.Xrm.Workflow
{
    /// <summary>
    /// Расширение стандартного функционала класса <see cref="InOutArgument"/>.
    /// </summary>
    // ReSharper disable once CheckNamespace
    public static class InOutArgumentExtensions
    {
        /// <summary>
        /// Получение значения входного параметра.
        /// </summary>
        /// <typeparam name="T">Тип параметра.</typeparam>
        /// <param name="argument">Экземпляр класса <see cref="InOutArgument{T}"/>.</param>
        /// <param name="context">Контекст выполенения.</param>
        /// <returns>Метод возвращает значение указанного входного параметра.</returns>
        public static T Get<T>(this InOutArgument<T> argument, Context context)
        {
            return argument.Get<T>(context.SourceActivityContext);
        }


        /// <summary>
        /// Установка значения выходного параметра.
        /// </summary>
        /// <typeparam name="T">Тип параметра.</typeparam>
        /// <param name="argument">Экземпляр класса <see cref="InOutArgument{T}"/>.</param>
        /// <param name="context">Контекст выполенения.</param>
        /// <param name="value">Устанавливаемое значение.</param>
        public static void Set<T>(this InOutArgument<T> argument, Context context, T value)
        {
            argument.Set(context.SourceActivityContext, value);
        }
    }
}