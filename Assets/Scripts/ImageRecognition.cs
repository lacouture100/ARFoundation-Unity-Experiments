using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
    // Start is called before the first frame update


    //Add our ReferenceImageManager
    private ARTrackedImageManager _arTrackedImageManager;

    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();

    }
    private void OnEnable()
    {
        //tracks information about the images inside the manager, every time they are updated, added, deleted, etc.. 
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;

    }
    private void OnDisable()
    {
        //tracks information about the images inside the manager, every time they are updated, added, deleted, etc.. 
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;

    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        //print each of the ARTracked Images added since the last event
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
 