using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack
{
    private int[] memory;
    private int count;
    private int size;

    public int Count { get { return this.count; } }
    public int Size { get { return this.size; } }

    public Stack(int newSize = 5)
    {
        this.count = 0;
        this.size = newSize;
        this.memory = new int[this.size];
    }

    public bool Push(int value)
    {
        if (this.count == this.size) { Debug.Log("full stack"); return false; }
        this.memory[this.count++] = value;
        return true;
    }

    public int Pop()
    {
        if (this.count == 0) { Debug.Assert(false, "empty stack"); return -1; }
        return this.memory[--this.count];
    }

    public int Top()
    {
        if (this.count == 0) { Debug.Assert(false, "empty stack"); return -1; }
        return this.memory[this.count - 1];
    }

    public bool Clear()
    {
        this.count = 0;
        return true;
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
