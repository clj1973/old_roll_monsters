using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour {

    public int enemySizeInt;
    public int enemyHealthInt;
    public int enemyAttackInt;





    void PlayerBuild()
    {
        enemySizeInt = Random.Range(1, 4);
        PlayerHealthAttack();
    }

    void PlayerHealthAttack()
    {
        if (enemySizeInt == 1)
        {
            enemyHealthInt = Random.Range(1, 34);
            enemyAttackInt = Random.Range(1, 18);
        }

        else if (enemySizeInt == 2)
        {
            enemyHealthInt = Random.Range(1, 67);
            enemyAttackInt = Random.Range(1, 34);
        }
        else
        {
            enemyHealthInt = Random.Range(1, 100);
            enemyAttackInt = Random.Range(1, 50);
        }
    }

}