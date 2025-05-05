using UnityEngine;
public enum AntType
{
    Muther,
    Worker,
    Fighter,
    Larva
}

public class AntStats 
{
    public AntType Type { get; set; }
    public float Speed { get; set; }
    public float Streng { get; set; }
    public Vector2 Size { get; set; }
    public Sprite Sprite { get; set; }

}
