using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    public int playerSizeInt;
    public int playerHealthInt;
    public int playerAttackInt;





    void PlayerBuild()
    {
        playerSizeInt = Random.Range(1, 4);
        PlayerHealthAttack();
    }
    
    void PlayerHealthAttack()
    {
        if (playerSizeInt == 1)
        {
            playerHealthInt = Random.Range(1, 34);
            playerAttackInt = Random.Range(1, 18);
        }

        else if (playerSizeInt == 2)
        {
            playerHealthInt = Random.Range(1, 67);
            playerAttackInt = Random.Range(1,34);
        }
        else
            {
            playerHealthInt = Random.Range(1, 100);
            playerAttackInt = Random.Range(1, 50);
        }
    }

}
