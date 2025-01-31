using System;

// Класс узла списка
public class Node(int value)
{
    public int Value { get; set; } = value;
    public Node Next { get; set; }
}

// Класс односвязного списка
public class SinglyLinkedList
{
    private Node? head;

    public void AddFirst(int value)
    {
        var newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
    }

    // Переворот списка
    public void Reverse()
    {
        if (head == null || head.Next == null) return;

        Node prev = null;
        Node current = head;
        while (current != null)
        {
            Node next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        head = prev;
    }

    // Вывод содержимого списка
    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList list = new SinglyLinkedList();

        // Заполнение списка элементами
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddFirst(1);

        // Вывод исходного списка
        Console.Write("Исходный список: ");
        list.Print();

        // Переворот списка
        list.Reverse();

        // Вывод перевернутого списка
        Console.Write("Перевёрнутый список: ");
        list.Print();
    }
}