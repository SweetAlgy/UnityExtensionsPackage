# Unity Extensions

A Unity package providing extension methods for `Vector2`, `Vector3`, `Vector2Int`, and `Vector3Int` structures. This
library significantly simplifies vector manipulation in Unity by enhancing Unity's built-in vector types with concise
and readable APIs.

---

## Table of Contents

1. [Features](#features)
2. [Why Use This Package?](#why-use-this-package)
3. [Installation](#installation)
4. [Usage](#usage)
   - [Modify a Single Component](#modify-a-single-component)
   - [Add to a Component](#add-to-a-component)
   - [Round, Floor, or Ceil the Components](#round-floor-or-ceil-the-components)
   - [Convert Between Types](#convert-between-types)
   - [Clone a Vector](#clone-a-vector)
   - [Combine Components](#combine-components)
   - [Other Examples](#other-examples)
5. [Integration in Your Project](#integration-in-your-project)
6. [License](#license)

---

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

All extension methods provided in this package are **immutable**, meaning they do not modify the original vector. Instead, they always create and return a **new instance** of the vector with the desired modifications. This ensures that your existing objects remain unchanged, providing a safer and more predictable programming experience.

---

### Modify a Single Component
```c#
// Assume originalPosition is a Vector3 (1.0f, 2.0f, 3.0f)
Vector3 originalPosition = new Vector3(1.0f, 2.0f, 3.0f);

// Create a new vector with the X component changed
Vector3 newPosition = originalPosition.WithX(10.5f);

// Outputs:
Debug.Log(originalPosition); // Outputs: (1.0, 2.0, 3.0)
Debug.Log(newPosition);      // Outputs: (10.5, 2.0, 3.0)
```

---

### Add to a Component
```c#
// Assume originalPosition is a Vector2 (2.0f, 3.0f)
Vector2 originalPosition = new Vector2(2.0f, 3.0f);

// Add 1 to the Y component of a Vector2
Vector2 newPosition = originalPosition.AddY(1.0f);

// Outputs:
Debug.Log(originalPosition); // Outputs: (2.0, 3.0)
Debug.Log(newPosition);      // Outputs: (2.0, 4.0)
```

---

### Round, Floor, or Ceil the Components
```c#
// Assume originalPosition is a Vector3 (2.7f, -1.3f, 4.5f)
Vector3 originalPosition = new Vector3(2.7f, -1.3f, 4.5f);

// Floor the components of a Vector3 and convert to Vector3Int
Vector3Int flooredVector = originalPosition.FloorToInt();

// Outputs:
Debug.Log(originalPosition); // Outputs: (2.7, -1.3, 4.5)
Debug.Log(flooredVector);    // Outputs: (2, -2, 4)

// Round a Vector2 to the nearest integers
Vector2 originalVector2 = new Vector2(1.3f, 3.8f);
Vector2Int roundedVector = originalVector2.RoundToInt(); 

// Outputs:
Debug.Log(originalVector2);  // Outputs: (1.3, 3.8)
Debug.Log(roundedVector);    // Outputs: (1, 4)
```

---

### Convert Between Types
```c#
// Assume originalPosition is a Vector3 (1.0f, 2.0f, 3.0f)
Vector3 originalPosition = new Vector3(1.0f, 2.0f, 3.0f);

// Convert Vector3 to Vector2 using the X and Z components
Vector2 convertedVector = originalPosition.ToVector2XZ(); 

// Outputs:
Debug.Log(originalPosition); // Outputs: (1.0, 2.0, 3.0)
Debug.Log(convertedVector);  // Outputs: (1.0, 3.0)

// Convert Vector2 to Vector3 with a custom Z value
Vector2 originalVector2 = new Vector2(4.0f, 5.0f);
Vector3 convertedVector2 = originalVector2.ToVector3XY(10.0f);

// Outputs:
Debug.Log(originalVector2);  // Outputs: (4.0, 5.0)
Debug.Log(convertedVector2); // Outputs: (4.0, 5.0, 10.0)
```

---

### Clone a Vector
```c#
// Assume originalPosition is a Vector3 (3.0f, 4.0f, 5.0f)
Vector3 originalPosition = new Vector3(3.0f, 4.0f, 5.0f);

// Create a copy of a vector
Vector3 copy = originalPosition.Clone();

// Outputs:
Debug.Log(originalPosition); // Outputs: (3.0, 4.0, 5.0)
Debug.Log(copy);             // Outputs: (3.0, 4.0, 5.0)
```

---

### Combine Components
```c#
// Assume originalPosition is a Vector3 (1.0f, 2.0f, 3.0f)
Vector3 originalPosition = new Vector3(1.0f, 2.0f, 3.0f);

// Replace X and Y of a Vector3
Vector3 combinedVector = originalPosition.WithXY(2.5f, 3.5f);

// Outputs:
Debug.Log(originalPosition); // Outputs: (1.0, 2.0, 3.0)
Debug.Log(combinedVector);   // Outputs: (2.5, 3.5, 3.0)
```

---

### Other Examples
Change two vector components at once:
```c#
// Assume originalVector is a Vector3 (2.0f, 3.0f, 4.0f)
Vector3 originalVector = new Vector3(2.0f, 3.0f, 4.0f);

// Update both Y and Z of a Vector3
Vector3 updatedVector = originalVector.WithYZ(4.5f, 9.5f);

// Outputs:
Debug.Log(originalVector);   // Outputs: (2.0, 3.0, 4.0)
Debug.Log(updatedVector);    // Outputs: (2.0, 4.5, 9.5)
```

Operate on individual components:
```c#
// Assume originalVector is a Vector3 (1.0f, 2.0f, 3.0f)
Vector3 originalVector = new Vector3(1.0f, 2.0f, 3.0f);

// Multiply X by a scalar
Vector3 scaledVector = originalVector.MultiplyX(3.5f);

// Outputs:
Debug.Log(originalVector);   // Outputs: (1.0, 2.0, 3.0)
Debug.Log(scaledVector);     // Outputs: (3.5, 2.0, 3.0)
```

---

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
