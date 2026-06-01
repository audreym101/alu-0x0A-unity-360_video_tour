using System.Collections;
using UnityEngine;

public class CampusTourManager : MonoBehaviour
{
    [Header("Campus Locations")]
    public GameObject outsideSphere;
    public GameObject parkingSphere;
    public GameObject elevatorSphere;

    public ScreenFader fader;

    void Start()
    {
        if (outsideSphere == null)
        {
            Debug.LogError("CampusTourManager: Assign all sphere fields in the Inspector!");
            return;
        }
        SetActiveSphere(outsideSphere);
    }

    public void ShowOutside()  => StartCoroutine(SwitchToOutside());
    public void ShowParking()  => StartCoroutine(SwitchToParking());
    public void ShowElevator() => StartCoroutine(SwitchToElevator());

    IEnumerator SwitchToOutside()
    {
        yield return fader.FadeOut();
        SetActiveSphere(outsideSphere);
        yield return fader.FadeIn();
    }

    IEnumerator SwitchToParking()
    {
        yield return fader.FadeOut();
        SetActiveSphere(parkingSphere);
        yield return fader.FadeIn();
    }

    IEnumerator SwitchToElevator()
    {
        yield return fader.FadeOut();
        SetActiveSphere(elevatorSphere);
        yield return fader.FadeIn();
    }

    void SetActiveSphere(GameObject target)
    {
        outsideSphere.SetActive(false);
        parkingSphere.SetActive(false);
        elevatorSphere.SetActive(false);
        target.SetActive(true);
    }
}
