using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class ImgTrack : MonoBehaviour
{
    public GameObject trainA, trainEu, trainIvolga,trainB,oldTrain;
    private ARTrackedImageManager aRTrackedImageManager;

    private GameObject train;
    // Start is called before the first frame update

    private string nameOfTrain;
    void Start()
    {
        aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();
        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
       

        
        
        foreach (ARTrackedImage img in args.added)
        {
            if (img.referenceImage.name.Equals("Train_A"))
            {
                Destroy(train);
                train = Instantiate(trainA, img.transform.position, img.transform.rotation);

                nameOfTrain = train.gameObject.name;
            }
            else if (img.referenceImage.name.Equals("Train_EU"))
            {
                Destroy(train);
                train = Instantiate(trainEu, img.transform.position, img.transform.rotation);

                nameOfTrain = train.gameObject.name;
            }
            else if (img.referenceImage.name.Equals("Train_Ivolga"))
            {
                Destroy(train);
                train = Instantiate(trainIvolga, img.transform.position, img.transform.rotation);

                nameOfTrain = train.gameObject.name;
            }
            else if (img.referenceImage.name.Equals("Train_B"))
            {
                Destroy(train);
                train = Instantiate(trainB, img.transform.position, img.transform.rotation);

                nameOfTrain = train.gameObject.name;
            }
            else if (img.referenceImage.name.Equals("Train_Old"))
            {
                Destroy(train);
                train = Instantiate(oldTrain, img.transform.position, img.transform.rotation);

                nameOfTrain = train.gameObject.name;
            }
        }

        
      
    }

 

    
}
