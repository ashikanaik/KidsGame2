using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
   [SerializeField]
   private Transform[] pictures;
   public GameObject wintext;
   public static bool youwin;
    void Start()
    {
        wintext.SetActive(false);
        youwin=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pictures[0].rotation.z==0 && pictures[1].rotation.z==0 && pictures[2].rotation.z==0&&pictures[3].rotation.z==0&&pictures[4].rotation.z==0&&pictures[5].rotation.z==0)
        {
            youwin=true;
            wintext.SetActive(true);
        }
    }
}
