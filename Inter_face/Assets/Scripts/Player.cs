using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, IDamagable, IHealable
{
    // キャラクターのHPを代入する変数
    public int hp = 100;
    // 残りHPを表示するテキスト
    [SerializeField] private Text hpText;

    public void Start()
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

    public virtual void AddDamage(int damage)
    {
        damage = Random.Range(0, 11);
        hp -= damage; 
        Debug.Log("damage: " + damage + ", hp: " + hp);

        if (hp <= 0)
        {
            Debug.Log("Character has taken damage and has 0 HP");
            hp = 0; // Ensure HP doesn't go negative
        }

        DisplayHpValue(); // UI update
    }

    public void AddHp(int heal)
    {
        hp += heal;
        Debug.Log("heal: " + heal + ", hp: " + hp);
        DisplayHpValue(); // UIの更新
    }
}
