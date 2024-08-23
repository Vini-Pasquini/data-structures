using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    private void Start()
    {
        // quick test
        Stack myStack = new Stack(10);
        Debug.Log(myStack.Count);
        myStack.Push(1);
        Debug.Log(myStack.Count);
        myStack.Push(2);
        Debug.Log(myStack.Count);
        Debug.Log(myStack.Pop());
        Debug.Log(myStack.Count);
    }
}
