using System.Collections;
using UnityEngine;

public class SwitchRooms : MonoBehaviour
{
    public GameObject livingRoomSphere;
    public GameObject cantinaSphere;
    public GameObject cubeSphere;
    public GameObject mezzanineSphere;

    public ScreenFader fader;

    void Start()
    {
        if (livingRoomSphere == null)
        {
            Debug.LogError("SwitchRooms: Assign all sphere fields in the Inspector!");
            return;
        }
        SetActiveSphere(livingRoomSphere);
    }

    public void ShowLivingRoom() => StartCoroutine(SwitchToLivingRoom());
    public void ShowCantina()    => StartCoroutine(SwitchToCantina());
    public void ShowCube()       => StartCoroutine(SwitchToCube());
    public void ShowMezzanine()  => StartCoroutine(SwitchToMezzanine());

    IEnumerator SwitchToLivingRoom()
    {
        yield return fader.FadeOut();
        SetActiveSphere(livingRoomSphere);
        yield return fader.FadeIn();
    }

    IEnumerator SwitchToCantina()
    {
        yield return fader.FadeOut();
        SetActiveSphere(cantinaSphere);
        yield return fader.FadeIn();
    }

    IEnumerator SwitchToCube()
    {
        yield return fader.FadeOut();
        SetActiveSphere(cubeSphere);
        yield return fader.FadeIn();
    }

    IEnumerator SwitchToMezzanine()
    {
        yield return fader.FadeOut();
        SetActiveSphere(mezzanineSphere);
        yield return fader.FadeIn();
    }

    void SetActiveSphere(GameObject target)
    {
        livingRoomSphere.SetActive(false);
        cantinaSphere.SetActive(false);
        cubeSphere.SetActive(false);
        mezzanineSphere.SetActive(false);
        target.SetActive(true);
    }
}
