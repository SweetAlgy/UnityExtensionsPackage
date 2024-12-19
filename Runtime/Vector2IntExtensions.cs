using UnityEngine;

namespace SweetAlgy.Extensions
{
    /// <summary>
    /// Provides extension methods for Unity's <see cref="Vector2Int"/> structure.
    /// </summary>
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// Adds a specified value to the x-component of the <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="x">The value to add to the x-component.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the added x-component.</returns>
        public static Vector2Int AddX(this Vector2Int self, int x)
            => new(self.x + x, self.y);
        
        /// <summary>
        /// Adds a specified value to the y-component of the <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The value to add to the y-component.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the added y-component.</returns>
        public static Vector2Int AddY(this Vector2Int self, int y)
            => new(self.x, self.y + y);

        /// <summary>
        /// Subtracts a specified value from the x-component of the <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="x">The value to subtract from the x-component.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the subtracted x-component.</returns>
        public static Vector2Int SubtractX(this Vector2Int self, int x)
            => new(self.x - x, self.y);
        
        /// <summary>
        /// Subtracts a specified value from the y-component of the <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The value to subtract from the y-component.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the subtracted y-component.</returns>
        public static Vector2Int SubtractY(this Vector2Int self, int y)
            => new(self.x, self.y - y);

        /// <summary>
        /// Multiplies the x-component of the <see cref="Vector2Int"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="x">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the multiplied x-component.</returns>
        public static Vector2Int MultiplyX(this Vector2Int self, int x)
            => new(self.x * x, self.y);
        
        /// <summary>
        /// Multiplies the y-component of the <see cref="Vector2Int"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the multiplied y-component.</returns>
        public static Vector2Int MultiplyY(this Vector2Int self, int y)
            => new(self.x, self.y * y);

        /// <summary>
        /// Divides the x-component of the <see cref="Vector2Int"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="x">The value to divide by.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the divided x-component.</returns>
        public static Vector2Int DivideX(this Vector2Int self, int x)
            => new(self.x / x, self.y);

        /// <summary>
        /// Divides the y-component of the <see cref="Vector2Int"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The value to divide by.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the divided y-component.</returns>
        public static Vector2Int DivideY(this Vector2Int self, int y)
            => new(self.x, self.y / y);

        /// <summary>
        /// Creates a clone of the <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the same components as the original.</returns>
        public static Vector2Int Clone(this Vector2Int self)
            => new(self.x, self.y);

        /// <summary>
        /// Replaces the x-component of the <see cref="Vector2Int"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="x">The value to set as the x-component.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the specified x-component.</returns>
        public static Vector2Int WithX(this Vector2Int self, int x)
            => new(x, self.y);

        /// <summary>
        /// Replaces the y-component of the <see cref="Vector2Int"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The value to set as the y-component.</param>
        /// <returns>A new <see cref="Vector2Int"/> with the specified y-component.</returns>
        public static Vector2Int WithY(this Vector2Int self, int y)
            => new(self.x, y);
        
        /// <summary>
        /// Converts the <see cref="Vector2Int"/> to a <see cref="Vector3"/> using x and y as the new vector's x and y components, with an optional z value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3"/> representation of this <see cref="Vector2Int"/>.</returns>
        public static Vector3 ToVector3XY(this Vector2Int self, float z = 0)
            => new(self.x, self.y, z);

        /// <summary>
        /// Converts the <see cref="Vector2Int"/> to a <see cref="Vector3"/> using x as the x-component, an optional y value for the y-component, and y as the z-component.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3"/> representation of this <see cref="Vector2Int"/>.</returns>
        public static Vector3 ToVector3XZ(this Vector2Int self, float y = 0)
            => new(self.x, y, self.y);

        /// <summary>
        /// Converts the <see cref="Vector2Int"/> to a <see cref="Vector3Int"/> using x and y as the new vector's x and y components, with an optional z value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2Int"/>.</returns>
        public static Vector3Int ToVector3IntXY(this Vector2Int self, int z = 0)
            => new(self.x, self.y, z);

        /// <summary>
        /// Converts the <see cref="Vector2Int"/> to a <see cref="Vector3Int"/> using x as the x-component, an optional y value for the y-component, and y as the z-component.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2Int"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2Int"/>.</returns>
        public static Vector3Int ToVector3IntXZ(this Vector2Int self, int y = 0)
            => new(self.x, y, self.y);
    }
}