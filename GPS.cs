using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace getGPS
{
    public class GPS : MonoBehaviour
    {
        public static GPS Instance { set; get; }

        public float latitude;
        public float longitude;
        public float altitude;

        public void Start()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            StartCoroutine(StartLocationService());
        }

        public IEnumerator StartLocationService()
        {
        
            if (!Input.location.isEnabledByUser)
            {
                Debug.Log("GPS not enabled");
                yield break;
            }

       
            Input.location.Start();

      
            int maxWait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1);
                maxWait--;
            }

        
            if (maxWait <= 0)
            {
                Debug.Log("Timed out");
                yield break;
            }

            if (Input.location.status == LocationServiceStatus.Failed)
            {
                Debug.Log("Unable to determine device location");
                yield break;
            }

        
            while (true) {
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;
                altitude = Input.location.lastData.altitude;
                yield return new WaitForSeconds(10);
          
            }
        }
    } 
}
   