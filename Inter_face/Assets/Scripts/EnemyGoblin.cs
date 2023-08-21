using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGoblin : MonoBehaviour, IDamagable
{
    // キャラクターのHPを代入する変数
    public int hp = 100;
    // 残りHPを表示するテキスト
    [SerializeField] private Text hpText;

    private void Start()
    {
        DisplayHpValue(); // 初期のHPを表示
    }

    /// <summary>
    /// HPの値をHpへ表示するメソッド
    /// </summary>
    protected void DisplayHpValue()
    {
        hpText.text = "HP: " + hp.ToString();
    }

    public virtual　void AddDamage(int  damage)
    {
        damage=Random.Range(0, 21); // 0~20のランダムな値でHPを減少
        hp -= damage;
        Debug.Log("damage: " + damage + ", hp: " + hp);

        // HPが0になった場合の処理
        if (hp <= 0)
        {
            Debug.Log("Goblinは倒れた！");
            hp = 0; // HPが負にならないように
        }

        DisplayHpValue(); // UIの更新
    }
}

