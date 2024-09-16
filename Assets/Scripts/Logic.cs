using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    private void Start()
    {
        // stack test
        Stack myStack = new Stack();

        // rl queue test
        RLQueue myEZQueue = new RLQueue();

        // mid queue test
        MidQueue myMidQueue = new MidQueue();

        // queue test
        OPQueue myQueue = new OPQueue();
    }
}
