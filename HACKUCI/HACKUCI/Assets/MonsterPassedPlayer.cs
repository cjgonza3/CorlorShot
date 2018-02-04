using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPassedPlayer : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("END GAME");
        Application.Quit();
    }
}
