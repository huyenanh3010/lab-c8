using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyFastPrefab;
    public GameObject enemyStrongPrefab;

    public float spawnInterval = 2f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        int rand = Random.Range(0, 2);

        GameObject enemy;

        if (rand == 0)
        {
            enemy = enemyFastPrefab;
        }
        else
        {
            enemy = enemyStrongPrefab;
        }

        Vector2 spawnPos = new Vector2(Random.Range(-3f, 3f), transform.position.y);

        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
}