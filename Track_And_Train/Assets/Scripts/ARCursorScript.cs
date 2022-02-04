using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARCursorScript : MonoBehaviour
{
    public GameObject objectToPlace;
    public ARRaycastManager raycastManager;
    void Start()
    {
      // objectToPlace.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.touchCount > 0 && Input.GetTouch(0).phase ==TouchPhase.Began)
        {
            var hits = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
            if(hits.Count > 0)
            {
                objectToPlace.SetActive(true);
                objectToPlace.transform.position = hits[0].pose.position;
                objectToPlace.transform.rotation = hits[0].pose.rotation;

            }

        }*/
    }
}
