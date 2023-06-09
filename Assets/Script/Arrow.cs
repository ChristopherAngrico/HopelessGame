using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject gArrow;
    public bool checkTriggered = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !checkTriggered)
        {
            StartCoroutine(nameof(DeployArrow));
            checkTriggered = true;
        }
    }

    IEnumerator DeployArrow()
    {
        while (true)
        {
            Instantiate(gArrow, GameObject.FindWithTag("Arrow").transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
