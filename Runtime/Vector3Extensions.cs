using UnityEngine;

namespace SweetAlgy.Extensions
{
    
    /// <summary>
    /// Provides extension methods for Unity's <see cref="Vector3"/> structure 
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Adds a specified value to the x-component of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to add to the x-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the added x-component.</returns>
        public static Vector3 AddX(this Vector3 self, float x)
            => new(self.x + x, self.y, self.z);
        
        /// <summary>
        /// Adds a specified value to the y-component of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="y">The value to add to the y-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the added y-component.</returns>
        public static Vector3 AddY(this Vector3 self, float y)
            => new(self.x, self.y + y, self.z);
        
        /// <summary>
        /// Adds a specified value to the z-component of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="z">The value to add to the z-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the added z-component.</returns>
        public static Vector3 AddZ(this Vector3 self, float z)
            => new(self.x, self.y, self.z + z);

        /// <summary>
        /// Subtracts a specified value from the x-component of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to subtract from the x-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the subtracted x-component.</returns>
        public static Vector3 SubtractX(this Vector3 self, float x)
            => new(self.x - x, self.y, self.z);
        
        /// <summary>
        /// Subtracts a specified value from the y-component of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="y">The value to subtract from the y-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the subtracted y-component.</returns>
        public static Vector3 SubtractY(this Vector3 self, float y)
            => new(self.x, self.y - y, self.z);
        
        /// <summary>
        /// Subtracts a specified value from the z-component of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="z">The value to subtract from the z-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the subtracted z-component.</returns>
        public static Vector3 SubtractZ(this Vector3 self, float z)
            => new(self.x, self.y, self.z - z);

        /// <summary>
        /// Multiplies the x-component of the <see cref="Vector3"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector3"/> with the multiplied x-component.</returns>
        public static Vector3 MultiplyX(this Vector3 self, float x)
            => new(self.x * x, self.y, self.z);
        
        /// <summary>
        /// Multiplies the y-component of the <see cref="Vector3"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="y">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector3"/> with the multiplied y-component.</returns>
        public static Vector3 MultiplyY(this Vector3 self, float y)
            => new(self.x, self.y * y, self.z);
        
        /// <summary>
        /// Multiplies the z-component of the <see cref="Vector3"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="z">The value to multiply by.</param>
        /// <returns>A new <see cref="Vector3"/> with the multiplied z-component.</returns>
        public static Vector3 MultiplyZ(this Vector3 self, float z)
            => new(self.x, self.y, self.z * z);

        /// <summary>
        /// Divides the x-component of the <see cref="Vector3"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to divide by.</param>
        /// <returns>A new <see cref="Vector3"/> with the divided x-component.</returns>
        public static Vector3 DivideX(this Vector3 self, float x)
            => new(self.x / x, self.y, self.z);
        
        /// <summary>
        /// Divides the y-component of the <see cref="Vector3"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="y">The value to divide by.</param>
        /// <returns>A new <see cref="Vector3"/> with the divided y-component.</returns>
        public static Vector3 DivideY(this Vector3 self, float y)
            => new(self.x, self.y / y, self.z);
        
        /// <summary>
        /// Divides the z-component of the <see cref="Vector3"/> by a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="z">The value to divide by.</param>
        /// <returns>A new <see cref="Vector3"/> with the divided z-component.</returns>
        public static Vector3 DivideZ(this Vector3 self, float z)
            => new(self.x, self.y, self.z / z);

        /// <summary>
        /// Creates a clone of the <see cref="Vector3"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A new <see cref="Vector3"/> with the same components as the original.</returns>
        public static Vector3 Clone(this Vector3 self)
            => new(self.x, self.y, self.z);

        /// <summary>
        /// Replaces the x-component of the <see cref="Vector3"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to set as the x-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the specified x-component.</returns>
        public static Vector3 WithX(this Vector3 self, float x)
            => new(x, self.y, self.z);
        
        /// <summary>
        /// Replaces the y-component of the <see cref="Vector3"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="y">The value to set as the y-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the specified y-component.</returns>
        public static Vector3 WithY(this Vector3 self, float y)
            => new(self.x, y, self.z);
        
        /// <summary>
        /// Replaces the z-component of the <see cref="Vector3"/> with a specified value.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="z">The value to set as the z-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the specified z-component.</returns>
        public static Vector3 WithZ(this Vector3 self, float z)
            => new(self.x, self.y, z);
        
        /// <summary>
        /// Replaces the x- and y-components of the <see cref="Vector3"/> with specified values.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to set as the x-component.</param>
        /// <param name="y">The value to set as the y-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the specified x- and y-components.</returns>
        public static Vector3 WithXY(this Vector3 self, float x, float y)
            => new(x, y, self.z);
        
        /// <summary>
        /// Replaces the x- and z-components of the <see cref="Vector3"/> with specified values.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="x">The value to set as the x-component.</param>
        /// <param name="z">The value to set as the z-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the specified x- and z-components.</returns>
        public static Vector3 WithXZ(this Vector3 self, float x, float z)
            => new(x, self.y, z);
        
