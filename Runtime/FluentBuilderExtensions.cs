using System;
using JetBrains.Annotations;

namespace SweetAlgy.Extensions
{
    /// <summary>
    /// Provides extension methods to simplify and streamline object configuration
    /// using fluent syntax with conditional logic.
    /// </summary>
    public static class FluentBuilderExtensions
    {
        /// <summary>
        /// Performs an action on the object and returns the object itself.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object on which the action is performed.</param>
        /// <param name="action">The action to perform on the object.</param>
        /// <returns>The original object after the action is performed.</returns>
        public static T Do<T>(this T self, Action<T> action)
        {
            action?.Invoke(self);
            return self;
        }

        /// <summary>
        /// Conditionally performs an action on the object and returns the object itself.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object on which the action is performed.</param>
        /// <param name="when">A boolean value indicating whether the action should be performed.</param>
        /// <param name="action">The action to perform on the object.</param>
        /// <returns>The original object after the action is conditionally performed.</returns>
        public static T If<T>(this T self, bool when, Action<T> action)
        {
            if (when) action?.Invoke(self);
            return self;
        }

        /// <summary>
        /// Conditionally performs an action on the object, based on the result of a function,
        /// and returns the object itself.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object on which the action is performed.</param>
        /// <param name="when">A function that determines whether the action should be performed.</param>
        /// <param name="action">The action to perform on the object.</param>
        /// <returns>The original object after the action is conditionally performed.</returns>
        public static T If<T>(this T self, Func<bool> when, Action<T> action)
        {
            if (when()) action?.Invoke(self);
            return self;
        }

        /// <summary>
        /// Conditionally performs an action on the object, based on the result of a function
        /// that evaluates the object, and returns the object itself.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object on which the action is performed.</param>
        /// <param name="when">A function that evaluates the object and determines whether the action should be performed.</param>
        /// <param name="action">The action to perform on the object.</param>
        /// <returns>The original object after the action is conditionally performed.</returns>
        public static T If<T>(this T self, Func<T, bool> when, Action<T> action)
        {
            if (when(self)) action?.Invoke(self);
            return self;
        }

        /// <summary>
        /// Executes an action if the object is null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object to check for null.</param>
        /// <param name="action">The action to execute if the object is null.</param>
        /// <returns>The original object.</returns>
        public static T IfNull<T>([CanBeNull] this T self, Action action) where T : class
        {
            if (self is null) action?.Invoke();
            return self;
        }
        
        /// <summary>
        /// Executes an action if the object is not null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object to check for non-null.</param>
        /// <param name="action">The action to execute if the object is not null.</param>
        /// <returns>The original object.</returns>
        public static T IfNotNull<T>([CanBeNull] this T self, Action<T> action) where T : class
        {
            if (self != null) action?.Invoke(self);
            return self;
        }

        /// <summary>
        /// Ensures the object is not null by using the specified default value when it is null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="self">The object to check for null.</param>
        /// <param name="defaultFactory">A function that creates the default value if the object is null.</param>
        /// <returns>The original object if not null; otherwise, the default value.</returns>
        public static T WithDefault<T>([CanBeNull] this T self, Func<T> defaultFactory) where T : class
            => self ?? defaultFactory();
    }
}