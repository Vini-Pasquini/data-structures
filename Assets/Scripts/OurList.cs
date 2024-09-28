using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurList<ListType>
{
    private class Node<NodeType>
    {
        public NodeType value;
        public Node<NodeType> next;

        public Node()
        {
            this.value = default(NodeType);
            this.next = null;
        }

        public Node(NodeType inValue, Node<NodeType> inNext = null)
        {
            this.value = inValue;
            this.next = inNext;
        }
    }
     
    private Node<ListType> _first;
    private Node<ListType> _last;
    private int _count;

    public int Count { get { return _count; } }

    public OurList()
    {
        this._first = this._last = null;
        this._count = 0;
    }

    public void InsertLast(ListType value)
    {
        Node<ListType> newNode = new Node<ListType>(value);
        if (this._first == null) { this._first = newNode; }
        if (this._last != null) { this._last.next = newNode; }
        this._last = newNode;
        this._count++;
    }

    public void InsertFirst(ListType value)
    {
        Node<ListType> newNode = new Node<ListType>(value, this._first);
        this._first = newNode;
        this._count++;
    }

    public void Remove(ListType value)
    {
        // :thonk:
    }
}
