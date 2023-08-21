using UnityEngine;

public class Buddy : Player
{
    // Override the AddDamage method to change the damage range
    public override void AddDamage(int damage)
    {
        damage= Random.Range(0, 41);
        hp -= damage;// 0~40のランダムな値でHPを減少
        Debug.Log("damage: " + damage + ", hp: " + hp);

        if (hp <= 0)
        {
            Debug.Log("Buddy has taken damage and has 0 HP");
            hp = 0; // Ensure HP doesn't go negative
        }

        DisplayHpValue(); // UI update
    }
}
