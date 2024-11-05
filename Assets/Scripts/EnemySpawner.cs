using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private float spawnTime;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float positionX = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);
            float positionY = stageData.LimitMax.y + 1.0f;

            Instantiate(enemyPrefab, new Vector3(positionX, positionY, 0.0f), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
