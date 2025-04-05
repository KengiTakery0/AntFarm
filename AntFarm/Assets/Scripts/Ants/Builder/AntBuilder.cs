
using UnityEngine;

public class AntBuilder 
{
    public GameObject Prefab { get; private set; }
    public Sprite AntSprite { get; private set; }

    public AntBuilder (GameObject prefab, Sprite antSprite)
    {
        Prefab = prefab;
        AntSprite = antSprite;
    }

    public WorkerAnt BuildWorker()
    {
        GameObject antObj = GameObject.Instantiate(Prefab);
        AntStats antStats = new()
        {
            Sprite = AntSprite,
            Type = Type.Worker,
            Speed = Random.Range(0.5f, 1.0f),
            Streng = 10f,
            Size = new Vector2(0.5f, 0.5f),
        };
        WorkerAnt Ant = antObj.AddComponent<WorkerAnt>().GetComponent<WorkerAnt>();
        Ant.Stats = antStats; 
        Ant.GetComponent<SpriteRenderer>().sprite = Ant.Stats.Sprite;
        Ant.transform.localScale = Ant.Stats.Size;

        return Ant;
    }
    public FighterAnt BuildFighter()
    {
        GameObject antObj = GameObject.Instantiate(Prefab);
        AntStats antStats = new()
        {
            Sprite = AntSprite,
            Type = Type.Fighter,
            Speed = Random.Range(0.3f, .5f),
            Streng = 10f,
            Size = new Vector2(1f,1f),
        };
        FighterAnt Ant = antObj.AddComponent<FighterAnt>().GetComponent<FighterAnt>();
        Ant.Stats = antStats;
        Ant.GetComponent<SpriteRenderer>().sprite = Ant.Stats.Sprite;
        Ant.transform.localScale = Ant.Stats.Size;

        return Ant;
    }
}
