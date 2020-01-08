using UnityEngine;

[CreateAssetMenu]
public class EnemyModel : ScriptableObject
{
    // Dados intrínsecos ao inimigo
    [SerializeField] private Sprite sprite = null;

    // Propriedade para aceder externamente a estes dados
    public Sprite Sprite => sprite;
}
