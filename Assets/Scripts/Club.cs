using TMPro;
using UnityEngine;

public class Club : MonoBehaviour
{
    [SerializeField] private TextMeshPro _score;

    private int _ballHitCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            _ballHitCount++;
            _score.text = "Shots: " + _ballHitCount;
        }
    }
}
