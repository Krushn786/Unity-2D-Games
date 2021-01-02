using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //Paramaters
    [SerializeField] int BreakableBlocks;

    //Cached Reference
    SceneLoader scene;

    private void Start()
    {
        scene = FindObjectOfType<SceneLoader>();   
    }
    public void CountBreakableBlocks() {
        BreakableBlocks++; ;
    }

    public void BlockDestoryed() {
        BreakableBlocks--;
        if (BreakableBlocks <= 0) {
            scene.LoadNextScene();
        }
    }
    
}
