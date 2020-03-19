using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject tree,tiger,chick,bird,grape,treeblack,tigerblack,chickblack,birdblack,grapeblack;
    Vector2 birdinitialpos,grapeinitialpos,chickinitialpos,treeinitialpos,tigerinitialpos;

    bool birdcorrect,grapecorrect,chickcorrect,treecorrect,tigercorrect;
    void Start() 
        {
            birdinitialpos=bird.transform.position;
            grapeinitialpos=grape.transform.position;
            chickinitialpos=chick.transform.position;
            treeinitialpos=tree.transform.position;
            tigerinitialpos=tiger.transform.position;
        }

        public void DragBird()
        {
            bird.transform.position=Input.mousePosition;
        }
    public void Draggrape()
        {
            grape.transform.position=Input.mousePosition;
        }
        public void Dragchick()
        {
            chick.transform.position=Input.mousePosition;
        }
        public void Dragtree()
        {
            tree.transform.position=Input.mousePosition;
        }
        public void Dragtiger()
        {
            tiger.transform.position=Input.mousePosition;
        }

        public void dropbird()
        {
            float Distance=Vector3.Distance(bird.transform.position,birdblack.transform.position);
            if(Distance<50)
            {
                bird.transform.position=birdblack.transform.position;
                birdcorrect=true;
            }
            else
            {
                bird.transform.position=birdinitialpos;
            }
        }
        public void dropgrape()
        {
            float Distance=Vector3.Distance(grape.transform.position,grapeblack.transform.position);
            if(Distance<50)
            {
                grape.transform.position=grapeblack.transform.position;
            grapecorrect=true;
            }
            else
            {
                grape.transform.position=grapeinitialpos;
            }
        }
         public void dropchick()
        {
            float Distance=Vector3.Distance(chick.transform.position,chickblack.transform.position);
            if(Distance<50)
            {
                chick.transform.position=chickblack.transform.position;
             chickcorrect=true;
            }
            else
            {
                chick.transform.position=chickinitialpos;
            }
        }
         public void droptree()
        {
            float Distance=Vector3.Distance(tree.transform.position,treeblack.transform.position);
            if(Distance<50)
            {
                tree.transform.position=treeblack.transform.position;
              treecorrect=true;
            }
            else
            {
                tree.transform.position=treeinitialpos;
            }
        }
         public void droptiger()
        {
            float Distance=Vector3.Distance(tiger.transform.position,tigerblack.transform.position);
            if(Distance<50)
            {
                tiger.transform.position=tigerblack.transform.position;
              tigercorrect=true;
            }
            else
            {
                tiger.transform.position=tigerinitialpos;
            }
        }
        
        void Update()
        {
            if(birdcorrect&&grapecorrect&&chickcorrect&&treecorrect&&tigercorrect)
            {
                Debug.Log("YOU WIN");
            }
        }
}
