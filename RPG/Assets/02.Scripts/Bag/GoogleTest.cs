using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleTest : MonoBehaviour
{
    const string URL = "https://docs.google.com/spreadsheets/d/1FwHv3bIN3mLeRkUar2Seq4LAVbaw5GL0eQK53GDdwyE/export?format=tsv";

    private IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(URL);
        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;
        print(data);
    }
    //https://www.youtube.com/watch?v=3LxaTtLsC-w&list=PL3KKSXoBRRW2NoL0sI5bHZkKnGOOBQh_X
}
