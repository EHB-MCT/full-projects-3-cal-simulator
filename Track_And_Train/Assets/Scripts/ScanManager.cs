using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class ScanManager : MonoBehaviour
{

    public GameObject unlock;
    public GameObject unlockType07, unlockType12, unlockSerie15, unlockMs08, unlockEur320;
    public ARTrackedImageManager aRTrackedImageManager;

    // Start is called before the first frame update
    void Start()
    {
       
        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (ARTrackedImage img in args.added)
        {
            if (img.referenceImage.name.Equals("ms08"))
            {
                unlockMs08.SetActive(true);
            }
            else if (img.referenceImage.name.Equals("euro320"))
            {
               unlockEur320.SetActive(true);
            }
            else if (img.referenceImage.name.Equals("type12"))
            {
               unlockType12.SetActive(true);
            }
            else if (img.referenceImage.name.Equals("type07"))
            {
               unlockType07.SetActive(true);
            }
            else if (img.referenceImage.name.Equals("serie15"))
            {
               unlockSerie15.SetActive(true);
            }
        }
       
    }

    
}
