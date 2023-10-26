using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject One;
    public GameObject Two;
    bool dest = false;
    public AudioSource player;

    public void Start()
    {
        One = null;
        Two = null;
    }


    public void Update()
    {
        GameObject cubes = GameObject.FindGameObjectWithTag("Cubes");
        if (cubes.transform.childCount > 0)
        {
            if (One != null && Two != null && One.name != Two.name)
            {
                if (One.CompareTag(Two.tag) && Two.CompareTag(One.tag))
                {
                    dest = true;
                    StartCoroutine("WaitTime");
                }
            }
        } else
        {
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            else if (SceneManager.GetActiveScene().name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            else if (SceneManager.GetActiveScene().name == "Level 3")
            {
                SceneManager.LoadScene("Credit");
            }
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1f);
        if (dest)
        {
            player.Play();
            Destroy(One);
            Destroy(Two);
        }
        dest = false;
    }
}
