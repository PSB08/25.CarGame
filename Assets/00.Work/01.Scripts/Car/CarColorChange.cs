using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColorChange : MonoBehaviour
{
    [SerializeField] private MeshRenderer mesh;
    [SerializeField] private Material[] colors;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            int random = Random.Range(0, colors.Length);
            mesh.material = colors[random];
        }
    }

}
