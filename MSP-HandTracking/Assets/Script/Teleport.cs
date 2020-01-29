using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject LEAPobject;
    public GameObject theCamera;
    private const float deskPositionX =(-2.5f);
    private const float deskPositionY =(5.8f);
    private const float deskPositionZ =(-8.6f);
    private const float camRotationy = (90f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TeleportUI()
    {
        StartCoroutine(teleportProcess());
    }
    private IEnumerator teleportProcess()
    {
        //theCamera.SetActive(false);
        yield return new WaitForSeconds(.5f);
        LEAPobject.transform.position = new Vector3(deskPositionX, deskPositionY, deskPositionZ);
        LEAPobject.transform.Rotate(0, camRotationy,0);
        
       // theCamera.SetActive(true);
        yield return new WaitForSeconds(.5f);
       
    }
}
