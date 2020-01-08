using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Instância que contém os dados intrínsecos dos inimigos
    [SerializeField] private EnemyModel model = null;

    private void Awake()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = model.Sprite;
    }
}
