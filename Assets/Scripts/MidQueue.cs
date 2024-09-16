using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Fila meio termo:
 * - nunca loopa os "ponteiros"
 * - apenas reescreve os elementos da fila quando necessario
 * - => (ok) definitivamente uma das implementacoes ja implementadas de todas as implementacoes...
 */
public class MidQueue
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

    public MidQueue(int newSize = 5)
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
        this.rear++;
        this.count++;
        if (this.rear == this.size)
        {
            for (int index = 0; index < this.count; index++) { this.memory[index] = this.memory[this.front + index]; }
            this.front = 0;
            this.rear = this.count;
        }
        return true;
    }

    public int Dequeue()
    {
        if (this.count == 0) { Debug.Assert(false, "empty"); return -1; }
        int result = this.memory[this.front];
        this.front++;
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
