using UnityEngine;
using System.Collections;

public class HintTextController : MonoBehaviour
{
    public Animation anim;

    private void Start()
    {
        Animation anim = GetComponent<Animation>();
    }

    public void MainToArchive()
    {
        anim.Play("HintTextHideRight");
    }

    public void ArchiveToMain()
    {
        anim.Play("HintTextShowRight");
    }
}
