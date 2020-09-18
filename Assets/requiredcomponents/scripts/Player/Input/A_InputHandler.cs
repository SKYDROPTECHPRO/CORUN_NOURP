using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class A_InputHandler : MonoBehaviour
{
    public event Action Applymask;
    public event Action Applysanitizer;
    public event Action Applymedication;
    public event Action Applyenergydrink;

    protected virtual void virtualawake() {}

    // Start is called before the first frame update
    void Awake()
    {
        virtualawake();
        
    }

    public abstract float getinput();

    public virtual void OnApplymask()
    {
        Applymask?.Invoke();
    }

    public virtual void OnApplysanitizer()
    {
        Applysanitizer?.Invoke();
    }

    public virtual void OnApplymedication()
    {
        Applymedication?.Invoke();
    }

    public virtual void OnApplyenergydrink()
    {
        Applyenergydrink?.Invoke();
    }
}
