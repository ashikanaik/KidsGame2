using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PyramidControl : MonoBehaviour
{
    public static int slotsOccupied;
    [SerializeField]
private Transform[] rings;
  [SerializeField]
public GameObject winSign;
[SerializeField]
public GameObject wrongSign;
    private void Start()
    {
       Drag.PuzzleDone+=CheckResults;
       slotsOccupied=0;
       winSign.SetActive(false);
       wrongSign.SetActive(false); 
    }
public void CheckResults()
{
    if(rings[0].position.y==-3.016f && rings[1].position.y==-1.78f && rings[2].position.y==-0.493f && rings[3].position.y==0.68f)
    {
        winSign.SetActive(true);
      Invoke("RelodGame",2f);
    }
    else{
        wrongSign.SetActive(true);
        Invoke("ReloadGame",1f);
    }
}
private void ReloadGame()
{
    Drag.PuzzleDone-=CheckResults;
    SceneManager.LoadScene("sampleScene");
}
    // Update is called once per frame

}
