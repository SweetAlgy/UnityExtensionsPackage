# Unity Extensions

A Unity package that simplifies development by providing extension methods for various commonly used operations. These
extensions help streamline object manipulations and configurations in a fluent and readable manner, reducing boilerplate
code.

---

## Table of Contents

1. [Features](#features)
2. [Why Use This Package?](#why-use-this-package)
3. [Installation](#installation)
4. [Usage](#usage)
   - [Vector Extensions](#vector-extensions)
   - [Fluent Object Configuration](#fluent-object-configuration)
5. [Integration in Your Project](#integration-in-your-project)
6. [License](#license)

---

## Features

The package includes a variety of enhancements, including:
1. **Vector Manipulations**
   - Easily update vector components (`x`, `y`, `z`) using fluent syntax.
   - Perform component-wise operations (addition, rounding, conversions, etc.).
   - Simplify type conversions between `Vector2`, `Vector3`, `Vector2Int`, and `Vector3Int`.
2. **Fluent Object Configuration**
   - Configure objects with fluent, conditional, and expressive methods.
   - Perform operations based on object states (e.g., null checks).
   - Ensure better readability and maintainability in configuring object behavior.

---

## Why Use This Package?

This package aims to improve productivity by reducing common patterns of boilerplate code in Unity. Whether you're manipulating Unity's `Vector` structures or working with custom objects, these extensions provide clean APIs to simplify your workflows.

Without this package:
```c#
Vector3 position = transform.position;
position = new Vector3(1.0f, position.y, position.z); // Verbose and error-prone
```

With this package:
```c#
Vector3 position = transform.position.WithX(1.0f); // Clean and expressive
```

Object configuration without this package:
```c#
if (myObject != null)
{
    if (shouldModify)
    {
        myObject.Property = value;
    }
}
```

Using Fluent Extensions:
```c#
myObject
    .IfNotNull(o => o.Property = value)
    .If(shouldModify, o => o.OtherProperty = anotherValue);
```

---

## Installation

**Steps to install:**

1. Open your Unity project.
2. Navigate to **Window** -> **Package Manager**.
3. Add the package manually by selecting **Add package from git URL** and entering:
   ```
   https://github.com/SweetAlgy/UnityExtensionsPackage.git
   ```
4. Alternatively, download the source files and add them to your `Assets/Scripts/` folder.

---

## Usage

### Vector Extensions

This package enhances Unity's vector types by providing easy-to-use APIs for manipulating components, type conversion, and more.

#### Modify a Single Component

```c#
// Assume originalPosition is a Vector3 (1.0f, 2.0f, 3.0f)
Vector3 originalPosition = new Vector3(1.0f, 2.0f, 3.0f);

// Create a new vector with the X component changed
Vector3 newPosition = originalPosition.WithX(10.5f);

// Outputs:
Debug.Log(originalPosition); // Outputs: (1.0, 2.0, 3.0)
Debug.Log(newPosition);      // Outputs: (10.5, 2.0, 3.0)
```

#### Add to a Component

```c#
// Assume originalPosition is a Vector2 (2.0f, 3.0f)
Vector2 originalPosition = new Vector2(2.0f, 3.0f);

// Add 1 to the Y component of a Vector2
Vector2 newPosition = originalPosition.AddY(1.0f);

// Outputs:
Debug.Log(originalPosition); // Outputs: (2.0, 3.0)
Debug.Log(newPosition);      // Outputs: (2.0, 4.0)
```

#### Round, Floor, or Ceil the Components

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

#### Convert Between Types

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

#### Clone a Vector

```c#
// Assume originalPosition is a Vector3 (3.0f, 4.0f, 5.0f)
Vector3 originalPosition = new Vector3(3.0f, 4.0f, 5.0f);

// Create a copy of a vector
Vector3 copy = originalPosition.Clone();

// Outputs:
Debug.Log(originalPosition); // Outputs: (3.0, 4.0, 5.0)
Debug.Log(copy);             // Outputs: (3.0, 4.0, 5.0)
```

#### Combine Components

```c#
// Assume originalPosition is a Vector3 (1.0f, 2.0f, 3.0f)
Vector3 originalPosition = new Vector3(1.0f, 2.0f, 3.0f);

// Replace X and Y of a Vector3
Vector3 combinedVector = originalPosition.WithXY(2.5f, 3.5f);

// Outputs:
Debug.Log(originalPosition); // Outputs: (1.0, 2.0, 3.0)
Debug.Log(combinedVector);   // Outputs: (2.5, 3.5, 3.0)
```

#### Other Examples

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

### Fluent Object Configuration

Make your workflows for configuring objects clean and readable with fluent extension methods. These extensions are designed to work with any type of object.

#### Fluent Syntax Example

```c#
using SweetAlgy.Extensions;

MyClass obj = new MyClass();

// Fluent configuration
obj.Do(o => o.Property = "Test")
   .If(true, o => o.AnotherProperty = 42)
   .If(() => obj.Property == "Test", o 
       => Console.WriteLine("Property set to Test"));
```
    
#### Conditional Actions

Perform conditional actions with `If`:
```c#
SomeObject.If(isCondition, x => x.SomeConfiguration = true);
SomeObject.If(() => SomeObject is Active, x => x.Property = newValue);
```

#### Handle Null References

Perform actions based on whether an object is `null` or not:
```c#
MyObject
    .IfNull(() => Debug.Log("Object is null"))
    .IfNotNull(o => o.Property = 42);
```

#### Provide a Default Value for Nullables
```c#
MyObject = MyObject.WithDefault(() 
    => new MyClass { Property = "DefaultValue" });
```

---

## Integration in Your Project

Use the extensions after importing the package by referencing the namespace:
```c#
using SweetAlgy.Extensions;
```

Example usage:
```c#
using UnityEngine;
using SweetAlgy.Extensions;

public class Example : MonoBehaviour
{
    void Start()
    {
        Vector3 position = transform.position
            .WithX(10.0f) // Change X-coordinate
            .AddY(2.0f);  // Increase Y-coordinate by 2

        Debug.Log(position);

        MyObject.Do(obj => obj.Property = "Hello").IfNotNull(obj => Debug.Log(obj.Property));
    }
}
```

---

## License

This project is licensed under the **MIT License**. See the LICENSE file for details.
