using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Real Life Queue:
 * - imita o comportamento de uma fila real
 * - reescreve os elementos da fila em toda remocaso
 * - => (péssima) implementacao menos otimizada
 */
public class RLQueue // Real Life Queue: move a fila toda em cada remocao, péssima otimizacao
{
    private int[] memory;
    private int size;
    private int count;

    public int Size { get { return this.size; } }
    public int Count { get { return this.count; } }

    public RLQueue(int inSize = 5)
    {
        this.size = inSize;
        this.memory = new int[this.size];
    }

    public bool Enqueue(int value)
    {
        if (this.count == this.size)
        {
            return false;
        }
        this.memory[this.count++] = value;
        return true;
    }

    public int Dequeue()
    {
        if (this.count == 0)
        {
            Debug.Assert(false, "empty");
        }
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
