using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void RestartCurrLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void FindCubesList()
    {
        GameObject cubes = GameObject.FindGameObjectWithTag("Cubes");
        Debug.Log(cubes.transform.childCount);
    }
}
