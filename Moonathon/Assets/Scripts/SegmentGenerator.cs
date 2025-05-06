using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;
    //make this an 2d arry to store at max 2 meteors per segemnt
    public GameObject[] meteors;

    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;
    [SerializeField] int wait = 5;

    // Start is called before the first frame update
    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        meteors[segmentNum].SetActive(true);
        meteors[segmentNum].GetComponent<Animator>().enabled = true;
        zPos += 50;
        yield return new WaitForSeconds(wait);
        creatingSegment = false;
    }
}
