# Area Calculator

This C# library provides functionality for calculating the area of geometric shapes such as circles and triangles. It is designed for external client use and includes features for easy extension to support additional shapes.

## Features

- **Circle Area Calculation:** Calculate the area of a circle using its radius.
- **Triangle Area Calculation:** Calculate the area of a triangle using three side lengths.
- **Right Triangle Check:** Verify whether a triangle is a right-angled triangle.
- **Unit Tests:** Includes a comprehensive set of unit tests to ensure the reliability of the library.

## Usage

### Circle Area Calculation

```csharp
double radius = 5.0;
IFigure circle = new Circle(radius);

FigureAreaCalculator areaCalculator = new FigureAreaCalculator();
double circleArea = areaCalculator.CalculateArea(circle);

Console.WriteLine($"Area of the circle with radius {radius}: {circleArea}");
```

### Triangle Area Calculation

```csharp
double sideA = 3.0;
double sideB = 4.0;
double sideC = 5.0;
IFigure triangle = new Triangle(sideA, sideB, sideC);

FigureAreaCalculator areaCalculator = new FigureAreaCalculator();
double triangleArea = areaCalculator.CalculateArea(triangle);

Console.WriteLine($"Area of the triangle with sides {sideA}, {sideB}, {sideC}: {triangleArea}");
```

### Right Triangle Check

```csharp
double sideA = 3.0;
double sideB = 4.0;
double sideC = 5.0;
Triangle triangleToCheck = new Triangle(sideA, sideB, sideC);

string triangleCheckResult = triangleToCheck.IsRightTriangle() ? "right angled triangle." : "non-right angled triangle.";

Console.WriteLine($"Triangle with sides {sideA}, {sideB}, {sideC} is a " + triangleCheckResult);
```

### Adding Support for New Shapes
To add support for new shapes, implement the corresponding interface IFigure to the class of a new geometric shape.
