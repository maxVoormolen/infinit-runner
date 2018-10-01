using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject background;
    private bool isInstanciated = false;

    private void Start()
    {
        gameObject.name = "Background";
    }


    // Update is called once per frame
    void Update ()
    {
        background.transform.position -= new Vector3(5f * Time.deltaTime, 0f, 0f);

        if (background.transform.position.x <= -10 && !isInstanciated)
        {
            Instantiate(background, new Vector3(background.transform.position.x + 90f, 0f, 5f), Quaternion.identity);
            isInstanciated = true;
        }

        //76f

        if (background.transform.position.x <= -90)
        {
            Destroy(background);
        }
    }
}
