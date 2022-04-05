using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlock : MonoBehaviour
{
    public Transform teleportDestination;
    public GameObject door1;
    public GameObject door2;
    public GameObject PuzzleHint;
    public MouseLook mouselook;
    private AudioSource deathsound;


    private void Start()
    {
        deathsound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Unlock1")
        {
            Destroy(door1);
            transform.position = teleportDestination.position;
        }

        if(col.gameObject.tag == "Unlock2")
        {
            Destroy(door2);
            transform.position = teleportDestination.position;
        }

        if (col.gameObject.tag == "teleport")
        {

            transform.position = teleportDestination.position;
            deathsound.Play();
        }

        if(col.gameObject.tag == "PuzzleStart")
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (col.gameObject.tag == "Finish") 
        {
            SceneManager.LoadScene(2);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if(col.gameObject.tag == "PuzzleHint")
        {
            PuzzleHint.SetActive(true);
            StartCoroutine(PuzzleText());
        }

        IEnumerator PuzzleText()
        {
            yield return new WaitForSeconds(5);
            PuzzleHint.SetActive(false);
        }

    }
}
