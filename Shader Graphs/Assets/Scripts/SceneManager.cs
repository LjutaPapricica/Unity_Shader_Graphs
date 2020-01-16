using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public Camera mainCam;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag.Equals("Dissolve"))
                {
                    MeshRenderer meshRenderer = hit.collider.gameObject.GetComponent<MeshRenderer>();
                    int dissolve = meshRenderer.material.GetInt("_DissolveVariable");
                    if (dissolve == -2)
                    {
                        dissolve = 0;
                    }
                    else
                    {
                        dissolve = -2;
                    }
                    meshRenderer.material.SetInt("_DissolveVariable",dissolve);
                }
            }
        }
    }
}
