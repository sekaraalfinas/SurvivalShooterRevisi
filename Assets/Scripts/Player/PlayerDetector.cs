using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            //Debug.Log("warning");
            float enemyDistance = Vector3.Distance(transform.position, other.transform.position);
            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}
