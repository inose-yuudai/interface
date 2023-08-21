using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 敵関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Enemys;
    // プレイヤー関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Players;

    /// <summary>
    /// Player側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void PlayerAttack()
    {
        // 1つの敵をランダムに選択
        GameObject targetEnemy = Enemys[Random.Range(0, Enemys.Length)];

        // IDamagableインターフェースを取得して、ダメージを与える
        IDamagable damagable = targetEnemy.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.AddDamage(Random.Range(0, 11)); 
        }
        else
        {
            Debug.Log("あああ");
        }
    }

    /// <summary>
    /// Enemy側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void EnemyAttack()
    {
        // 1つのプレイヤーをランダムに選択
        GameObject targetPlayer = Players[Random.Range(0, Players.Length)];

        // IDamagableインターフェースを取得して、ダメージを与える
        IDamagable damagable = targetPlayer.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.AddDamage(Random.Range(0, 21)); 
        }
    }

    /// <summary>
    /// プレイヤーを回復させる際に呼び出すメソッド
    /// </summary>
    public void PlayerHeal()
    {
        foreach (GameObject player in Players)
        {
            // IHealableインターフェースを取得して、HPを回復する
            IHealable healable = player.GetComponent<IHealable>();
            if (healable != null)
            {
                healable.AddHp(10); // HPを10回復させる
            }
        }
    }
}
