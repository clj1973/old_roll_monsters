using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    public Text playerSizeText = null;
    public Text playerHealthText = null;
    public Text playerAttackText = null;

    public GameObject playerSmallInstan;
    public GameObject playerMediumInstan;
    public GameObject playerLargeInstan;
    public GameObject enemySmallInstan;
    public GameObject enemyMediumInstan;
    public GameObject enemyLargeInstan;

    public Text enemySizeText = null;
    public Text enemyHealthText = null;
    public Text enemyAttackText = null;

	int CoinTossInt;



    int playerSizeInt;
    int playerHealthInt;
    int playerAttackInt;

    int enemySizeInt;
    int enemyHealthInt;
    int enemyAttackInt;



    // Use this for initialization
   void Start () {

		PlayerBuild();
		EnemyBuild();


       // CleanRound();

    }
	
	 //Update is called once per frame
	void Update () {
       

    }



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
            playerAttackInt = Random.Range(1, 34);
        }
        else
        {
            playerHealthInt = Random.Range(1, 100);
            playerAttackInt = Random.Range(1, 50);
       }

        playerSizeText.text = playerSizeInt.ToString();
        playerHealthText.text = playerHealthInt.ToString();
        playerAttackText.text = playerAttackInt.ToString();

       int displayPlayer = System.Convert.ToInt32(playerSizeText.text);

        

        if (displayPlayer == 1)
        {
            Vector3 posSmall = new Vector3(-9, -3, 0);
            Instantiate(playerSmallInstan, posSmall , Quaternion.identity);
        } else if (displayPlayer == 2)
            {
            Vector3 posMedium = new Vector3(-9, -3, 0);
            Instantiate(playerMediumInstan, posMedium, Quaternion.identity);
        }
        else
        {
            Vector3 posLarge = new Vector3(-9, -2, 0);
            Instantiate(playerLargeInstan, posLarge, Quaternion.identity);
        }

        Debug.Log(playerSizeInt);
        Debug.Log(playerHealthInt);
        Debug.Log(playerAttackInt);
    }






	void EnemyBuild ()
    {
        enemySizeInt = Random.Range(1, 4);
        EnemyHealthAttack();
    }

    void EnemyHealthAttack()
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

    enemySizeText.text = enemySizeInt.ToString();
    enemyHealthText.text = enemyHealthInt.ToString();
    enemyAttackText.text = enemyAttackInt.ToString();

        int displayEnemy = System.Convert.ToInt32(enemySizeText.text);



        if (displayEnemy == 1)
        {
            Vector3 posSmallEnemy = new Vector3(9, -3, 0);
            Instantiate(enemySmallInstan, posSmallEnemy, Quaternion.identity);
        }
        else if (displayEnemy == 2)
        {
            Vector3 posMediumEnemy = new Vector3(9, -3, 0);
            Instantiate(enemyMediumInstan, posMediumEnemy, Quaternion.identity);
        }
        else
        {
            Vector3 posLargeEnemy = new Vector3(9, -2, 0);
            Instantiate(enemyLargeInstan, posLargeEnemy, Quaternion.identity);
        }
    }



    void CleanRound()
    {
        //playerSizeText = "";
        //playerHealthText = "";
        //playerAttackText = "";

        playerHealthInt = 0;
        playerHealthInt = 0;
        playerAttackInt = 0;

        //enemySizeText = "";
        //enemyHealthText = "";
        //enemyAttackText = "";

        enemyHealthInt = 0;
        enemyHealthInt = 0;
        enemyAttackInt = 0;
    }

	public void cointoss ()
	{
		CoinTossInt=Random.Range(1,3);
		Debug.Log(CoinTossInt);
		//CoinTossInt = 0;
		//Debug.Log(enemyHealthInt);
		//Debug.Log (playerHealthInt);

		if (CoinTossInt == 1)
		{
			int playerstrike = enemyHealthInt - playerAttackInt;
			enemyHealthInt = playerstrike;

			if (enemyHealthInt < 0)
			{
				Debug.Log("you win");

				GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemygo");
				foreach(GameObject enemygo in enemies)
					GameObject.Destroy(enemygo);

				//CleanRound ();
				//Start ();
			}
			else
			{

			}


		}

		else
		{
			
			int enemystrike = playerHealthInt - enemyAttackInt;
			playerHealthInt = enemystrike;

			if (playerHealthInt < 0)
			{
				Debug.Log("you lost");

				GameObject[] player = GameObject.FindGameObjectsWithTag("playergo");
				foreach(GameObject playergo in player)
					GameObject.Destroy(playergo);
				

				//CleanRound ();
				//Start ();
			}
			else
			{

			}
		}
	}




}
