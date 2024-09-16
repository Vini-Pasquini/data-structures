using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack
{
    private int[] memory;
    private int size;
    private int count;

    public int Size { get { return this.size; } }
    public int Count { get { return this.count; } }

    public Stack(int inSize = 5)
    {
        this.count = 0;
        this.size = inSize;
        this.memory = new int[this.size];
    }

    public bool Push(int value)
    {
        if (this.count == this.size)
        {
            return false;
        }
        this.memory[this.count] = value;
        this.count++;
        return true;
    }

    public int Pop()
    {
        if (this.count == 0)
        {
            Debug.Assert(false);
        }
        int result = this.memory[this.count];
        this.count--;
        return result;
    }

    public int Top()
    {
        if (this.count == 0)
        {
            Debug.Assert(false);
        }
        return this.memory[this.count - 1];
    }

    public void Clear()
    {
        this.count = 0;
    }

    public bool isEmpty()
    {
        return this.count == 0; // expressao booleana, resulta em verdadeiro ou falso

        /* "Equivalente"
         * if (this.count == 0)
         * {
         *     return true;
         * }
         * return false;
         */
    }

    public bool isFull()
    {
        return this.count == this.size; // expressao booleana, resulta em verdadeiro ou falso

        /* "Equivalente"
         * if (this.count == this.size)
         * {
         *     return true;
         * }
         * return false;
         */
    }
}
