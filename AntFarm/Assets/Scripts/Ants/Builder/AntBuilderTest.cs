using System.Collections;
using UnityEngine;

public class AntBuilderTest : MonoBehaviour
{
    [SerializeField] GameObject AntPrefab;
    [SerializeField] Sprite AntSprite;
    void Start()
    {
        StartCoroutine(Test());
    }

  

    IEnumerator Test()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            AntBuilder builder = new AntBuilder(AntPrefab, AntSprite);

            var ant = builder.BuildWorker(this.transform.position);
            ant.Move(true);

        }
    }
}
