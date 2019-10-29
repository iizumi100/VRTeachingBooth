using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class localposition : Publisher<Messages.Geometry.PoseStamped>
    {
        public Transform PublishedTransform;
        public string FrameId = "Unity";
        int a;

        private Messages.Geometry.PoseStamped message;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        private void FixedUpdate()
        {
            UpdateMessage();
        }

        private void InitializeMessage()
        {
            message = new Messages.Geometry.PoseStamped
            {
                header = new Messages.Standard.Header()
                {
                    frame_id = FrameId
                }
            };
        }

        private void UpdateMessage()
        {
            message.header.Update();
            message.pose.position = GetGeometryPoint();
            // message.pose.orientation = GetGeometryQuaternion();
            if (OVRInput.Get(OVRInput.RawButton.X) && a < 2)
            {
                a += 1;
                if (a < 2)
                    return;
                Publish(message);
               
            }

           if (OVRInput.GetUp(OVRInput.RawButton.X))
           {
                a = 0;
           }

        }

        private Messages.Geometry.Point GetGeometryPoint()
        {
            Messages.Geometry.Point geometryPoint = new Messages.Geometry.Point();

            geometryPoint.x = GetLocalPosition.localpos.z;
            geometryPoint.y = -GetLocalPosition.localpos.x;
            geometryPoint.z = GetLocalPosition.localpos.y;
            return geometryPoint;
        }

        private Messages.Geometry.Quaternion GetGeometryQuaternion()
        {
          Messages.Geometry.Quaternion geometryQuaternion = new Messages.Geometry.Quaternion();
          geometryQuaternion.x = -GetLocalPosition.localrot.y;
          geometryQuaternion.y = GetLocalPosition.localrot.z;
          geometryQuaternion.z = GetLocalPosition.localrot.x;
          geometryQuaternion.w = -GetLocalPosition.localrot.w;
          return geometryQuaternion;
        }

    }
}