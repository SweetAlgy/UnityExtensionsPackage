# Unity Extensions

A Unity package providing extension methods for `Vector2`, `Vector3`, `Vector2Int`, and `Vector3Int` structures. This
library significantly simplifies vector manipulation in Unity by enhancing Unity's built-in vector types with concise
and readable APIs.

## Features

This package provides a comprehensive set of extension methods for Unity's vector types:
1. **Component-wise addition, subtraction, multiplication, and division**
   Modify individual components of `Vector2`, `Vector3`, `Vector2Int`, and `Vector3Int` with simple and intuitive methods.
2. **Cloning vectors**
   Easily create a copy of a vector.
3. **Update individual components**
   Replace specific components (`x`, `y`, `z`) of a vector using methods like `WithX`, `WithY`, and `WithZ`.
4. **Conversion methods**
   Convert between `Vector2`, `Vector3`, `Vector2Int`, and `Vector3Int` using straightforward methods.
5. **Rounding, flooring, and ceiling**
   Round, floor, or ceil vector components quickly with helper methods.
6. 
## Why Use This Package?
Manipulating Unity's native `Vector` types often results in verbose and repetitive code. For example, updating a single component of a `Vector3` often requires recreating the vector:
``` c#
// Without my Unity Extensions package
Vector3 position = originalPosition;
position = new Vector3(1.5f, position.y, position.z);
```
With this package, the same code becomes significantly easier to write and understand:
``` c#
// With my Unity Extensions package
Vector3 position = originalPosition.WithX(1.5f);
```
The library removes common boilerplate code and makes manipulation of Unity vectors faster, more expressive, and less error-prone.

## Installation
You can install this package in Unity using the following steps:
1. Open your Unity project.
2. Navigate to **Window** -> **Package Manager**.
3. Add the package manually by clicking the **+** button at the top left, selecting **Add package from git URL**, and entering:
``` 
   https://github.com/SweetAlgy/UnityExtensionsPackage.git
```
1. Alternatively, download the source and copy the `.cs` files into your Unity project (e.g., in the `Assets/Scripts` folder).

That's it! You can now start using the extension methods in your scripts.

## Usage
Below are some examples demonstrating how to use the extension methods:
### Modify a Single Component
``` c#
// Create a new vector with the X component changed
Vector3 newPosition = originalPosition.WithX(10.5f);
```
### Add to a Component
``` c#
// Add 1 to the Y component of a Vector2
Vector2 newPosition = originalPosition.AddY(1.0f);
```
### Round, Floor, or Ceil the Components
``` c#
// Floor the components of a Vector3 and convert to Vector3Int
Vector3Int flooredVector = originalPosition.FloorToInt();

// Round a Vector2 to the nearest integers
Vector2Int roundedVector = originalPosition.RoundToInt();
```
### Convert Between Types
``` c#
// Convert Vector3 to Vector2 using the X and Z components
Vector2 convertedVector = originalPosition.ToVector2XZ();

// Convert Vector2 to Vector3 with a custom Z value
Vector3 convertedVector = originalPosition.ToVector3XY(5.0f);
```
### Clone a Vector
``` c#
// Create a copy of a vector
Vector3 copy = originalPosition.Clone();
```
### Combine Components
``` c#
// Replace X and Y of a Vector3
Vector3 combinedVector = originalPosition.WithXY(2.5f, 3.0f);
```
### Other Examples
Change two vector components at once:
``` c#
// Update both Y and Z of a Vector3
Vector3 updatedVector = originalVector.WithYZ(4.5f, 9.5f);
```
Operate on individual components:
``` c#
// Multiply X by a scalar
Vector3 scaledVector = originalVector.MultiplyX(3.5f);
```
## Integration in Your Project
Once installed, you can start using the library by adding the appropriate namespace at the top of your script:
``` c#
using SweetAlgy.Extensions;
```
For example:
``` c#
using UnityEngine;
using SweetAlgy.Extensions;

public class Example : MonoBehaviour
{
    void Start()
    {
        Vector3 position = transform.position
            .WithX(10.0f)
            .AddY(2.0f);

        Debug.Log(position);
    }
}
```

## License
This project is licensed under the **MIT License**. See the LICENSE file for details.
