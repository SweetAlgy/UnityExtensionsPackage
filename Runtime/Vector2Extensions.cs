using UnityEngine;

namespace SweetAlgy.Extensions
{
    /// <summary>
    /// Provides extension methods for Unity's <see cref="Vector2"/> structure.
    /// </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        /// Adds a specified value to the x-component of the <see cref="Vector2"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="x">The value to add to the x-component.</param>
        /// <returns>A new <see cref="Vector2"/> with the added x-component.</returns>
        public static Vector2 AddX(this Vector2 self, float x)
            => new(self.x + x, self.y);
        
        /// <summary>
        /// Adds a specified value to the y-component of the <see cref="Vector2"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The value to add to the y-component.</param>
        /// <returns>A new <see cref="Vector2"/> with the added y-component.</returns>
        public static Vector2 AddY(this Vector2 self, float y)
            => new(self.x, self.y + y);

        /// <summary>
        /// Subtracts a specified value from the x-component of the <see cref="Vector2"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="x">The value to subtract from the x-component.</param>
        /// <returns>A new <see cref="Vector2"/> with the subtracted x-component.</returns>
        public static Vector2 SubtractX(this Vector2 self, float x)
            => new(self.x - x, self.y);
        
        /// <summary>
        /// Subtracts a specified value from the y-component of the <see cref="Vector2"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The value to subtract from the y-component.</param>
        /// <returns>A new <see cref="Vector2"/> with the subtracted y-component.</returns>
        public static Vector2 SubtractY(this Vector2 self, float y)
            => new(self.x, self.y - y);

        /// <summary>
        /// Multiplies the x-component of the <see cref="Vector2"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="x">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector2"/> with the multiplied x-component.</returns>
        public static Vector2 MultiplyX(this Vector2 self, float x)
            => new(self.x * x, self.y);
        
        /// <summary>
        /// Multiplies the y-component of the <see cref="Vector2"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector2"/> with the multiplied y-component.</returns>
        public static Vector2 MultiplyY(this Vector2 self, float y)
            => new(self.x, self.y * y);
        
        /// <summary>
        /// Divides the x-component of the <see cref="Vector2"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="x">The value to divide by.</param>
        /// <returns>A new <see cref="Vector2"/> with the divided x-component.</returns>
        public static Vector2 DivideX(this Vector2 self, float x)
            => new(self.x / x, self.y);
        
        /// <summary>
        /// Divides the y-component of the <see cref="Vector2"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The value to divide by.</param>
        /// <returns>A new <see cref="Vector2"/> with the divided y-component.</returns>
        public static Vector2 DivideY(this Vector2 self, float y)
            => new(self.x, self.y / y);

        /// <summary>
        /// Creates a clone of the <see cref="Vector2"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <returns>A new <see cref="Vector2"/> with the same components as the original.</returns>
        public static Vector2 Clone(this Vector2 self)
            => new(self.x, self.y);

        /// <summary>
        /// Replaces the x-component of the <see cref="Vector2"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="x">The value to set as the x-component.</param>
        /// <returns>A new <see cref="Vector2"/> with the specified x-component.</returns>
        public static Vector2 WithX(this Vector2 self, float x)
            => new(x, self.y);
        
        /// <summary>
        /// Replaces the y-component of the <see cref="Vector2"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The value to set as the y-component.</param>
        /// <returns>A new <see cref="Vector2"/> with the specified y-component.</returns>
        public static Vector2 WithY(this Vector2 self, float y)
            => new(self.x, y);

        /// <summary>
        /// Converts the <see cref="Vector2"/> to a <see cref="Vector3"/> using the x and y for the new vector's x and y, with an optional z value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3"/> representation of this <see cref="Vector2"/>.</returns>
        public static Vector3 ToVector3XY(this Vector2 self, float z = 0)
            => new(self.x, self.y, z);
        
        /// <summary>
        /// Converts the <see cref="Vector2"/> to a <see cref="Vector3"/> using x for the x-component, the y parameter for the y-component, 
        /// and y of the <see cref="Vector2"/> for the z-component.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3"/> representation of this <see cref="Vector2"/>.</returns>
        public static Vector3 ToVector3XZ(this Vector2 self, float y = 0)
            => new(self.x, y, self.y);

        /// <summary>
        /// Converts the <see cref="Vector2"/> to a <see cref="Vector2Int"/> by truncating the components to integers.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of this <see cref="Vector2"/>.</returns>
        public static Vector2Int ToVector2Int(this Vector2 self)
            => new((int)self.x, (int)self.y);

