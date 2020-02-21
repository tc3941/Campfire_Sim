using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class onClickStuff : MonoBehaviour {
  

    public void clicked()
    {
        SceneManager.LoadScene(1);
    }
}
