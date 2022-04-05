using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;
    public GameObject Puzzle;
    public GameObject Barrier;
    public GameObject PuzzleStart;

    [SerializeField]
    int totalPipes = 0;

    int correctPipes = 0;

    private void Start()
    {
        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];
        for(int i = 0; i < Pipes.Length;i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    
    }

    public void correctMove()
    {
        correctPipes += 1;

        Debug.Log("Correct");
        if(correctPipes == totalPipes)
        {
            Destroy(Barrier);
            Destroy(Puzzle);
            Destroy(PuzzleStart);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
             
    }

    public void wrongMove()
    {
        correctPipes -= 1;
    }
}
