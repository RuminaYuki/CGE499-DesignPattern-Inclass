using System;
using System.Collections;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private readonly ArrayList _observer = new ArrayList();

    public void Attach(Observer observer)
    {
        _observer.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observer.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach(Observer observer in _observer)
        {
            observer.Notify(this);
        }
    }
}
