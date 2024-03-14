using System.Runtime.CompilerServices;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add two items with different priorities and remove the highest priority item.
        // Expected Result: Display items
        Console.WriteLine("Test 1");
        var items = new PriorityQueue();
        items.Enqueue("book", 1);
        items.Enqueue("stapler", 3);
        items.Enqueue("paper", 2);
        Console.WriteLine($"Item added: {items}");
        items.Dequeue();
        Console.WriteLine($"Item left: {items}");

        // Defect(s) Found: Items display but nothing is removed.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add no items
        // Expected Result: Error message displays
        Console.WriteLine("Test 2");
        var item = new PriorityQueue();
        item.Dequeue();

        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}