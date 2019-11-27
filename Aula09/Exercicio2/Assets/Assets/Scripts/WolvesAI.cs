using UnityEngine;

public class WolvesAI : AnimalsAI
{
    protected override void SelectTarget()
    {
        Debug.Log("Wolves select target");
    }
    protected override void Move()
    {
        Debug.Log("Wolves move");
    }
    protected override void TryEat()
    {
        Debug.Log("Wolves try to eat");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Wolves try to reproduce");
    }
}
