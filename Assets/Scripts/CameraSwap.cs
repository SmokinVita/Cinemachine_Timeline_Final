using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{

    [SerializeField] private GameObject[] _cams;
    [SerializeField] private int _currentCam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _cams[_currentCam].SetActive(false);
            _currentCam++;
            if (_currentCam > _cams.Length - 1)
                _currentCam = 0;
            _cams[_currentCam].SetActive(true);
        }
    }

}
