using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscruber : MonoBehaviour
{
    private string v;

    public Subscruber(string v)
    {
        this.v = v;
    }

    public void ShowMessage()
    {
        print(this.v);
    }
}

public class Test : MonoBehaviour
{
    private List<Subscruber> subscribers;

    // Start is called before the first frame update
    void Start()
    {

        var sub1 = new Subscruber("Sub 1 message");
        var sub2 = new Subscruber("Sub 2 message");

        subscribers = new List<Subscruber>();
        subscribers.Add(sub1);
        subscribers.Add(sub2);
    }

    public void OnClick()
    {
        foreach (Subscruber subs in subscribers)
        {
            subs.ShowMessage();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