        /// <summary>
        /// Converts the <see cref="Vector2"/> to a <see cref="Vector3Int"/> by truncating the x and y components to integers
        /// and using the optional z parameter for the z-component.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>.</returns>
        public static Vector3Int ToVector3IntXY(this Vector2 self, int z = 0)
            => new((int)self.x, (int)self.y, z);
        
        /// <summary>
        /// Converts the <see cref="Vector2"/> to a <see cref="Vector3Int"/> by truncating the x component to an integer,
        /// using the optional y parameter for the y-component, and truncating the y of <see cref="Vector2"/> for the z-component.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>.</returns>
        public static Vector3Int ToVector3IntXZ(this Vector2 self, int y = 0)
            => new((int)self.x, y, (int)self.y);

        /// <summary>
        /// Floors the components of the <see cref="Vector2"/> and returns a new <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of this <see cref="Vector2"/>, with floored components.</returns>
        public static Vector2Int FloorToInt(this Vector2 self)
            => Vector2Int.FloorToInt(self);
        
        /// <summary>
        /// Ceils the components of the <see cref="Vector2"/> and returns a new <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of this <see cref="Vector2"/>, with ceiled components.</returns>
        public static Vector2Int CeilToInt(this Vector2 self)
            => Vector2Int.CeilToInt(self);
        
        /// <summary>
        /// Rounds the components of the <see cref="Vector2"/> and returns a new <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of this <see cref="Vector2"/>, with rounded components.</returns>
        public static Vector2Int RoundToInt(this Vector2 self)
            => Vector2Int.RoundToInt(self);

        /// <summary>
        /// Floors the components of the <see cref="Vector2"/> and returns a <see cref="Vector3Int"/> with the optional z value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>, with floored x and y values and the specified z value.</returns>
        public static Vector3Int FloorToIntXY(this Vector2 self, int z = 0)
            => new()
            {
                x = Mathf.FloorToInt(self.x),
                y = Mathf.FloorToInt(self.y),
                z = z,
            };
        
        /// <summary>
        /// Floors the components of the <see cref="Vector2"/> and returns a <see cref="Vector3Int"/> using an optional y parameter.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>, with floored x and z values and the specified y value.</returns>
        public static Vector3Int FloorToIntXZ(this Vector2 self, int y = 0)
            => new()
            {
                x = Mathf.FloorToInt(self.x),
                y = y,
                z = Mathf.FloorToInt(self.y),
            };

        /// <summary>
        /// Ceils the components of the <see cref="Vector2"/> and returns a <see cref="Vector3Int"/> with the optional z value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>, with ceiled x and y values and the specified z value.</returns>
        public static Vector3Int CeilToIntXY(this Vector2 self, int z = 0)
            => new()
            {
                x = Mathf.CeilToInt(self.x),
                y = Mathf.CeilToInt(self.y),
                z = z,
            };
        
        /// <summary>
        /// Ceils the components of the <see cref="Vector2"/> and returns a <see cref="Vector3Int"/> using an optional y parameter.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>, with ceiled x and z values and the specified y value.</returns>
        public static Vector3Int CeilToIntXZ(this Vector2 self, int y = 0)
            => new()
            {
                x = Mathf.CeilToInt(self.x),
                y = y,
                z = Mathf.CeilToInt(self.y),
            };

        /// <summary>
        /// Rounds the components of the <see cref="Vector2"/> and returns a <see cref="Vector3Int"/> with the optional z value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="z">The optional z-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>, with rounded x and y values and the specified z value.</returns>
        public static Vector3Int RoundToIntXY(this Vector2 self, int z = 0)
            => new()
            {
                x = Mathf.RoundToInt(self.x),
                y = Mathf.RoundToInt(self.y),
                z = z,
            };
        
        /// <summary>
        /// Rounds the components of the <see cref="Vector2"/> and returns a <see cref="Vector3Int"/> using an optional y parameter.
        /// </summary>
        /// <param name="self">The original <see cref="Vector2"/>.</param>
        /// <param name="y">The optional y-component value. Defaults to 0.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of this <see cref="Vector2"/>, with rounded x and z values and the specified y value.</returns>
        public static Vector3Int RoundToIntXZ(this Vector2 self, int y = 0)
            => new()
            {
                x = Mathf.RoundToInt(self.x),
                y = y,
                z = Mathf.RoundToInt(self.y),
            };
    }
}