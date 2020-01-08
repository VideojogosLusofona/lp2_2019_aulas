using UnityEngine;

public class Level : MonoBehaviour
{
    // Variaveis do editor
    [SerializeField] private GameObject enemyPrefab = null;
    [SerializeField] private LevelSpec levelSpec = null;

    private void Awake()
    {
        // Spawn dos inimigos
        foreach (Vector3 pos in levelSpec.EnemySpawnPoints)
        {
            GameObject newEnemy =
                Instantiate(enemyPrefab, pos, Quaternion.identity);
        }
    }
}