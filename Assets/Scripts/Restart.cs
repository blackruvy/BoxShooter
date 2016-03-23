using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
    void onCollisionEnter(Collision newCollision)
    {
        if(newCollision.gameObject.tag == "Projectile")
        {
            GameManager.gm.RestartGame();
        }
    }
}
