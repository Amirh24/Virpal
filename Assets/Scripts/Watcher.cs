using UnityEngine;
using System.Collections;
using System;




public class Watcher : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }

    public static void Init(MonoBehaviour monoObject)
    {
        monoObject.InvokeRepeating("Watcher.Updater", 0, 3);
    }

    public static void Updater()
    {
        MonoBehaviour.print("Updater called from watcher");
        int happenissLevel = PlayerPrefs.GetInt("happiness");
        string lastUpdatedHappiness = PlayerPrefs.GetString("lastUpdatedHappiness");

        if (!string.IsNullOrEmpty(lastUpdatedHappiness))
        {
            try
            {

                DateTime dt = new DateTime(long.Parse(lastUpdatedHappiness));

                TimeSpan span = DateTime.Now.Subtract(dt);
                int mins = span.Minutes;
                bool shouldUpdate = false;
                while (mins >= 3)
                {
                    shouldUpdate = true;
                    happenissLevel--;
                    mins -= 3;
                }

                if (shouldUpdate)
                {
                    PlayerPrefs.SetInt("happiness", happenissLevel);
                    //reset update
                    PlayerPrefs.SetString("lastUpdatedHappiness", DateTime.Now.Ticks.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }
    }

}
