public class AreaCalculator {

    // Rectangle
    public static double area(double length, double breadth) {
        return length * breadth;
    }

    // Circle
    public static double area(double radius) {
        return Math.PI * radius * radius;
    }

    // Triangle (distinct method name to avoid ambiguity)
    public static double areaTriangle(double base, double height) {
        return 0.5 * base * height;
    }

    public static void main(String[] args) {
        double rectangle = area(5, 4);
        double circle = area(3);
        double triangle = areaTriangle(6, 3);

        System.out.println("Rectangle Area: " + rectangle);
        System.out.println("Circle Area: " + circle);
        System.out.println("Triangle Area: " + triangle);
    }
}
