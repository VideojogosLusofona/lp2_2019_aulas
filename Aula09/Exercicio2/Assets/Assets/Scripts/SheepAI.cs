using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("Sheep move");
    }
    protected override void TryEat()
    {
        Debug.Log("Sheep try to eat");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Sheep try to reproduce");
    }
}
