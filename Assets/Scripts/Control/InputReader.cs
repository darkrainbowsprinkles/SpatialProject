using UnityEngine;
using SpatialSys.UnitySDK;

namespace Papime.Control
{
    public class InputReader : MonoBehaviour, IAvatarInputActionsListener
    {
        public void ToggleInput(bool state)
        {
            SpatialBridge.actorService.localActor.avatar.Move(Vector2.zero, false);
            SpatialBridge.inputService.StartAvatarInputCapture(state, state, state, state, this);
        }

        void IInputActionsListener.OnInputCaptureStarted(InputCaptureType captureType) { }
        void IInputActionsListener.OnInputCaptureStopped(InputCaptureType captureType) { }
        void IAvatarInputActionsListener.OnAvatarActionInput(InputPhase inputPhase) { }
        void IAvatarInputActionsListener.OnAvatarAutoSprintToggled(bool on) { }
        void IAvatarInputActionsListener.OnAvatarJumpInput(InputPhase inputPhase) { }
        void IAvatarInputActionsListener.OnAvatarMoveInput(InputPhase inputPhase, Vector2 inputMove) { }
        void IAvatarInputActionsListener.OnAvatarSprintInput(InputPhase inputPhase) { }
    }
}