        /// <summary>
        /// Replaces the y- and z-components of the <see cref="Vector3"/> with specified values.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <param name="y">The value to set as the y-component.</param>
        /// <param name="z">The value to set as the z-component.</param>
        /// <returns>A new <see cref="Vector3"/> with the specified y- and z-components.</returns>
        public static Vector3 WithYZ(this Vector3 self, float y, float z)
            => new(self.x, y, z);

        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector2"/> using the x and y for the new vector's x and y.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2"/> representation of this <see cref="Vector3"/>.</returns>
        public static Vector2 ToVector2XY(this Vector3 self)
            => new(self.x, self.y);
        
        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector2"/> using the x and z for the new vector's x and y.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2"/> representation of this <see cref="Vector3"/>.</returns>
        public static Vector2 ToVector2XZ(this Vector3 self)
            => new(self.x, self.z);
        
        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector2"/> using the y and z for the new vector's x and y.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2"/> representation of this <see cref="Vector3"/>.</returns>
        public static Vector2 ToVector2YZ(this Vector3 self)
            => new(self.y, self.z);
        
        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector2Int"/> by truncating the x and y components to integers.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, using truncated x and y components.</returns>
        public static Vector2Int ToVector2IntXY(this Vector3 self)
            => new((int)self.x, (int)self.y);
        
        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector2Int"/> by truncating the x and z components to integers.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, using truncated x and z components.</returns>
        public static Vector2Int ToVector2IntXZ(this Vector3 self)
            => new((int)self.x, (int)self.z);
        
        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector2Int"/> by truncating the y and z components to integers.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, using truncated y and z components.</returns>
        public static Vector2Int ToVector2IntYZ(this Vector3 self)
            => new((int)self.y, (int)self.z);

        /// <summary>
        /// Converts the <see cref="Vector3"/> to a <see cref="Vector3Int"/> by truncating all components to integers.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of the <see cref="Vector3"/>, using truncated x, y, and z components.</returns>
        public static Vector3Int ToVector3Int(this Vector3 self)
            => new((int)self.x, (int)self.y, (int)self.z);

        /// <summary>
        /// Floors the x and y components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with floored x and y components.</returns>
        public static Vector2Int FloorToIntXY(this Vector3 self)
            => new()
            {
                x = Mathf.FloorToInt(self.x),
                y = Mathf.FloorToInt(self.y),
            };

        /// <summary>
        /// Floors the x and z components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with floored x and z components.</returns>
        public static Vector2Int FloorToIntXZ(this Vector3 self)
            => new()
            {
                x = Mathf.FloorToInt(self.x),
                y = Mathf.FloorToInt(self.z),
            };

        /// <summary>
        /// Floors the y and z components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with floored y and z components.</returns>
        public static Vector2Int FloorToIntYZ(this Vector3 self)
            => new()
            {
                x = Mathf.FloorToInt(self.y),
                y = Mathf.FloorToInt(self.z),
            };

        /// <summary>
        /// Ceils the x and y components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with ceiled x and y components.</returns>
        public static Vector2Int CeilToIntXY(this Vector3 self)
            => new()
            {
                x = Mathf.CeilToInt(self.x),
                y = Mathf.CeilToInt(self.y),
            };
        
        /// <summary>
        /// Ceils the x and z components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with ceiled x and z components.</returns>
        public static Vector2Int CeilToIntXZ(this Vector3 self)
            => new()
            {
                x = Mathf.CeilToInt(self.x),
                y = Mathf.CeilToInt(self.z),
            };

        /// <summary>
        /// Ceils the y and z components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with ceiled y and z components.</returns>
        public static Vector2Int CeilToIntYZ(this Vector3 self)
            => new()
            {
                x = Mathf.CeilToInt(self.y),
                y = Mathf.CeilToInt(self.z),
            };

        /// <summary>
        /// Rounds the x and y components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with rounded x and y components.</returns>
        public static Vector2Int RoundToIntXY(this Vector3 self)
            => new()
            {
                x = Mathf.RoundToInt(self.x),
                y = Mathf.RoundToInt(self.y),
            };
        
        /// <summary>
        /// Rounds the x and z components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with rounded x and z components.</returns>
        public static Vector2Int RoundToIntXZ(this Vector3 self)
            => new()
            {
                x = Mathf.RoundToInt(self.x),
                y = Mathf.RoundToInt(self.z),
            };
        
        /// <summary>
        /// Rounds the y and z components of the <see cref="Vector3"/> and converts them to a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector2Int"/> representation of the <see cref="Vector3"/>, with rounded y and z components.</returns>
        public static Vector2Int RoundToIntYZ(this Vector3 self)
            => new()
            {
                x = Mathf.RoundToInt(self.y),
                y = Mathf.RoundToInt(self.z),
            };
        
        /// <summary>
        /// Floors all components of the <see cref="Vector3"/> and converts them to a <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of the <see cref="Vector3"/>, with floored x, y, and z components.</returns>
        public static Vector3Int FloorToInt(this Vector3 self)
            => Vector3Int.FloorToInt(self);
        
        /// <summary>
        /// Ceils all components of the <see cref="Vector3"/> and converts them to a <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of the <see cref="Vector3"/>, with ceiled x, y, and z components.</returns>
        public static Vector3Int CeilToInt(this Vector3 self)
            => Vector3Int.CeilToInt(self);

        /// <summary>
        /// Rounds all components of the <see cref="Vector3"/> and converts them to a <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="self">The original <see cref="Vector3"/>.</param>
        /// <returns>A <see cref="Vector3Int"/> representation of the <see cref="Vector3"/>, with rounded x, y, and z components.</returns>
        public static Vector3Int RoundToInt(this Vector3 self)
            => Vector3Int.RoundToInt(self);
    }
}