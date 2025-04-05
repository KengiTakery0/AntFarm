using UnityEngine;
public enum Type
{
    Muther,
    Worker,
    Fighter
}

public class AntStats 
{
    public Type Type { get; set; }
    public float Speed { get; set; }
    public float Streng { get; set; }
    public Vector2 Size { get; set; }
    public Sprite Sprite { get; set; }

}
