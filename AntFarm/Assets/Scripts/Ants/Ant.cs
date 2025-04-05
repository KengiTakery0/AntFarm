using UnityEngine;

public class Ant : MonoBehaviour
{
    public AntStats Stats;
    public Vector2 MoveDir { get; set; }
    public virtual void Move(bool? random) { }
    public virtual void Grab(GameObject thing) { }
    public virtual void Carry(GameObject thing) { }
    public virtual void Eat(GameObject thing) { }

    protected Rigidbody2D rb;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
    protected virtual void Move() { }

}
