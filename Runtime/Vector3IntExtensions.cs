using UnityEngine;

namespace SweetAlgy.Extensions
{
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Adds the specified value to the X component of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to add to the X component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated X component.</returns>
        public static Vector3Int AddX(this Vector3Int self, int x)
            => new(self.x + x, self.y, self.z);
        
        /// <summary>
        /// Adds the specified value to the Y component of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="y">The value to add to the Y component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Y component.</returns>
        public static Vector3Int AddY(this Vector3Int self, int y)
            => new(self.x, self.y + y, self.z);
        
        /// <summary>
        /// Adds the specified value to the Z component of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="z">The value to add to the Z component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Z component.</returns>
        public static Vector3Int AddZ(this Vector3Int self, int z)
            => new(self.x, self.y, self.z + z);

        /// <summary>
        /// Subtracts the specified value from the X component of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to subtract from the X component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated X component.</returns>
        public static Vector3Int SubtractX(this Vector3Int self, int x)
            => new(self.x - x, self.y, self.z);
        
        /// <summary>
        /// Subtracts the specified value from the Y component of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="y">The value to subtract from the Y component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Y component.</returns>
        public static Vector3Int SubtractY(this Vector3Int self, int y)
            => new(self.x, self.y - y, self.z);
        
        /// <summary>
        /// Subtracts the specified value from the Z component of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="z">The value to subtract from the Z component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Z component.</returns>
        public static Vector3Int SubtractZ(this Vector3Int self, int z)
            => new(self.x, self.y, self.z - z);

        /// <summary>
        /// Multiplies the X component of the current <see cref="Vector3Int"/> by the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to multiply with the X component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated X component.</returns>
        public static Vector3Int MultiplyX(this Vector3Int self, int x)
            => new(self.x * x, self.y, self.z);
        
        /// <summary>
        /// Multiplies the Y component of the current <see cref="Vector3Int"/> by the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="y">The value to multiply with the Y component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Y component.</returns>
        public static Vector3Int MultiplyY(this Vector3Int self, int y)
            => new(self.x, self.y * y, self.z);
        
        /// <summary>
        /// Multiplies the Z component of the current <see cref="Vector3Int"/> by the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="z">The value to multiply with the Z component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Z component.</returns>
        public static Vector3Int MultiplyZ(this Vector3Int self, int z)
            => new(self.x, self.y, self.z * z);

        /// <summary>
        /// Divides the X component of the current <see cref="Vector3Int"/> by the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to divide the X component by.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated X component.</returns>
        public static Vector3Int DivideX(this Vector3Int self, int x)
            => new(self.x / x, self.y, self.z);
        
        /// <summary>
        /// Divides the Y component of the current <see cref="Vector3Int"/> by the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="y">The value to divide the Y component by.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Y component.</returns>
        public static Vector3Int DivideY(this Vector3Int self, int y)
            => new(self.x, self.y / y, self.z);

        /// <summary>
        /// Divides the Z component of the current <see cref="Vector3Int"/> by the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="z">The value to divide the Z component by.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the updated Z component.</returns>
        public static Vector3Int DivideZ(this Vector3Int self, int z)
            => new(self.x, self.y, self.z / z);

        /// <summary>
        /// Creates a copy of the current <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A new <see cref="Vector3Int"/> identical to the current one.</returns>
        public static Vector3Int Clone(this Vector3Int self)
            => new(self.x, self.y, self.z);

        /// <summary>
        /// Creates a new <see cref="Vector3Int"/> by setting the X component to the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to set for the X component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the specified X component.</returns>
        public static Vector3Int WithX(this Vector3Int self, int x)
            => new(x, self.y, self.z);

        /// <summary>
        /// Creates a new <see cref="Vector3Int"/> by setting the Y component to the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="y">The value to set for the Y component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the specified Y component.</returns>
        public static Vector3Int WithY(this Vector3Int self, int y)
            => new(self.x, y, self.z);

        /// <summary>
        /// Creates a new <see cref="Vector3Int"/> by setting the Z component to the specified value.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="z">The value to set for the Z component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the specified Z component.</returns>
        public static Vector3Int WithZ(this Vector3Int self, int z)
            => new(self.x, self.y, z);

        /// <summary>
        /// Creates a new <see cref="Vector3Int"/> by setting the X and Y components to the specified values.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to set for the X component.</param>
        /// <param name="y">The value to set for the Y component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the specified X and Y components.</returns>
        public static Vector3Int WithXY(this Vector3Int self, int x, int y)
            => new(x, y, self.z);

        /// <summary>
        /// Creates a new <see cref="Vector3Int"/> by setting the X and Z components to the specified values.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="x">The value to set for the X component.</param>
        /// <param name="z">The value to set for the Z component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the specified X and Z components.</returns>
        public static Vector3Int WithXZ(this Vector3Int self, int x, int z)
            => new(x, self.y, z);

        /// <summary>
        /// Creates a new <see cref="Vector3Int"/> by setting the Y and Z components to the specified values.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <param name="y">The value to set for the Y component.</param>
        /// <param name="z">The value to set for the Z component.</param>
        /// <returns>A new <see cref="Vector3Int"/> with the specified Y and Z components.</returns>
        public static Vector3Int WithYZ(this Vector3Int self, int y, int z)
            => new(self.x, y, z);

        /// <summary>
        /// Converts the current <see cref="Vector3Int"/> to a <see cref="Vector2"/> by using the X and Y components.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A <see cref="Vector2"/> with the X and Y components of the current <see cref="Vector3Int"/>.</returns>
        public static Vector2 ToVector2XY(this Vector3Int self)
            => new(self.x, self.y);

        /// <summary>
        /// Converts the current <see cref="Vector3Int"/> to a <see cref="Vector2"/> by using the X and Z components.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A <see cref="Vector2"/> with the X and Z components of the current <see cref="Vector3Int"/>.</returns>
        public static Vector2 ToVector2XZ(this Vector3Int self)
            => new(self.x, self.z);

        /// <summary>
        /// Converts the current <see cref="Vector3Int"/> to a <see cref="Vector2"/> by using the Y and Z components.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A <see cref="Vector2"/> with the Y and Z components of the current <see cref="Vector3Int"/>.</returns>
        public static Vector2 ToVector2YZ(this Vector3Int self)
            => new(self.y, self.z);

        /// <summary>
        /// Converts the current <see cref="Vector3Int"/> to a <see cref="Vector2Int"/> by using the X and Y components.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> with the X and Y components of the current <see cref="Vector3Int"/>.</returns>
        public static Vector2Int ToVector2IntXY(this Vector3Int self)
            => new(self.x, self.y);

        /// <summary>
        /// Converts the current <see cref="Vector3Int"/> to a <see cref="Vector2Int"/> by using the X and Z components.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> with the X and Z components of the current <see cref="Vector3Int"/>.</returns>
        public static Vector2Int ToVector2IntXZ(this Vector3Int self)
            => new(self.x, self.z);

        /// <summary>
        /// Converts the current <see cref="Vector3Int"/> to a <see cref="Vector2Int"/> by using the Y and Z components.
        /// </summary>
        /// <param name="self">The current <see cref="Vector3Int"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> with the Y and Z components of the current <see cref="Vector3Int"/>.</returns>
        public static Vector2Int ToVector2IntYZ(this Vector3Int self)
            => new(self.y, self.z);
    }
}