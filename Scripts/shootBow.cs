using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootBow : MonoBehaviour
{
    public Text shootText;
    private bool inside = false;

    void OnTriggerStay(Collider other)
    {
        inside = true;
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyUp(KeyCode.X))
            {

                GetComponent<Nokobot.Assets.Crossbow.CrossbowShoot>().shootArrow();
                other.GetComponent<animationScript1>().setBoolean(true);
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        inside = false;
    }
        private void Update()
    {
        shootText.gameObject.SetActive(inside);
    }
}

