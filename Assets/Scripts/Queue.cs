using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue
{
    private int[] memory;
    private int count;
    private int size;
    private int front;
    private int rear;

    public int Count { get { return this.count; } }
    public int Size { get { return this.size; } }
    public int Front { get { return this.front; } }
    public int Rear { get { return this.rear; } }

    public Queue(int newSize)
    {
        this.front = 0;
        this.rear = 0;
        this.size = newSize;
        this.memory = new int[this.size];
    }

    public bool Enqueue(int value)
    {
        if (this.count == this.size) { Debug.Log("full"); return false; }
        this.memory[this.rear] = value;
        this.rear = (this.rear + 1 >= this.size ? 0 : this.rear + 1);
        this.count++;
        return true;
    }

    public int Dequeue()
    {
        if (this.count == 0) { Debug.Assert(false, "empty"); return -1; }
        int result = this.memory[this.front];
        this.front = (this.front + 1 >= this.size ? 0 : this.front + 1);
        this.count--;
        return result;
    }

    public void Clear()
    {
        this.rear = this.front = this.count = 0;
    }

    public bool isEmpty()
    {
        if (this.count == 0) { return true; }
        return false;
    }

    public bool isFull()
    {
        if (this.count == this.size) { return true; }
        return false;
    }
}
