using UnityEngine;
using System.Collections;

public class BackButtonController : MonoBehaviour
{
    public Animation anim;

    private void Start()
    {
        Animation anim = GetComponent<Animation>();
    }

    public void MainToArchive()
    {
        anim.Play("BackButtonShow");
    }

    public void ArchiveToMain()
    {
        anim.Play("BackButtonHide");
    }
}
