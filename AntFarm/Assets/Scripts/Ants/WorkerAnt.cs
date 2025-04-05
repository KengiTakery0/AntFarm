using System.Collections;
using UnityEngine;

public class WorkerAnt : Ant
{
    protected override void Awake()
    {
        base.Awake();
        Move();
    }
   
    IEnumerator Base()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(0.2f);
            rb.linearVelocity = new Vector2(Mathf.Cos(rb.rotation), Mathf.Sin(rb.rotation)) * Stats.Speed;
            yield return new WaitForSecondsRealtime(1f);
              rb.rotation = Random.Range(0, 360);
           
        }
    }
    public void Build() { }

    protected override void Move()
    {
        StartCoroutine(Base());
    }
}
