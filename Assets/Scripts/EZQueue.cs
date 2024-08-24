using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EZQueue
{
    private int[] memory;
    private int count;
    private int size;

    public int Count { get { return this.count; } }
    public int Size { get { return this.size; } }

    public EZQueue(int newSize)
    {
        this.size = newSize;
        this.memory = new int[this.size];
    }

    public bool Enqueue(int value)
    {
        if (this.count == this.size) { Debug.Log("full"); return false; }
        this.memory[this.count++] = value;
        return true;
    }

    public int Dequeue()
    {
        if (this.count == 0) { Debug.Assert(false, "empty"); return -1; }
        int result = this.memory[0];
        for (int index = 0; index <= this.count; index++)
        {
            if (index == this.size - 1) break;
            this.memory[index] = this.memory[index + 1];
        }
        this.count--;
        return result;
    }

    public void Clear()
    {
        this.count = 0;
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
