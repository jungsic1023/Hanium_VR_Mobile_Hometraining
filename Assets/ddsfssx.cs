using UnityEngine;

public class ddsfssx : MonoBehaviour
{
    // Toggle between Diffuse and Transparent/Diffuse shaders
    // when space key is pressed

    Shader shader1;

    Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("NoiseBlendedStandardMaterial");

    }

    void Update()
    {
    }
}
