using UnityEngine;
using SpatialSys.UnitySDK;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] float animationLength = 1f;
    [SerializeField] string animationID;
    bool playing = false;
    float elapsedTime = 0f;
    IAvatar localAvatar;

    void Awake()
    {
        localAvatar = SpatialBridge.actorService.localActor.avatar;
    }

    void Update()
    {
        if (localAvatar.isGrounded && !playing && Input.GetKeyDown(KeyCode.Mouse0))
        {
            localAvatar.PlayEmote(AssetType.EmbeddedAsset, animationID);
            playing = true;
            elapsedTime = 0f;
        }

        if (playing)
        {
            elapsedTime += Time.deltaTime;
            localAvatar.Move(Vector2.zero, false);

            if (elapsedTime >= animationLength)
            {
                elapsedTime = 0f;
                playing = false;
                localAvatar.StopEmote();
            }
        }
    }
}