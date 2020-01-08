using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LevelSpec")] // Aparece no menu "Assets"
public class LevelSpec : ScriptableObject // Estende ScriptableObject
{
    // Variaveis do editor
    [SerializeField] private Vector3[] enemySpawnPoints = null;
    // Propriedade para aceder à variável
    public IEnumerable<Vector3> EnemySpawnPoints => enemySpawnPoints;
}
