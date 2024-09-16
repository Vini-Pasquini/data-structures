using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Fila Apelona:
 * - loopa os "ponteiros" quando necessário
 * - nao reescreve nenhum elemento, nunca
 * - => (ótima) implementacao mais otimizada
 */
public class OPQueue
{
    private int[] memory;
    private int size;
    private int count;
    private int front;
    private int rear;

    public int Size { get { return this.size; } }
    public int Count { get { return this.count; } }

    public OPQueue(int inSize = 5)
    {
        this.front = this.rear = this.count = 0; // todos os atributos da linha recebem o valor 0
        this.size = inSize;
        this.memory = new int[this.size];
    }

    public bool Enqueue(int value)
    {
        if (this.count == this.size)
        {
            return false;
        }
        this.memory[this.rear] = value;
        this.rear++;
        if (this.rear == this.size)
        {
            this.rear = 0;
        }
        this.count++;
        return true;
    }

    public int Dequeue(int valor)
    {
        if (this.count == 0)
        {
            Debug.Assert(false);
        }
        int result = this.memory[this.front];
        this.front++;
        if (this.front == this.size)
        {
            this.front = 0;
        }
        this.count--;
        return result;
    }

    public void Clear()
    {
        this.rear = this.front = this.count = 0; // todos os atributos da linha recebem o valor 0
        
        /* Equivalente a fazer:
         * this.rear = 0;
         * this.front = 0;
         * this.count = 0;
         */
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
