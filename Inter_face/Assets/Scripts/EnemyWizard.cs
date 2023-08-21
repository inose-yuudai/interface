using UnityEngine;

public class EnemyWizard : EnemyGoblin
{
    // AddDamageメソッドをオーバーライドして、ダメージ量を0~40の範囲に変更します
    public override void AddDamage(int damage)
    {
        damage=Random.Range(0, 41); // 0~40のランダムな値でHPを減少
        hp -= damage;
        Debug.Log("damage: " + damage + ", hp: " + hp);

        if (hp <= 0)
        {
            Debug.Log("EnemyWizard has taken damage and has 0 HP");
            hp = 0; // HPが負にならないように
        }

        DisplayHpValue(); // UIの更新
    }
}
